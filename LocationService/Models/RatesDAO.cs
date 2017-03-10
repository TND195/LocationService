using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class RatesDAO : DataProvider
    {
        public float getRate(int id)
        {
            connect();
            string query = "SELECT * FROM DANHGIA WHERE MaDuLieu = " + id;
            adapter = new SqlDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList ls = ConvertDataSetToArrayList(dataset);
            List<Rates> arr = new List<Rates>();
            int dem = 0;
            float tong = 0;
            foreach (Object o in ls)
            {
                Rates dg = (Rates)o;
                tong = tong + dg.Scores;
                dem++;
            }
            disconnect();
            if (dem == 0)
                return 0;
            return (tong / dem);
        }
        public bool updateDanhGia(Rates dg)
        {
            try
            {
                connect();
                string updateCommand = "UPDATE DANHGIA SET DanhGia = " + dg.Scores +
                    " WHERE IdTaiKhoan = '" + dg.Id + "' AND MaDuLieu = " + dg.IdPlace;
                executeNonQuery(updateCommand);
                disconnect();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }

        public bool insertDanhGia(Rates dg)
        {
            try
            {
                connect();
                string insertCommand = "INSERT INTO DANHGIA  VALUES('"
                    + dg.Id + "', " + dg.IdPlace + ", " + dg.Scores + ")";
                executeNonQuery(insertCommand);
                disconnect();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            Rates dg = new Rates();
            dg.Id = dt.Rows[i]["IdTaiKhoan"].ToString();
            dg.IdPlace = dt.Rows[i].IsNull("MaDuLieu") ? 0 : (int)dt.Rows[i]["MaDuLieu"];
            dg.Scores = (dt.Rows[i].IsNull("DanhGia") == true) ? 0.0f : (float)(double)dt.Rows[i]["DanhGia"];

            return (object)dg;
        }
    }
}