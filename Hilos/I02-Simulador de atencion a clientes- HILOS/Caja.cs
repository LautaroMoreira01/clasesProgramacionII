using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace I02_Simulador_de_atencion_a_clientes__HILOS
{
    
    public delegate void DelegadoClienteAtendido(Caja caja, string cliente);

    public class Caja
    {
        
        private static Random random;
        private Queue<string> clientesALaEspera;
        private string nombreCaja;
        private DelegadoClienteAtendido delegadoClienteAtendido;
        public string NombreCaja { get => nombreCaja; }

        public int CantidadClientesALaEspera { get => clientesALaEspera.Count; }

        static Caja()
        {
            random = new Random();
        }
        public Caja(string nombre, DelegadoClienteAtendido delegadoClienteAtendido)
        {
            clientesALaEspera = new Queue<string>();
            nombreCaja = nombre;
            this.delegadoClienteAtendido = delegadoClienteAtendido;
        }

        internal void AgregarCliente(string cliente)
        {
            clientesALaEspera.Enqueue(cliente);
        }

        internal Task IniciarAtencion()
        {
            return Task.Run(AtenderCliente);
        }
       
        private void AtenderCliente()
        {

            while (true)
            {
                if (clientesALaEspera.Any())
                {
                    string cliente = clientesALaEspera.Dequeue();

                    delegadoClienteAtendido(this, cliente);

                    Thread.Sleep(random.Next(1000, 5000));
                }
            }

        }

    }
}
