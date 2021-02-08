using Figures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public abstract class Figure : IFigure
    {
        public virtual double Square { get; protected set; }
    }
}
