﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using I02_Simulador_de_atencion_a_clientes__HILOS;

namespace I02Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DelegadoClienteAtendido delegadoClienteAtendido = (caja, cliente) =>
            {
                Console.WriteLine($"{DateTime.Now:HH:MM:ss} - Hilo {Task.CurrentId} - {caja.NombreCaja} - Atendiendo a {cliente}. Quedan {caja.CantidadClientesALaEspera} en esta caja.");
            };

            Caja caja1 = new Caja("Caja1", delegadoClienteAtendido);
            Caja caja2 = new Caja("Caja2",delegadoClienteAtendido);

            List<Caja> cajas = new List<Caja>();

            cajas.Add(caja1);
            cajas.Add(caja2);

            Negocio negocio = new Negocio( cajas);

            Console.WriteLine("Asignando cajas...");

            List<Task> hilos = negocio.ComenzarAtencion();
            

            Task.WaitAll(hilos.ToArray());
        }
    }
}
