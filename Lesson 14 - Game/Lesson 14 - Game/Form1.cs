using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_14___Game
{
    public partial class Game : Form
    {
        const string iconPath = "../../img/Bird.ico";
        int size = 64;
        int x, y;
        Icon icon = new Icon(iconPath);
        const int smallStep = 5;
        const int largeStep = 40;
        
        private void Game_Paint(object sender, PaintEventArgs e)
        {
            if (x> ClientSize.Width-size)
                x = 0;
            if (y> ClientSize.Height-size)
                y = 0;
            if (x < 0)
                x = ClientSize.Width - size;
            if (y < 0)
                y = ClientSize.Height - size;
            if (size > ClientSize.Height)
                size = ClientSize.Height;
            if (size > ClientSize.Width)
                size = ClientSize.Width;   
                    
            e.Graphics.DrawIcon(icon, new Rectangle(x, y, size, size));
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (e.Alt)
                        y -= largeStep;
                    else
                        y -= smallStep;
                    break;
                case Keys.Down:
                    if (e.Alt)
                        y += largeStep;
                    else
                        y += smallStep;
                    break;
                case Keys.Left:
                    if (e.Alt)
                        x -= largeStep;
                    else
                        x -= smallStep;
                    break;
                case Keys.Right:
                    if (e.Alt)
                        x += largeStep;
                    else
                        x += smallStep;
                    break;
                case Keys.Oemplus:
                    size += smallStep;
                    break;
                case Keys.OemMinus:
                    size -= smallStep;
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.D1:
                    x = y = 0;
                    break;
                case Keys.D2:
                    x = ClientSize.Width - size;
                    y = 0;
                    break;
                case Keys.D3:
                    x = 0;
                    y = ClientSize.Height-size;
                    break;
                case Keys.D4:
                    x = ClientSize.Width - size;
                    y = ClientSize.Height - size;
                    break;
                default:
                    break;
            }
            this.Refresh();
        }

        public Game()
        {
            InitializeComponent();
            x = ClientSize.Width / 2 - size/2;
            y = ClientSize.Height / 2 - size/2;
        }

    }
}
