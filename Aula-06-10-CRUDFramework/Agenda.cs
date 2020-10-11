using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06_10_CRUDFramework
{
    class Agenda
    {

        public int id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string CEP { get; set; }
        public double Salario { get; set; }

    }
}
