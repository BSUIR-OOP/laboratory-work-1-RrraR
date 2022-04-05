using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ClassLibrary2
{
    [Serializable()]
    public class Shape
    {
        public virtual Graphics Draw(Graphics Space, Pen Color)
        {
            return Space;
        }

    }
}
