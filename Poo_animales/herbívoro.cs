﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_animales
{
    class herbívoro : Animal
    {
        private string tipoComida;

        //constructores
        public herbívoro(string tipoC, string nombre, int edad):base(nombre,edad)//caso cuando es herdacion
        {
            tipoComida = tipoC;
        }

        //propiedades de cada atributo Set y Get forma 1
        //public string TipoComida
        //{
        //    get { return tipoComida; }
        //    set { tipoComida = value; }
        //}

        //forma 2
        public string getTipoComida()
        {
            return tipoComida;
        }

        public void setTipoComida(string tipoC)
        {
            tipoComida = tipoC;
        }
        public string noComo()
        {
            return "No como carne con edad -";
        }
    }
}
