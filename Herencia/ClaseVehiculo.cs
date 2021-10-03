using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class ClaseVehiculo
    { 

        public int masa { get; set; }
    public Boolean velocidadmaxima { get; set; }


    
    public virtual string getInfo()
    {
        var propiedades = "";

        if ( velocidadmaxima == true)
        {
            propiedades = "tiene masa";
        }
        else
        {
            propiedades = "no tiene masa";
        }
        return "El vehiculo tiene una velocidad maxima de 120km/h " +
            " y " + propiedades;
    }
    public virtual string moverse()
    {
        return "El vehiculo no puede moverse sin acelerar";
    }


    
        public string partes()
        {
            return "El vehiculo tiene muchas partes";
        }


        public virtual string detener()
    {
        return "El vehiculo se esta deteniendo";
    }
        public virtual string  cambiardevelocidad()
        {
            return "El vehiculo cambia de velocidad constantemente";
        }

    }
}
