using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Jugador : Persona
    {
        public int Numero { get; set; }  // ya estaba y creamos numCamisa
        public bool EsTitular { get; set; } 
        public Equipo Equipo { get; set; }
        public Posicion Posicion { get; set; }
        public int? NumCamiseta { get; set; }

        public Jugador(int numero, Equipo equipo, Posicion posicion, int? numCamiseta)
        {
            this.Numero = numero;
            this.Equipo = equipo;
            this.Posicion = posicion;
            this.NumCamiseta = numCamiseta;

            if (numCamiseta.HasValue)
            {
                if (numCamiseta.Value >=1 && numCamiseta.Value <=11 )
                {
                    this.EsTitular = true;    // preguntar por el default del bool
                }
            }

        }

        public override bool ProximaARetiro()
        {
            return Edad >= (Constantes.EdadRetiro - 2) || Edad <= (Constantes.EdadRetiro + 2);
        }
    }
}
