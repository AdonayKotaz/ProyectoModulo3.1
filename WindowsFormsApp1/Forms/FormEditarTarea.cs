using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    using System.Data.SQLite;
    using System.Drawing.Drawing2D;

    public partial class FormEditarTarea : Form
    {
        string connectionString = "Data Source=tareas.db;Version=3;";

        public FormEditarTarea()
        {
            InitializeComponent();
        }

        public int IdTarea { get; set; }

        private void RedondearPanel(Panel panel, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(panel.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(panel.Width - radio, panel.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, panel.Height - radio, radio, radio, 90, 90);

            path.CloseFigure();
            panel.Region = new Region(path);
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            RedondearPanel(panel1, 20);
            RedondearPanel(panel2, 25);

        }

        public void CargarDatos(
    int id,
    string nombre,
    DateTime fecha,
    DateTime hora)
        {
            IdTarea = id;
            textBoxNombre.Text = nombre;
           
            dateTimePickerFecha.Value = fecha;
            dateTimePickerHora.Value = hora;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = @"
        UPDATE Tareas
        SET Nombre = @nombre,
            Fecha = @fecha,
            Hora = @hora
        WHERE Id = @id";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", textBoxNombre.Text);
                cmd.Parameters.AddWithValue("@fecha", dateTimePickerFecha.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@hora", dateTimePickerHora.Value.ToString("HH:mm"));
                cmd.Parameters.AddWithValue("@id", IdTarea);

                cmd.ExecuteNonQuery();
            }

            this.Close(); // 🔥 cerrar ventana flotante

        }
    }
}
