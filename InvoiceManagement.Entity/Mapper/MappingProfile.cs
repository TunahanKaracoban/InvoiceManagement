using AutoMapper;
using InvoiceManagement.Entity.Dto;
using InvoiceManagement.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.Entity.Mapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Apartment, DtoApartment>().ReverseMap();
            CreateMap<Block, DtoBlock>().ReverseMap();
            CreateMap<Due, DtoDue>().ReverseMap();
            CreateMap<Invoice, DtoInvoice>().ReverseMap();
            CreateMap<InvoiceType, DtoInvoiceType>().ReverseMap();
            CreateMap<Message, DtoMessage>().ReverseMap();
            CreateMap<Month, DtoMonth>().ReverseMap();
            CreateMap<Role, DtoRole>().ReverseMap();
            CreateMap<RoomType, DtoRoomType>().ReverseMap();
            CreateMap<User, DtoUser>().ReverseMap();
            CreateMap<User, DtoLoginUser>();
            CreateMap<DtoLogin, User>();

        }
    }
}
