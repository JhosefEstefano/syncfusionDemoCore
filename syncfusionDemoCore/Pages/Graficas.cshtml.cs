using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace syncfusionDemoCore.Pages
{
    public class GraficasModel : PageModel
    {
        public List<ChartData> chartData { get; set; } = new List<ChartData>();
        public List<LineData> lineData { get; set; } = new List<LineData>();
        public List<PieData> pieData1 { get; set; } = new List<PieData>();

        public double[] cellSpacing { get; set; } = new double[] { 10, 10 };
        public void OnGet()
        {
            chartData = new List<ChartData>{
                new ChartData {
                    month = "Jan",
                    sales = 35,
                },
                new ChartData {
                    month = "Feb",
                    sales = 28,
                },
                new ChartData {
                    month = "Mar",
                    sales = 34,
                },
                 new ChartData {
                    month = "Apr",
                    sales = 32,
                },
                new ChartData {
                    month = "May",
                    sales = 40,
                },
                new ChartData {
                    month = "Jun",
                    sales = 32,
                },
                new ChartData {
                    month = "Jul",
                    sales = 35,
                },
                new ChartData {
                    month = "Aug",
                    sales = 55,
                },
                new ChartData {
                    month = "Sep",
                    sales = 38,
                },
                 new ChartData {
                    month = "Oct",
                    sales = 30,
                },
                new ChartData {
                    month = "Nov",
                    sales = 25,
                },
                new ChartData {
                    month = "Dec",
                    sales = 32,
                }
            };
            lineData = new List<LineData>
            {
                new LineData {
                    x = 2013,
                    y = 28,
                },
                new LineData {
                    x = 2014,
                    y = 25,
                },
                new LineData {
                    x = 2015,
                    y = 26,
                },
                new LineData {
                    x = 2016,
                    y = 27,
                },
                new LineData {
                    x = 2017,
                    y = 32,
                },
                new LineData {
                    x = 2018,
                    y = 35,
                }
            };
            pieData1 = new List<PieData>
            {
                new PieData {
                    x = "Chrome",
                    y = 37,
                    text = "37%",
                },
                new PieData {
                    x = "UC Browser",
                    y = 17,
                    text = "17%",
                },
                new PieData {
                    x = "iPhone",
                    y = 19,
                    text = "19%",
                },
                new PieData {
                    x = "Others",
                    y = 4,
                    text = "4%",
                },
                new PieData {
                    x = "Opera",
                    y = 11,
                    text = "11%",
                },
                new PieData {
                    x = "Android",
                    y = 12,
                    text = "12%",
                }
            };

        }

        public class spacingModel
        {
       
        }
        public class ChartData
        {
            public string month;
            public double sales;
        }
        public class LineData
        {
            public double x;
            public double y;
        }

        public class PieData
        {
            public string x;
            public double y;
            public string text;
        }
 
    }
}
