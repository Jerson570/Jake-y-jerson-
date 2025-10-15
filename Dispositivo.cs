using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TODO: Analizar por qué el polimorfismo no funciona como se espera.

namespace wEvaluación
{
    public class Dispositivo
    {
        public string Nombre { get; set; }
        public double CostoBase { get; set; }

        public virtual double CalcularMantenimiento()
        {
            return CostoBase * 0.15;
        }
    }

    public class Laptop : Dispositivo
    {
        
        public new double CalcularMantenimiento()
        {
            return CostoBase * 0.15;
        }
    }

    public class Tablet : Dispositivo
    {
        
        public double CalcularMantenimiento(double extra)
        {
            return (CostoBase * 0.05) + extra;
        }
    }

    public class Celular : Dispositivo
    {
        
        public override double CalcularMantenimiento()
        {
            return 100000;
        }
    }
}
