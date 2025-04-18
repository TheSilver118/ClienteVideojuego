namespace ClienteVideojuego
{
    partial class FormListarArma
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
            this.btn_listar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Daño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Municion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Velocidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMunicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DañoArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cadencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(252, 264);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(178, 72);
            this.btn_listar.TabIndex = 3;
            this.btn_listar.Text = "Listar armas";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Daño,
            this.Municion,
            this.Nombre,
            this.Vida,
            this.Velocidad,
            this.FechaCreacion,
            this.NombreMunicion,
            this.DañoArea,
            this.Cadencia});
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(487, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Daño
            // 
            this.Daño.HeaderText = "Daño";
            this.Daño.Name = "Daño";
            this.Daño.ReadOnly = true;
            // 
            // Municion
            // 
            this.Municion.HeaderText = "Municion";
            this.Municion.Name = "Municion";
            this.Municion.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Vida
            // 
            this.Vida.HeaderText = "Vida";
            this.Vida.Name = "Vida";
            this.Vida.ReadOnly = true;
            // 
            // Velocidad
            // 
            this.Velocidad.HeaderText = "Velocidad";
            this.Velocidad.Name = "Velocidad";
            this.Velocidad.ReadOnly = true;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.HeaderText = "FechaCreacion";
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.ReadOnly = true;
            // 
            // NombreMunicion
            // 
            this.NombreMunicion.HeaderText = "NombreMunicion";
            this.NombreMunicion.Name = "NombreMunicion";
            this.NombreMunicion.ReadOnly = true;
            // 
            // DañoArea
            // 
            this.DañoArea.HeaderText = "DañoArea";
            this.DañoArea.Name = "DañoArea";
            this.DañoArea.ReadOnly = true;
            // 
            // Cadencia
            // 
            this.Cadencia.HeaderText = "Cadencia";
            this.Cadencia.Name = "Cadencia";
            this.Cadencia.ReadOnly = true;
            // 
            // FormListarArma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormListarArma";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Daño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Municion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Velocidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMunicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DañoArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cadencia;
    }
}