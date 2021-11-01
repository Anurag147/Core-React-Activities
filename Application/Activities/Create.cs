using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Activities
{
    public class Create
    {       
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
        public class Command : IRequest{
            public Activity act {get;set;}
        }
        public class Handler : IRequestHandler<Command>
        {
            public Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                    _co
            }
        }
    }
}