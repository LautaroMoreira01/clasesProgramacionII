using System;
using System.Collections.Generic;

namespace Indexador
{
    public class Libro
    {

        private List<string> paginas;

        public Libro()
        {
            paginas = new List<string>();
        }
        public string this[int i]
        {
            get
            {
                string rta = "";
                if (i >= 0 && i < paginas.Count) 
                {
                    rta = paginas[i];
                }

                return rta;
            }
            set
            {
                //if(  i >= 0 && i <= paginas.Count)
                //{
                //    paginas.Add(value);
                //}
                 if(i >= 0)
                {
                    paginas.Insert(i , value);
                }
            }
        }
    }
}
