using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Cliente : Pessoa
    {
        public int Id_Plano { get; set; }
        public DateTime InicioContrato { get; set; }
        public DateTime FimDoContrato { get; set; }

        /* Id , Id_Plano,	InicioDoContrato, FimDoContrato */
    }
}
