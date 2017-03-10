using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class CommentDAO : DataProvider
    {
        public List<Comment> getDsBinhLuan(int id)
        {
            connect();
            string query = "SELECT * FROM BINHLUAN WHERE MaDuLieu = '" + id + "'";
            adapter = new SqlDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList ls = ConvertDataSetToArrayList(dataset);
            List<Comment> arr = new List<Comment>();
            foreach (Object o in ls)
            {
                arr.Add((Comment)o);
            }

            disconnect();
            return arr;
        }

        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            Comment bl = new Comment();
            bl.IdComment = (int)dt.Rows[i]["MaBinhLuan"];
            bl.IdUser = dt.Rows[i]["IdTaiKhoan"].ToString();
            bl.Content = dt.Rows[i]["NoiDung"].ToString();
            bl.Time = (DateTime)dt.Rows[i]["ThoiGian"];
            bl.IdPlace = (int)dt.Rows[i]["MaDuLieu"];
            return (object)bl;
        }

        public bool insertBinhLuan(Comment bl)
        {
            try
            {
                connect();
                string insertCommand = "INSERT INTO BINHLUAN VALUES(" +
                    bl.IdPlace + ", '" +
                    bl.IdUser + "', N'" +
                    bl.Content + "', " +
                    bl.Time.Year + "-" + bl.Time.Month + "-" + bl.Time.Day + ")";
                executeNonQuery(insertCommand);
                disconnect();
                return true;
            }
            catch (Exception )
            {
                return false;
            }

        }
    }
}