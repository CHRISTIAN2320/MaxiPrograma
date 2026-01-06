namespace DiscoAdoNet
{
    partial class DiscoForm1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDisco = new System.Windows.Forms.DataGridView();
            this.pcbImagenDisco = new System.Windows.Forms.PictureBox();
            this.btnListarEstilos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagenDisco)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisco
            // 
            this.dgvDisco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisco.Location = new System.Drawing.Point(21, 105);
            this.dgvDisco.Name = "dgvDisco";
            this.dgvDisco.Size = new System.Drawing.Size(527, 196);
            this.dgvDisco.TabIndex = 0;
            this.dgvDisco.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvDisco.SelectionChanged += new System.EventHandler(this.dgvDisco_SelectionChanged);
            // 
            // pcbImagenDisco
            // 
            this.pcbImagenDisco.Location = new System.Drawing.Point(585, 105);
            this.pcbImagenDisco.Name = "pcbImagenDisco";
            this.pcbImagenDisco.Size = new System.Drawing.Size(247, 196);
            this.pcbImagenDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagenDisco.TabIndex = 1;
            this.pcbImagenDisco.TabStop = false;
            // 
            // btnListarEstilos
            // 
            this.btnListarEstilos.Location = new System.Drawing.Point(473, 337);
            this.btnListarEstilos.Name = "btnListarEstilos";
            this.btnListarEstilos.Size = new System.Drawing.Size(75, 23);
            this.btnListarEstilos.TabIndex = 2;
            this.btnListarEstilos.Text = "Listar Estilos";
            this.btnListarEstilos.UseVisualStyleBackColor = true;
            this.btnListarEstilos.Click += new System.EventHandler(this.btnListarEstilos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(21, 337);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // DiscoForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnListarEstilos);
            this.Controls.Add(this.pcbImagenDisco);
            this.Controls.Add(this.dgvDisco);
            this.Name = "DiscoForm1";
            this.Text = "DiscoForm";
            this.Load += new System.EventHandler(this.DiscoForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagenDisco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisco;
        private System.Windows.Forms.PictureBox pcbImagenDisco;
        private System.Windows.Forms.Button btnListarEstilos;
        private System.Windows.Forms.Button btnAgregar;
    }
}

