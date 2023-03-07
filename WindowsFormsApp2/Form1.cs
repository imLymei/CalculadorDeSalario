using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Cpf = CpfInput.Text;
            funcionario.Nome = NomeInput.Text;
            funcionario.Valor_hora = float.Parse(ValorInput.Text);
            funcionario.Horas = int.Parse(HorasInput.Text);

            funcionario.CalcularSalario();

            SalarioLabel.Visible = true;
            SalarioOutput.Visible = true;

            SalarioOutput.Text = "R$ "+ funcionario.Salario.ToString("n2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SalarioLabel.Visible = false;
            SalarioOutput.Visible = false;
        }
    }
}
