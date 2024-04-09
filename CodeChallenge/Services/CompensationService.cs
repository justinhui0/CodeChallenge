using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeChallenge.Models;
using Microsoft.Extensions.Logging;
using CodeChallenge.Repositories;
using Microsoft.AspNetCore.Components.Forms;

namespace CodeChallenge.Services
{
    public class CompensationService : ICompensationService
    {
        private readonly ILogger<CompensationService> _logger;
        private readonly ICompensationRepository _compensationRepository;

        public CompensationService(ILogger<CompensationService> logger, ICompensationRepository compensationRepository)
        {
            _logger = logger;
            _compensationRepository = compensationRepository;

        }

        public Compensation CreateCompensation(Compensation compensation)
        {
            if (compensation != null)
            {
                _compensationRepository.AddCompensation(compensation);
                _compensationRepository.SaveAsync().Wait();

            }
            return compensation;
        }

        public Compensation GetById(string id)
        {
            if (!String.IsNullOrEmpty(id))
            {
                return _compensationRepository.GetById(id);
            }

            return null;
        }
    }
}
