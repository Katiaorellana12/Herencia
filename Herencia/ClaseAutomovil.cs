using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class ClaseAutomovil:ClaseAvion
    {



        public override string Info()
        {
            var propiedades = "";

            if (velocidadmaxima == true)
            {
                propiedades = "tiene masa";
            }
            else
            {
                propiedades = "no tiene masa";
            }
            return "El automovil tiene una velocidad maxima de 120Km /h  " +
                " y " + propiedades;
        }
        public override string combustible()
        {
            return "El automovil tiene tanque lleno";
        }

        public override string moverse()
        {
            return "El automovil no puede moverse sin acelerar";
        }

        public override string cambiodevelocidad()
        {
            return "El automovil cambia de velocidad";
        }


        public override string detenerse()
        {
            return "El automovil se esta deteniendo";
        }
        public override string girar()
        {
            return "El automovil gira";
        }
      
    }
}
