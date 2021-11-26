using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model
{
    public class Element
    {
        public Element()
        {
            Id = Guid.NewGuid();
        }

        public Element(int width, int height, int vertical, int horizontal, int casement)
            :base()
        {
            Width = width;
            Height = height;
            Vertical = vertical;
            Horizontal = horizontal;
            Casement = casement;
        }

        public Guid Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Vertical { get; set; }
        public int Horizontal { get; set; }
        public int Casement { get; set; }

        public int Frame { get => (int)(2*Width+2*Height); }
        public int Impost { get => (int)(Vertical * Height + Horizontal * Width); }
        public int Sash 
        { 
            //get => Casement * 2 * ((ushort)Width / Vertical + (ushort)Height / Horizontal); 
            get
            {
                int casementWidth = Width;
                int casementHeight = Height;

                if (Vertical != 0)
                    casementWidth = Width / (Vertical+1);

                if (Horizontal != 0)
                    casementHeight = Height / (Horizontal+1);

                return Casement * 2 * (casementHeight + casementWidth);
            }
        }
    }
}
