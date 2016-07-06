using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;
using AutoMapper;
using BO;
using BusinessLogicLayer;
using IHMWeb.Dtos;

namespace IHMWeb.Controllers.Api
{
    public class ClientController : ApiController
    {
        private GestionnaireContrat gesContrat;

        public ClientController()
        {
            gesContrat = new GestionnaireContrat();
        }

        public IEnumerable<ClientDto> GetClients()
        {
            return gesContrat.GetAllClients().Select(Mapper.Map<Client, ClientDto>);
        }

        public IHttpActionResult GetClient(int id)
        {
            var client = gesContrat.GetClient(id);
            if(client == null)
               return NotFound();
            return Ok(Mapper.Map<Client, ClientDto>(client));
        }

        //Put/api
        [HttpPut]
        public IHttpActionResult UpdateClient(int id, ClientDto clientDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var clientInDb = gesContrat.GetClient(id);
            if(clientInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(clientDto, clientInDb);
            gesContrat.ValiderChangement();

            return Ok();

        }
    }
}
