using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CCF.DAO
{
    class ConexionBD
    {
        protected SqlConnection Conexion = new SqlConnection("Server=DISSMVELASQUEZ\\SQLEXPRESS;DataBase=creditos_fiscales;Integrated Security= True;"); 
    }
}
