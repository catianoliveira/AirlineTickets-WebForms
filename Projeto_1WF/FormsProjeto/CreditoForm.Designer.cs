namespace FormsProjeto
{
    partial class CreditoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbCredito = new System.Windows.Forms.PictureBox();
            this.pbSair = new System.Windows.Forms.PictureBox();
            this.lblData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 315);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 310);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 5);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(341, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 305);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(341, 5);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "V 1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cátia Oliveira";
            // 
            // pbCredito
            // 
            this.pbCredito.Image = global::FormsProjeto.Properties.Resources.System_31_512;
            this.pbCredito.Location = new System.Drawing.Point(12, 12);
            this.pbCredito.Name = "pbCredito";
            this.pbCredito.Size = new System.Drawing.Size(54, 35);
            this.pbCredito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCredito.TabIndex = 19;
            this.pbCredito.TabStop = false;
            // 
            // pbSair
            // 
            this.pbSair.Image = ((System.Drawing.Image)(resources.GetObject("pbSair.Image")));
            this.pbSair.Location = new System.Drawing.Point(295, 15);
            this.pbSair.Name = "pbSair";
            this.pbSair.Size = new System.Drawing.Size(39, 32);
            this.pbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSair.TabIndex = 20;
            this.pbSair.TabStop = false;
            this.pbSair.Click += new System.EventHandler(this.PbSair_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(119, 198);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(100, 24);
            this.lblData.TabIndex = 21;
            this.lblData.Text = "26/02/2020";
            // 
            // CreditoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(346, 315);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.pbSair);
            this.Controls.Add(this.pbCredito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreditoForm";
            this.Text = "CreditoForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbCredito;
        private System.Windows.Forms.PictureBox pbSair;
        private System.Windows.Forms.Label lblData;
    }
}