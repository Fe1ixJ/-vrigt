#define my_debug
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mule_Shooter
{
    public partial class Form1 : Form
    {
        int _cursX = 0;
        int _cursY = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timerGameLoop_Tick(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //skapa ett nytt grafikobjekt Ritar ut text på angiven plats
            Graphics dc = e.Graphics;
            TextFormatFlags flags = TextFormatFlags.Left|TextFormatFlags.EndEllipsis;
            Font _font = new System.Drawing.Font("Stencil", 12, FontStyle.Regular);
            TextRenderer.DrawText(dc, "X =" + _cursX.ToString() + " : " + "Y=" + _cursY.ToString(), _font, new Rectangle(10, 10, 120, 20), SystemColors.ControlText, flags);

            // anrioa ursprungsfunktionen
            base.OnPaint(e);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            _cursX = e.X;
            _cursY = e.Y;

            this.Refresh();
        }
    }

}
