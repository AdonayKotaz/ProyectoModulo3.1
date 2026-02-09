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
    }
}
