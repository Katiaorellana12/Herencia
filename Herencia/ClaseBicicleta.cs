using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class ClaseBicicleta:ClaseVehiculo
    {

       
        public override string getInfo()
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
            return "El bicicleta tiene una velocidad maxima de 42km/h " +
                " y " + propiedades;
        }
        public  override string moverse()
        {
            return "La bicicleta no puede moverse sin pedalear";
        }
       
        public override string detener()
        {
            return "La bicicleta se esta deteniendo";
        }
        public override string cambiardevelocidad()
        {
            return "La bicicleta cambia de velocidad rapido";
        }
        public string girarse()
        {
            return "La bicicleta gira";
        }
    }
}
