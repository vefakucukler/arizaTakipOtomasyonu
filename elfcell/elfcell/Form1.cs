using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elfcell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listAdSoyad.Items.Add(txtAdSoyad.Text);
            listArıza.Items.Add(TxtArıza.Text);
            listTamirFiyati.Items.Add(TxtTamirFiyati.Text+" TL");
            listTamirSuresi.Items.Add(TxtTamirSuresi.Text+" Gün");
            listTelefon.Items.Add(txtTelefon.Text);
            listTelefonMarkası.Items.Add(cmbBoxTelefonMarkası.Text);
            listTelefonModeli.Items.Add(TxtTelefonModeli.Text);
            listSeriNumarasi.Items.Add(txtSeriNumarasi.Text);
            listOzelNot.Items.Add(txtOzelNot.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Clear();
            TxtArıza.Clear();
            txtOzelNot.Clear();
            TxtTamirFiyati.Clear();
            TxtTamirSuresi.Clear();
            txtTelefon.Clear();
            TxtTelefonModeli.Clear();
            txtSeriNumarasi.Clear();
            cmbBoxTelefonMarkası.Text="";
            
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
