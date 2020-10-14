namespace FormsProjeto
{
    partial class ListaBilhetesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaBilhetesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridBilhetes = new System.Windows.Forms.DataGridView();
            this.bilheteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pbExportar = new System.Windows.Forms.PictureBox();
            this.pbSair = new System.Windows.Forms.PictureBox();
            this.pbBilhetes = new System.Windows.Forms.PictureBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBilhete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBilhetes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilheteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExportar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBilhetes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 5);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(795, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 468);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 468);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(790, 5);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 468);
            this.panel4.TabIndex = 2;
            // 
            // dataGridBilhetes
            // 
            this.dataGridBilhetes.AllowUserToAddRows = false;
            this.dataGridBilhetes.AllowUserToDeleteRows = false;
            this.dataGridBilhetes.AutoGenerateColumns = false;
            this.dataGridBilhetes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridBilhetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBilhetes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.IdBilhete,
            this.nomeDataGridViewTextBoxColumn,
            this.documentoDataGridViewTextBoxColumn,
            this.classeDataGridViewTextBoxColumn,
            this.lugarDataGridViewTextBoxColumn});
            this.dataGridBilhetes.DataSource = this.bilheteBindingSource;
            this.dataGridBilhetes.Location = new System.Drawing.Point(49, 65);
            this.dataGridBilhetes.Name = "dataGridBilhetes";
            this.dataGridBilhetes.ReadOnly = true;
            this.dataGridBilhetes.Size = new System.Drawing.Size(703, 342);
            this.dataGridBilhetes.TabIndex = 7;
            // 
            // bilheteBindingSource
            // 
            this.bilheteBindingSource.DataSource = typeof(Biblioteca.Bilhete);
            // 
            // pbExportar
            // 
            this.pbExportar.Image = global::FormsProjeto.Properties.Resources._171492_48;
            this.pbExportar.Location = new System.Drawing.Point(679, 413);
            this.pbExportar.Name = "pbExportar";
            this.pbExportar.Size = new System.Drawing.Size(60, 42);
            this.pbExportar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExportar.TabIndex = 13;
            this.pbExportar.TabStop = false;
            this.pbExportar.Click += new System.EventHandler(this.pbExportar_Click);
            // 
            // pbSair
            // 
            this.pbSair.Image = ((System.Drawing.Image)(resources.GetObject("pbSair.Image")));
            this.pbSair.Location = new System.Drawing.Point(749, 12);
            this.pbSair.Name = "pbSair";
            this.pbSair.Size = new System.Drawing.Size(39, 32);
            this.pbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSair.TabIndex = 6;
            this.pbSair.TabStop = false;
            this.pbSair.Click += new System.EventHandler(this.PbSair_Click);
            // 
            // pbBilhetes
            // 
            this.pbBilhetes.Image = global::FormsProjeto.Properties.Resources._216459_512;
            this.pbBilhetes.Location = new System.Drawing.Point(0, 8);
            this.pbBilhetes.Name = "pbBilhetes";
            this.pbBilhetes.Size = new System.Drawing.Size(80, 51);
            this.pbBilhetes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBilhetes.TabIndex = 12;
            this.pbBilhetes.TabStop = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID Voo";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IdBilhete
            // 
            this.IdBilhete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdBilhete.DataPropertyName = "IdBilhete";
            this.IdBilhete.HeaderText = "ID Bilhete";
            this.IdBilhete.Name = "IdBilhete";
            this.IdBilhete.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentoDataGridViewTextBoxColumn
            // 
            this.documentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.documentoDataGridViewTextBoxColumn.DataPropertyName = "Documento";
            this.documentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
            this.documentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classeDataGridViewTextBoxColumn
            // 
            this.classeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.classeDataGridViewTextBoxColumn.DataPropertyName = "Classe";
            this.classeDataGridViewTextBoxColumn.HeaderText = "Classe";
            this.classeDataGridViewTextBoxColumn.Name = "classeDataGridViewTextBoxColumn";
            this.classeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lugarDataGridViewTextBoxColumn
            // 
            this.lugarDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lugarDataGridViewTextBoxColumn.DataPropertyName = "Lugar";
            this.lugarDataGridViewTextBoxColumn.HeaderText = "Lugar";
            this.lugarDataGridViewTextBoxColumn.Name = "lugarDataGridViewTextBoxColumn";
            this.lugarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ListaBilhetesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.pbExportar);
            this.Controls.Add(this.dataGridBilhetes);
            this.Controls.Add(this.pbSair);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbBilhetes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaBilhetesForm";
            this.Text = "ListaBilhetesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBilhetes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilheteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExportar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBilhetes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbSair;
        private System.Windows.Forms.DataGridView dataGridBilhetes;
        private System.Windows.Forms.BindingSource bilheteBindingSource;
        private System.Windows.Forms.PictureBox pbBilhetes;
        private System.Windows.Forms.PictureBox pbExportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBilhete;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarDataGridViewTextBoxColumn;
    }
}