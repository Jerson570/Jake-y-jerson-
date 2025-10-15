using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wEvaluación
{
    public partial class frmActividadEvaluativa : Form
    {
        public frmActividadEvaluativa()
        {
            InitializeComponent();
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            lstResumen.Items.Clear();
            List<Dispositivo> dispositivos = new List<Dispositivo>
            {
                new Laptop("Laptop 1", 1_000_000m),
                new Tablet("Tablet 1", 800_000m),
                new Celular("Celular 1", 500_000m),
                new Laptop("Laptop 2", 10_000_000m)
            };

           
            foreach (var d in dispositivos)
            {
                decimal mantenimiento = d.CalcularMantenimiento();
                lstResumen.Items.Add(
                    $"{d.GetType().Name} ({d.Nombre}) - " +
                    $"Costo Base: {d.CostoBase:C0} - " +
                    $"Mantenimiento: {mantenimiento:C0}"
                );
            }
        }
    }
}
