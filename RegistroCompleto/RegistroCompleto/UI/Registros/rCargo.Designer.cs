namespace RegistroCompleto.UI.Registros
{
    partial class rCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rCargo));
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Eliminar_button = new System.Windows.Forms.Button();
            this.Guardar_button = new System.Windows.Forms.Button();
            this.Nuevo_button = new System.Windows.Forms.Button();
            this.Buscar_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CargoId";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(122, 43);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(187, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripción";
            // 
            // Eliminar_button
            // 
            this.Eliminar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar_button.Image = global::RegistroCompleto.Properties.Resources.delete_icon;
            this.Eliminar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminar_button.Location = new System.Drawing.Point(298, 143);
            this.Eliminar_button.Name = "Eliminar_button";
            this.Eliminar_button.Size = new System.Drawing.Size(103, 37);
            this.Eliminar_button.TabIndex = 20;
            this.Eliminar_button.Text = "Eliminar";
            this.Eliminar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminar_button.UseVisualStyleBackColor = true;
            this.Eliminar_button.Click += new System.EventHandler(this.Eliminar_button_Click);
            // 
            // Guardar_button
            // 
            this.Guardar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar_button.Image = global::RegistroCompleto.Properties.Resources.Save_black_512_icon;
            this.Guardar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardar_button.Location = new System.Drawing.Point(172, 143);
            this.Guardar_button.Name = "Guardar_button";
            this.Guardar_button.Size = new System.Drawing.Size(108, 37);
            this.Guardar_button.TabIndex = 19;
            this.Guardar_button.Text = "Guardar";
            this.Guardar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardar_button.UseVisualStyleBackColor = true;
            this.Guardar_button.Click += new System.EventHandler(this.Guardar_button_Click);
            // 
            // Nuevo_button
            // 
            this.Nuevo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevo_button.Image = global::RegistroCompleto.Properties.Resources.application_add_512_icon;
            this.Nuevo_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevo_button.Location = new System.Drawing.Point(48, 143);
            this.Nuevo_button.Name = "Nuevo_button";
            this.Nuevo_button.Size = new System.Drawing.Size(107, 37);
            this.Nuevo_button.TabIndex = 18;
            this.Nuevo_button.Text = "Nuevo";
            this.Nuevo_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevo_button.UseVisualStyleBackColor = true;
            this.Nuevo_button.Click += new System.EventHandler(this.Nuevo_button_Click);
            // 
            // Buscar_button
            // 
            this.Buscar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar_button.Image = global::RegistroCompleto.Properties.Resources.preview_search_find_locate_1551;
            this.Buscar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscar_button.Location = new System.Drawing.Point(317, 24);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(94, 39);
            this.Buscar_button.TabIndex = 4;
            this.Buscar_button.Text = "Buscar";
            this.Buscar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscar_button.UseVisualStyleBackColor = true;
            this.Buscar_button.Click += new System.EventHandler(this.Buscar_button_Click);
            // 
            // rCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 208);
            this.Controls.Add(this.Eliminar_button);
            this.Controls.Add(this.Guardar_button);
            this.Controls.Add(this.Nuevo_button);
            this.Controls.Add(this.Buscar_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rCargo";
            this.Text = "Registro de Cargos";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Buscar_button;
        private System.Windows.Forms.Button Eliminar_button;
        private System.Windows.Forms.Button Guardar_button;
        private System.Windows.Forms.Button Nuevo_button;
    }
}