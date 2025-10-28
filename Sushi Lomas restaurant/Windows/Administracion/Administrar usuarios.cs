using Sushi_Lomas_restaurant.Class;
using Sushi_Lomas_restaurant.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Lomas_restaurant.Windows.Administracion
{
    public partial class Administrar_usuarios : Form
    {
        public Administrar_usuarios()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            StyleDataGridView.styleDgv(dataGridView1);
            User.lista(dataGridView1);

            dataGridView1.ReadOnly = true;

            txt_usuario.TabIndex = 0;
            cmb_Rol.TabIndex = 1;
            txt_contraseña.TabIndex = 2;
            btn_registrar.TabIndex = 3;
            btn_eliminar.TabIndex = 4;
        }

        int _rol = 0;
        int id_usuario;

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {
            if (txt_usuario.Text.Length > 0)
            {
                User.verificar_existencia(txt_usuario.Text, lblMensaje);
            }
            else
            {
                lblMensaje.Text = "";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

            if (fila.Cells[0].Value != null && fila.Cells[0].Value != DBNull.Value)
            {
                id_usuario = (int)fila.Cells[0].Value;
            }
            else
            {
                return;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debes de seleccionar al usuario que quieres eliminar.");
                return;
            }

            if (id_usuario == 0)
            {
                MessageBox.Show("Error al leer el ID del usuario.");
                return;
            }

            User.desactivar(id_usuario);
            User.lista(dataGridView1);
        }

        private void cmb_Rol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Rol.SelectedItem == null)
            {
                _rol = 0;
                return;
            }

            if (cmb_Rol.SelectedItem.ToString() == "Administrador")
                _rol = 1;
            else
                _rol = 2;
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            disparador();
        }


        void disparador()
        {
            if (string.IsNullOrEmpty(txt_contraseña.Text) || cmb_Rol.SelectedItem == null || string.IsNullOrEmpty(txt_contraseña.Text))
            {
                MessageBox.Show("Debes llenar todos los campos.");
                return;
            }

            string nombre = txt_usuario.Text;
            int rol = _rol;
            string contraseña = txt_contraseña.Text;

            User.registrar(nombre, rol, contraseña);
            User.lista(dataGridView1);
            limpiar();
        }

        void limpiar()
        {
            txt_usuario.Clear();
            cmb_Rol.SelectedIndex = -1;
            txt_contraseña.Clear();

            _rol = 0;
        }
    }
}
