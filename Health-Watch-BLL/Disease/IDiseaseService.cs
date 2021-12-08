using Health_Watch_DTO.DTOs.Disease;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Watch_BLL.Disease
{
    public interface IDiseaseService
    {
        Task<DiseaseToListDTO> Get(int Id);
        Task<List<DiseaseToListDTO>> GetAll();
        Task<DiseaseToAddDTO> Add(DiseaseToAddDTO entity);
        Task<DiseaseToUpdateDTO> Update(DiseaseToUpdateDTO entity);
        Task<int> Delete(DiseaseToAddDTO entity);
    }
}
