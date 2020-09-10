
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace DPRN1_U3_AC_PIVM
{
    class Proceso
    {
        Menu menu = new Menu();
        private List<Encuesta> listEncuesta;
        private Encuesta encuesta;
        private Dato datoEncuesta;

        public void Opciones()
        {
            listEncuesta = new List<Encuesta>;
            int opcion;
            datoEncuesta = new Dato("Encuesta.bd");

            do
            {
                do
                {
                    if (File.Exists("Encuesta.bd"))
                    {
                        listEncuesta= datoEncuesta.deserializarEncuesta();
                        Console.WriteLine("Hay Encuesta ");
                    }
                    menu.menu();
                    Console.WriteLine("Ingresa opcion valida [1 -5]");
                    opcion = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (opcion < 1 || opcion > 5)
                    {
                        Console.WriteLine("Ingresa opcion valida [1 -5]");
                    }
                } while (opcion < 1 || opcion > 6);
            } while (opcion < 1 || opcion > 6);
        }
    }
}
