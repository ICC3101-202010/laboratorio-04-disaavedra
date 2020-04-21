using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class ComputadorCentral : IAutomatico, IManual
    {
        MaquinaRecepcion Recepcion = new MaquinaRecepcion();

        MaquinaAlmacenamiento Almacenamiento = new MaquinaAlmacenamiento();

        MaquinaEnsamblaje Ensamblaje = new MaquinaEnsamblaje();

        MaquinaVerificacion Verificacion = new MaquinaVerificacion();

        MaquinaEmpaque Empaque = new MaquinaEmpaque();

        int re = 5;

        int al = 6;

        int en = 7;

        int ve = 8;

        int em = 9;

        public void ReinicioAutomatico()
        {
            if (Recepcion.memoriaRecepcion == re)
            {
                Recepcion.Reinicio();
            }

            if (Almacenamiento.memoriaAlmacenamiento == al)
            {
                Almacenamiento.Reinicio();
            }

            if (Ensamblaje.memoriaEnsamblaje == en)
            {
                Ensamblaje.Reinicio();
            }

            if (Verificacion.memoriaVerificacion == ve)
            {
                Verificacion.Reinicio();   
            }

            if (Empaque.memoriaEmpaque == em)
            {
                Empaque.Reinicio();
            }

            else
            {
                Console.WriteLine("Sigue el trabajo");
            }

            Recepcion.memoriaRecepcion++;

            Almacenamiento.memoriaAlmacenamiento++;

            Ensamblaje.memoriaEnsamblaje++;

            Verificacion.memoriaVerificacion++;

            Empaque.memoriaEmpaque++;

        }

        public void EncendidoMaquinas()
        {
            Recepcion.Encendido();

            Almacenamiento.Encendido();

            Ensamblaje.Encendido();

            Verificacion.Encendido();

            Empaque.Encendido();
        }

        public void ApagadoMaquinas()
        {
            Recepcion.Apagado();

            Almacenamiento.Apagado();

            Ensamblaje.Apagado();

            Verificacion.Apagado();

            Empaque.Apagado();
        }

        public void MemoriaManual()
        {
            int contador = 0;

            if (Recepcion.memoriaRecepcion >= re)
            {
                Console.WriteLine("Memoria de Recepcion llena");

                contador++;
            }

            if (Almacenamiento.memoriaAlmacenamiento >= al)
            {
                Console.WriteLine("Memoria de Almacenamiento llena");

                contador++;
            }

            if (Ensamblaje.memoriaEnsamblaje >= en)
            {
                Console.WriteLine("Memoria de Ensamblaje llena");

                contador++;
            }

            if (Verificacion.memoriaVerificacion >= ve)
            {
                Console.WriteLine("Memoria de Verificacion llena");

                contador++;
            }

            if (Empaque.memoriaEmpaque >= em)
            {
                Console.WriteLine("Memoria de Empaque llena");

                contador++;
            }

            if (contador == 0)
            {
                Console.WriteLine("Sigue el trabajo, no hay memorias llenas");
            }

            Recepcion.memoriaRecepcion++;

            Almacenamiento.memoriaAlmacenamiento++;

            Ensamblaje.memoriaEnsamblaje++;

            Verificacion.memoriaVerificacion++;

            Empaque.memoriaEmpaque++;

        }

        public void ReinicioManualCentral(String maquina)
        {
            if(maquina == "1")
            {
                Recepcion.ReinicioManual();
            }

            if (maquina == "2")
            {
                Almacenamiento.ReinicioManual();
            }

            if (maquina == "3")
            {
                Ensamblaje.ReinicioManual();
            }

            if (maquina == "4")
            {
                Verificacion.ReinicioManual();
            }

            if (maquina == "5")
            {
                Empaque.ReinicioManual();
            }
        }
    }
}
