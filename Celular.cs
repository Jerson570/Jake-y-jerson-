using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wEvaluación
{/// Celular, en este el mantenimiento corrresponde al 10% del valor base
    public sealed class Celular:Dispositivo
    {
        public Celular(string nombre, decimal costoBase):base(nombre, costoBase) { }

        public override decimal CalcularMantenimiento()
        {
            return Math.Round(CostoBase * 0.10m, 2);
        }
    }
}
