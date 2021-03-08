using arbolsimple.clases.ArbolBinario;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace arbolsimple.clases.JuegoAnimal
{
    class AdivinaAnimal
    {
        private static Nodo raiz;

        public AdivinaAnimal()
        {
            raiz = new Nodo("Elefante");

        }

        public void jugar()
        {
            Nodo nodo = raiz;
            while (nodo != null)// Interacion del arbol
            {
                if (nodo.izquierda != null)//Existe una pregunta
                {
                    Console.WriteLine(nodo.valorNodo());
                    nodo = (respuesta()) ? nodo.izquierda : nodo.derecha;

                }

                else
                {
                    Console.WriteLine($"Ya se, es un {nodo.valorNodo()}?");
                    if (respuesta())
                    {
                        Console.WriteLine("Gane!! :)");

                    }
                    else {
                        animalNuevo(nodo);
                    }
                    nodo = null;
                    return;
                }//fin if
            }//fin while
        }//fin jugar

        public bool respuesta()
        {
            while (true)
            {
                String resp = Console.ReadLine().ToLower().Trim();
                if (resp.Equals("si")) return true;
                if (resp.Equals("no")) return false;
                Console.WriteLine("La respuesta debe ser si o no");
            }
        }// fin respuesta

        public void animalNuevo(Nodo nodo)
        {

            String animalNodo = (String)nodo.valorNodo();
            Console.WriteLine("Cuale es tu animal pues?");
            String nuevoA = Console.ReadLine();
            Console.WriteLine($"Que pregunta con respuesta si / no puedo hacer para decir que es: {nuevoA}");
            string pregunta = Console.ReadLine();
            Nodo nodo1 = new Nodo(animalNodo);
            Nodo nodo2 = new Nodo(nuevoA);
            Console.WriteLine($"Para un(a) {nuevoA} la respuesta es si /no ?");
            nodo.nuevoValor(pregunta + "?");

           

            //-------------------------------------------------------------------------------------------------------------
            //*****guardar informacion******
            TextWriter archivo;
            archivo = new StreamWriter("archivoInfo.txt",true);
            string informacion1, informacion2;
            informacion1 = nuevoA;
            informacion2 = pregunta;
            archivo.WriteLine(informacion1);
            archivo.WriteLine(informacion2);
            archivo.Close();
            //--------------------------------------------------------------------------------------------------------------

            //****leer informacion*****
            string FileToRead = @"C:\Users\casti\Desktop\7to Semestre\Programacion 3\JuegoAdivinaAnimal-main\arbolsimple\bin\Debug\netcoreapp3.1\archivoInfo.txt";

            // Creating string array  
            string[] lines = File.ReadAllLines(FileToRead);
            Console.WriteLine(String.Join(Environment.NewLine, lines));

            //--------------------------------------------------------------------------------------------------------------



            if (respuesta())
            {
                nodo.izquierda = nodo1;
                nodo.derecha = nodo2;

            }
            else
            {
                nodo.izquierda = nodo2;
                nodo.derecha = nodo1;
            }


           






        }








    }
}
