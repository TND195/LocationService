using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class CategoryDAO :DataProvider
    {
        public List<Category> getDsDichVu()
        {
            connect();
            string query = "SELECT * FROM DICHVU";
            adapter = new SqlDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList ls = ConvertDataSetToArrayList(dataset);
            List<Category> arr = new List<Category>();
            foreach (Object o in ls)
            {
                arr.Add((Category)o);
            }

            return arr;
        }


        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            Category dv = new Category();
            dv.Id = (int)dt.Rows[i]["MaDichVu"];
            dv.Name = dt.Rows[i]["TenDichVu"].ToString();
            dv.Image = dt.Rows[i]["Hinh"].ToString();

            return (object)dv;
        }
    }
}