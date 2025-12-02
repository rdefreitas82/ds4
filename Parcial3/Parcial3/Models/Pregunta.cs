using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial3.Models
{
    public class Preguntas
    {
        public string Id { get; set; }
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }

        public Preguntas(string id, string pregunta, string respuesta)
        {
            Id = id;
            Pregunta = pregunta;
            Respuesta = respuesta;
        }
    }
}