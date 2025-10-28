namespace Sushi_Lomas_restaurant.Windows.Sistema
{
    partial class Cambiar_contraseña
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.btn_cambiar = new System.Windows.Forms.Button();
            this.lblmsgUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.txt_nombre.Location = new System.Drawing.Point(670, 436);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(506, 36);
            this.txt_nombre.TabIndex = 6;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contraseña.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.txt_contraseña.Location = new System.Drawing.Point(670, 591);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(506, 36);
            this.txt_contraseña.TabIndex = 7;
            // 
            // btn_cambiar
            // 
            this.btn_cambiar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cambiar.FlatAppearance.BorderSize = 0;
            this.btn_cambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cambiar.Location = new System.Drawing.Point(662, 708);
            this.btn_cambiar.Name = "btn_cambiar";
            this.btn_cambiar.Size = new System.Drawing.Size(522, 61);
            this.btn_cambiar.TabIndex = 8;
            this.btn_cambiar.UseVisualStyleBackColor = false;
            this.btn_cambiar.Click += new System.EventHandler(this.btn_cambiar_Click);
            // 
            // lblmsgUsuario
            // 
            this.lblmsgUsuario.AutoSize = true;
            this.lblmsgUsuario.BackColor = System.Drawing.Color.White;
            this.lblmsgUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblmsgUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.lblmsgUsuario.Location = new System.Drawing.Point(679, 485);
            this.lblmsgUsuario.Name = "lblmsgUsuario";
            this.lblmsgUsuario.Size = new System.Drawing.Size(0, 21);
            this.lblmsgUsuario.TabIndex = 9;
            // 
            // Cambiar_contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sushi_Lomas_restaurant.Properties.Resources.Cambiar_la_contraseña;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1480, 850);
            this.Controls.Add(this.lblmsgUsuario);
            this.Controls.Add(this.btn_cambiar);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_nombre);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Cambiar_contraseña";
            this.Text = "*- ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Button btn_cambiar;
        private System.Windows.Forms.Label lblmsgUsuario;
    }
}