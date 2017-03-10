using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class KeyPlaceDAO : DataProvider
    {
        public List<int> getPlace(String keyword)
        {
            connect();
            string query = "SELECT * FROM TUKHOADIADIEM";
            adapter = new SqlDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList ls = ConvertDataSetToArrayList(dataset);
            List<int> arr = new List<int>();
            
            foreach (Object o in ls)
            {
                KeyPlace key = (KeyPlace)o;
                keyword = FormatString.FormatSrt(keyword);
                String str = FormatString.FormatSrt(key.NameKeyPlace);
                ApproximatString approximat = new ApproximatString(keyword);
                if(approximat.SoSanh(str))
                {
                    arr.Add(key.IdPlace);
                }
            }
            disconnect();
            return arr;
        }
        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            KeyPlace tk = new KeyPlace();
            tk.IdKeyPlace = dt.Rows[i].IsNull("MaTuKhoaTenDiaDiem") == true ? 0 : (int)dt.Rows[i]["MaTuKhoaTenDiaDiem"];
            tk.NameKeyPlace = dt.Rows[i]["TuKhoaTenDiaDiem"].ToString();
            tk.IdPlace = dt.Rows[i].IsNull("MaTenDiaDiem") == true ? 0 : (int)dt.Rows[i]["MaTenDiaDiem"];

            return (object)tk;
        }
    }
}