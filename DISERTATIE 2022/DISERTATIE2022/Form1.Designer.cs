
namespace DISERTATIE2022
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Out = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TransmisiaBB = new System.Windows.Forms.Button();
            this.DMQAM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MQAM = new System.Windows.Forms.Button();
            this.DMF = new System.Windows.Forms.Button();
            this.MF = new System.Windows.Forms.Button();
            this.DMA = new System.Windows.Forms.Button();
            this.MA = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.Out);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1511, 120);
            this.panel1.TabIndex = 0;
            // 
            // Out
            // 
            this.Out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Out.BackColor = System.Drawing.Color.Red;
            this.Out.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Out.Location = new System.Drawing.Point(1393, 23);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(104, 77);
            this.Out.TabIndex = 7;
            this.Out.Text = "X";
            this.Out.UseVisualStyleBackColor = false;
            this.Out.Click += new System.EventHandler(this.Out_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1199, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "APLICATIE WINDOWS PRIVIND MODULATIA SI DEMODULATIA UNUI SEMNAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DISERTATIE2022.Properties.Resources.Sample_10_1024x724;
            this.pictureBox1.Location = new System.Drawing.Point(3, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1030, 717);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel2.Controls.Add(this.TransmisiaBB);
            this.panel2.Controls.Add(this.DMQAM);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.MQAM);
            this.panel2.Controls.Add(this.DMF);
            this.panel2.Controls.Add(this.MF);
            this.panel2.Controls.Add(this.DMA);
            this.panel2.Controls.Add(this.MA);
            this.panel2.Location = new System.Drawing.Point(1030, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 714);
            this.panel2.TabIndex = 2;
            // 
            // TransmisiaBB
            // 
            this.TransmisiaBB.BackColor = System.Drawing.Color.White;
            this.TransmisiaBB.Location = new System.Drawing.Point(118, 642);
            this.TransmisiaBB.Name = "TransmisiaBB";
            this.TransmisiaBB.Size = new System.Drawing.Size(298, 64);
            this.TransmisiaBB.TabIndex = 7;
            this.TransmisiaBB.Text = "Transmisia BB";
            this.TransmisiaBB.UseVisualStyleBackColor = false;
            this.TransmisiaBB.Click += new System.EventHandler(this.TransmisiaBB_Click);
            // 
            // DMQAM
            // 
            this.DMQAM.BackColor = System.Drawing.Color.White;
            this.DMQAM.Location = new System.Drawing.Point(118, 550);
            this.DMQAM.Name = "DMQAM";
            this.DMQAM.Size = new System.Drawing.Size(298, 64);
            this.DMQAM.TabIndex = 6;
            this.DMQAM.Text = "Demodulatia QAM";
            this.DMQAM.UseVisualStyleBackColor = false;
            this.DMQAM.Click += new System.EventHandler(this.DMQAM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(81, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Meniul Principal";
            // 
            // MQAM
            // 
            this.MQAM.BackColor = System.Drawing.Color.White;
            this.MQAM.Location = new System.Drawing.Point(118, 458);
            this.MQAM.Name = "MQAM";
            this.MQAM.Size = new System.Drawing.Size(298, 64);
            this.MQAM.TabIndex = 4;
            this.MQAM.Text = "Modulatia QAM";
            this.MQAM.UseVisualStyleBackColor = false;
            this.MQAM.Click += new System.EventHandler(this.MQAM_Click);
            // 
            // DMF
            // 
            this.DMF.BackColor = System.Drawing.Color.White;
            this.DMF.Location = new System.Drawing.Point(118, 369);
            this.DMF.Name = "DMF";
            this.DMF.Size = new System.Drawing.Size(298, 64);
            this.DMF.TabIndex = 3;
            this.DMF.Text = "Demodulatia in Frecventa";
            this.DMF.UseVisualStyleBackColor = false;
            this.DMF.Click += new System.EventHandler(this.DMF_Click);
            // 
            // MF
            // 
            this.MF.BackColor = System.Drawing.Color.White;
            this.MF.Location = new System.Drawing.Point(118, 270);
            this.MF.Name = "MF";
            this.MF.Size = new System.Drawing.Size(298, 64);
            this.MF.TabIndex = 2;
            this.MF.Text = "Modulatia in Frecventa";
            this.MF.UseVisualStyleBackColor = false;
            this.MF.Click += new System.EventHandler(this.MF_Click);
            // 
            // DMA
            // 
            this.DMA.BackColor = System.Drawing.Color.White;
            this.DMA.Location = new System.Drawing.Point(118, 182);
            this.DMA.Name = "DMA";
            this.DMA.Size = new System.Drawing.Size(298, 64);
            this.DMA.TabIndex = 1;
            this.DMA.Text = "Demodulatia in Amplitudine";
            this.DMA.UseVisualStyleBackColor = false;
            this.DMA.Click += new System.EventHandler(this.DMA_Click);
            // 
            // MA
            // 
            this.MA.BackColor = System.Drawing.Color.White;
            this.MA.Location = new System.Drawing.Point(118, 94);
            this.MA.Name = "MA";
            this.MA.Size = new System.Drawing.Size(298, 64);
            this.MA.TabIndex = 0;
            this.MA.Text = "Modulatia in Amplitudine";
            this.MA.UseVisualStyleBackColor = false;
            this.MA.Click += new System.EventHandler(this.MA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 838);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Meniul Princpal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DMQAM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MQAM;
        private System.Windows.Forms.Button DMF;
        private System.Windows.Forms.Button MF;
        private System.Windows.Forms.Button DMA;
        private System.Windows.Forms.Button MA;
        private System.Windows.Forms.Button Out;
        private System.Windows.Forms.Button TransmisiaBB;
    }
}

