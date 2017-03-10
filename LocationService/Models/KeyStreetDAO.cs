using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class KeyStreetDAO : DataProvider
    {
        public int getStreet(String keyword)
        {
            connect();
            string query = "SELECT * FROM TUKHOADUONG";
            adapter = new SqlDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList ls = ConvertDataSetToArrayList(dataset);

            foreach (Object o in ls)
            {
                KeyStreet key = (KeyStreet)o;
                keyword = FormatString.FormatSrt(keyword);
                String str = FormatString.FormatSrt(key.NameStreet);
                if(str == keyword)
                {
                    return key.IdStreet;
                }
            }
            disconnect();
            return -1;
        }

    }
}