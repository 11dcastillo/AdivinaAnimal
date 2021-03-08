using System;
using System.Collections.Generic;
using System.Text;

namespace arbolsimple.clases.ArbolBinario
{
    class Nodo
    {
        public object dato;
        public Nodo izquierda;
        public Nodo derecha;

        public Nodo (object valor)
        {
            dato = valor;
            izquierda = null;
            derecha = null;

        }

        public Nodo (Nodo ramaIzquierda, object valor, Nodo ramaDerecha)
        {
            dato = valor;
            izquierda = ramaIzquierda;
            derecha = ramaDerecha;

        }

        public void visitar ()
        {
            Console.WriteLine(dato +"=>");
        }

        public object valorNodo()
        {
            return dato;
        }

        public Nodo subarbolDerecho()
        {
            return derecha;

        }

        public Nodo  subarbolIzquierdo()
        {
            return izquierda;
        }

        public void nuevoValor (object nv)
        {
            dato = nv;
        }

        public void ramaIzda (Nodo n)
        {
            izquierda = n;
        }

        public void ramaDcho (Nodo n)
        {
            derecha = n;
        }

    }
}
