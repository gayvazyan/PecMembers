using Microsoft.JSInterop;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.Services
{
    public class DownloadExcel
    {
        public void GenerateExcel(IJSRuntime iJSRuntime, byte[] fileContents)
        {
            iJSRuntime.InvokeAsync<DownloadExcel>(
                "saveAsFile",
                "pecmember.xlsx",
                Convert.ToBase64String(fileContents)
                );
        }
    }
}
