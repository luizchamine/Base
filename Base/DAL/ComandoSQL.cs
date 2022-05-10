using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ComandoSQL
    {
        private SqlCommand comando;
        private List<ParametroSQL> parametros;

        public SqlCommand Comando
        {
            get { return comando; }
            set { comando = value; }
        }

        public List<ParametroSQL> Parametros
        {
            get { return parametros; }
            set { parametros = value; }
        }

    }
}
