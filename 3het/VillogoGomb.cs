using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3het
{
    internal class VillogoGomb : Button
    {
        public VillogoGomb() 
        {
            MouseEnter += VillogoGomb_MouseEnter;
            MouseLeave += VillogoGomb_MouseLeave;
        }

        private void VillogoGomb_MouseLeave(object? sender, EventArgs e)
        {
            Random rnd = new Random();
            BackColor = Color.FromArgb(rnd.Next(0, 250), rnd.Next(0, 250), rnd.Next(0, 250));
        }

        private void VillogoGomb_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
