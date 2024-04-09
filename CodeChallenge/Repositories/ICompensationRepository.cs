using CodeChallenge.Models;
using System;
using System.Threading.Tasks;

namespace CodeChallenge.Repositories
{
    public interface ICompensationRepository
    {
        Compensation AddCompensation(Compensation compensation);
        Task SaveAsync();
        Compensation GetById(string id);
    }
}