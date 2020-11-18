using DTO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
  public  class ExtractExcelData
    {
        public static void SaveStudents(string filePath)
        {
            XSSFWorkbook hssfwb;
            using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                hssfwb = new XSSFWorkbook(file);
            }

            ISheet sheet = hssfwb.GetSheetAt(0);
            for (int row = 1; row <= sheet.LastRowNum; row++)
            {
                if (sheet.GetRow(row) != null) //null is when the row only contains empty cells 
                {
                    // string.Format("Row {0} = {1}", row, sheet.GetRow(row).GetCell(0).StringCellValue);
                    UserDTO user = new UserDTO();
                    user.FirstName = sheet.GetRow(row).GetCell(0).StringCellValue;
                    user.LastName= sheet.GetRow(row).GetCell(1).StringCellValue;
                    user.ID= sheet.GetRow(row).GetCell(2).NumericCellValue.ToString();
                    user.Email= sheet.GetRow(row).GetCell(3).StringCellValue;
                    user.LayerNumber= (int)sheet.GetRow(row).GetCell(4).NumericCellValue;
                    UserBL.RegisterStudent(user);
                }
            }
        }
    }
}
