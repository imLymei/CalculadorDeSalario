using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Funcionario
    {
        public string Nome { get; set; } = String.Empty;
        public string Cpf { get; set; } = String.Empty;
        public float Valor_hora { get; set; }
        public int Horas { get; set; }
        public float Salario { get; private set; }
        public void CalcularSalario()
        {
            Salario = Horas * Valor_hora;
        }
    }
}
