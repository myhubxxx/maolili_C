using DBCon1.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DBCon1.test_dao
{
    class ExcelTest
    {

        public void test() {
            //importLib();
            //construct();
            importData();
        }
        public void importData() {

            new ImportExcel().importData("西瓜部门", "tempTable", "testIP.xlsx");
        
        
        }
        public void construct() {
            new ImportExcel().exportExcel("西瓜部门", "totaltable", "Template.xlsx");


        }
        public void importLib() {
            DataSet ds = new DataSet("new_dataset");
            DataTable dt = new DataTable("data_table");

            ds.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
            dt.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;

            dt = new TableDao().findAllDataTable("西瓜部门", "totaltable");

            ds.Tables.Add(dt);
            


            ExcelLibrary.DataSetHelper.CreateWorkbook("MyExcelFile.xls", ds);
        
        }




    }
}
