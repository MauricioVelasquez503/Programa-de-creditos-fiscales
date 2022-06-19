using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CCF.DTO;

namespace CCF.DAO
{
    internal class ClienteDao : ConexionBD
    {

        SqlDataReader Leerfilas;
        SqlCommand Comando = new SqlCommand();

        //METODOS CRUD
        public List<ClientesDto> VerRegistros(string condicion)
        {
            Comando.Connection = Conexion;
            Comando.CommandText = "VerClientes";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Condicion",condicion);

            Conexion.Open();
            Leerfilas = Comando.ExecuteReader();

            List<ClientesDto> ListaGenerica = new List<ClientesDto>();
            while (Leerfilas.Read()) 
            {
                ListaGenerica.Add(new ClientesDto
                {
                    Nrc = Leerfilas.GetString(0),
                    Razon = Leerfilas.GetString(1),
                    Direccion = Leerfilas.GetString(2),
                    Nit = Leerfilas.GetString(3),
                    Giro = Leerfilas.GetString(4),
                });
            }
            Leerfilas.Close();
            Conexion.Close();

            return ListaGenerica;
        }

        public void Insert() { }
        public void Edit(){}
        public void Delete() { }

    }
}
