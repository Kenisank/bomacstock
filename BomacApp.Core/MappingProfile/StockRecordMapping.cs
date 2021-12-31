using AutoMapper;
using BomacApp.Core.Resources.RecordStatement;
using BomacApp.Core.Resources.StockRecord;
using BomacApp.Domain.Model;
using System;
using System.Linq;

namespace BomacApp.Core.MappingProfile
{
    public class StockRecordMapping : Profile
    {
        public StockRecordMapping()
        {
            //api resources to model
            CreateMap<RecordFormResources, StockRecords>()
                .ForMember(a=>a.Type, opt=>opt.MapFrom(b=>b.Type))
                .ForMember(a => a.Id, opt => opt.Ignore());

            //model to api resources
            CreateMap<StockRecords, RecordViewResources>()
                .ForMember(a => a.Item, opt => opt.MapFrom(b => b.Item.Name));


            //api resources to model
            CreateMap<PersonRecordFormDetailResources, PersonRecords>()
                  .ForMember(a => a.Id, opt => opt.Ignore());


            //model to api
            CreateMap<PersonRecords, PersonRecordPersonDetailsResources>()
                .ForMember(a => a.Person, opt => opt.MapFrom(b => b.Person.Name))
                .ForMember(a => a.Receipt, opt => opt.MapFrom(b=> $"{b.Receipt.Name}-{b.ReceiptNumber}"))
                .ForMember(a => a.Type, opt => opt.MapFrom(b => b.Records.LastOrDefault().Type.ToString()))
                .ForMember(a => a.Balance, opt => opt.MapFrom(b => b.Person.Balance.ToString("#,##0.00")))
                .ForMember(a=>a.OrderNum, opt=>opt.MapFrom(b=> $"{(TimeZoneInfo.ConvertTime(b.Records.LastOrDefault().DateAdded, TimeZoneInfo.FindSystemTimeZoneById("W. Central Africa Standard Time"))).ToString("dd/MM/yyyy HH:mm")}"))
                .ForMember(a => a.Total, opt => opt.MapFrom(b => b.Amount.ToString("#,##0.00")))
                .ForMember(a=>a.Records, opt=>opt.MapFrom(b=>b.Records));



            //model to api resources
            CreateMap<StockRecords, RecordResources>()
                .ForMember(a => a.Type, opt => opt.MapFrom(b => b.Type.ToString()))
                .ForMember(a => a.Item, opt => opt.MapFrom(b => $"{ b.Item.Name} {b.Item.Category.Name}"))
                .ForMember(a => a.DateAdded, opt => opt.MapFrom(b => $"{(TimeZoneInfo.ConvertTime(b.DateAdded, TimeZoneInfo.FindSystemTimeZoneById("W. Central Africa Standard Time"))).ToString("dd/MM/yyyy HH:mm")}")) ;


            //model to api resources
            CreateMap<StockRecords, PersonRecordOrderResources>()
                .ForMember(a => a.Description, opt => opt.MapFrom(b => $"{b.Quantity.Reams}Reams {b.Quantity.Sheets}Sheets"))
                .ForMember(a => a.Type, opt => opt.MapFrom(b => $"{b.Type.ToString()}"))
                .ForMember(a => a.Amount, opt => opt.MapFrom(b => b.Amount))
                .ForMember(a => a.Balance, opt => opt.MapFrom(b => b.PendingBalance))
                .ForMember(a => a.Date, opt => opt.MapFrom(b => $"{(TimeZoneInfo.ConvertTime(b.DateAdded, TimeZoneInfo.FindSystemTimeZoneById("W. Central Africa Standard Time"))).ToString("dd/MM/yyyy HH:mm")}"))
                 .ForMember(a => a.Ref, opt => opt.MapFrom(b => $"{b.Record.Receipt.Name}/{b.Record.ReceiptNumber}"));






        }
    }
}