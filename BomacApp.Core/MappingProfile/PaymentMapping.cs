using AutoMapper;
using BomacApp.Core.Resources.Payments;
using BomacApp.Core.Resources.RecordStatement;
using BomacApp.Domain.Model;
using System;

namespace BomacApp.Core.MappingProfile
{
    public class PaymentMapping : Profile
    {
        public PaymentMapping()
        {


            //api resources to model
            CreateMap<PaymentFormResources, Payments>()
                .ForMember(a => a.AmountPaid, opt => opt.MapFrom(b => b.Amount))
                .ForMember(a => a.ModeId, opt => opt.MapFrom(b => b.ModeId))
                .ForMember(a => a.PersonId, opt => opt.MapFrom(b => b.PersonId))
                .ForMember(a => a.Ref, opt => opt.MapFrom(b => b.Ref))
                .ForMember(a => a.AccountId, opt => opt.MapFrom(b => b.AccountId))
                .ForMember(a => a.Id, opt => opt.Ignore());


            //model to api resources
            CreateMap<Payments, PersonStatementRecordResources>()
                .ForMember(a => a.Balance, opt => opt.MapFrom(b => b.PendingBalance))
                .ForMember(a => a.Amount, opt => opt.MapFrom(b => b.AmountPaid.ToString("#,##0.00")))
                .ForMember(a => a.StockNo, opt => opt.MapFrom(b => b.PaymentNo))
               .ForMember(a => a.Description, opt => opt.MapFrom(b => $"{b.Mode.Name} <br/> { b.Account.Name}-{b.Account.Number}"))
               .ForMember(a => a.DateAdded, opt => opt.MapFrom(b =>b.DateAdded))
               .ForMember(a => a.Type, opt => opt.MapFrom(b => $"{b.Type.ToString()}"))
              .ForMember(a => a.Date, opt => opt.MapFrom(b => $"{(TimeZoneInfo.ConvertTime(b.DateAdded, TimeZoneInfo.FindSystemTimeZoneById("W. Central Africa Standard Time"))).ToString("dd/MM/yyyy HH:mm")}"));




            //model to api resources
            CreateMap<Banks, BankSharedResources>()
                .ForMember(a => a.Name, opt => opt.MapFrom(b => b.Name))
                .ForMember(a => a.Id, opt => opt.MapFrom(b => b.Id))
                .ForMember(a => a.Accounts, opt => opt.MapFrom(b => b.Accounts));




        }
    }
}