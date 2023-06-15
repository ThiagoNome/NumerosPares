using NumerosPares.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosPares.View
{
    public partial class FormView : Form
    {
        public FormView()
        {
            InitializeComponent();
        }
        Numeros par = new Numeros();

        private void resultado_Click(object sender, EventArgs e)
        {
            if (valores.Text != string.Empty)
            {
                int valor = Convert.ToInt32(valores.Text);
                string resultado = par.Calcular(valor);
                tx_resultado.Text = (resultado.ToString());
            }
            
        }
    }
}
