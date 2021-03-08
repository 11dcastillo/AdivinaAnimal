using System;
using System.Collections.Generic;
using System.Text;

namespace arbolsimple.clases.ArbolBinario
{
    class ArbolBinario
    {
        protected Nodo raiz;

        public ArbolBinario()
        {
            raiz = null;
        }

        public ArbolBinario(Nodo Valorraiz)
        {
            this.raiz = Valorraiz;
        }
        public Nodo raizArbol()
        {
            return raiz;
        }

        bool esVacio()
        {
            return  raiz == null;
        }
        public static Nodo nuevoArbol(Nodo ramaIzqda, object dato, Nodo ramaDrcha)
        {
            return new Nodo(ramaIzqda, dato, ramaDrcha);

        }


    }
}
