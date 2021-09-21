using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01
{
    public abstract class Sobrescrito
    {

        protected string miAtributo;
        public Sobrescrito()
        {
            miAtributo = "Pobar Abstracto.";
        }
        public override string ToString()
        {
            return "Este es mi metodo ToString sobrecargado!";
        }
        public override bool Equals(object obj)
        {
            return obj.GetType() ==  this.GetType();
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }
        public abstract string MiMetodo();
        public abstract string MiPropiedad { get; }
    }
}
