namespace Primer_parcial.UI.Registros
{
    partial class RegistroParcial
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
            this.label1 = new System.Windows.Forms.Label();
            this.IDnumero = new System.Windows.Forms.NumericUpDown();
            this.Buscar = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Fecha = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.Label();
            this.Grupo = new System.Windows.Forms.Label();
            this.fechar = new System.Windows.Forms.DateTimePicker();
            this.tdescripcion = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.Integrantes = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // IDnumero
            // 
            this.IDnumero.Location = new System.Drawing.Point(102, 31);
            this.IDnumero.Name = "IDnumero";
            this.IDnumero.Size = new System.Drawing.Size(158, 20);
            this.IDnumero.TabIndex = 1;
            // 
            // Buscar
            // 
            this.Buscar.Image = global::Primer_parcial.Properties.Resources.find;
            this.Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscar.Location = new System.Drawing.Point(303, 15);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(125, 58);
            this.Buscar.TabIndex = 2;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nuevo
            // 
            this.Nuevo.Image = global::Primer_parcial.Properties.Resources.new2;
            this.Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevo.Location = new System.Drawing.Point(99, 348);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(123, 90);
            this.Nuevo.TabIndex = 3;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Guardar
            // 
            this.Guardar.Image = global::Primer_parcial.Properties.Resources.Save;
            this.Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardar.Location = new System.Drawing.Point(303, 348);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(125, 89);
            this.Guardar.TabIndex = 4;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Image = global::Primer_parcial.Properties.Resources.Delete;
            this.Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminar.Location = new System.Drawing.Point(500, 348);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(126, 91);
            this.Eliminar.TabIndex = 5;
            this.Eliminar.Text = "Elminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(26, 79);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(37, 13);
            this.Fecha.TabIndex = 6;
            this.Fecha.Text = "Fecha";
            this.Fecha.Click += new System.EventHandler(this.label2_Click);
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(0, 110);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(63, 13);
            this.Descripcion.TabIndex = 7;
            this.Descripcion.Text = "Descripcion";
            this.Descripcion.Click += new System.EventHandler(this.Descripcion_Click);
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Location = new System.Drawing.Point(14, 148);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(49, 13);
            this.Cantidad.TabIndex = 8;
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Click += new System.EventHandler(this.Cantidad_Click);
            // 
            // Grupo
            // 
            this.Grupo.AutoSize = true;
            this.Grupo.Location = new System.Drawing.Point(27, 187);
            this.Grupo.Name = "Grupo";
            this.Grupo.Size = new System.Drawing.Size(36, 13);
            this.Grupo.TabIndex = 9;
            this.Grupo.Text = "Grupo";
            this.Grupo.Click += new System.EventHandler(this.Grupo_Click);
            // 
            // fechar
            // 
            this.fechar.Location = new System.Drawing.Point(102, 79);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(156, 20);
            this.fechar.TabIndex = 11;
            this.fechar.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // tdescripcion
            // 
            this.tdescripcion.Location = new System.Drawing.Point(99, 110);
            this.tdescripcion.Name = "tdescripcion";
            this.tdescripcion.Size = new System.Drawing.Size(324, 20);
            this.tdescripcion.TabIndex = 12;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(102, 148);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(158, 20);
            this.numericUpDown2.TabIndex = 13;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(99, 187);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(161, 20);
            this.numericUpDown3.TabIndex = 14;
            // 
            // Integrantes
            // 
            this.Integrantes.AutoSize = true;
            this.Integrantes.Location = new System.Drawing.Point(3, 219);
            this.Integrantes.Name = "Integrantes";
            this.Integrantes.Size = new System.Drawing.Size(60, 13);
            this.Integrantes.TabIndex = 15;
            this.Integrantes.Text = "Integrantes";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(99, 219);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(159, 20);
            this.numericUpDown4.TabIndex = 16;
            // 
            // RegistroParcial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.Integrantes);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.tdescripcion);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.Grupo);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.IDnumero);
            this.Controls.Add(this.label1);
            this.Name = "RegistroParcial";
            this.Text = "RegistroParcial";
            this.Load += new System.EventHandler(this.RegistroParcial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IDnumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IDnumero;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.Label Grupo;
        private System.Windows.Forms.DateTimePicker fechar;
        private System.Windows.Forms.TextBox tdescripcion;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label Integrantes;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
    }
}