using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class MaquinaRecepcion : Maquina
    {
        public int memoriaRecepcion = 0;

        public override void Encendido()
        {
            Console.WriteLine("Encendido de maquina de Recepcion");
        }

        public override void Reinicio()
        {
            Console.WriteLine("Memoria de Recepcion llena");

            Console.WriteLine("Reinicio de maquina de Recepcion");

            memoriaRecepcion = 0;
        }

        public override void Apagado()
        {
            Console.WriteLine("Apagado de maquina de Recepcion");
        }

        public override void ReinicioManual()
        {
            memoriaRecepcion = 0;

            Console.WriteLine("Memoria Recepcion reiniciada");
        }
    }
}
