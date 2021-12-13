using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Snake2
{
    public enum DireccioSnake
    {
        Dreta,
        Esquerre,
        Avall,
        Amunt
    }

    class SnakeGame
    {
        public const int X_SIZE = 5;
        public const int Y_SIZE = 5;

        Point capSerp = new Point(X_SIZE/2, 0);
        public DireccioSnake direccio = DireccioSnake.Dreta;

        public Point CapSerp { get => capSerp; set => capSerp = value; }
        public DireccioSnake Direccio { get => direccio; set => direccio = value; }

        internal void moure(DireccioSnake dir)
        {
            switch (dir) {
                case DireccioSnake.Dreta:
                    capSerp.X++;
                    break;
                case DireccioSnake.Esquerre:
                    capSerp.X--;
                    break;
                case DireccioSnake.Avall:
                    capSerp.Y++;
                    break;
                case DireccioSnake.Amunt:
                    capSerp.Y--;
                    break;
                default:
                    break;
            }
        }
    }
}
