using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Funcionario : Pessoa
    {
        public int Id_Permissao { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public double Salario { get; set; }
        public string Cargo { get; set; }
        public DateTime DataAdmissao { get; set; }
    }
}
