using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialCostLib.DataService;
using MaterialCostLib.Models;
using Microsoft.Office.Interop.Excel;
using System.Globalization;

namespace MaterialCostLib.BusinessLayer 
{
    public class Main : DataService.MainBase
    {
        public List<MainDTO> SelectMainData()
        {
            try
            {
                var db = new Main();
                var dba = db.SelectDataFromMainCSV();
                foreach(var item in dba)
                {
                    item.Cost = (item.UnitCost * item.Qty).ToString("C", CultureInfo.CurrentCulture);
                }
                return dba;
            }
            catch(Exception ex)
            {
                return new List<MainDTO>();
            }
        }
        public List<MaterialDTO> SelectMaterialData()
        {
            try
            {
                var db = new MaterialCostLib.DataService.MaterialsDataBase();
                var dba = db.SelectDataFromMaterialCSV();
                return dba;
            }
            catch (Exception ex)
            {
                return new List<MaterialDTO>();
            }
        }
        public List<CategoryDTO> SelectCategorylData()
        {
            try
            {
                var db = new MaterialCostLib.DataService.CategoryDataBase();
                var dba = db.SelectDataFromCategoryCSV();
                return dba;
            }
            catch (Exception ex)
            {
                return new List<CategoryDTO>();
            }
        }
        public void InsertDataToMain(List<MainDTO> list)
        {
            try
            {
                var db = new MainBase();
                db.InsertDataToMain(list);
                
            }
            catch (Exception ex)
            {
                var messageBox = ex;
            }
        }
        public void InsertIntoMaterial(string item)
        {
            try
            {
                var db = new MaterialCostLib.DataService.MaterialsDataBase();
                db.InsertMaterialBase(item);
            }
            catch(Exception ex)
            {
                var messageBox = ex;
            }
        }
        public void InsertIntoCategory(string item)
        {
            try
            {
                var db = new MaterialCostLib.DataService.CategoryDataBase();
                db.InsertCategoryBase(item);
            }
            catch (Exception ex)
            {
                var messageBox = ex;
            }
        }
        public bool DeleteMaterial(string material)
        {
            try
            {
                var db = new MaterialsDataBase();
                db.DeleteMaterialBase(material);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
