using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCF.DTO
{
    internal class ClientesDto
    {
        //ATRIBUTOS

        string _Nrc;
        string _Razon;
        string _Direccion;
        string _Nit;
        string _Giro;

        public string Nrc { get => _Nrc; set => _Nrc = value; }

        public string Razon { get => _Razon; set => _Razon = value; }

        public string Direccion { get => _Direccion; set => _Direccion = value; }
        
        public string Nit { get => _Nit; set => _Nit = value; }
        public string Giro { get => _Giro; set => _Giro = value; }
     



        //PROPIEDADES GETTER AND SETTERS

    }
}
