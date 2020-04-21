using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class MaquinaEnsamblaje : Maquina
    {
        public int memoriaEnsamblaje = 0;

        public override void Encendido()
        {
            Console.WriteLine("Encendido de maquina de Ensamblaje");
        }

        public override void Reinicio()
        {
            Console.WriteLine("Memoria de Ensamblaje llena");

            Console.WriteLine("Reinicio de maquina de Ensamblaje");

            memoriaEnsamblaje = 0;
        }

        public override void Apagado()
        {
            Console.WriteLine("Apagado de maquina de Ensamblaje");
        }

        public override void ReinicioManual()
        {
            memoriaEnsamblaje = 0;

            Console.WriteLine("Memoria Ensamblaje reiniciada");
        }
    }
}
