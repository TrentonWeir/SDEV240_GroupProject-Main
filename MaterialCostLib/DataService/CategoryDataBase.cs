﻿using MaterialCostLib.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MaterialCostLib.DataService
{
    public class CategoryDataBase
    {
        private string _CategoryDataBase = "../../../DataSource/CategoryDataBase.csv";
        public void InsertCategoryBase(string item)
        {
            try
            {
                var theData = File.ReadAllLines(_CategoryDataBase);
                var count = theData.Count();
                var c = ",";
                var csv = new StringBuilder();
                csv.AppendLine(Convert.ToString(count) + c + item);
                File.AppendAllText(_CategoryDataBase, csv.ToString());

            }
            catch
            {
                var count = 1;
                var c = ",";
                var csv = new StringBuilder();
                csv.AppendLine(Convert.ToString(count) + c + item);
                File.AppendAllText(_CategoryDataBase, csv.ToString());
            }
        }
        public List<CategoryDTO> SelectDataFromCategoryCSV()
        {
            try
            {
                var list = new List<CategoryDTO>();
                var lines = File.ReadAllLines(_CategoryDataBase);
                foreach (var line in lines)
                {
                    var newline = line.Split(',');
                    list.Add(new CategoryDTO
                    {
                        Id = Convert.ToInt32(newline[0]),
                        Category = Convert.ToString(newline[1])
                    });
                }
                return list;
            }
            catch (Exception ex)
            {
                File.AppendAllText("../../../DataSource/ERRORLIST.csv", ex.Message);
                return new List<CategoryDTO>();
            }

        }
        public void InsertCategoryBase(List<CategoryDTO> list)
        {

            foreach (var item in list)
            {
                try
                {
                    var theData = File.ReadAllLines(_CategoryDataBase);
                    var count = theData.Count();
                    var c = ",";
                    var csv = new StringBuilder();
                    csv.AppendLine(Convert.ToString(count) + c + item.Category);
                    File.AppendAllText(_CategoryDataBase, csv.ToString());
                }
                catch
                {
                    var count = 1;
                    var c = ",";
                    var csv = new StringBuilder();
                    csv.AppendLine(Convert.ToString(count) + c + item.Category);
                    File.AppendAllText(_CategoryDataBase, csv.ToString());
                }

            }
        }
        public bool DeleteCategoryBase(string category)
        {
            try
            {
                var list = SelectDataFromCategoryCSV();
                list.RemoveAll(x => x.Category == category);
                File.Delete(_CategoryDataBase);
                InsertCategoryBase(list);
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
