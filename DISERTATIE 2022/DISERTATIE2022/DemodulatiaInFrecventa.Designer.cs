
namespace DISERTATIE2022
{
    partial class DemodulatiaInFrecventa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Demodulare2 = new System.Windows.Forms.Button();
            this.Demodulare1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1454, 104);
            this.panel1.TabIndex = 1;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Silver;
            this.Back.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Back.Location = new System.Drawing.Point(1345, 10);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(97, 78);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(523, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Demodulatia in Frecventa";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.Demodulare2);
            this.panel2.Controls.Add(this.Demodulare1);
            this.panel2.Location = new System.Drawing.Point(-1, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1454, 709);
            this.panel2.TabIndex = 2;
            // 
            // Demodulare2
            // 
            this.Demodulare2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Demodulare2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Demodulare2.Location = new System.Drawing.Point(461, 354);
            this.Demodulare2.Name = "Demodulare2";
            this.Demodulare2.Size = new System.Drawing.Size(547, 112);
            this.Demodulare2.TabIndex = 2;
            this.Demodulare2.Text = "B. Demodulare cu bucla PLL";
            this.Demodulare2.UseVisualStyleBackColor = false;
            this.Demodulare2.Click += new System.EventHandler(this.Demodulare2_Click);
            // 
            // Demodulare1
            // 
            this.Demodulare1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Demodulare1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Demodulare1.Location = new System.Drawing.Point(461, 165);
            this.Demodulare1.Name = "Demodulare1";
            this.Demodulare1.Size = new System.Drawing.Size(547, 112);
            this.Demodulare1.TabIndex = 1;
            this.Demodulare1.Text = "A. Demodulare prin derivare și detecție de anvelopă";
            this.Demodulare1.UseVisualStyleBackColor = false;
            this.Demodulare1.Click += new System.EventHandler(this.Demodulare1_Click);
            // 
            // DemodulatiaInFrecventa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 818);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "DemodulatiaInFrecventa";
            this.Text = "DemodulatiaInFrecventa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Demodulare2;
        private System.Windows.Forms.Button Demodulare1;
    }
}