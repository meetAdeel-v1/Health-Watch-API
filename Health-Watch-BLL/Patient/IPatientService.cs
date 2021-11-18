using Health_Watch_DTO.DTOs.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Watch_BLL.Patient
{
    public interface IPatientService
    {
        Task<PatientToListDTO> Get(int Id);
        Task<List<PatientToListDTO>> GetAll();
        Task<PatientToAddDTO> Add(PatientToAddDTO entity);
        Task<PatientToUpdateDTO> Update(PatientToUpdateDTO entity);
        Task<int> Delete(PatientToAddDTO entity);
    }
}
