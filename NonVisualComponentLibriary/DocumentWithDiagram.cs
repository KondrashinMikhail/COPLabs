using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;

namespace NonVisualComponentLibriary
{
    public class DocumentWithDiagram
    {
        public void CreateCircleDiagrammExcel(string destinationFullPath, string sheetHeader, string diagramHeader, List<string> values, List<int> range) 
        {
            if (destinationFullPath == null || sheetHeader == null || diagramHeader == null || values == null || range == null) throw new Exception("Null data");

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excelPackage = new();

            ExcelWorksheet sheet = excelPackage.Workbook.Worksheets.Add(sheetHeader);

                for (int i = 0; i < values.Count; i++)
                {
                    sheet.Cells[1, i + 1].Value = values[i];
                    sheet.Cells[2, i + 1].Value = range[i];
                }

                ExcelPieChart pieChart = sheet.Drawings.AddChart(diagramHeader, eChartType.Pie3D) as ExcelPieChart;
                pieChart.Title.Text = diagramHeader;
                pieChart.Series.Add(ExcelRange.GetAddress(2, 1, 2, values.Count), ExcelRange.GetAddress(1, 1, 1, range.Count));
                pieChart.Legend.Position = eLegendPosition.Right;
                pieChart.DataLabel.ShowPercent = true;
                pieChart.SetSize(500, 400);
                pieChart.SetPosition(4, 0, 2, 0);
            
            excelPackage.SaveAs(new FileInfo(destinationFullPath));
        }
    }
}
