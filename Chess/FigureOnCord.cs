using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class FigureOnCord
    {
        public Figure figure { get; private set; }
        public Cord cord { get; private set; }
        public FigureOnCord (Figure figure, Cord cord)
        {
            this.cord = cord;
            this.figure = figure;
        }

        
    }   
}
