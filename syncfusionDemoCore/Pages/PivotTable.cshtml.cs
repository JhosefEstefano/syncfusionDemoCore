using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace syncfusionDemoCore.Pages
{
    public class PivotTableModel : PageModel
    {

        public List<PivotData> ListaDatos { get; set; }

        public void OnGet()
        {
            this.ListaDatos = Getdata();
        }

        public class PivotData
        {
            public string CodigoBodega { get; set; } = string.Empty;
            public string Bodega { get; set; } = string.Empty;
            public string Serie { get; set; } = string.Empty;
            public int NoFactura { get; set; } = 0;
            public string Fecha { get; set; } = string.Empty;
            public int Credito { get; set; } = 0;
            public string Comentario { get; set; } = string.Empty;
            public int NoPedido { get; set; } = 0;
            public int CodigoCliente { get; set; } = 0;
            public string NIT { get; set; } = string.Empty;
            public string Cliente { get; set; } = string.Empty;
            public int CodigoVendedor { get; set; }
            public string Vendedor { get; set; } = string.Empty;
            public string CodigoProducto { get; set; } = string.Empty;
            public string NombreProducto { get; set; } = string.Empty;
            public string FamiliaProducto { get; set; } = string.Empty; 
            public string TipoProducto { get; set; } = string.Empty;
            public string LineaProducto { get; set; } = string.Empty;
            public string ClaseProducto { get; set; } = string.Empty;
            public decimal CantidadVenta { get; set; } = 0;
            public decimal PrecioUnitario { get; set; } = 0;
            public decimal Total { get; set; } = 0;
        }

        public List<PivotData> Getdata()
        {
            using StreamReader reader = new("wwwroot/data/ConsultaVentas.json");
            var json = reader.ReadToEnd();
            List<PivotData> data = JsonConvert.DeserializeObject<List<PivotData>>(json);
            return data;
        }


    }
}
