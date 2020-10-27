using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Idade
{
    public partial class Idade : Form
    {
        public Idade()
        {
            InitializeComponent();
        }

        private void btnCalculaIdade_Click(object sender, EventArgs e)
        {
            if (DataNascimento.Value.Year < DateTime.Now.Year)
            {
                int idade = DateTime.Now.Year - DataNascimento.Value.Year;
                if (DateTime.Now.DayOfYear  < DataNascimento.Value.DayOfYear) idade--;

                lblIdade.Text = "A idade é " + idade;
            }
            else
            {
                lblIdade.Text = 0 + " anos de idade!";
            }
        }
    }
}
