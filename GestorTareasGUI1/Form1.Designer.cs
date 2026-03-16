namespace GestorTareasGUI1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.Papi = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCompletar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chkPrioridadAlta = new System.Windows.Forms.CheckBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblContadorTareas = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.AccessibleDescription = "";
            this.txtNombre.AccessibleName = "";
            this.txtNombre.Location = new System.Drawing.Point(41, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(41, 88);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(41, 150);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 2;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // Papi
            // 
            this.Papi.FormattingEnabled = true;
            this.Papi.Location = new System.Drawing.Point(303, 48);
            this.Papi.Name = "Papi";
            this.Papi.Size = new System.Drawing.Size(349, 134);
            this.Papi.TabIndex = 3;
            this.Papi.SelectedIndexChanged += new System.EventHandler(this.lstTareas_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(303, 238);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Añadir tarea";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(303, 267);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar tarea";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCompletar
            // 
            this.btnCompletar.Location = new System.Drawing.Point(303, 296);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(176, 23);
            this.btnCompletar.TabIndex = 6;
            this.btnCompletar.Text = "Marcar completada";
            this.btnCompletar.UseVisualStyleBackColor = true;
            this.btnCompletar.Click += new System.EventHandler(this.btnCompletar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "NOMBRE:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "DESCRIPCION:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "FECHA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "LISTA";
            // 
            // chkPrioridadAlta
            // 
            this.chkPrioridadAlta.AutoSize = true;
            this.chkPrioridadAlta.Location = new System.Drawing.Point(303, 188);
            this.chkPrioridadAlta.Name = "chkPrioridadAlta";
            this.chkPrioridadAlta.Size = new System.Drawing.Size(88, 17);
            this.chkPrioridadAlta.TabIndex = 11;
            this.chkPrioridadAlta.Text = "Prioridad Alta";
            this.chkPrioridadAlta.UseVisualStyleBackColor = true;
            this.chkPrioridadAlta.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(303, 211);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 12;
            // 
            // lblContadorTareas
            // 
            this.lblContadorTareas.AutoSize = true;
            this.lblContadorTareas.Location = new System.Drawing.Point(306, 375);
            this.lblContadorTareas.Name = "lblContadorTareas";
            this.lblContadorTareas.Size = new System.Drawing.Size(72, 13);
            this.lblContadorTareas.TabIndex = 13;
            this.lblContadorTareas.Text = "Total tareas 0";
            this.lblContadorTareas.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(303, 325);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarCampos.TabIndex = 14;
            this.btnLimpiarCampos.Text = "Limpiar";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.lblContadorTareas);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.chkPrioridadAlta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompletar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.Papi);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.ListBox Papi;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCompletar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox chkPrioridadAlta;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblContadorTareas;
        private System.Windows.Forms.Button btnLimpiarCampos;
    }
}

