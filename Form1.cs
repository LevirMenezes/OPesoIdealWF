using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        public RadioButton RbnChecado { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void radioBtnHomem_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = sender as RadioButton;
            if (rbn.Checked)
            {
                RbnChecado = rbn;
                SetPesoIdeal();
            }
        }

        private void radioBtnMulher_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = sender as RadioButton;
            if (rbn.Checked)
            {
                RbnChecado = rbn;
                SetPesoIdeal();
            }
        }

        private void SetPesoIdeal()
        {
            if (!String.IsNullOrEmpty(txtAltura.Text))
            {
                if (RbnChecado.Text == "Homem")
                {
                    this.lblPesoIdeal.Text = PesoIdealHomem().ToString();
                }
                else
                {
                    this.lblPesoIdeal.Text = PesoIdealMulher().ToString();
                }
            }
        }

        private double PesoIdealHomem()
        {
            return (72.7 * double.Parse(txtAltura.Text)) - 58;
        }

        private double PesoIdealMulher()
        {
            return (62.1 * double.Parse(this.txtAltura.Text)) - 44.7;
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            if (RbnChecado != null)
            {
                SetPesoIdeal();
            }
        }
    }
}
