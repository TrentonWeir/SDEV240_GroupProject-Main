using MaterialCostLib.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MaterialCostLib.BusinessLayer
{
    public class CommonCommands
    {
        public string ExportMainDTO_List_AsCSV(List<MainDTO> list)
        {
            try
            {

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "CSV File|*.csv";
                save.Title = "Save CSV File";
                save.ShowDialog();
                double total = 0;
                if (!string.IsNullOrWhiteSpace(save.FileName))
                {
                    var csv = new StringBuilder();
                    csv.AppendLine($"Id,Category,Item,Material,Description,Qty,UnitCost,Cost");
                    foreach (var item in list)
                    {
                        string csvBuilder = $"{item.Id},{item.Category},{item.Item},{item.Material},{item.Description},{item.Qty},{item.UnitCost},{item.Cost}";
                        csv.AppendLine(csvBuilder);
                        total += Convert.ToDouble(item.Cost);
                    }
                    csv.AppendLine($",,,,,,Total cost is:, {total}");
                    File.AppendAllText(save.FileName, csv.ToString());

                }
                return $"{save.FileName} was successfully saved!";
            }
            catch (Exception ex)
            {
                return $"{ex.Message}";
            }
        }
        public string ExportMainDTO_List_AsText(List<MainDTO> list)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "TEXT FIle |*.txt";
                save.Title = "Save .txt File";
                save.ShowDialog();
                double total = 0;
                if (!string.IsNullOrWhiteSpace(save.FileName))
                {
                    var txt = new StringBuilder();
                    txt.AppendLine($"Id Category Item Material Description Qty UnitCost Cost");
                    foreach (var item in list)
                    {
                        string csvBuilder = $"{item.Id} {item.Category} {item.Item} {item.Material} {item.Description} {item.Qty} {item.UnitCost} {item.Cost}";
                        txt.AppendLine(csvBuilder);
                        total += Convert.ToDouble(item.Cost);
                    }
                    txt.AppendLine($"Total cost is: {total}");
                    File.AppendAllText(save.FileName, txt.ToString());
                }
                return $"{save.FileName} was successfully saved!";
            }
            catch (Exception ex)
            {
                return $"{ex.Message}";
            }
        }
    }
}
