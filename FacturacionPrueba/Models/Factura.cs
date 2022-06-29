using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacturacionPrueba.Models
{
    public class Factura
    {
        public string NombreCliente { get; set; }
        public int IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreEmpresa { get; set; }
    }
}
