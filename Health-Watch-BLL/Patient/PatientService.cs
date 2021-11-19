using AutoMapper;
using Health_Watch_DAL.Repositories.IRepos;
using Health_Watch_DTO.DTOs.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Watch_BLL.Patient
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IMapper _mapper;
        public PatientService(IPatientRepository patientRepository, IMapper mapper)
        {
            _patientRepository = patientRepository;
            _mapper = mapper;
        }
        public async Task<PatientToListDTO> Get(int Id)
        {
            var result = await _patientRepository.Get(Id);
            return _mapper.Map<PatientToListDTO>(result);
        }

        public async Task<List<PatientToListDTO>> GetAll()
        {
            return _mapper.Map<List<PatientToListDTO>>(await _patientRepository.GetAll());
        }

        public async Task<PatientToAddDTO> Add(PatientToAddDTO entity)
        {
            var result =await _patientRepository.Add(_mapper.Map<Health_Watch_Entity.Entities.Patient>(entity));
            return _mapper.Map<PatientToAddDTO>(result);
        }

        public async Task<PatientToUpdateDTO> Update(PatientToUpdateDTO entity)
        {
            var result =await _patientRepository.Update(_mapper.Map<Health_Watch_Entity.Entities.Patient>(entity));
            return _mapper.Map<PatientToUpdateDTO>(result);
        }

        public async Task<int> Delete(PatientToAddDTO entity)
        {
            return await _patientRepository.Delete(_mapper.Map<Health_Watch_Entity.Entities.Patient>(entity));
        }
    }
}
