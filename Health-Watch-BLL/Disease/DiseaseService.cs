using AutoMapper;
using Health_Watch_Entity.Entities;
using Health_Watch_DAL.Repositories.IRepos;
using Health_Watch_DTO.DTOs.Disease;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Watch_BLL.Disease
{
    public class DiseaseService : IDiseaseService
    {
        private readonly IDiseaseRepository _diseaseRepository;
        private readonly IMapper _mapper;
        public DiseaseService(IDiseaseRepository diseaseRepository, IMapper mapper)
        {
            _diseaseRepository = diseaseRepository;
            _mapper = mapper;
        }

        public async Task<DiseaseToListDTO> Get(int Id)
        {
            var result = await _diseaseRepository.Get(Id);
            return _mapper.Map<DiseaseToListDTO>(result);
        }

        public async Task<List<DiseaseToListDTO>> GetAll()
        {
            return _mapper.Map<List<DiseaseToListDTO>>(await _diseaseRepository.GetAll());
        }

        public async Task<DiseaseToAddDTO> Add(DiseaseToAddDTO entity)
        {
            var result =await _diseaseRepository.Add(_mapper.Map<Health_Watch_Entity.Entities.Disease>(entity));
            return _mapper.Map<DiseaseToAddDTO>(result);
        }

        public async Task<DiseaseToUpdateDTO> Update(DiseaseToUpdateDTO entity)
        {
            var result = await _diseaseRepository.Update(_mapper.Map<Health_Watch_Entity.Entities.Disease>(entity));
            return _mapper.Map<DiseaseToUpdateDTO>(result);
        }

        public async Task<int> Delete(DiseaseToAddDTO entity)
        {
            return (await _diseaseRepository.Delete(_mapper.Map<Health_Watch_Entity.Entities.Disease>(entity)));
        }
    }
}
