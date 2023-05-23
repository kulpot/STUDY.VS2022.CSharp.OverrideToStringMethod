using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideToStringMethod
{
    class Vertex
    {
        private int _x, _y, _z;

        public Vertex(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public int X { get { return _x; } }
        public int Y { get { return _y; } }
        public int Z { get { return _z; } }

        public override string ToString()
        {
           return string.Format("{0}, {1}, {2}", _x, _y, _z);
        }
    }
}
