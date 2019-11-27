using System;

namespace Interfaces.Clases {

    public class Caja : ICaja, IMedidas
    {
        public Caja()
        {
        }

        public Caja(string color, string contenido, bool estaAbierta)
        {
            this.Color = color;
            this.Contenido = contenido;
            this.estaAbierta = estaAbierta;
        }

        public Caja(string color, string contenido, bool estaAbierta, double largo, double ancho) : this(color, contenido, estaAbierta)
        {
            this.Largo = largo;
            this.Ancho = ancho;
        }

        public string Color { get; set; }
        public string Contenido { get; set; }
        public bool estaAbierta { get; set; }
        public double Largo { get; set; }
        public double Ancho { get; set; }

        public bool Abrir()
        {
            return (estaAbierta?estaAbierta:!estaAbierta);
        }

        public bool Cerrar()
        {
            return (estaAbierta?!estaAbierta:estaAbierta);
        }

        public string Medidas()
        {
            return $"({Largo},{Ancho}";
        }
    }


}

