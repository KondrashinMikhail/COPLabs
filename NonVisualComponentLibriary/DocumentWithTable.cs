using OfficeOpenXml;

namespace NonVisualComponentLibriary
{
    public class DocumentWithTable
    {
        public void CreateTableExcel<T>(string destinationFullPath, List<T> objects, Dictionary<string, List<string>> mergingCells, Dictionary<int, int> rowHeight, string header, List<string> tableHead)
        {
            if (objects == null || mergingCells == null) throw new Exception("Null data");

            foreach (var obj in objects) 
                foreach (var item in tableHead) 
                    if (obj.GetType().GetProperty(item).GetValue(obj) == null) throw new Exception("Not all fields are filled");

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage ExcelPkg = new();
            ExcelWorksheet sheet = ExcelPkg.Workbook.Worksheets.Add(header);

            sheet.Cells[1, 1].Value = header;

            int row = 2;
            int column = 1;
            List<string> nonVerifiable = new();

            foreach (var item in rowHeight)
                sheet.Cells[item.Key, 1].EntireRow.Height = item.Value;

            sheet.Cells[row, column, tableHead.Count + 2, objects.Count + 2].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
            sheet.Cells[row, column, tableHead.Count + 2, objects.Count + 2].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
            sheet.Cells[row, column, tableHead.Count + 2, objects.Count + 2].Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
            sheet.Cells[row, column, tableHead.Count + 2, objects.Count + 2].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

            sheet.Cells[row, column, tableHead.Count + 2, objects.Count + 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
            sheet.Cells[row, column, tableHead.Count + 2, objects.Count + 2].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;

            foreach (var field in objects.First().GetType().GetProperties())
                if (tableHead.Contains(field.Name.ToString()))
                {
                    var draining = isMerging(mergingCells, field.Name.ToString());
                    if (draining == null)
                    {
                        if (!nonVerifiable.Contains(field.Name.ToString()))
                        {
                            sheet.Cells[row, column].Value = field.Name.ToString();

                            column += 2;
                            foreach (var obj in objects)
                            {
                                sheet.Cells[row, column].Value = obj.GetType().GetProperty(field.Name.ToString()).GetValue(obj);
                                column++;
                            }
                            column = 1;
                            sheet.Cells[row, column, row, column + 1].Merge = true;
                            row++;
                        }
                    }
                    else
                        if (!nonVerifiable.Contains(field.Name.ToString()))
                        {
                            sheet.Cells[row, column].Value = draining.Value.Key.ToString();
                            sheet.Cells[row, column, row + draining.Value.Value.Count - 1, column].Merge = true;

                            foreach (var value in draining.Value.Value)
                            {
                                sheet.Cells[row, column + 1].Value = value.ToString();
                                column += 2;
                                foreach (var obj in objects)
                                {
                                    sheet.Cells[row, column].Value = obj.GetType().GetProperty(value.ToString()).GetValue(obj);
                                    column++;
                                }
                                column = 1;
                                row++;
                                nonVerifiable.Add(value.ToString());
                            }
                        }
                }
            sheet.Cells[row, column, tableHead.Count + 2, objects.Count + 2].EntireColumn.AutoFit();
            ExcelPkg.SaveAs(new FileInfo(destinationFullPath));

        }

        private KeyValuePair<string, List<string>>? isMerging(Dictionary<string, List<string>> mergingCells, string field) 
        {
            foreach (var item in mergingCells)
                if (item.Value.Contains(field))
                    return item;
            return null;
        }
    }
}
