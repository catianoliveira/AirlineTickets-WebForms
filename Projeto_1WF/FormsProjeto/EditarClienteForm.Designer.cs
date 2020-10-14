namespace FormsProjeto
{
    partial class EditarClienteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarClienteForm));
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbOK = new System.Windows.Forms.PictureBox();
            this.pbSair = new System.Windows.Forms.PictureBox();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cbGenero.Location = new System.Drawing.Point(108, 179);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(234, 21);
            this.cbGenero.TabIndex = 65;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(223, 146);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(119, 20);
            this.tbID.TabIndex = 64;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(94, 77);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(248, 20);
            this.tbNome.TabIndex = 63;
            // 
            // dataNascimento
            // 
            this.dataNascimento.CalendarForeColor = System.Drawing.Color.White;
            this.dataNascimento.CalendarMonthBackground = System.Drawing.Color.LightSlateGray;
            this.dataNascimento.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dataNascimento.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dataNascimento.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascimento.Location = new System.Drawing.Point(196, 113);
            this.dataNascimento.MaxDate = new System.DateTime(2020, 1, 18, 0, 0, 0, 0);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(146, 21);
            this.dataNascimento.TabIndex = 62;
            this.dataNascimento.Value = new System.DateTime(2020, 1, 18, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "Data Nascimento: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 20);
            this.label5.TabIndex = 60;
            this.label5.Text = "Nº Doc. Identificação: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Género: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Nome: ";
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(114, 215);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(228, 20);
            this.tbTelefone.TabIndex = 69;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(104, 250);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(238, 20);
            this.tbEmail.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Telefone: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "E-mail: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(368, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 370);
            this.panel1.TabIndex = 73;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 5);
            this.panel2.TabIndex = 74;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 360);
            this.panel3.TabIndex = 74;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(368, 5);
            this.panel4.TabIndex = 74;
            // 
            // pbOK
            // 
            this.pbOK.Image = global::FormsProjeto.Properties.Resources._4781846_512;
            this.pbOK.Location = new System.Drawing.Point(147, 293);
            this.pbOK.Name = "pbOK";
            this.pbOK.Size = new System.Drawing.Size(80, 48);
            this.pbOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOK.TabIndex = 76;
            this.pbOK.TabStop = false;
            this.pbOK.Click += new System.EventHandler(this.PbOK_Click);
            // 
            // pbSair
            // 
            this.pbSair.Image = ((System.Drawing.Image)(resources.GetObject("pbSair.Image")));
            this.pbSair.Location = new System.Drawing.Point(312, 12);
            this.pbSair.Name = "pbSair";
            this.pbSair.Size = new System.Drawing.Size(39, 32);
            this.pbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSair.TabIndex = 72;
            this.pbSair.TabStop = false;
            this.pbSair.Click += new System.EventHandler(this.PbSair_Click);
            // 
            // pbEditar
            // 
            this.pbEditar.Image = global::FormsProjeto.Properties.Resources._2561383_512;
            this.pbEditar.Location = new System.Drawing.Point(12, 12);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(61, 35);
            this.pbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditar.TabIndex = 71;
            this.pbEditar.TabStop = false;
            // 
            // EditarClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(373, 370);
            this.Controls.Add(this.pbOK);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbSair);
            this.Controls.Add(this.pbEditar);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.dataNascimento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditarClienteForm";
            this.Text = "Editar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pbOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.DateTimePicker dataNascimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbEditar;
        private System.Windows.Forms.PictureBox pbSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbOK;
    }
}