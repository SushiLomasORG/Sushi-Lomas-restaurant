using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Lomas_restaurant.Styles
{
    public static class StyleDataGridView
    {
        public static void styleDgv(DataGridView dgv)
        {
            // Performance
            typeof(DataGridView).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
                .SetValue(dgv, true);

            dgv.EnableHeadersVisualStyles = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToResizeRows = false;

            // Colores
            Color colorFondo = Color.White;
            Color colorAlternado = Color.FromArgb(245, 245, 245);
            Color colorGrid = Color.FromArgb(220, 220, 220);
            Color headerBack = Color.FromArgb(40, 40, 40);  // 🔹 mismo color para TODOS los headers
            Color headerFore = Color.White;
            Color selectionBack = Color.Silver;
            Color selectionFore = Color.White;

            // Filas alternadas
            dgv.RowsDefaultCellStyle.BackColor = colorFondo;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = colorAlternado;

            // Grid y bordes
            dgv.GridColor = colorGrid;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // 🔹 Encabezados de columnas
            dgv.ColumnHeadersDefaultCellStyle.BackColor = headerBack;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = headerFore;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 30;

            // 🔹 Encabezados de filas
            dgv.RowHeadersDefaultCellStyle.BackColor = headerBack;
            dgv.RowHeadersDefaultCellStyle.ForeColor = headerFore;
            dgv.RowHeadersDefaultCellStyle.SelectionBackColor = headerBack;
            dgv.RowHeadersDefaultCellStyle.SelectionForeColor = headerFore;

            // Selección
            dgv.DefaultCellStyle.SelectionBackColor = selectionBack;
            dgv.DefaultCellStyle.SelectionForeColor = selectionFore;

            // Texto de celdas
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 12F);
            dgv.DefaultCellStyle.Padding = new Padding(6, 4, 6, 4);

            // Ajustar columnas
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;

            // 🔹 Ajustar altura de filas al contenido
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }


        //public static void styleDgv(DataGridView dgv)
        //{
        //    // Performance
        //    typeof(DataGridView).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
        //        .SetValue(dgv, true);

        //    dgv.EnableHeadersVisualStyles = false;
        //    dgv.BorderStyle = BorderStyle.None;
        //    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    dgv.AllowUserToResizeRows = false;

        //    // Colores
        //    Color colorFondo = Color.White;
        //    Color colorAlternado = Color.FromArgb(245, 245, 245);
        //    Color colorGrid = Color.FromArgb(220, 220, 220);
        //    Color headerBack = Color.FromArgb(40, 40, 40);  // 🔹 mismo color para TODOS los headers
        //    Color headerFore = Color.White;
        //    Color selectionBack = Color.Silver;
        //    Color selectionFore = Color.White;

        //    // Filas alternadas
        //    dgv.RowsDefaultCellStyle.BackColor = colorFondo;
        //    dgv.AlternatingRowsDefaultCellStyle.BackColor = colorAlternado;

        //    // Grid y bordes
        //    dgv.GridColor = colorGrid;
        //    dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

        //    // 🔹 Encabezados de columnas
        //    dgv.ColumnHeadersDefaultCellStyle.BackColor = headerBack;
        //    dgv.ColumnHeadersDefaultCellStyle.ForeColor = headerFore;
        //    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
        //    dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        //    dgv.ColumnHeadersHeight = 30;

        //    // 🔹 Encabezados de filas (para que también se vean iguales)
        //    dgv.RowHeadersDefaultCellStyle.BackColor = headerBack;
        //    dgv.RowHeadersDefaultCellStyle.ForeColor = headerFore;
        //    dgv.RowHeadersDefaultCellStyle.SelectionBackColor = headerBack;
        //    dgv.RowHeadersDefaultCellStyle.SelectionForeColor = headerFore;

        //    // Selección
        //    dgv.DefaultCellStyle.SelectionBackColor = selectionBack;
        //    dgv.DefaultCellStyle.SelectionForeColor = selectionFore;

        //    // Texto de celdas
        //    dgv.DefaultCellStyle.Font = new Font("Segoe UI", 12F);
        //    dgv.DefaultCellStyle.Padding = new Padding(6, 4, 6, 4);

        //    // Ajustar columnas
        //    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    dgv.RowHeadersVisible = false;
        //}
    }
}
