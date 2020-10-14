namespace FormsProjeto
{
    partial class AparelhosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AparelhosForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridAparelhos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LugaresEconomicos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LugaresExecutivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aparelhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLugaresExecutivos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLugaresEconomicos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbApagar = new System.Windows.Forms.PictureBox();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            this.pbAparelhos = new System.Windows.Forms.PictureBox();
            this.pbSair = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAparelhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aparelhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAparelhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(676, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 418);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 418);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 413);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(671, 5);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(671, 5);
            this.panel4.TabIndex = 8;
            // 
            // dataGridAparelhos
            // 
            this.dataGridAparelhos.AllowUserToAddRows = false;
            this.dataGridAparelhos.AllowUserToDeleteRows = false;
            this.dataGridAparelhos.AutoGenerateColumns = false;
            this.dataGridAparelhos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridAparelhos.ColumnHeadersHeight = 25;
            this.dataGridAparelhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridAparelhos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.modeloDataGridViewTextBoxColumn,
            this.LugaresEconomicos,
            this.LugaresExecutivos,
            this.quantidadeDataGridViewTextBoxColumn});
            this.dataGridAparelhos.DataSource = this.aparelhoBindingSource;
            this.dataGridAparelhos.Location = new System.Drawing.Point(70, 49);
            this.dataGridAparelhos.MultiSelect = false;
            this.dataGridAparelhos.Name = "dataGridAparelhos";
            this.dataGridAparelhos.ReadOnly = true;
            this.dataGridAparelhos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAparelhos.Size = new System.Drawing.Size(565, 197);
            this.dataGridAparelhos.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 52;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.FillWeight = 85.51724F;
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LugaresEconomicos
            // 
            this.LugaresEconomicos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LugaresEconomicos.DataPropertyName = "LugaresEconomicos";
            this.LugaresEconomicos.FillWeight = 85.51724F;
            this.LugaresEconomicos.HeaderText = "Lugares Economicos";
            this.LugaresEconomicos.Name = "LugaresEconomicos";
            this.LugaresEconomicos.ReadOnly = true;
            // 
            // LugaresExecutivos
            // 
            this.LugaresExecutivos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LugaresExecutivos.DataPropertyName = "LugaresExecutivos";
            this.LugaresExecutivos.FillWeight = 85.51724F;
            this.LugaresExecutivos.HeaderText = "Lugares Executivos";
            this.LugaresExecutivos.Name = "LugaresExecutivos";
            this.LugaresExecutivos.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.FillWeight = 143.4483F;
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeDataGridViewTextBoxColumn.Width = 80;
            // 
            // aparelhoBindingSource
            // 
            this.aparelhoBindingSource.DataSource = typeof(Biblioteca.Aparelho);
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(158, 267);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(201, 20);
            this.tbModelo.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Modelo: ";
            // 
            // tbLugaresExecutivos
            // 
            this.tbLugaresExecutivos.Location = new System.Drawing.Point(255, 339);
            this.tbLugaresExecutivos.Name = "tbLugaresExecutivos";
            this.tbLugaresExecutivos.Size = new System.Drawing.Size(104, 20);
            this.tbLugaresExecutivos.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(86, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Quantidade: ";
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(196, 371);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(163, 20);
            this.tbQuantidade.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(86, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "Lugares executivos:";
            // 
            // tbLugaresEconomicos
            // 
            this.tbLugaresEconomicos.Location = new System.Drawing.Point(265, 303);
            this.tbLugaresEconomicos.Name = "tbLugaresEconomicos";
            this.tbLugaresEconomicos.Size = new System.Drawing.Size(94, 20);
            this.tbLugaresEconomicos.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(83, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Lugares económicos: ";
            // 
            // pbAdd
            // 
            this.pbAdd.Image = global::FormsProjeto.Properties.Resources._226591_512;
            this.pbAdd.Location = new System.Drawing.Point(390, 266);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(67, 37);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 63;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.PbAdd_Click);
            // 
            // pbApagar
            // 
            this.pbApagar.Image = global::FormsProjeto.Properties.Resources._216103_5121;
            this.pbApagar.Location = new System.Drawing.Point(538, 261);
            this.pbApagar.Name = "pbApagar";
            this.pbApagar.Size = new System.Drawing.Size(55, 42);
            this.pbApagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApagar.TabIndex = 62;
            this.pbApagar.TabStop = false;
            this.pbApagar.Click += new System.EventHandler(this.PbApagar_Click);
            // 
            // pbEditar
            // 
            this.pbEditar.Image = global::FormsProjeto.Properties.Resources._2561383_512;
            this.pbEditar.Location = new System.Drawing.Point(463, 267);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(61, 35);
            this.pbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditar.TabIndex = 61;
            this.pbEditar.TabStop = false;
            this.pbEditar.Click += new System.EventHandler(this.PbEditar_Click);
            // 
            // pbAparelhos
            // 
            this.pbAparelhos.Image = global::FormsProjeto.Properties.Resources._3592824_512;
            this.pbAparelhos.Location = new System.Drawing.Point(12, 12);
            this.pbAparelhos.Name = "pbAparelhos";
            this.pbAparelhos.Size = new System.Drawing.Size(52, 42);
            this.pbAparelhos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAparelhos.TabIndex = 6;
            this.pbAparelhos.TabStop = false;
            // 
            // pbSair
            // 
            this.pbSair.Image = ((System.Drawing.Image)(resources.GetObject("pbSair.Image")));
            this.pbSair.Location = new System.Drawing.Point(630, 11);
            this.pbSair.Name = "pbSair";
            this.pbSair.Size = new System.Drawing.Size(39, 32);
            this.pbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSair.TabIndex = 5;
            this.pbSair.TabStop = false;
            this.pbSair.Click += new System.EventHandler(this.PbSair_Click);
            // 
            // AparelhosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(681, 418);
            this.Controls.Add(this.tbLugaresEconomicos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbQuantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLugaresExecutivos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.pbApagar);
            this.Controls.Add(this.pbEditar);
            this.Controls.Add(this.dataGridAparelhos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbAparelhos);
            this.Controls.Add(this.pbSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AparelhosForm";
            this.Text = "Aparelhos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AparelhosForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAparelhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aparelhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAparelhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSair;
        private System.Windows.Forms.PictureBox pbAparelhos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridAparelhos;
        public System.Windows.Forms.BindingSource aparelhoBindingSource;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pbApagar;
        private System.Windows.Forms.PictureBox pbEditar;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLugaresExecutivos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLugaresEconomicos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LugaresEconomicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn LugaresExecutivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
    }
}