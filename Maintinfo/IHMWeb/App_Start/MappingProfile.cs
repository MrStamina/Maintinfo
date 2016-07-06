using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using BO;
using IHMWeb.Dtos;

namespace IHMWeb.App_Start
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            //Model to Dto
            Mapper.CreateMap<Client, ClientDto>();

            //Dto to Model
            Mapper.CreateMap<ClientDto, Client>();
        }
       
    }
}