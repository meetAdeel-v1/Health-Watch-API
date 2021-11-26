using Health_Watch_Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Watch_DAL.Repositories.IRepos
{
    public interface IPatientRepository
    {
        Task<Patient> Get(int id);
        Task<List<Patient>> GetAll();
        Task<Patient> Add(Patient entity);
        Task<Patient> Update(Patient entity);
        Task<int> Delete(Patient entity);
    }
}
