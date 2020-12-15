
namespace ProjektOMEGA
{
    partial class FormUtama
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
            this.buttonAnggaran = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPendaftaran = new System.Windows.Forms.Button();
            this.buttonPelaporan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonKegiatan = new System.Windows.Forms.Button();
            this.labelUtama = new System.Windows.Forms.Label();
            this.labelPersetujuan = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAnggaran
            // 
            this.buttonAnggaran.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnggaran.Location = new System.Drawing.Point(37, 39);
            this.buttonAnggaran.Name = "buttonAnggaran";
            this.buttonAnggaran.Size = new System.Drawing.Size(201, 49);
            this.buttonAnggaran.TabIndex = 0;
            this.buttonAnggaran.Text = "Anggaran dan Program";
            this.buttonAnggaran.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPendaftaran);
            this.groupBox1.Controls.Add(this.buttonPelaporan);
            this.groupBox1.Controls.Add(this.buttonAnggaran);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 257);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrator";
            // 
            // buttonPendaftaran
            // 
            this.buttonPendaftaran.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPendaftaran.Location = new System.Drawing.Point(37, 171);
            this.buttonPendaftaran.Name = "buttonPendaftaran";
            this.buttonPendaftaran.Size = new System.Drawing.Size(201, 49);
            this.buttonPendaftaran.TabIndex = 0;
            this.buttonPendaftaran.Text = "Pendaftaran User";
            this.buttonPendaftaran.UseVisualStyleBackColor = true;
            this.buttonPendaftaran.Click += new System.EventHandler(this.buttonPendaftaran_Click);
            // 
            // buttonPelaporan
            // 
            this.buttonPelaporan.Location = new System.Drawing.Point(37, 105);
            this.buttonPelaporan.Name = "buttonPelaporan";
            this.buttonPelaporan.Size = new System.Drawing.Size(201, 49);
            this.buttonPelaporan.TabIndex = 0;
            this.buttonPelaporan.Text = "Pelaporan";
            this.buttonPelaporan.UseVisualStyleBackColor = true;
            this.buttonPelaporan.Click += new System.EventHandler(this.buttonPelaporan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonKegiatan);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(305, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 257);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Laporan Kegiatan";
            // 
            // buttonKegiatan
            // 
            this.buttonKegiatan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKegiatan.Location = new System.Drawing.Point(46, 39);
            this.buttonKegiatan.Name = "buttonKegiatan";
            this.buttonKegiatan.Size = new System.Drawing.Size(201, 49);
            this.buttonKegiatan.TabIndex = 0;
            this.buttonKegiatan.Text = "Input Kegiatan";
            this.buttonKegiatan.UseVisualStyleBackColor = true;
            this.buttonKegiatan.Click += new System.EventHandler(this.buttonKegiatan_Click);
            // 
            // labelUtama
            // 
            this.labelUtama.AutoSize = true;
            this.labelUtama.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUtama.Location = new System.Drawing.Point(12, 15);
            this.labelUtama.Name = "labelUtama";
            this.labelUtama.Size = new System.Drawing.Size(222, 31);
            this.labelUtama.TabIndex = 3;
            this.labelUtama.Text = "Mau ngapain anda?";
            // 
            // labelPersetujuan
            // 
            this.labelPersetujuan.AutoSize = true;
            this.labelPersetujuan.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersetujuan.Location = new System.Drawing.Point(16, 343);
            this.labelPersetujuan.Name = "labelPersetujuan";
            this.labelPersetujuan.Size = new System.Drawing.Size(297, 14);
            this.labelPersetujuan.TabIndex = 4;
            this.labelPersetujuan.Text = "Aplikasi ini disediakan secara gratis \"as is\" oleh Narotama";
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.Location = new System.Drawing.Point(507, 333);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(78, 31);
            this.buttonKeluar.TabIndex = 0;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = true;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 376);
            this.ControlBox = false;
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.labelPersetujuan);
            this.Controls.Add(this.labelUtama);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Pelaporan Program CSR";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnggaran;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonPendaftaran;
        private System.Windows.Forms.Button buttonPelaporan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonKegiatan;
        private System.Windows.Forms.Label labelUtama;
        private System.Windows.Forms.Label labelPersetujuan;
        private System.Windows.Forms.Button buttonKeluar;
    }
}

