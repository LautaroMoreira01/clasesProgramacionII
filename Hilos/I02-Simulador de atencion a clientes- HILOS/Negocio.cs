using NameGenerator.Generators;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace I02_Simulador_de_atencion_a_clientes__HILOS
{
    public class Negocio
    {
        private static RealNameGenerator realNameGenerator;
        private ConcurrentQueue<string> clientes;
        private List<Caja> cajas;

        public Negocio(List<Caja> cajas)
        {
            this.cajas = cajas;
            this.clientes = new ConcurrentQueue<string>();
        }
        static Negocio()
        {
            realNameGenerator = new RealNameGenerator();
        }


        public List<Task> ComenzarAtencion()
        {
            List<Task> hilos = new List<Task>();

            hilos.AddRange(IniciarCajas());

            hilos.Add (Task.Run(() => CargarCliente()));

            hilos.Add(Task.Run(() => AsignarCajas()));

            return hilos;
        }

        private void AsignarCajas()
        {
            while (true)
            {

                Caja cajaConMenosClientes = cajas.OrderBy(c => c.CantidadClientesALaEspera).First();

                clientes.TryDequeue(out string cliente);

                if (!string.IsNullOrEmpty(cliente))
                {
                    cajaConMenosClientes.AgregarCliente(cliente);
                }
            }

        }

        private List<Task> IniciarCajas()
        {
            List<Task> hilos = new List<Task>();

            foreach (Caja caja in cajas)
            {
                hilos.Add(Task.Run(() => caja.IniciarAtencion()));
            }
            return hilos;
        }

        private void CargarCliente()
        {
            while (true)
            {
                string cliente = realNameGenerator.Generate();
                Thread.Sleep(1000);
                clientes.Enqueue(cliente);
            }
        }
    }
}
