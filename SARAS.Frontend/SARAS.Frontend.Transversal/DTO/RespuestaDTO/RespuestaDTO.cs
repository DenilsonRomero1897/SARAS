using System;
using System.Collections.Generic;
using System.Text;

namespace SARAS.Frontend.Transversal.DTO.RespuestaDTO
{
    public class RespuestaDTO<T>
    {
        public T Entidad { get; set; }
        public string Mensaje { get; set; }
        public int Codigo { get; set; }
        public string Excepcion { get; set; }
    }
}
