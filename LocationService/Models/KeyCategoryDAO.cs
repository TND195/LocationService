using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class KeyCategoryDAO : DataProvider
    {
        public KeyWord getCategory(String keyword)
        {
            connect();
            string query = "SELECT * FROM TUKHOADICHVU";
            adapter = new SqlDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList ls = ConvertDataSetToArrayList(dataset);
            KeyWord kw = new KeyWord();
            foreach (Object o in ls)
            {
                KeyCategory key = (KeyCategory)o;
                keyword = FormatString.FormatSrt(keyword);
                String str = FormatString.FormatSrt(key.NameKeyCategory);
                int ps = keyword.IndexOf(str);
                if (keyword == str)
                {
                    kw.Id = key.IdCateggory;
                    kw.StrKeyFirst = "";
                    kw.StrKeyLast = "";
                    return kw;
                }
                if (ps == 0 && keyword.Length > str.Length)
                {
                    kw.Id = key.IdCateggory;
                    kw.StrKeyFirst = "";
                    kw.StrKeyLast = keyword.Substring(str.Length - ps);
                    return kw;
                }
                if(ps > 0 && ((ps + str.Length) <= keyword.Length))
                {
                    kw.Id = key.IdCateggory;
                    kw.StrKeyFirst = keyword.Substring(ps + str.Length);
                    kw.StrKeyLast = keyword.Substring(0, ps);
                    return kw;
                }
                if(ps > 0)
                {
                    kw.Id = key.IdCateggory;
                    kw.StrKeyFirst = "";
                    kw.StrKeyLast  = keyword.Substring(0, ps);
                    return kw;
                }
            }
            disconnect();
            return null;
        }
        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            KeyCategory tkdv = new KeyCategory();
            tkdv.IdKeyCategory = (int)dt.Rows[i]["MaTuKhoaDichVu"];
            tkdv.NameKeyCategory = dt.Rows[i]["TenTuKhoaDichVu"].ToString();
            tkdv.IdCateggory = (int)dt.Rows[i]["MaDichVu"];

            return (object)tkdv;
        }
        //public List<Place> getPlace(string str)
        //{
        //    int id = getCategory(str);
        //    string query = "SELECT * FROM TUKHOADUONG";
        //}

    }
}