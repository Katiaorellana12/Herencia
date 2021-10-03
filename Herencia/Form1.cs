using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            ClaseAvion claseAvion = new ClaseAvion();
            ClaseVehiculo claseVehiculo = new ClaseVehiculo();
            ClaseBicicleta claseBicicleta = new ClaseBicicleta();
            ClaseAutomovil claseAutomovil = new ClaseAutomovil();
            
            claseAvion.velocidadmaxima = false;
            claseVehiculo.velocidadmaxima = true;
            claseAvion.atributos = 7;
            claseAutomovil.velocidadmaxima = false;


            MessageBox.Show(claseVehiculo.getInfo());
            MessageBox.Show(claseVehiculo.partes());
            MessageBox.Show(claseVehiculo.moverse());
            MessageBox.Show(claseVehiculo.detener());
            MessageBox.Show(claseVehiculo.cambiardevelocidad());
            MessageBox.Show(claseAvion.Info());
            MessageBox.Show(claseAvion.detenerse());
            MessageBox.Show(claseAvion.girar());
            MessageBox.Show(claseAvion.moverse());
            MessageBox.Show(claseAvion.comunicacion());
            MessageBox.Show(claseAvion.cambiodevelocidad());
            MessageBox.Show(claseAvion.combustible());
            MessageBox.Show(claseBicicleta.getInfo());
            MessageBox.Show(claseBicicleta.moverse());
            MessageBox.Show(claseBicicleta.detener());
            MessageBox.Show(claseBicicleta.cambiardevelocidad());
            MessageBox.Show(claseBicicleta.girarse());
            MessageBox.Show(claseAutomovil.Info());
            MessageBox.Show(claseAutomovil.moverse());
            MessageBox.Show(claseAutomovil.detenerse());
            MessageBox.Show(claseAutomovil.cambiodevelocidad());
            MessageBox.Show(claseAutomovil.girar());
        }
    }
    }
 