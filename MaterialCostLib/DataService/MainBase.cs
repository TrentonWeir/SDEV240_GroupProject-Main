using MaterialCostLib.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace MaterialCostLib.DataService
{
    public class MainBase
    {
        private string MainDataBase = "../../../DataSource/MainDataBase.csv";
        public List<MainDTO> SelectDataFromMainCSV()
        {
            try
            {
                var list = new List<MainDTO>();
                var lines = File.ReadAllLines(MainDataBase);
                foreach (var line in lines)
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
            catch (Exception ex)
            {
                File.AppendAllText("../../../DataSource/ERRORLIST.csv", ex.Message);
                return new List<MainDTO>();
            }

        }
        public List<SavedEstimatesDTO> SelectEstimatesBase()
        {
            try
            {
                var list = new List<SavedEstimatesDTO>();
                var lines = File.ReadAllLines(MainDataBase);
                foreach (var line in lines)
                {
                    var newline = line.Split(',');
                    list.Add(new SavedEstimatesDTO
                    {
                        EstimateId = Convert.ToInt32(newline[0]),
                        Description = Convert.ToString(newline[1]),
                        Total = Convert.ToDouble(newline[2]),
                        Date = Convert.ToDateTime(newline[3]),
                    });
                }
                return list;
            }
            catch (Exception ex)
            {
                File.AppendAllText("../../../DataSource/ERRORLIST.csv", ex.Message);
                return new List<SavedEstimatesDTO>();
            }

        }
        public void InsertDataToMain(List<MainDTO> list)
        {
            try
            {
                var theData = File.ReadAllLines(MainDataBase);
                var count = theData.Count() + 1;
                var c = "|";
                var csv = new StringBuilder();
                foreach (var item in list)
                {
                    csv.AppendLine(Convert.ToString(count) + c + Convert.ToString(item.Category) + c + Convert.ToString(item.Item) + c + Convert.ToString(item.Material) + c + Convert.ToString(item.Description) + c
                        + Convert.ToString(item.Qty) + c + Convert.ToString(item.UnitCost) + c + Convert.ToString(item.Cost));
                    count++;
                }
                File.AppendAllText(MainDataBase, csv.ToString());

            }
            catch
            {
                var count = 1;
                var c = "|";
                var csv = new StringBuilder();
                foreach (var item in list)
                {
                    csv.AppendLine(Convert.ToString(count) + c + Convert.ToString(item.Category) + c + Convert.ToString(item.Item) + c + Convert.ToString(item.Material) + c + Convert.ToString(item.Description) + c
                        + Convert.ToString(item.Qty) + c + Convert.ToString(item.UnitCost) + c + Convert.ToString(item.Cost));
                    count++;
                }
                File.AppendAllText(MainDataBase, csv.ToString());

            }
        }

        internal void InsertEstimateDataToMainBase(List<MainDTO> list)
        {
            try
            {
                var theData = File.ReadAllLines(MainDataBase);
                var count = theData.Count() + 1;
                var c = "|";
                var csv = new StringBuilder();
                double total = 0.00;
                string str = string.Empty;
                foreach (var item in list)
                {

                    str += "~" + Convert.ToString(item.Id) + c + Convert.ToString(item.Category) + c + Convert.ToString(item.Item) + c + Convert.ToString(item.Material) + c + Convert.ToString(item.Description) + c
                        + Convert.ToString(item.Qty) + c + Convert.ToString(item.UnitCost) + c + Convert.ToString(item.Cost);
                    total += Convert.ToDouble(item.Cost.Trim('$'));
                }
                csv.AppendLine($"{count},{str},{total},{DateTime.Now}");
                File.AppendAllText(MainDataBase, csv.ToString());
            }
            catch
            {
                var count = 1;
                var c = "|";
                var csv = new StringBuilder();
                double total = 0.00;
                string str = string.Empty;
                foreach (var item in list)
                {
                    if (item != list.First())
                    {
                        str += "~";
                    }
                    str += Convert.ToString(item.Id) + c + Convert.ToString(item.Category) + c + Convert.ToString(item.Item) + c + Convert.ToString(item.Material) + c + Convert.ToString(item.Description) + c
                        + Convert.ToString(item.Qty) + c + Convert.ToString(item.UnitCost) + c + Convert.ToString(item.Cost) + "|";
                    total += Convert.ToDouble(item.Cost.Trim('$'));

                }
                csv.AppendLine($"{count},{str},{total},{DateTime.Now}");
                File.AppendAllText(MainDataBase, csv.ToString());
            }

        }
        internal void InsertEstimateDataToMainBase(List<MainDTO> list, int id)
        {
            try
            {
                var data = File.ReadAllLines(MainDataBase);
                File.Delete(MainDataBase);
                var c = "|";
                var csv = new StringBuilder();
                double total = 0.00;
                string str = string.Empty;
                int i = 0;
                foreach (var item in list)
                {
                    if (i < 1)
                    {
                        str += Convert.ToString(item.Id) + c + Convert.ToString(item.Category) + c + Convert.ToString(item.Item) + c + Convert.ToString(item.Material) + c + Convert.ToString(item.Description) + c
                        + Convert.ToString(item.Qty) + c + Convert.ToString(item.UnitCost) + c + Convert.ToString(item.Cost);
                        total += Convert.ToDouble(item.Cost.Trim('$'));
                    }
                    else
                    {
                        str += "~" + Convert.ToString(item.Id) + c + Convert.ToString(item.Category) + c + Convert.ToString(item.Item) + c + Convert.ToString(item.Material) + c + Convert.ToString(item.Description) + c
                        + Convert.ToString(item.Qty) + c + Convert.ToString(item.UnitCost) + c + Convert.ToString(item.Cost);
                        total += Convert.ToDouble(item.Cost.Trim('$'));
                    }
                    i++;
                }
                data[(id - 1)] = ($"{id},{str},{total},{DateTime.Now}");
                foreach (var item in data)
                {
                    csv.AppendLine(item);
                }
                File.AppendAllText(MainDataBase, csv.ToString());
            }
            catch (Exception ex)
            {
                File.AppendAllText("../../../DataSource/ERRORLIST.csv", ex.Message);
            }

        }

        public void DeleteGridSelectionBase(List<MainDTO> list)
        {
            try
            {
                File.Delete(MainDataBase);
                InsertDataToMain(list);
            }
            catch (Exception ex)
            {
                File.AppendAllText("../../../DataSource/ERRORLIST.csv", ex.Message);
            }
        }
    }
}
