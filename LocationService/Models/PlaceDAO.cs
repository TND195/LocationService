using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class PlaceDAO : DataProvider
    {
     
        private List<Place> getDsDiaDiem(int id,String str)
        {
            connect();
            string query = "SELECT DULIEU.MaDuLieu, DULIEU.SoNha, DULIEU.KinhDo,DULIEU.ViDo,DULIEU.ChuThich,DULIEU.DanhGia,DICHVU.TenDichVu,DICHVU.Hinh,DUONG.TenDuong,PHUONG.TenPhuong,QUANHUYEN.TenQuanHuyen,TINHTHANH.TenTinhThanh,TENDIADIEM.TenDiaDiem  FROM TENDIADIEM JOIN DULIEU ON TENDIADIEM.MaTenDiaDiem = DULIEU.MaTenDiaDiem JOIN DICHVU ON DICHVU.MaDichVu = DULIEU.MaDichVu JOIN DUONG ON DUONG.MaDuong = DULIEU.MaDuong JOIN PHUONG ON PHUONG.MaPhuong = DULIEU.MaPhuong JOIN QUANHUYEN ON QUANHUYEN.MaQuanHuyen = DULIEU.MaQuanHuyen JOIN TINHTHANH ON TINHTHANH.MaTinhThanh = DULIEU.MaTinhThanh " + "WHERE " + str + "=" + id;
            adapter = new SqlDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList ls = ConvertDataSetToArrayList(dataset);
            List<Place> arr = new List<Place>();
            foreach (Object o in ls)
            {
                arr.Add((Place)o);
            }
            disconnect();
            return arr;
        }
        public Place getPlace(int id)
        {
            List <Place> list = getDsDiaDiem(id, "DULIEU.MaDuLieu");
            for(int i=0;i< list.Count;i++)
            {
                if(list[i].IdPlace == id)
                {
                    return list[i];
                }
            }
            return null;
        }
        private List<Place> getDsDiaDiem(int idCategory, int id,String str)
        {
            connect();
            string query = "SELECT DULIEU.MaDuLieu, DULIEU.SoNha, DULIEU.KinhDo,DULIEU.ViDo,DULIEU.ChuThich,DULIEU.DanhGia,DICHVU.TenDichVu,DICHVU.Hinh,DUONG.TenDuong,PHUONG.TenPhuong,QUANHUYEN.TenQuanHuyen,TINHTHANH.TenTinhThanh,TENDIADIEM.TenDiaDiem  FROM TENDIADIEM JOIN DULIEU ON TENDIADIEM.MaTenDiaDiem = DULIEU.MaTenDiaDiem JOIN DICHVU ON DICHVU.MaDichVu = DULIEU.MaDichVu JOIN DUONG ON DUONG.MaDuong = DULIEU.MaDuong JOIN PHUONG ON PHUONG.MaPhuong = DULIEU.MaPhuong JOIN QUANHUYEN ON QUANHUYEN.MaQuanHuyen = DULIEU.MaQuanHuyen JOIN TINHTHANH ON TINHTHANH.MaTinhThanh = DULIEU.MaTinhThanh " + "WHERE DICHVU.MaDichVu =" + idCategory + " AND " + str + "=" + id;
            adapter = new SqlDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList ls = ConvertDataSetToArrayList(dataset);
            List<Place> arr = new List<Place>();
            foreach (Object o in ls)
            {
                arr.Add((Place)o);
            }
            disconnect();
            return arr;
        }
        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            Place dd = new Place();
            dd.IdPlace = dt.Rows[i].IsNull("MaDuLieu") == true ? 0 : (int)dt.Rows[i]["MaDuLieu"];
            dd.Category = dt.Rows[i]["TenDichVu"].ToString();
            dd.Imagecategory = dt.Rows[i]["Hinh"].ToString();
            dd.Street = dt.Rows[i]["TenDuong"].ToString();
            dd.Ward = dt.Rows[i]["TenPhuong"].ToString();
            dd.NamePlace = dt.Rows[i]["TenDiaDiem"].ToString();
            dd.District = dt.Rows[i]["TenQuanHuyen"].ToString();
            dd.City = dt.Rows[i]["TenTinhThanh"].ToString();
            dd.Number = dt.Rows[i]["SoNha"].ToString();
            dd.Longitude = dt.Rows[i].IsNull("KinhDo") == true ? 0.0d : (double)dt.Rows[i]["KinhDo"];
            dd.Latitude = dt.Rows[i].IsNull("ViDo") == true ? 0.0d : (double)dt.Rows[i]["ViDo"];
            dd.Note = dt.Rows[i]["ChuThich"].ToString();
            RatesDAO dgO = new RatesDAO();
            dd.Scores = dgO.getRate(dd.IdPlace);
            return (object)dd;
        }
        public List<Place> Search2(String str)
        {
           
            connect();
            string query = "SELECT DULIEU.MaDuLieu, DULIEU.SoNha, DULIEU.KinhDo,DULIEU.ViDo,DULIEU.ChuThich,DULIEU.DanhGia,DICHVU.TenDichVu,DICHVU.Hinh,DUONG.TenDuong,PHUONG.TenPhuong,QUANHUYEN.TenQuanHuyen,TINHTHANH.TenTinhThanh,TENDIADIEM.TenDiaDiem  FROM TENDIADIEM JOIN DULIEU ON TENDIADIEM.MaTenDiaDiem = DULIEU.MaTenDiaDiem JOIN DICHVU ON DICHVU.MaDichVu = DULIEU.MaDichVu JOIN DUONG ON DUONG.MaDuong = DULIEU.MaDuong JOIN PHUONG ON PHUONG.MaPhuong = DULIEU.MaPhuong JOIN QUANHUYEN ON QUANHUYEN.MaQuanHuyen = DULIEU.MaQuanHuyen JOIN TINHTHANH ON TINHTHANH.MaTinhThanh = DULIEU.MaTinhThanh " + "WHERE TENDIADIEM.TenDiaDiem  LIKE " + "'%" + str + "%'";
            adapter = new SqlDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList ls = ConvertDataSetToArrayList(dataset);
            List<Place> arr = new List<Place>();
            foreach (Object o in ls)
            {
                arr.Add((Place)o);
            }
            disconnect();
            return arr;
        }
        public List<Place> Search(String str)
        {
            List<Place> listPlace = new List<Place>();
            KeyCategoryDAO keyCategoryDAO = new KeyCategoryDAO();
            KeyWord kw = keyCategoryDAO.getCategory(str);
            if(kw != null)

            {
                if(kw.StrKeyFirst == "" && kw.StrKeyLast == "")
                {
                    listPlace = getDsDiaDiem(kw.Id, "DICHVU.MaDichVu");
                    return listPlace;
                }
                else
                {
                    KeyDistrictDAO keyDistrictDAO = new KeyDistrictDAO();
                    if(kw.StrKeyFirst == "")
                    {
                        int t = keyDistrictDAO.getDistrict(kw.StrKeyLast);
                        if(t != -1)
                        {
                            listPlace = getDsDiaDiem(kw.Id, t, "QUANHUYEN.MaQuanHuyen");
                            return listPlace;
                        }
                    }
                    if(kw.StrKeyLast == "" )
                    {
                        int t = keyDistrictDAO.getDistrict(kw.StrKeyFirst);
                        if (t != -1)
                        {
                            listPlace = getDsDiaDiem(kw.Id, t, "QUANHUYEN.MaQuanHuyen");
                            return listPlace;
                        }
                    }
                   
                    
                    else
                    {
                        KeyWardDAO keyWardDAO = new KeyWardDAO();
                        if (kw.StrKeyFirst == "")
                        {
                            int t = keyWardDAO.getWard(kw.StrKeyLast);
                            if (t != -1)
                            {
                                listPlace = getDsDiaDiem(kw.Id, t, "QUANHUYEN.MaQuanHuyen");
                                return listPlace;
                            }
                        }
                        if (kw.StrKeyLast == "")
                        {
                            int t = keyWardDAO.getWard(kw.StrKeyFirst);
                            if (t != -1)
                            {
                                listPlace = getDsDiaDiem(kw.Id, t, "QUANHUYEN.MaQuanHuyen");
                                return listPlace;
                            }
                        }
                        else
                        {
                            listPlace = getDsDiaDiem(kw.Id, "DICHVU.MaDichVu");
                            return listPlace;
                        }
                    }
                }
            }
            else
            {
                KeyDistrictDAO keyDistrictDAO = new KeyDistrictDAO();
                int t = keyDistrictDAO.getDistrict(str);
                if (t != -1)
                {
                    listPlace = getDsDiaDiem(t, "QUANHUYEN.MaQuanHuyen");
                    return listPlace;
                }
                else
                {
                    KeyWardDAO keyWardDAO = new KeyWardDAO();
                    t = keyWardDAO.getWard(str);
                    if (t != -1)
                    {
                        listPlace = getDsDiaDiem(t, "PHUONG.MaPhuong");
                        return listPlace;
                    }
                    else
                    {
                        KeyPlaceDAO keyPlace = new KeyPlaceDAO();
                        List<int> list = keyPlace.getPlace(str);
                        if (list.Count != 0)
                        {
                            for (int j = 0; j < list.Count; j++)
                            {
                                listPlace = getDsDiaDiem(list[j], "TenDiaDiem.MaTenDiaDiem");
                                return listPlace;
                            }
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }

            return null;
        }
    }
}