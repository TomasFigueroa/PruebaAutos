namespace Froent
{
    partial class Auto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auto));
            this.Txt_Patente = new System.Windows.Forms.TextBox();
            this.Txt_Color = new System.Windows.Forms.TextBox();
            this.Txt_Precio = new System.Windows.Forms.TextBox();
            this.dgautos = new System.Windows.Forms.DataGridView();
            this.Dt_Fecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Bt_Agregar = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgautos)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Patente
            // 
            this.Txt_Patente.Location = new System.Drawing.Point(35, 49);
            this.Txt_Patente.Name = "Txt_Patente";
            this.Txt_Patente.Size = new System.Drawing.Size(100, 22);
            this.Txt_Patente.TabIndex = 0;
            // 
            // Txt_Color
            // 
            this.Txt_Color.Location = new System.Drawing.Point(35, 106);
            this.Txt_Color.Name = "Txt_Color";
            this.Txt_Color.Size = new System.Drawing.Size(100, 22);
            this.Txt_Color.TabIndex = 1;
            // 
            // Txt_Precio
            // 
            this.Txt_Precio.Location = new System.Drawing.Point(35, 160);
            this.Txt_Precio.Name = "Txt_Precio";
            this.Txt_Precio.Size = new System.Drawing.Size(100, 22);
            this.Txt_Precio.TabIndex = 2;
            // 
            // dgautos
            // 
            this.dgautos.AllowUserToAddRows = false;
            this.dgautos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgautos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgautos.Location = new System.Drawing.Point(241, 27);
            this.dgautos.Name = "dgautos";
            this.dgautos.ReadOnly = true;
            this.dgautos.RowHeadersWidth = 51;
            this.dgautos.RowTemplate.Height = 24;
            this.dgautos.Size = new System.Drawing.Size(547, 411);
            this.dgautos.TabIndex = 3;
            // 
            // Dt_Fecha
            // 
            this.Dt_Fecha.Location = new System.Drawing.Point(35, 212);
            this.Dt_Fecha.Name = "Dt_Fecha";
            this.Dt_Fecha.Size = new System.Drawing.Size(200, 22);
            this.Dt_Fecha.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Patente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Color";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de Ingreso";
            // 
            // Bt_Agregar
            // 
            this.Bt_Agregar.Location = new System.Drawing.Point(35, 292);
            this.Bt_Agregar.Name = "Bt_Agregar";
            this.Bt_Agregar.Size = new System.Drawing.Size(97, 36);
            this.Bt_Agregar.TabIndex = 9;
            this.Bt_Agregar.Text = "Agregar";
            this.Bt_Agregar.UseVisualStyleBackColor = true;
            this.Bt_Agregar.Click += new System.EventHandler(this.Bt_Agregar_Click);
            // 
            // Check
            // 
            this.Check.AutoSize = true;
            this.Check.Location = new System.Drawing.Point(35, 250);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(116, 20);
            this.Check.TabIndex = 10;
            this.Check.Text = "Disponibilidad";
            this.Check.UseVisualStyleBackColor = true;
            // 
            // Auto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.Bt_Agregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dt_Fecha);
            this.Controls.Add(this.dgautos);
            this.Controls.Add(this.Txt_Precio);
            this.Controls.Add(this.Txt_Color);
            this.Controls.Add(this.Txt_Patente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Auto";
            this.Text = "Autos";
            ((System.ComponentModel.ISupportInitialize)(this.dgautos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Patente;
        private System.Windows.Forms.TextBox Txt_Color;
        private System.Windows.Forms.TextBox Txt_Precio;
        private System.Windows.Forms.DateTimePicker Dt_Fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Bt_Agregar;
        private System.Windows.Forms.DataGridView dgautos;
        private System.Windows.Forms.CheckBox Check;
    }
}

