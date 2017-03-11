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
        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            DetailService chitiet_dulieu = new DetailService();
            chitiet_dulieu.IdPlace = (int)dt.Rows[i]["MaDuLieu"];
            chitiet_dulieu.IdDetailService = (int)dt.Rows[i]["MaChiTiet"];
            chitiet_dulieu.Name = dt.Rows[i]["Ten"].ToString();
            chitiet_dulieu.Price = dt.Rows[i]["GiaTien"].ToString();
            chitiet_dulieu.Note = dt.Rows[i]["ChuThich"].ToString();
            return (object)chitiet_dulieu;
        }

    }
}