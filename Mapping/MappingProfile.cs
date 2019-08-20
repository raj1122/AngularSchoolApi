using System.Linq;
using AutoMapper;
using SchoolApi.Controllers.Resources;
using SchoolApi.Dtos;
using SchoolApi.Helpers;
using SchoolApi.Models;

namespace SchoolApi.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<StudentModel, StudentForListDto>();
            CreateMap<UserModel, UserAllDetailDto>();
            CreateMap<UserModel, UserListDto>();            
            CreateMap<PhoneNumberModel, PhoneNumberDto>();


            CreateMap<UserDetailsModel, UserDetailDto>()
            .ForMember(dest =>  dest.Age ,opt =>
            {
                opt.MapFrom( s  => s.DateOfBirth.CaluclateAge() );
            });
            

            
            // domain to API Resource
            // CreateMap< UserModel , UserModelResources>();
            // CreateMap< PhoneNumberModel , PhoneNumberResources>();
            // CreateMap<StudentAttendanceModel, AttendaceResource>();


        

            // CreateMap< StudentModel , DetailResource>()
            // .ForMember( dr => dr.audit ,opt => opt.MapFrom( sd => new AuditResource { createdTime = sd.createdTime, updatedBy = sd.updatedBy , updatedTime = sd.updatedTime  } ))
            // .ForMember( dr => dr.Features ,opt => opt.MapFrom( sad => sad.Features.Select(sa => sa.StudentAttendanceModelId)));
            

            // API Resource to Domain
            // CreateMap< DetailResource , StudentModel>()
            // .ForMember( sd => sd.Id , opt => opt.Ignore())
            // .ForMember( sd => sd.createdTime ,opt => opt.MapFrom(dr => dr.audit.createdTime))
            // .ForMember( sd => sd.updatedBy ,opt => opt.MapFrom(dr => dr.audit.updatedBy))
            // .ForMember( sd => sd.updatedTime ,opt => opt.MapFrom(dr => dr.audit.updatedTime))
            // .ForMember( sd => sd.Features ,opt => opt.MapFrom(
            //                                                     dr => dr.Features.
            //                                                     Select(id => new StudDetailAttendanceModel{ StudentAttendanceModelId = id } )));
            
        }
    }
}