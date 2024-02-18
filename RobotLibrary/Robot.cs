using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotLibrary
{
    public class Robot
    {
        private readonly Random _random = new Random();
        private (int X, int Y) _coord;

        public string Name { get; set; }
        public (int X, int Y) Coordinates { get { return _coord; } }

        public Robot(int x, int y, string name)
        {
            _coord = (x, y);
            Name = name;
        }

        public void Move()
        {
            int direction = _random.Next(0, 4);
            switch (direction)
            {
                case 0: // вперёд
                    _coord.Y++;
                    break;
                case 1: // назад
                    _coord.Y--;
                    break;
                case 2: // влево
                    _coord.X--;
                    break;
                case 3: // вправо
                    _coord.X++;
                    break;
            }
        }

        public string GetInfo()
        {
            return $"{Name} ({_coord.X}, {_coord.Y})";
        }

        public override string ToString()
        {
            return $"{Name} ({_coord.X}, {_coord.Y})";
        }
    }
}
