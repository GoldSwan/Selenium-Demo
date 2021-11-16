using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

//https://docs.microsoft.com/ko-kr/dotnet/csharp/programming-guide/interop/walkthrough-office-programming
namespace WorkAutomation.Service
{
    class ExcelService : IAutomationService
    {
        MainForm mainForm { get; set; }
        public ExcelService(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }
        public void AutoService()
        {

        }
        void DisplayInExcel(string strExcelInputData)
        {
            var excelApplication = new Excel.Application();
            var workBook = excelApplication.Workbooks.Open(mainForm.txtExcelDirectory.Text);
        }        
    }
}
