using MaterialCostLib.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MaterialCostLib.DataService
{
    public class MaterialsDataBase
    {
        private string MaterialDataBase = "../../../DataSource/MaterialDataBase.csv";
        public void InsertMaterialBase(string item)
        {
            try
            {
                var theData = File.ReadAllLines(MaterialDataBase);
                var count = theData.Count();
                var c = ",";
                var csv = new StringBuilder();
                csv.AppendLine(Convert.ToString(count) + c + item);
                File.AppendAllText(MaterialDataBase, csv.ToString());

            }
            catch
            {
                var count = 1;
                var c = ",";
                var csv = new StringBuilder();
                csv.AppendLine(Convert.ToString(count) + c + item);
                File.AppendAllText(MaterialDataBase, csv.ToString());
            }
        }
        public void InsertMaterialBase(List<MaterialDTO> list)
        {

            foreach (var item in list)
            {
                try
                {
                    var theData = File.ReadAllLines(MaterialDataBase);
                    var count = theData.Count();
                    var c = ",";
                    var csv = new StringBuilder();
                    csv.AppendLine(Convert.ToString(count) + c + item.Material);
                    File.AppendAllText(MaterialDataBase, csv.ToString());
                }
                catch
                {
                    var count = 1;
                    var c = ",";
                    var csv = new StringBuilder();
                    csv.AppendLine(Convert.ToString(count) + c + item.Material);
                    File.AppendAllText(MaterialDataBase, csv.ToString());
                }

            }
        }
        public List<MaterialDTO> SelectDataFromMaterialCSV()
        {
            try
            {
                var list = new List<MaterialDTO>();
                var lines = File.ReadAllLines(MaterialDataBase);
                foreach (var line in lines)
                {
                    var newline = line.Split(',');
                    list.Add(new MaterialDTO
                    {
                        Id = Convert.ToInt32(newline[0]),
                        Material = Convert.ToString(newline[1])
                    });
                }
                return list;
            }
            catch (Exception ex)
            {
                File.AppendAllText("../../../DataSource/ERRORLIST.csv", ex.Message);
                return new List<MaterialDTO>();
            }

        }
        public bool DeleteMaterialBase(string material)
        {
            try
            {
                var list = SelectDataFromMaterialCSV();
                list.RemoveAll(x => x.Material == material);
                File.Delete(MaterialDataBase);
                InsertMaterialBase(list);
                return true;
            }
            catch (Exception ex)
            {
                File.AppendAllText("../../../DataSource/ERRORLIST.csv", ex.Message);
                return false;
            }
        }

    }
}
