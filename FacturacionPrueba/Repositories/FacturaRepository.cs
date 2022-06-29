using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FacturacionPrueba.Models;
using System.Data;

namespace FacturacionPrueba.Repositories
{
    public class FacturaRepository
    {
        private readonly string StringConnection = "data source=JAVI08-PC\\MYMSSQLSERVER;initial catalog = TestDb; persist security info=True; Integrated Security = SSPI;";

        public bool TestConnection()
        {
            try
            {
                var cdn = new SqlConnection(StringConnection);
                cdn.Open();
                return true;
            } catch(Exception ex)
            {
                return false;
            }
        }

        public List<Producto> GetProductos()
        {
            try
            {
                using (var cdn = new SqlConnection(StringConnection))
                {
                    var query = "SELECT * FROM productos";
                    var cmd = new SqlCommand(query, cdn);
                    var da = new SqlDataAdapter(cmd);
                    DataTable tb = new DataTable();
                    da.Fill(tb);
                    return MapToProductos(tb);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private List<Producto> MapToProductos(DataTable tb)
        {
            var productos = new List<Producto>();
            if (tb.Rows.Count == 0) return null;

            productos = (from producto in tb.AsEnumerable()
                         select new Producto() {
                             Codigo = producto["codigoProducto"].ToString(),
                             Descripcion = producto.Field<string>("descripcion"),
                             Precio = producto.Field<decimal>("precio")

                         }).ToList();

            return productos;
        }
    }
}
