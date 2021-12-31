using AutoMapper;
using BomacApp.Core.Resources.Person;
using BomacApp.Core.Resources.RecordStatement;
using BomacApp.Domain.Dal.UnitOfWork;
using BomacApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BomacApp.Core.MappingProfile
{
    public class PersonMapping:Profile
    {

       





        public PersonMapping()
        {


            //api resource to model
            CreateMap<PersonFormResources, Dealers>()
                  .ForMember(a => a.Id, opt => opt.Ignore())
                  .ForMember(a => a.Contact, opt => opt.MapFrom(b=> new Contact { Email = b.Email, PPhoneNo=b.PPhoneNo, Web=b.Web }));




            //api resource to model
            CreateMap<PersonFormResources, Customers>()
                  .ForMember(a => a.Id, opt => opt.Ignore())
                  .ForMember(a => a.Contact, opt => opt.MapFrom(b => new Contact { Email = b.Email, PPhoneNo = b.PPhoneNo, Web = b.Web }));






            //model to api resource
            CreateMap<BusinessPersons, PersonSharedResources>();



            //model to api resources 
            CreateMap<Dealers, PersonsResouces>()
                .ForMember(a => a.UniqueNo, opt => opt.MapFrom(b => b.UniqueNumber))
                .ForMember(a=>a.State, opt=>opt.MapFrom(b=>$"{b.State.Name}"))
                .ForMember(a => a.RecordId, opt => opt.MapFrom(b => b.Records.LastOrDefault().Id))
                .ForMember(a => a.Phone, opt => opt.MapFrom(b => b.Contact.PPhoneNo))
                .ForMember(a => a.LastRecord, opt => opt.MapFrom(b => $"{(TimeZoneInfo.ConvertTime(b.Records.LastOrDefault().DateAdded, TimeZoneInfo.FindSystemTimeZoneById("W. Central Africa Standard Time"))).ToString("dd/MM/yyyy HH:mm")}"));



            //model to api resources 
            CreateMap<Customers, PersonsResouces>()
                .ForMember(a => a.UniqueNo, opt => opt.MapFrom(b => b.UniqueNumber))
                .ForMember(a => a.State, opt => opt.MapFrom(b => $"{b.State.Name}"))
                .ForMember(a => a.RecordId, opt => opt.MapFrom(b => b.Records.LastOrDefault().Id))
                .ForMember(a => a.Phone, opt => opt.MapFrom(b => b.Contact.PPhoneNo))
                .ForMember(a => a.LastRecord, opt => opt.MapFrom(b => $"{(TimeZoneInfo.ConvertTime(b.Records.LastOrDefault().DateAdded, TimeZoneInfo.FindSystemTimeZoneById("W. Central Africa Standard Time"))).ToString("dd/MM/yyyy HH:mm")}"));




            //model to api resources 
            CreateMap<BusinessPersons, PersonsResouces>()
                .ForMember(a => a.UniqueNo, opt => opt.MapFrom(b => b.UniqueNumber))
                .ForMember(a => a.State, opt => opt.MapFrom(b => $"{b.State.Name}"))
                .ForMember(a => a.RecordId, opt => opt.MapFrom(b => b.Records.LastOrDefault().Id))
                .ForMember(a => a.Phone, opt => opt.MapFrom(b => b.Contact.PPhoneNo))
                .ForMember(a => a.LastRecord, opt => opt.MapFrom(b => $"{(TimeZoneInfo.ConvertTime(b.Records.LastOrDefault().DateAdded, TimeZoneInfo.FindSystemTimeZoneById("W. Central Africa Standard Time"))).ToString("dd/MM/yyyy HH:mm")}"));





            CreateMap<BusinessPersons, PersonRecordDetailResources>()
                .ForMember(a => a.Phone, opt => opt.MapFrom(b => b.Contact.PPhoneNo))
                .ForMember(a => a.UniqueNo, opt => opt.MapFrom(b => b.UniqueNumber));

        }


    }
}