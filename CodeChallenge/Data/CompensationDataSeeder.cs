using CodeChallenge.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.Data
{
    public class CompensationDataSeeder
    {
        private CompensationContext _compensationContext;
        private const String EMPLOYEE_SEED_DATA_FILE = "resources/EmployeeSeedData.json";

        public CompensationDataSeeder(CompensationContext compensationContext)
        {
            _compensationContext = compensationContext;
        }

        public async Task Seed()
        {

        }
    }
}
