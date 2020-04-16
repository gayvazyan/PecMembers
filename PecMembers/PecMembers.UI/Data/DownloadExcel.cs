using Microsoft.JSInterop;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Data
{
    public class DownloadExcel
    {
        public void GenerateExcel(IJSRuntime iJSRuntime, byte[] fileContents)
        {
           //// byte[] fileContents;
           // ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

           // using (var package = new ExcelPackage())
           // {
           //     var workSheet = package.Workbook.Worksheets.Add("Sheet1");
           //     #region Header Row
           //     workSheet.Cells[1, 1].Value = "Student Name";
           //     workSheet.Cells[1, 1].Style.Font.Size = 12;
           //     workSheet.Cells[1, 1].Style.Font.Bold = true;
           //     workSheet.Cells[1, 1].Style.Border.Top.Style = ExcelBorderStyle.Hair;

           //     workSheet.Cells[1, 2].Value = "Student Roll";
           //     workSheet.Cells[1, 2].Style.Font.Size = 12;
           //     workSheet.Cells[1, 2].Style.Font.Bold = true;
           //     workSheet.Cells[1, 2].Style.Border.Top.Style = ExcelBorderStyle.Hair;
           //     #endregion

           //     #region Body 1st Row
           //     workSheet.Cells[2, 1].Value = "Shakib";
           //     workSheet.Cells[2, 1].Style.Font.Size = 12;
           //     workSheet.Cells[2, 1].Style.Font.Bold = true;
           //     workSheet.Cells[2, 1].Style.Border.Top.Style = ExcelBorderStyle.Hair;

           //     workSheet.Cells[2, 2].Value = "1001";
           //     workSheet.Cells[2, 2].Style.Font.Size = 12;
           //     workSheet.Cells[2, 2].Style.Font.Bold = true;
           //     workSheet.Cells[2, 2].Style.Border.Top.Style = ExcelBorderStyle.Hair;
           //     #endregion

           //     #region Body 2st Row
           //     workSheet.Cells[3, 1].Value = "Rohit";
           //     workSheet.Cells[3, 1].Style.Font.Size = 12;
           //     workSheet.Cells[3, 1].Style.Font.Bold = true;
           //     workSheet.Cells[3, 1].Style.Border.Top.Style = ExcelBorderStyle.Hair;

           //     workSheet.Cells[3, 2].Value = "1002";
           //     workSheet.Cells[3, 2].Style.Font.Size = 12;
           //     workSheet.Cells[3, 2].Style.Font.Bold = true;
           //     workSheet.Cells[3, 2].Style.Border.Top.Style = ExcelBorderStyle.Hair;
           //     #endregion

           //     fileContents = package.GetAsByteArray();
           // }
            iJSRuntime.InvokeAsync<DownloadExcel>(
                "saveAsFile",
                "Student List.xlsx",
                Convert.ToBase64String(fileContents)
                );
        }
    }
}
