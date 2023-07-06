﻿using Application.Core;
using AutoMapper;
using Domain.ModelDTOs;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Profiles
{
    public class AuditionNotReviewedDetails
    {
        public class Query : IRequest<Result<List<AuditionDto>>>
        {
            public string Id { get; set; }
        }
        public class Handler : IRequestHandler<Query, Result<List<AuditionDto>>>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;

            public Handler(DataContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<Result<List<AuditionDto>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var auditions = _context.Auditions.Include(asr => asr.ActorShowRole).Where(a => a.ActorShowRole.ActorId == request.Id).AsQueryable();
                if (auditions == null) return Result<List<AuditionDto>>.Success(new List<AuditionDto>());
                var notReviewedAuditions = await auditions.Where(a => a.Reviews.Count == 0).ToListAsync();
                return Result<List<AuditionDto>>.Success(_mapper.Map<List<AuditionDto>>(notReviewedAuditions));
            }
        }
    }
}