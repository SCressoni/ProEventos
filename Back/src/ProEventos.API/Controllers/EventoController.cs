using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]
        {
            new Evento(){
                    EventoId = 1,
                    Tema = "Angular 11 e .NET 5",
                    Local = "Lisboa / Portugal",
                    Lote = "1 lote",
                    QtdePessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImageURL = "foto.png"
                },
                new Evento(){
                    EventoId = 2,
                    Tema = "Java React",
                    Local = "Porto / Portugal",
                    Lote = "2 lote",
                    QtdePessoas = 180,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImageURL = "foto.png"
                }
        };
        public EventoController()
        {            
        }   

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public IEnumerable<Evento> Get(int id)
        {
            return _evento.Where(x => x.EventoId == id);
        }
    }
}
