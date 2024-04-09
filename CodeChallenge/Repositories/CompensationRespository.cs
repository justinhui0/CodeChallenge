using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeChallenge.Models;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using CodeChallenge.Data;

namespace CodeChallenge.Repositories
{
    public class CompensationRepository : ICompensationRepository
    {
        private readonly CompensationContext _compensationContext;

        private readonly ILogger<ICompensationRepository> _logger;

        public CompensationRepository(ILogger<ICompensationRepository> logger, CompensationContext compensationContext)
        {
            _compensationContext = compensationContext;
            _logger = logger;
        }

        public Compensation AddCompensation(Compensation compensation)
        {
            compensation.CompensationId = compensation.Employee.EmployeeId;
            _compensationContext.Compensations.AddRange(compensation);
            return compensation;
        }

        public Compensation GetById(string id)
        {
             return _compensationContext.Compensations.Include(x => x.Employee).Include(x => x.Employee.DirectReports).SingleOrDefault(e => e.CompensationId == id);
        }

        public Task SaveAsync()
        {
            return _compensationContext.SaveChangesAsync();
        }
    }
}
