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
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        public string pesan = "Aplikasi CSR ini menjelaskan";

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonKegiatan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKegiatan buka = new FormKegiatan();
            buka.Show();
        }

        private void buttonPelaporan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLaporan buka = new FormLaporan();
            buka.Show();
        }

        private void buttonPendaftaran_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDaftar buka = new FormDaftar();
            buka.Show();
        }
    }
}
