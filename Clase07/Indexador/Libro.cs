using System;
using System.Collections.Generic;

namespace Indexador
{
    public class Libro
    {

        private List<string> paginas;

        public string this[int i]
        {
            get
            {
                string rta = "";
                if (i >= 0) 
                {
                    rta = paginas[i];
                }

                return rta;
            }
            set
            {
                if(i <= paginas.Count && i >= 0)
                {
                    paginas[i] = value;
                }
                else if(i > paginas.Count)
                {
                    paginas.Add(value);
                }
            }
        }
    }
}
