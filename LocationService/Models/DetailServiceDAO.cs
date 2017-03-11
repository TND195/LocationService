using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class DetailServiceDAO :DataProvider
    {
        public List<DetailService> get_ChiTiet_DichVu(int ma_dulieu)
        {
            connect();
            string query = string.Format(" select a.MaDuLieu, a.MaChiTiet, b.Ten, b.GiaTien, b.ChuThich from CHITIET_DULIEU a join CHITIETDICHVU b on (a.MaChiTiet = b.MaChiTiet) where a.MaDuLieu = {0}", ma_dulieu);
            adapter = new SqlDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList ls = ConvertDataSetToArrayList(dataset);
            List<DetailService> list = new List<DetailService>();
            foreach (Object o in ls)
            {
                list.Add((DetailService)o);
            }
            return list;
        }
    }
}