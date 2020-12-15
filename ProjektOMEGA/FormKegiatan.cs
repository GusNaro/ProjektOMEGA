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
    public partial class FormKegiatan : Form
    {
        public FormKegiatan()
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
            comboBoxJenis.SelectedIndex = 0;
            comboBoxProker.SelectedIndex = 0;
            comboBoxTahun.SelectedIndex = 0;
            comboBoxWilayah.SelectedIndex = 0;
            labelWelcome.Text = "Halo Narotama \nSilakan masukkan rincian kegiatannya dibawah ini";
        }
    }
}
