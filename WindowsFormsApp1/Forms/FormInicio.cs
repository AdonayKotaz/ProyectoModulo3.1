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
    using System.Drawing.Drawing2D;

    public partial class FormInicio : Form
    {
        public FormInicio()
        {

            InitializeComponent();
            this.MaximizeBox = false;

            textBox1.Text = placeholder;
            textBox1.ForeColor = Color.Gray;

            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;


            textBox2.Text = placeholder2;
            textBox2.ForeColor = Color.Gray;

            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;

        }
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
            RedondearPanel(panel2, 20);
            RedondearPanel(panel3, 20);
            RedondearPanel(panel4, 20);
            RedondearPanel(panel5, 20);
            RedondearPanel(panel6, 20);
            RedondearPanel(flowLayoutPanel1, 20);

            panelSombra.BackColor = Color.FromArgb(60, Color.Black);
            RedondearPanel(panelSombra, 20);

            panelSombra2.BackColor = Color.FromArgb(60, Color.Black);
            RedondearPanel(panelSombra2, 20);

            panelSombra3.BackColor = Color.FromArgb(60, Color.Black);
            RedondearPanel(panelSombra3, 20);

            panelSombra4.BackColor = Color.FromArgb(60, Color.Black);
            RedondearPanel(panelSombra4, 20);
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

      
        private string placeholder = "Nombre de tarea...";
        private string placeholder2 = "Descripción...";

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nombre de la tarea...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Tag?.ToString() == "placeholder")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                textBox1.Tag = null;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = placeholder;
                textBox1.ForeColor = Color.Gray;
                textBox1.Tag = "placeholder";
            }
        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (textBox1.Text == placeholder)
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = placeholder;
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == placeholder2)
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = placeholder2;
                textBox2.ForeColor = Color.Gray;
            }
        }
    }
}
