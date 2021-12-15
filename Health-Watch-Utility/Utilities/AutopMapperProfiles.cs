using AutoMapper;
using Health_Watch_DTO.DTOs.Disease;
using Health_Watch_DTO.DTOs.Patient;
using Health_Watch_Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Watch_Utility.Utilities
{
    public static class AutopMapperProfiles
    {
        public class AutoMapperProfile : Profile
        {
            public AutoMapperProfile()
            {
                //User Mappings

                //Patient Mappings
                CreateMap<Patient, PatientToAddDTO>().ReverseMap();
                CreateMap<Patient, PatientToListDTO>().ReverseMap();
                CreateMap<Patient, PatientToUpdateDTO>().ReverseMap();
                //Disease Mappings
                CreateMap<Disease, DiseaseToListDTO>().ReverseMap();
                CreateMap<Disease, DiseaseToAddDTO>().ReverseMap();
                CreateMap<Disease, DiseaseToUpdateDTO>().ReverseMap();
            }
        }
    }
}
