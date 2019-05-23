using System;

namespace RegistroCompleto.UI.Registros
{
    partial class rUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rUsuarios));
            this.Nombre_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Email_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UsuarioId_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NivelUsuario_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Usuario_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Clave_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FechaIngreso_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Eliminar_button = new System.Windows.Forms.Button();
            this.Buscar_button = new System.Windows.Forms.Button();
            this.Guardar_button = new System.Windows.Forms.Button();
            this.Nuevo_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioId_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NivelUsuario_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre_textBox
            // 
            this.Nombre_textBox.Location = new System.Drawing.Point(140, 63);
            this.Nombre_textBox.Name = "Nombre_textBox";
            this.Nombre_textBox.Size = new System.Drawing.Size(331, 20);
            this.Nombre_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-mail";
            // 
            // Email_textBox
            // 
            this.Email_textBox.Location = new System.Drawing.Point(140, 104);
            this.Email_textBox.Name = "Email_textBox";
            this.Email_textBox.Size = new System.Drawing.Size(331, 20);
            this.Email_textBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "UsuarioID";
            // 
            // UsuarioId_numericUpDown
            // 
            this.UsuarioId_numericUpDown.Location = new System.Drawing.Point(140, 23);
            this.UsuarioId_numericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UsuarioId_numericUpDown.Name = "UsuarioId_numericUpDown";
            this.UsuarioId_numericUpDown.Size = new System.Drawing.Size(220, 20);
            this.UsuarioId_numericUpDown.TabIndex = 5;
            // 
            // NivelUsuario_numericUpDown
            // 
            this.NivelUsuario_numericUpDown.Location = new System.Drawing.Point(140, 146);
            this.NivelUsuario_numericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NivelUsuario_numericUpDown.Name = "NivelUsuario_numericUpDown";
            this.NivelUsuario_numericUpDown.Size = new System.Drawing.Size(331, 20);
            this.NivelUsuario_numericUpDown.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nivel de Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Usuario";
            // 
            // Usuario_textBox
            // 
            this.Usuario_textBox.Location = new System.Drawing.Point(140, 191);
            this.Usuario_textBox.Name = "Usuario_textBox";
            this.Usuario_textBox.Size = new System.Drawing.Size(331, 20);
            this.Usuario_textBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Clave";
            // 
            // Clave_textBox
            // 
            this.Clave_textBox.Location = new System.Drawing.Point(140, 238);
            this.Clave_textBox.Name = "Clave_textBox";
            this.Clave_textBox.Size = new System.Drawing.Size(331, 20);
            this.Clave_textBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha de Ingreso";
            // 
            // FechaIngreso_dateTimePicker
            // 
            this.FechaIngreso_dateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaIngreso_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaIngreso_dateTimePicker.Location = new System.Drawing.Point(140, 286);
            this.FechaIngreso_dateTimePicker.Name = "FechaIngreso_dateTimePicker";
            this.FechaIngreso_dateTimePicker.Size = new System.Drawing.Size(331, 20);
            this.FechaIngreso_dateTimePicker.TabIndex = 14;
            // 
            // Eliminar_button
            // 
            this.Eliminar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar_button.Image = global::RegistroCompleto.Properties.Resources.delete_icon;
            this.Eliminar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminar_button.Location = new System.Drawing.Point(319, 345);
            this.Eliminar_button.Name = "Eliminar_button";
            this.Eliminar_button.Size = new System.Drawing.Size(103, 47);
            this.Eliminar_button.TabIndex = 17;
            this.Eliminar_button.Text = "Eliminar";
            this.Eliminar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminar_button.UseVisualStyleBackColor = true;
            this.Eliminar_button.Click += new System.EventHandler(this.Eliminar_button_Click);
            // 
            // Buscar_button
            // 
            this.Buscar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar_button.Image = global::RegistroCompleto.Properties.Resources.icono;
            this.Buscar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscar_button.Location = new System.Drawing.Point(378, 19);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(93, 38);
            this.Buscar_button.TabIndex = 18;
            this.Buscar_button.Text = "Buscar";
            this.Buscar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscar_button.UseVisualStyleBackColor = true;
            this.Buscar_button.Click += new System.EventHandler(this.Buscar_button_Click);
            // 
            // Guardar_button
            // 
            this.Guardar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar_button.Image = global::RegistroCompleto.Properties.Resources.Save_black_512_icon;
            this.Guardar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardar_button.Location = new System.Drawing.Point(193, 345);
            this.Guardar_button.Name = "Guardar_button";
            this.Guardar_button.Size = new System.Drawing.Size(108, 47);
            this.Guardar_button.TabIndex = 16;
            this.Guardar_button.Text = "Guardar";
            this.Guardar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardar_button.UseVisualStyleBackColor = true;
            this.Guardar_button.Click += new System.EventHandler(this.Guardar_button_Click);
            // 
            // Nuevo_button
            // 
            this.Nuevo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevo_button.Image = global::RegistroCompleto.Properties.Resources.application_add_512_icon1;
            this.Nuevo_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevo_button.Location = new System.Drawing.Point(69, 345);
            this.Nuevo_button.Name = "Nuevo_button";
            this.Nuevo_button.Size = new System.Drawing.Size(107, 47);
            this.Nuevo_button.TabIndex = 15;
            this.Nuevo_button.Text = "Nuevo";
            this.Nuevo_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevo_button.UseVisualStyleBackColor = true;
            this.Nuevo_button.Click += new System.EventHandler(this.Nuevo_button_Click);
            // 
            // rUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 422);
            this.Controls.Add(this.Buscar_button);
            this.Controls.Add(this.Eliminar_button);
            this.Controls.Add(this.Guardar_button);
            this.Controls.Add(this.Nuevo_button);
            this.Controls.Add(this.FechaIngreso_dateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Clave_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Usuario_textBox);
            this.Controls.Add(this.NivelUsuario_numericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UsuarioId_numericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Email_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nombre_textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rUsuarios";
            this.Text = "Resgistro de Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioId_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NivelUsuario_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox Nombre_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Email_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown UsuarioId_numericUpDown;
        private System.Windows.Forms.NumericUpDown NivelUsuario_numericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Usuario_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Clave_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker FechaIngreso_dateTimePicker;
        private System.Windows.Forms.Button Nuevo_button;
        private System.Windows.Forms.Button Guardar_button;
        private System.Windows.Forms.Button Eliminar_button;
        private System.Windows.Forms.Button Buscar_button;
    }
}