using System;
using System.Collections;
using System.Collections.Generic;
using excel = Microsoft.Office.Interop.Excel;

namespace DemoProject.Library
{
   public class ReadTestData
    {
        excel.Application xlApp;
        excel.Workbook xlWorkbook;
        excel.Worksheet x1Worksheet;
        excel.Range xlRange;
        public ArrayList keyCount;
        public ReadTestData()
        {
            xlApp = new excel.Application();
       //     xlApp.Visible = false;
            xlApp.ScreenUpdating = false;
            xlWorkbook = xlApp.Workbooks.Open(@"C:\temp\TestData.xlsx");
            x1Worksheet = xlWorkbook.Sheets[1];
            xlRange = x1Worksheet.UsedRange;
            keyCount = new ArrayList();
            xlApp.Calculation = excel.XlCalculation.xlCalculationManual;

        }
        //get Total row count
        public int totalRowCount()
        {
            return  xlRange.Rows.Count;
        }

        //get Total Column Count
        public int totalColumnCount()
        {
            return xlRange.Columns.Count;
        }

      

        public Dictionary<string, string>  readExcelData()
        {
            //load excel
            //excel.Application xlApp = new excel.Application();
            //excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\temp\TestData.xlsx");
            //excel.Worksheet x1Worksheet = xlWorkbook.Sheets[1];
            //excel.Range xlRange = x1Worksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            var map = new Dictionary<string, string>();
            for (int i = 2; i <= rowCount; i++)
            {
                String executionStatus = xlRange.Cells[i, 4].Value2.ToString();
                Console.WriteLine("Execution status=" + xlRange.Cells[i, 4].Value2.ToString());
                String methodName = xlRange.Cells[i, 3].Value2.ToString();

                if (executionStatus.Equals("Y") && methodName.Equals("login"))
                {
                    for (int j = 2; j <= colCount; j++)
                {
                        //Console.WriteLine("Add values to Map");
                        //Console.WriteLine(xlRange.Cells[1, j].Value2.ToString() + "_" + i);
                        //Console.WriteLine(xlRange.Cells[i, j].Value2.ToString());
                     map.Add(xlRange.Cells[1, j].Value2.ToString()+"_"+i, xlRange.Cells[i, j].Value2.ToString());
                        if (!keyCount.Contains(i.ToString()))
                        {
                            keyCount.Add(i.ToString());
                        }
                    }

                }
            }
            Console.WriteLine(map.Count);
            Console.WriteLine(keyCount[0]);
            return map;
        }
                    

    }
}
