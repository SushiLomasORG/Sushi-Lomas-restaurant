namespace Sushi_Lomas_restaurant.Windows.Sistema
{
    partial class Autorizacion
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
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.cb_mostrarContraseña = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.Transparent;
            this.btn_confirmar.FlatAppearance.BorderSize = 0;
            this.btn_confirmar.Location = new System.Drawing.Point(78, 138);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(343, 50);
            this.btn_confirmar.TabIndex = 0;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txt_contraseña.Location = new System.Drawing.Point(78, 83);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(343, 39);
            this.txt_contraseña.TabIndex = 1;
            this.txt_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_mostrarContraseña
            // 
            this.cb_mostrarContraseña.AutoSize = true;
            this.cb_mostrarContraseña.Location = new System.Drawing.Point(427, 97);
            this.cb_mostrarContraseña.Name = "cb_mostrarContraseña";
            this.cb_mostrarContraseña.Size = new System.Drawing.Size(15, 14);
            this.cb_mostrarContraseña.TabIndex = 2;
            this.cb_mostrarContraseña.UseVisualStyleBackColor = true;
            this.cb_mostrarContraseña.CheckedChanged += new System.EventHandler(this.cb_mostrarContraseña_CheckedChanged);
            // 
            // Autorizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.cb_mostrarContraseña);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.btn_confirmar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Autorizacion";
            this.Text = "Autorizacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.CheckBox cb_mostrarContraseña;
    }
}