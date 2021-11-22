using Health_Watch_Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Watch_DAL.Repositories.IRepos
{
    public interface IDiseaseRepository
    {
        Task<Disease> Get(int id);
        Task<List<Disease>> GetAll();
        Task<Disease> Add(Disease entity);
        Task<Disease> Update(Disease entity);
        Task<int> Delete(Disease entity);
    }
}
