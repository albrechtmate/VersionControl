using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Mikulas.Abstractions
{
    public abstract class Toy : Label
    {
        public Toy()
        {
            this.AutoSize = false;
            this.Width = 50;
            Height = Width;
            Paint += Toy_Paint;
        }

        private void Toy_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected abstract void DrawImage(Graphics g);

        public void MoveToy()
        {
            Left += 1;
        }
    }
}
