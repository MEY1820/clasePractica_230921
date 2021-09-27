using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_230921
{
    class Figura
    {
        // Definir Miembros
        // Propiedades 

        public string _figuraId { get; set; }
        public string _forma { get; set; }
        public string _angulo { get; set; }

        // Propiedades autoimplementada
        public string _lados { get; set; }

        // Metodo constructor
        public Figura(string figuraId, string forma, string angulo, string lados) // Metodo constructor vacio
        {
            _figuraId = figuraId;
            _forma = forma;
            _angulo = angulo;
            _lados = lados;

        }
        public string ObtenerDatos()
        {
            return "Numero de la figura: " + _figuraId + " Forma: " + _forma + " Cantidad de angulos: "
                + _angulo + " Cantidad de lados: " + _lados;

        }
    }

}