namespace ClienteVideojuego
{
    partial class FormCambiarMunicion
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_cambiar = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Cadencia = new System.Windows.Forms.Label();
            this.lbl_DanoArea = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cadencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DañoArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeric_cadencia = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_cadencia)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 72);
            this.button1.TabIndex = 3;
            this.button1.Text = "Listar Municiones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cadencia,
            this.DañoArea});
            this.dataGridView1.Location = new System.Drawing.Point(304, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_cambiar
            // 
            this.btn_cambiar.Location = new System.Drawing.Point(54, 320);
            this.btn_cambiar.Name = "btn_cambiar";
            this.btn_cambiar.Size = new System.Drawing.Size(178, 60);
            this.btn_cambiar.TabIndex = 4;
            this.btn_cambiar.Text = "Cambiar";
            this.btn_cambiar.UseVisualStyleBackColor = true;
            this.btn_cambiar.Click += new System.EventHandler(this.btn_cambiar_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(321, 341);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 5;
            this.txt_Nombre.TextChanged += new System.EventHandler(this.txt_Nombre_TextChanged);
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(349, 312);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 9;
            this.lbl_Nombre.Text = "Nombre";
            this.lbl_Nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Cadencia
            // 
            this.lbl_Cadencia.AutoSize = true;
            this.lbl_Cadencia.Location = new System.Drawing.Point(478, 312);
            this.lbl_Cadencia.Name = "lbl_Cadencia";
            this.lbl_Cadencia.Size = new System.Drawing.Size(52, 13);
            this.lbl_Cadencia.TabIndex = 10;
            this.lbl_Cadencia.Text = "Cadencia";
            // 
            // lbl_DanoArea
            // 
            this.lbl_DanoArea.AutoSize = true;
            this.lbl_DanoArea.Location = new System.Drawing.Point(620, 312);
            this.lbl_DanoArea.Name = "lbl_DanoArea";
            this.lbl_DanoArea.Size = new System.Drawing.Size(55, 13);
            this.lbl_DanoArea.TabIndex = 11;
            this.lbl_DanoArea.Text = "DañoArea";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(95, 70);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 13;
            this.textNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Nombre
            // 
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cadencia
            // 
            this.Cadencia.Frozen = true;
            this.Cadencia.HeaderText = "Cadencia";
            this.Cadencia.Name = "Cadencia";
            this.Cadencia.ReadOnly = true;
            // 
            // DañoArea
            // 
            this.DañoArea.Frozen = true;
            this.DañoArea.HeaderText = "DañoArea";
            this.DañoArea.Name = "DañoArea";
            this.DañoArea.ReadOnly = true;
            // 
            // numeric_cadencia
            // 
            this.numeric_cadencia.Location = new System.Drawing.Point(443, 341);
            this.numeric_cadencia.Name = "numeric_cadencia";
            this.numeric_cadencia.Size = new System.Drawing.Size(120, 20);
            this.numeric_cadencia.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "true",
            "false"});
            this.comboBox1.Location = new System.Drawing.Point(581, 340);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // FormCambiarMunicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numeric_cadencia);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.lbl_DanoArea);
            this.Controls.Add(this.lbl_Cadencia);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btn_cambiar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCambiarMunicion";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_cadencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_cambiar;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Cadencia;
        private System.Windows.Forms.Label lbl_DanoArea;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cadencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DañoArea;
        private System.Windows.Forms.NumericUpDown numeric_cadencia;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}