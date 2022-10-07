using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;

namespace NonVisualComponentLibriary
{
    public class DocumentWithDiagram
    {
        public void CreateCircleDiagrammExcel(string destinationFullPath, string sheetHeader, string diagramHeader, Dictionary<string, int> valRange, LegendPosition legendPosition) 
        { 
            if (destinationFullPath == null || sheetHeader == null || diagramHeader == null || valRange == null) throw new Exception("Null data");

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excelPackage = new();

            ExcelWorksheet sheet = excelPackage.Workbook.Worksheets.Add(sheetHeader);

            int i = 0;

            foreach (var kvp in valRange) 
            {
                sheet.Cells[1, i + 1].Value = kvp.Key;
                sheet.Cells[2, i + 1].Value = kvp.Value;
                i++;
            }
            ExcelPieChart pieChart = sheet.Drawings.AddChart(diagramHeader, eChartType.Pie3D) as ExcelPieChart;
            pieChart.Title.Text = diagramHeader;
            pieChart.Series.Add(ExcelRange.GetAddress(2, 1, 2, valRange.Count), ExcelRange.GetAddress(1, 1, 1, valRange.Count));

            switch (legendPosition) 
            {
                case LegendPosition.Left:
                    pieChart.Legend.Position = eLegendPosition.Left;
                    break;
                    case LegendPosition.Right:
                    pieChart.Legend.Position = eLegendPosition.Right;
                    break;
                case LegendPosition.Top:
                    pieChart.Legend.Position = eLegendPosition.Top;
                    break;
                case LegendPosition.Bottom:
                    pieChart.Legend.Position = eLegendPosition.Bottom;
                    break;
            }
            pieChart.Legend.Position = eLegendPosition.Right;
            pieChart.DataLabel.ShowPercent = true;
            pieChart.SetSize(500, 400);
            pieChart.SetPosition(4, 0, 2, 0);
            
            excelPackage.SaveAs(new FileInfo(destinationFullPath));
        }
    }
}
