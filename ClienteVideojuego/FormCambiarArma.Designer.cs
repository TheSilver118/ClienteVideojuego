namespace ClienteVideojuego
{
    partial class FormCambiarArma
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
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Daño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Municion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Velocidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Index = new System.Windows.Forms.Label();
            this.lbl_DanoArea = new System.Windows.Forms.Label();
            this.lbl_Cadencia = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_Index = new System.Windows.Forms.TextBox();
            this.txt_DanoArea = new System.Windows.Forms.TextBox();
            this.txt_Cadencia = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.btn_cambiar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(37, 105);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(178, 72);
            this.btn_listar.TabIndex = 5;
            this.btn_listar.Text = "Listar armas";
            this.btn_listar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Daño,
            this.Municion,
            this.Velocidad,
            this.Index});
            this.dataGridView1.Location = new System.Drawing.Point(241, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
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
            // Velocidad
            // 
            this.Velocidad.HeaderText = "Velocidad";
            this.Velocidad.Name = "Velocidad";
            this.Velocidad.ReadOnly = true;
            // 
            // Index
            // 
            this.Index.HeaderText = "Index";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            // 
            // lbl_Index
            // 
            this.lbl_Index.AutoSize = true;
            this.lbl_Index.Location = new System.Drawing.Point(583, 319);
            this.lbl_Index.Name = "lbl_Index";
            this.lbl_Index.Size = new System.Drawing.Size(54, 13);
            this.lbl_Index.TabIndex = 21;
            this.lbl_Index.Text = "Velocidad";
            this.lbl_Index.Click += new System.EventHandler(this.lbl_Index_Click);
            // 
            // lbl_DanoArea
            // 
            this.lbl_DanoArea.AutoSize = true;
            this.lbl_DanoArea.Location = new System.Drawing.Point(478, 319);
            this.lbl_DanoArea.Name = "lbl_DanoArea";
            this.lbl_DanoArea.Size = new System.Drawing.Size(50, 13);
            this.lbl_DanoArea.TabIndex = 20;
            this.lbl_DanoArea.Text = "Municion";
            // 
            // lbl_Cadencia
            // 
            this.lbl_Cadencia.AutoSize = true;
            this.lbl_Cadencia.Location = new System.Drawing.Point(377, 319);
            this.lbl_Cadencia.Name = "lbl_Cadencia";
            this.lbl_Cadencia.Size = new System.Drawing.Size(33, 13);
            this.lbl_Cadencia.TabIndex = 19;
            this.lbl_Cadencia.Text = "Daño";
            this.lbl_Cadencia.Click += new System.EventHandler(this.lbl_Cadencia_Click);
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(269, 319);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 18;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // txt_Index
            // 
            this.txt_Index.Location = new System.Drawing.Point(559, 348);
            this.txt_Index.Name = "txt_Index";
            this.txt_Index.Size = new System.Drawing.Size(100, 20);
            this.txt_Index.TabIndex = 17;
            // 
            // txt_DanoArea
            // 
            this.txt_DanoArea.Location = new System.Drawing.Point(453, 348);
            this.txt_DanoArea.Name = "txt_DanoArea";
            this.txt_DanoArea.Size = new System.Drawing.Size(100, 20);
            this.txt_DanoArea.TabIndex = 16;
            // 
            // txt_Cadencia
            // 
            this.txt_Cadencia.Location = new System.Drawing.Point(347, 348);
            this.txt_Cadencia.Name = "txt_Cadencia";
            this.txt_Cadencia.Size = new System.Drawing.Size(100, 20);
            this.txt_Cadencia.TabIndex = 15;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(241, 348);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 14;
            // 
            // btn_cambiar
            // 
            this.btn_cambiar.Location = new System.Drawing.Point(37, 319);
            this.btn_cambiar.Name = "btn_cambiar";
            this.btn_cambiar.Size = new System.Drawing.Size(178, 60);
            this.btn_cambiar.TabIndex = 13;
            this.btn_cambiar.Text = "Cambiar";
            this.btn_cambiar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(665, 348);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(697, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Index";
            // 
            // FormCambiarArma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_Index);
            this.Controls.Add(this.lbl_DanoArea);
            this.Controls.Add(this.lbl_Cadencia);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.txt_Index);
            this.Controls.Add(this.txt_DanoArea);
            this.Controls.Add(this.txt_Cadencia);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btn_cambiar);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCambiarArma";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_Index;
        private System.Windows.Forms.Label lbl_DanoArea;
        private System.Windows.Forms.Label lbl_Cadencia;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_Index;
        private System.Windows.Forms.TextBox txt_DanoArea;
        private System.Windows.Forms.TextBox txt_Cadencia;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Button btn_cambiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Daño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Municion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Velocidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}