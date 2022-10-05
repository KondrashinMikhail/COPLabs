using OfficeOpenXml;
using OfficeOpenXml.Drawing;

namespace NonVisualComponentLibriary
{
    public class DocumentWithContext
    {
        private readonly int Height = 200;
        private readonly int Width = 195;

        public void SaveImagesToExcel(string destinationFullPath, string sheetHeader, FileInfo[] images) 
        {
            if (destinationFullPath == null || sheetHeader == null || images == null) throw new Exception("Null data");

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage ExcelPkg = new ();
            ExcelWorksheet sheet = ExcelPkg.Workbook.Worksheets.Add(sheetHeader);

            int rowIndex = 1;
            int colIndex = 1;

            foreach (var image in images) 
            {
                ExcelPicture pic = sheet.Drawings.AddPicture(image.Name, image);
                pic.SetPosition(rowIndex, 0, colIndex, 0);
                pic.SetSize(Width, Height);
                rowIndex += 11;
            }

            ExcelPkg.SaveAs(new FileInfo(destinationFullPath));
        }
    }
}
