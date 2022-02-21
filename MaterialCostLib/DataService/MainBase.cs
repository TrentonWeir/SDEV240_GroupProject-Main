using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialCostLib.Models;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Office.Interop.Excel;
using ExcelDataReader;


namespace MaterialCostLib.DataService 
{
    public class MainBase
    {
        private string MainDataBase = "../../../DataSource/MainDataBase.csv";
        List<string> source = System.IO.Directory.GetFiles("../../../DataSource/").ToList();
        public List<MainDTO> SelectDataFromMainCSV()
        {
            try
            {
                var list = new List<MainDTO>();
                var lines = File.ReadAllLines(MainDataBase);
                foreach(var line in lines)
                {
                    var newline = line.Split(',');
                    list.Add(new MainDTO
                    {
                        Id = Convert.ToInt32(newline[0]),
                        Category = Convert.ToString(newline[1]),
                        Item = Convert.ToString(newline[2]),
                        Material = Convert.ToString(newline[3]),
                        Description = Convert.ToString(newline[4]),
                        Qty = float.Parse(newline[5]),
                        UnitCost = float.Parse(newline[6]),
                        Cost = Convert.ToString(newline[7])
                    });
                }
                return list;
            }
            catch(Exception ex)
            {
                File.AppendAllText("../../../DataSource/ERRORLIST.csv", ex.ToString());
                return new List<MainDTO>();
            }

        }
        public void InsertDataToMain(List<MainDTO> list)
        {
            try
            {
                var theData = File.ReadAllLines(MainDataBase);
                var count = theData.Count();
                var c = ",";
                var csv = new StringBuilder();
                foreach (var item in list)
                {
                    csv.AppendLine(Convert.ToString(count)+ c+Convert.ToString(item.Category) + c + Convert.ToString(item.Item) + c + Convert.ToString(item.Material) + c + Convert.ToString(item.Description) + c
                        + Convert.ToString(item.Qty) + c + Convert.ToString(item.UnitCost) + c + Convert.ToString(item.Cost));
                    File.AppendAllText("../../../DataSource/MainDataBase.csv", csv.ToString());
                }
            }
            catch
            {
                var count = 1;
                var c = ",";
                var csv = new StringBuilder();
                foreach (var item in list)
                {
                    csv.AppendLine(Convert.ToString(count) + c + Convert.ToString(item.Category) + c + Convert.ToString(item.Item) + c + Convert.ToString(item.Material) + c + Convert.ToString(item.Description) + c
                        + Convert.ToString(item.Qty) + c + Convert.ToString(item.UnitCost) + c + Convert.ToString(item.Cost));
                    File.WriteAllText("../../../DataSource/MainDataBase.csv", Convert.ToString(csv));
                }
            }
        }

        public void DeleteGridSelectionBase(List<MainDTO> list)
        {
            try
            {
                File.Delete(MainDataBase);
                InsertDataToMain(list);
            }
            catch(Exception ex)
            {
                File.AppendAllText("../../../DataSource/ERRORLIST.csv", ex.ToString());
            }
        }
    }
}
