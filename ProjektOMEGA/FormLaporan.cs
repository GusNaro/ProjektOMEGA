using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektOMEGA
{
    public partial class FormLaporan : Form
    {
        public FormLaporan()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormUtama buka = new FormUtama();
            buka.Show();
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {
            comboBoxTahun.SelectedIndex = 0;
            comboBoxPeriode.SelectedIndex = 0;
            comboBoxWilayah.SelectedIndex = 0;
        }
    }
}
