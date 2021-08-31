using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo
    {
        public const short cantidadTintamaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }
        public short GetTinta()
        {
            return tinta;
        }

        private void SetTinta(short tinta)
        {
            
            if (tinta > 0 && this.tinta + tinta <= cantidadTintamaxima)
            {
                this.tinta += tinta;
                
            }
            else if (tinta < 0 && this.tinta - tinta >= 0)
            {
                this.tinta -= tinta;
            }
        }

        public void Recargar()
        {
            SetTinta((short)(this.tinta - cantidadTintamaxima));
        }

        public bool Pintar(short gasto, out string dibujo)
        {

        }

    }
}
