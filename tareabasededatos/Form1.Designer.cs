namespace tareabasededatos
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.numericUpDownpower = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewPersonajes = new System.Windows.Forms.DataGridView();
            this.buttonPrueba = new System.Windows.Forms.Button();
            this.buttoncrear = new System.Windows.Forms.Button();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.comboBoxRaza = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownpower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Raza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Power";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(102, 18);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(105, 22);
            this.id.TabIndex = 4;
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(102, 55);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(105, 22);
            this.textBoxnombre.TabIndex = 5;
            // 
            // numericUpDownpower
            // 
            this.numericUpDownpower.Location = new System.Drawing.Point(102, 133);
            this.numericUpDownpower.Name = "numericUpDownpower";
            this.numericUpDownpower.Size = new System.Drawing.Size(104, 22);
            this.numericUpDownpower.TabIndex = 7;
            // 
            // dataGridViewPersonajes
            // 
            this.dataGridViewPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonajes.Location = new System.Drawing.Point(28, 241);
            this.dataGridViewPersonajes.Name = "dataGridViewPersonajes";
            this.dataGridViewPersonajes.RowHeadersWidth = 51;
            this.dataGridViewPersonajes.RowTemplate.Height = 24;
            this.dataGridViewPersonajes.Size = new System.Drawing.Size(559, 228);
            this.dataGridViewPersonajes.TabIndex = 8;
            // 
            // buttonPrueba
            // 
            this.buttonPrueba.Location = new System.Drawing.Point(588, 43);
            this.buttonPrueba.Name = "buttonPrueba";
            this.buttonPrueba.Size = new System.Drawing.Size(243, 112);
            this.buttonPrueba.TabIndex = 9;
            this.buttonPrueba.Text = "Prueba de Conexion";
            this.buttonPrueba.UseVisualStyleBackColor = true;
            // 
            // buttoncrear
            // 
            this.buttoncrear.Location = new System.Drawing.Point(242, 21);
            this.buttoncrear.Name = "buttoncrear";
            this.buttoncrear.Size = new System.Drawing.Size(129, 40);
            this.buttoncrear.TabIndex = 10;
            this.buttoncrear.Text = "Crear";
            this.buttoncrear.UseVisualStyleBackColor = true;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(117, 183);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(138, 39);
            this.buttonCargar.TabIndex = 11;
            this.buttonCargar.Text = "Cargar datos";
            this.buttonCargar.UseVisualStyleBackColor = true;
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Location = new System.Drawing.Point(313, 98);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(176, 83);
            this.buttonbuscar.TabIndex = 12;
            this.buttonbuscar.Text = "Buscar";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            // 
            // comboBoxRaza
            // 
            this.comboBoxRaza.FormattingEnabled = true;
            this.comboBoxRaza.Location = new System.Drawing.Point(102, 95);
            this.comboBoxRaza.Name = "comboBoxRaza";
            this.comboBoxRaza.Size = new System.Drawing.Size(103, 24);
            this.comboBoxRaza.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 496);
            this.Controls.Add(this.comboBoxRaza);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.buttoncrear);
            this.Controls.Add(this.buttonPrueba);
            this.Controls.Add(this.dataGridViewPersonajes);
            this.Controls.Add(this.numericUpDownpower);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownpower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.NumericUpDown numericUpDownpower;
        private System.Windows.Forms.DataGridView dataGridViewPersonajes;
        private System.Windows.Forms.Button buttonPrueba;
        private System.Windows.Forms.Button buttoncrear;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.ComboBox comboBoxRaza;
    }
}

