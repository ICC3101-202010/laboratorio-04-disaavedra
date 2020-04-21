using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class MaquinaAlmacenamiento : Maquina
    {
        public int memoriaAlmacenamiento = 0;

        public override void Encendido()
        {
            Console.WriteLine("Encendido de maquina de Almacenamiento");
        }

        public override void Reinicio()
        {
            Console.WriteLine("Memoria de Almacenamiento llena");

            Console.WriteLine("Reinicio de maquina de Almacenamiento");

            memoriaAlmacenamiento = 0;
        }

        public override void Apagado()
        {
            Console.WriteLine("Apagado de maquina de Almacenamiento");
        }

        public override void ReinicioManual()
        {
            memoriaAlmacenamiento = 0;

            Console.WriteLine("Memoria Almacenamiento reiniciada");
        }
    }
}
