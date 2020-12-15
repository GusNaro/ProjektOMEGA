
namespace ProjektOMEGA
{
    partial class FormKegiatan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTahun = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxJenis = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxProker = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxWilayah = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKegiatan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNomorNota = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxRealiasi = new System.Windows.Forms.TextBox();
            this.buttonUnggahPDF = new System.Windows.Forms.Button();
            this.textBoxKeterangan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxSetuju = new System.Windows.Forms.CheckBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxWilayah);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxProker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxJenis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxTahun);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 188);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jenis Program";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tahun Anggaran";
            // 
            // comboBoxTahun
            // 
            this.comboBoxTahun.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTahun.FormattingEnabled = true;
            this.comboBoxTahun.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.comboBoxTahun.Location = new System.Drawing.Point(24, 59);
            this.comboBoxTahun.Name = "comboBoxTahun";
            this.comboBoxTahun.Size = new System.Drawing.Size(74, 28);
            this.comboBoxTahun.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Jenis";
            // 
            // comboBoxJenis
            // 
            this.comboBoxJenis.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxJenis.FormattingEnabled = true;
            this.comboBoxJenis.Items.AddRange(new object[] {
            "CSR",
            "TJSL"});
            this.comboBoxJenis.Location = new System.Drawing.Point(24, 126);
            this.comboBoxJenis.Name = "comboBoxJenis";
            this.comboBoxJenis.Size = new System.Drawing.Size(74, 28);
            this.comboBoxJenis.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Program Kerja";
            // 
            // comboBoxProker
            // 
            this.comboBoxProker.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProker.FormattingEnabled = true;
            this.comboBoxProker.Items.AddRange(new object[] {
            "Pendidikan",
            "Kesehatan",
            "Seni dan Budaya",
            "Olahraga",
            "Sosial Lainnya",
            "Sarana & Prasarana Pelestarian Alam, Lingkungan & Kebersihan",
            "Sarana dan Prasarana selain yang tercakup sebelumnya",
            "Kemitraan"});
            this.comboBoxProker.Location = new System.Drawing.Point(178, 59);
            this.comboBoxProker.Name = "comboBoxProker";
            this.comboBoxProker.Size = new System.Drawing.Size(328, 28);
            this.comboBoxProker.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Wilayah";
            // 
            // comboBoxWilayah
            // 
            this.comboBoxWilayah.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWilayah.FormattingEnabled = true;
            this.comboBoxWilayah.Items.AddRange(new object[] {
            "Denpasar",
            "Badung",
            "Buleleng",
            "Tabanan",
            "Jembrana",
            "Gianyar",
            "Klungkung",
            "Bangli",
            "Karangasem",
            "Nusa Tenggara Barat"});
            this.comboBoxWilayah.Location = new System.Drawing.Point(178, 126);
            this.comboBoxWilayah.Name = "comboBoxWilayah";
            this.comboBoxWilayah.Size = new System.Drawing.Size(198, 28);
            this.comboBoxWilayah.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonKeluar);
            this.groupBox2.Controls.Add(this.buttonSubmit);
            this.groupBox2.Controls.Add(this.checkBoxSetuju);
            this.groupBox2.Controls.Add(this.buttonUnggahPDF);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.textBoxNomorNota);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxKeterangan);
            this.groupBox2.Controls.Add(this.textBoxRealiasi);
            this.groupBox2.Controls.Add(this.textBoxKegiatan);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 410);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rincian Kegiatan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nama Kegiatan";
            // 
            // textBoxKegiatan
            // 
            this.textBoxKegiatan.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKegiatan.Location = new System.Drawing.Point(24, 62);
            this.textBoxKegiatan.Name = "textBoxKegiatan";
            this.textBoxKegiatan.Size = new System.Drawing.Size(469, 26);
            this.textBoxKegiatan.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(244, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nomor Nota Persetujuan";
            // 
            // textBoxNomorNota
            // 
            this.textBoxNomorNota.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomorNota.Location = new System.Drawing.Point(248, 200);
            this.textBoxNomorNota.Name = "textBoxNomorNota";
            this.textBoxNomorNota.Size = new System.Drawing.Size(157, 26);
            this.textBoxNomorNota.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tanggal Kegiatan";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 26);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Realisasi (Rp)";
            // 
            // textBoxRealiasi
            // 
            this.textBoxRealiasi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRealiasi.Location = new System.Drawing.Point(24, 200);
            this.textBoxRealiasi.Name = "textBoxRealiasi";
            this.textBoxRealiasi.Size = new System.Drawing.Size(207, 26);
            this.textBoxRealiasi.TabIndex = 7;
            this.textBoxRealiasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonUnggahPDF
            // 
            this.buttonUnggahPDF.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnggahPDF.Location = new System.Drawing.Point(416, 200);
            this.buttonUnggahPDF.Name = "buttonUnggahPDF";
            this.buttonUnggahPDF.Size = new System.Drawing.Size(90, 26);
            this.buttonUnggahPDF.TabIndex = 9;
            this.buttonUnggahPDF.Text = "Unggah PDF";
            this.buttonUnggahPDF.UseVisualStyleBackColor = true;
            // 
            // textBoxKeterangan
            // 
            this.textBoxKeterangan.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeterangan.Location = new System.Drawing.Point(24, 262);
            this.textBoxKeterangan.Multiline = true;
            this.textBoxKeterangan.Name = "textBoxKeterangan";
            this.textBoxKeterangan.Size = new System.Drawing.Size(482, 71);
            this.textBoxKeterangan.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Keterangan (Opsional)";
            // 
            // checkBoxSetuju
            // 
            this.checkBoxSetuju.AutoSize = true;
            this.checkBoxSetuju.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSetuju.Location = new System.Drawing.Point(28, 357);
            this.checkBoxSetuju.Name = "checkBoxSetuju";
            this.checkBoxSetuju.Size = new System.Drawing.Size(191, 24);
            this.checkBoxSetuju.TabIndex = 11;
            this.checkBoxSetuju.Text = "Ya, data diatas sudah benar";
            this.checkBoxSetuju.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(285, 350);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(122, 37);
            this.buttonSubmit.TabIndex = 12;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.Location = new System.Drawing.Point(416, 350);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(90, 37);
            this.buttonKeluar.TabIndex = 13;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = true;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(12, 16);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(33, 20);
            this.labelWelcome.TabIndex = 14;
            this.labelWelcome.Text = "......";
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 682);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelWelcome);
            this.Name = "FormLaporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Program CSR";
            this.Load += new System.EventHandler(this.FormLaporan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxWilayah;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxProker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxJenis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTahun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonUnggahPDF;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxNomorNota;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKeterangan;
        private System.Windows.Forms.TextBox textBoxRealiasi;
        private System.Windows.Forms.TextBox textBoxKegiatan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.CheckBox checkBoxSetuju;
        private System.Windows.Forms.Label labelWelcome;
    }
}