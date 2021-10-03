using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class ClaseAvion:ClaseVehiculo
    {
       

     
        public virtual string Info()
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
            return "El avíon  tiene una velocidad maxima de 7,200Km /h  " +
                " y " + propiedades;
        }
 
       
        public int atributos { get; set; }
        public virtual string combustible()
        {
            return "El avión tiene tanque lleno";
        }
        public override string moverse()
        {
            return "El avión no puede moverse sin acelerar";
        }



        public virtual string cambiodevelocidad()
        {
            return "El avíon no cambia de velocidad";
        }


        public virtual string detenerse()
        {
            return "El avíon se esta deteniendo";
        }
        public virtual string  girar()
        {
            return "El avión giro";
        }
        public  string comunicacion()
        {
            return "El avíon tiene sistema de comunicacion";
        }
    }
}
