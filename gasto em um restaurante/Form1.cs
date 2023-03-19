using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gasto_em_um_restaurante
{
    public partial class FormGastoEmRestaurante : Form
    {
        public FormGastoEmRestaurante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotalDaConta.Text = (Convert.ToDouble(
            txtDespesa.Text) * 1.10).ToString("N");
        }

        private void txtDespesa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalDaConta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
