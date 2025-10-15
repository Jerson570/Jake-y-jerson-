using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wEvaluación
{ ///Respresenta la tablet y el mantenimiento vale el 5% del costo base 
    public sealed class Tablet:Dispositivo
    {
        public Tablet(string nombre, decimal costoBase):base(nombre, costoBase) { }

        public override decimal CalcularMantenimiento()
        {
            return Math.Round(CostoBase * 0.05m, 2);
        }
    }

    
}
