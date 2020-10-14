namespace FormsProjeto
{
    partial class ClientesForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesForm));
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbApagar = new System.Windows.Forms.PictureBox();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbSair = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AllowUserToAddRows = false;
            this.dataGridClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridClientes.AutoGenerateColumns = false;
            this.dataGridClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dNDataGridViewTextBoxColumn,
            this.documentoDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridClientes.DataSource = this.clienteBindingSource;
            this.dataGridClientes.Location = new System.Drawing.Point(35, 57);
            this.dataGridClientes.MultiSelect = false;
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.ReadOnly = true;
            this.dataGridClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClientes.Size = new System.Drawing.Size(727, 202);
            this.dataGridClientes.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 52;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dNDataGridViewTextBoxColumn
            // 
            this.dNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dNDataGridViewTextBoxColumn.DataPropertyName = "DN";
            this.dNDataGridViewTextBoxColumn.HeaderText = "Data Nascimento";
            this.dNDataGridViewTextBoxColumn.Name = "dNDataGridViewTextBoxColumn";
            this.dNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentoDataGridViewTextBoxColumn
            // 
            this.documentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.documentoDataGridViewTextBoxColumn.DataPropertyName = "Documento";
            this.documentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
            this.documentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            this.generoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Biblioteca.Cliente);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 5);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 426);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 426);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(780, 5);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(785, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 426);
            this.panel4.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(453, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "E-mail: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(453, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefone: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(62, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Género: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(62, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nº Doc. Identificação: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(62, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Data Nascimento: ";
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
            this.dataNascimento.Location = new System.Drawing.Point(226, 314);
            this.dataNascimento.MaxDate = new System.DateTime(2020, 1, 18, 0, 0, 0, 0);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(164, 21);
            this.dataNascimento.TabIndex = 15;
            this.dataNascimento.Value = new System.DateTime(2020, 1, 18, 0, 0, 0, 0);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(126, 278);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(264, 20);
            this.tbNome.TabIndex = 16;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(523, 381);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(222, 20);
            this.tbEmail.TabIndex = 17;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(541, 346);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(204, 20);
            this.tbTelefone.TabIndex = 18;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(253, 347);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(137, 20);
            this.tbID.TabIndex = 19;
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cbGenero.Location = new System.Drawing.Point(143, 380);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(247, 21);
            this.cbGenero.TabIndex = 57;
            // 
            // pbAdd
            // 
            this.pbAdd.Image = global::FormsProjeto.Properties.Resources._226591_512;
            this.pbAdd.Location = new System.Drawing.Point(559, 265);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(67, 37);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 60;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.PbAdd_Click);
            // 
            // pbApagar
            // 
            this.pbApagar.Image = global::FormsProjeto.Properties.Resources._216103_5121;
            this.pbApagar.Location = new System.Drawing.Point(699, 261);
            this.pbApagar.Name = "pbApagar";
            this.pbApagar.Size = new System.Drawing.Size(55, 42);
            this.pbApagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApagar.TabIndex = 59;
            this.pbApagar.TabStop = false;
            this.pbApagar.Click += new System.EventHandler(this.PbApagar_Click);
            // 
            // pbEditar
            // 
            this.pbEditar.Image = global::FormsProjeto.Properties.Resources._2561383_512;
            this.pbEditar.Location = new System.Drawing.Point(629, 265);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(61, 37);
            this.pbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditar.TabIndex = 58;
            this.pbEditar.TabStop = false;
            this.pbEditar.Click += new System.EventHandler(this.PbEditar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormsProjeto.Properties.Resources._309042_512__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pbSair
            // 
            this.pbSair.Image = ((System.Drawing.Image)(resources.GetObject("pbSair.Image")));
            this.pbSair.Location = new System.Drawing.Point(739, 12);
            this.pbSair.Name = "pbSair";
            this.pbSair.Size = new System.Drawing.Size(39, 32);
            this.pbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSair.TabIndex = 4;
            this.pbSair.TabStop = false;
            this.pbSair.Click += new System.EventHandler(this.PbSair_Click);
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(790, 431);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.pbApagar);
            this.Controls.Add(this.pbEditar);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.dataNascimento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridClientes);
            this.Controls.Add(this.pbSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientesForm";
            this.Text = "Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientesForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSair;
        private System.Windows.Forms.DataGridView dataGridClientes;
        public System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dataNascimento;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.PictureBox pbEditar;
        private System.Windows.Forms.PictureBox pbApagar;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}