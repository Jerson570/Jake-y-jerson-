using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wEvaluación
{ /// <summary>
  /// Laptop, el mantenimiento corresponde al 15%
  /// </summary>

    public sealed class Laptop: Dispositivo
    {
        public Laptop(string nombre, decimal costoBase) : base(nombre, costoBase)
        {

        }

        public override decimal CalcularMantenimiento()
        {
            return Math.Round(CostoBase * 0.15m, 2);
        }
    }
}
