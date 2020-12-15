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
    public partial class FormDaftar : Form
    {
        public FormDaftar()
        {
            InitializeComponent();
        }

        private void FormDaftar_Load(object sender, EventArgs e)
        {
            comboBoxLevel.SelectedIndex = 0;
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            FormUtama buka = new FormUtama();
            buka.Show();
        }
    }
}
