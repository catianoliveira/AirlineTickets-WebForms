namespace FormsProjeto
{
    partial class AeroportosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AeroportosForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbAeroportos = new System.Windows.Forms.PictureBox();
            this.pbSair = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridAeroportos = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeroportoNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paísDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeroportoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbApagar = new System.Windows.Forms.PictureBox();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAeroporto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAeroportos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAeroportos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApagar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAeroportos
            // 
            this.pbAeroportos.Image = global::FormsProjeto.Properties.Resources._2639757_512;
            this.pbAeroportos.Location = new System.Drawing.Point(3, 12);
            this.pbAeroportos.Name = "pbAeroportos";
            this.pbAeroportos.Size = new System.Drawing.Size(76, 49);
            this.pbAeroportos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAeroportos.TabIndex = 13;
            this.pbAeroportos.TabStop = false;
            // 
            // pbSair
            // 
            this.pbSair.Image = ((System.Drawing.Image)(resources.GetObject("pbSair.Image")));
            this.pbSair.Location = new System.Drawing.Point(668, 12);
            this.pbSair.Name = "pbSair";
            this.pbSair.Size = new System.Drawing.Size(39, 32);
            this.pbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSair.TabIndex = 14;
            this.pbSair.TabStop = false;
            this.pbSair.Click += new System.EventHandler(this.PbSair_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 5);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(714, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 414);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 409);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 414);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(714, 5);
            this.panel4.TabIndex = 17;
            // 
            // dataGridAeroportos
            // 
            this.dataGridAeroportos.AllowUserToAddRows = false;
            this.dataGridAeroportos.AllowUserToDeleteRows = false;
            this.dataGridAeroportos.AllowUserToOrderColumns = true;
            this.dataGridAeroportos.AutoGenerateColumns = false;
            this.dataGridAeroportos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridAeroportos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAeroportos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.aeroportoNomeDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.paísDataGridViewTextBoxColumn});
            this.dataGridAeroportos.DataSource = this.aeroportoBindingSource;
            this.dataGridAeroportos.Location = new System.Drawing.Point(85, 55);
            this.dataGridAeroportos.MultiSelect = false;
            this.dataGridAeroportos.Name = "dataGridAeroportos";
            this.dataGridAeroportos.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridAeroportos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAeroportos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAeroportos.Size = new System.Drawing.Size(551, 216);
            this.dataGridAeroportos.TabIndex = 19;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 52;
            // 
            // aeroportoNomeDataGridViewTextBoxColumn
            // 
            this.aeroportoNomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aeroportoNomeDataGridViewTextBoxColumn.DataPropertyName = "AeroportoNome";
            this.aeroportoNomeDataGridViewTextBoxColumn.HeaderText = "Aeroporto";
            this.aeroportoNomeDataGridViewTextBoxColumn.Name = "aeroportoNomeDataGridViewTextBoxColumn";
            this.aeroportoNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paísDataGridViewTextBoxColumn
            // 
            this.paísDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paísDataGridViewTextBoxColumn.DataPropertyName = "País";
            this.paísDataGridViewTextBoxColumn.HeaderText = "País";
            this.paísDataGridViewTextBoxColumn.Name = "paísDataGridViewTextBoxColumn";
            this.paísDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aeroportoBindingSource
            // 
            this.aeroportoBindingSource.DataSource = typeof(Biblioteca.Aeroporto);
            // 
            // pbAdd
            // 
            this.pbAdd.Image = global::FormsProjeto.Properties.Resources._226591_512;
            this.pbAdd.Location = new System.Drawing.Point(498, 279);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(67, 37);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 66;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.PbAdd_Click);
            // 
            // pbApagar
            // 
            this.pbApagar.Image = global::FormsProjeto.Properties.Resources._216103_5121;
            this.pbApagar.Location = new System.Drawing.Point(581, 272);
            this.pbApagar.Name = "pbApagar";
            this.pbApagar.Size = new System.Drawing.Size(55, 44);
            this.pbApagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApagar.TabIndex = 65;
            this.pbApagar.TabStop = false;
            this.pbApagar.Click += new System.EventHandler(this.PbApagar_Click);
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(145, 374);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(235, 20);
            this.tbPais.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "País: ";
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(171, 335);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(209, 20);
            this.tbCidade.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(94, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "Cidade:";
            // 
            // tbAeroporto
            // 
            this.tbAeroporto.Location = new System.Drawing.Point(190, 295);
            this.tbAeroporto.Name = "tbAeroporto";
            this.tbAeroporto.Size = new System.Drawing.Size(190, 20);
            this.tbAeroporto.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(94, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "Aeroporto: ";
            // 
            // AeroportosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(719, 419);
            this.Controls.Add(this.tbAeroporto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.pbApagar);
            this.Controls.Add(this.dataGridAeroportos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbSair);
            this.Controls.Add(this.pbAeroportos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AeroportosForm";
            this.Text = "Aeroportos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AeroportosForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbAeroportos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAeroportos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAeroportos;
        private System.Windows.Forms.PictureBox pbSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.DataGridView dataGridAeroportos;
        public System.Windows.Forms.BindingSource aeroportoBindingSource;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pbApagar;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAeroporto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeroportoNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paísDataGridViewTextBoxColumn;
    }
}