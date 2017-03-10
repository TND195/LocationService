using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class KeyCityDAO :DataProvider
    {
        public int getCity(String keyword)
        {
            connect();
            string query = "SELECT * FROM TUKHOATINHTHANH";
            adapter = new SqlDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList ls = ConvertDataSetToArrayList(dataset);
   
            foreach (Object o in ls)
            {
                KeyCity key = (KeyCity)o;
                keyword = FormatString.FormatSrt(keyword);
                String str = FormatString.FormatSrt(key.NameKeyCity);
                if (str == keyword)
                {
                    return key.IdCity;
                }
            }
            disconnect();
            return -1;
        }
    }
}