using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class KeyDistrictDAO :DataProvider
    {
        public int getDistrict(String keyword)
        {
            connect();
            string query = "SELECT * FROM TUKHOAQUANHUYEN";
            adapter = new SqlDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList ls = ConvertDataSetToArrayList(dataset);
         
            foreach (Object o in ls)
            {
                KeyDistrict key = (KeyDistrict)o;
                keyword = FormatString.FormatSrt(keyword);
                String str = FormatString.FormatSrt(key.NameKeyDistrict);
                if (keyword == str)
                {
                    return key.IdDistrict;
                       
                }
            }
            disconnect();
            return -1;
        }
        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            KeyDistrict tk = new KeyDistrict();
            tk.IdKeyDistrict = dt.Rows[i].IsNull("MaTuKhoaQuanHuyen") == true ? 0 : (int)dt.Rows[i]["MaTuKhoaQuanHuyen"];
            tk.NameKeyDistrict = dt.Rows[i]["TuKhoaQuanHuyen"].ToString();
            tk.IdDistrict = dt.Rows[i].IsNull("MaQuanHuyen") == true ? 0 : (int)dt.Rows[i]["MaQuanHuyen"];

            return (object)tk;
        }

    }
}