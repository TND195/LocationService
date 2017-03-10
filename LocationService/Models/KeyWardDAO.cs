using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class KeyWardDAO :DataProvider
    {
        public int getWard(String keyword)
        {
            connect();
            string query = "SELECT * FROM TUKHOAPHUONG";
            adapter = new SqlDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList ls = ConvertDataSetToArrayList(dataset);
            foreach (Object o in ls)
            {
                KeyWard key = (KeyWard)o;
                keyword = FormatString.FormatSrt(keyword);
                String str = FormatString.FormatSrt(key.NameKeyWard);
                if (str == keyword)
                {
                    return key.IdWard;
                }
            }
            disconnect();
            return -1;
        }
        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            KeyWard tkp = new KeyWard();
            tkp.IdKeyWard = (int)dt.Rows[i]["MaTuKhoaPhuong"];
            tkp.NameKeyWard = dt.Rows[i]["TuKhoaPhuong"].ToString();
            tkp.IdWard = (int)dt.Rows[i]["MaPhuong"];
            return (object)tkp;
        }
    }

}