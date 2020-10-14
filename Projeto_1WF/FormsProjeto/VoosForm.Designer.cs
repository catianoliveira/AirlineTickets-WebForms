namespace FormsProjeto
{
    partial class VoosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoosForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbSair = new System.Windows.Forms.PictureBox();
            this.pbVoos = new System.Windows.Forms.PictureBox();
            this.vooBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOrigem = new System.Windows.Forms.ComboBox();
            this.dTPHora = new System.Windows.Forms.DateTimePicker();
            this.cbAparelho = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbApagar = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.aparelhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeroportoDestinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeroportoOrigemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridVoos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vooBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVoos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 465);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 5);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(787, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 460);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 460);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(782, 5);
            this.panel4.TabIndex = 3;
            // 
            // pbSair
            // 
            this.pbSair.Image = ((System.Drawing.Image)(resources.GetObject("pbSair.Image")));
            this.pbSair.Location = new System.Drawing.Point(741, 11);
            this.pbSair.Name = "pbSair";
            this.pbSair.Size = new System.Drawing.Size(39, 32);
            this.pbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSair.TabIndex = 6;
            this.pbSair.TabStop = false;
            this.pbSair.Click += new System.EventHandler(this.PbSair_Click);
            // 
            // pbVoos
            // 
            this.pbVoos.Image = global::FormsProjeto.Properties.Resources._3383442_512;
            this.pbVoos.Location = new System.Drawing.Point(5, 12);
            this.pbVoos.Name = "pbVoos";
            this.pbVoos.Size = new System.Drawing.Size(81, 55);
            this.pbVoos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVoos.TabIndex = 15;
            this.pbVoos.TabStop = false;
            // 
            // vooBindingSource
            // 
            this.vooBindingSource.DataSource = typeof(Biblioteca.Voo);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(162, 268);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(188, 20);
            this.tbID.TabIndex = 98;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(84, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 97;
            this.label6.Text = "Voo nº:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 96;
            this.label2.Text = "Destino:";
            // 
            // cbDestino
            // 
            this.cbDestino.Enabled = false;
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(165, 338);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(185, 21);
            this.cbDestino.TabIndex = 95;
            this.cbDestino.SelectedIndexChanged += new System.EventHandler(this.cbDestino_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 94;
            this.label1.Text = "Origem:";
            // 
            // cbOrigem
            // 
            this.cbOrigem.FormattingEnabled = true;
            this.cbOrigem.Location = new System.Drawing.Point(165, 303);
            this.cbOrigem.Name = "cbOrigem";
            this.cbOrigem.Size = new System.Drawing.Size(185, 21);
            this.cbOrigem.TabIndex = 93;
            this.cbOrigem.SelectedIndexChanged += new System.EventHandler(this.CbOrigem_SelectedIndexChanged);
            // 
            // dTPHora
            // 
            this.dTPHora.Location = new System.Drawing.Point(234, 375);
            this.dTPHora.Name = "dTPHora";
            this.dTPHora.Size = new System.Drawing.Size(116, 20);
            this.dTPHora.TabIndex = 104;
            // 
            // cbAparelho
            // 
            this.cbAparelho.FormattingEnabled = true;
            this.cbAparelho.Location = new System.Drawing.Point(178, 413);
            this.cbAparelho.Name = "cbAparelho";
            this.cbAparelho.Size = new System.Drawing.Size(172, 21);
            this.cbAparelho.TabIndex = 103;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(84, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 102;
            this.label4.Text = "Aparelho:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(383, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 101;
            this.label5.Text = "Dia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(84, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 100;
            this.label3.Text = "Hora de partida:";
            // 
            // pbAdd
            // 
            this.pbAdd.Image = global::FormsProjeto.Properties.Resources._226591_512;
            this.pbAdd.Location = new System.Drawing.Point(678, 258);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(67, 37);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 107;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.PbAdd_Click);
            // 
            // pbApagar
            // 
            this.pbApagar.Image = global::FormsProjeto.Properties.Resources._216103_5121;
            this.pbApagar.Location = new System.Drawing.Point(686, 301);
            this.pbApagar.Name = "pbApagar";
            this.pbApagar.Size = new System.Drawing.Size(55, 42);
            this.pbApagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApagar.TabIndex = 106;
            this.pbApagar.TabStop = false;
            this.pbApagar.Click += new System.EventHandler(this.PbApagar_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(438, 272);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 109;
            // 
            // aparelhoDataGridViewTextBoxColumn
            // 
            this.aparelhoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aparelhoDataGridViewTextBoxColumn.DataPropertyName = "Aparelho";
            this.aparelhoDataGridViewTextBoxColumn.HeaderText = "Aparelho";
            this.aparelhoDataGridViewTextBoxColumn.Name = "aparelhoDataGridViewTextBoxColumn";
            this.aparelhoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaDataGridViewTextBoxColumn
            // 
            this.diaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diaDataGridViewTextBoxColumn.DataPropertyName = "Dia";
            this.diaDataGridViewTextBoxColumn.HeaderText = "Dia";
            this.diaDataGridViewTextBoxColumn.Name = "diaDataGridViewTextBoxColumn";
            this.diaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aeroportoDestinoDataGridViewTextBoxColumn
            // 
            this.aeroportoDestinoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aeroportoDestinoDataGridViewTextBoxColumn.DataPropertyName = "AeroportoDestino";
            this.aeroportoDestinoDataGridViewTextBoxColumn.HeaderText = "Destino";
            this.aeroportoDestinoDataGridViewTextBoxColumn.Name = "aeroportoDestinoDataGridViewTextBoxColumn";
            this.aeroportoDestinoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aeroportoOrigemDataGridViewTextBoxColumn
            // 
            this.aeroportoOrigemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aeroportoOrigemDataGridViewTextBoxColumn.DataPropertyName = "AeroportoOrigem";
            this.aeroportoOrigemDataGridViewTextBoxColumn.HeaderText = "Origem";
            this.aeroportoOrigemDataGridViewTextBoxColumn.Name = "aeroportoOrigemDataGridViewTextBoxColumn";
            this.aeroportoOrigemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 52;
            // 
            // dataGridVoos
            // 
            this.dataGridVoos.AllowUserToAddRows = false;
            this.dataGridVoos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridVoos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridVoos.AutoGenerateColumns = false;
            this.dataGridVoos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridVoos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridVoos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle10.Format = "d";
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVoos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridVoos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVoos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.aeroportoOrigemDataGridViewTextBoxColumn,
            this.aeroportoDestinoDataGridViewTextBoxColumn,
            this.diaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.aparelhoDataGridViewTextBoxColumn});
            this.dataGridVoos.DataSource = this.vooBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVoos.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridVoos.Location = new System.Drawing.Point(87, 50);
            this.dataGridVoos.MultiSelect = false;
            this.dataGridVoos.Name = "dataGridVoos";
            this.dataGridVoos.ReadOnly = true;
            this.dataGridVoos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.dataGridVoos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridVoos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVoos.Size = new System.Drawing.Size(654, 202);
            this.dataGridVoos.TabIndex = 110;
            // 
            // VoosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(792, 465);
            this.Controls.Add(this.dataGridVoos);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.pbApagar);
            this.Controls.Add(this.dTPHora);
            this.Controls.Add(this.cbAparelho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDestino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOrigem);
            this.Controls.Add(this.pbVoos);
            this.Controls.Add(this.pbSair);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VoosForm";
            this.Text = "Voos";
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vooBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVoos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbSair;
        private System.Windows.Forms.PictureBox pbVoos;
        private System.Windows.Forms.BindingSource vooBindingSource;
        private System.Windows.Forms.TextBox tbID;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDestino;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOrigem;
        private System.Windows.Forms.DateTimePicker dTPHora;
        private System.Windows.Forms.ComboBox cbAparelho;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pbApagar;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aparelhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeroportoDestinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeroportoOrigemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridVoos;
    }
}