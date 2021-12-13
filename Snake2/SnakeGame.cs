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
        public const int X_SIZE = 10;
        public const int Y_SIZE = 10;

        Point capSerp = new Point(X_SIZE/2, 0);
        DireccioSnake direccio = DireccioSnake.Dreta;
        public List<Point> pomes = new List<Point>();
        private int NUMPOMES;

        public Point CapSerp { get => capSerp; set => capSerp = value; }
        public DireccioSnake Direccio { get => direccio; set => direccio = value; }

        public SnakeGame() {
            Random r = new Random();
            for (int i = 0; i < NUMPOMES; i++) {
                pomes.Add(new Point(r.Next(X_SIZE),r.Next(Y_SIZE)));
            }
        }

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
