using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    public class ExcelReader
    {
    
        public void Read(int nums)
        {
            string path = "lab2.xls";
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                IWorkbook workbook = new XSSFWorkbook(fs);
                ISheet sheet = workbook.GetSheet("Животные");

            }

        }
        public void Add()
        {

        }
    }


}

