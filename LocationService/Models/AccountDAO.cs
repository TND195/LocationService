using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class AccountDAO : DataProvider
    {
        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            Account acc = new Account();
            acc.Email = dt.Rows[i]["Email"].ToString();
            acc.Name = dt.Rows[i]["Ten"].ToString();
            acc.Gender = (dt.Rows[i].IsNull("GioiTinh") == true) ? 0 : (int)dt.Rows[i]["GioiTinh"];
            acc.Birth = dt.Rows[i]["NgaySinh"].ToString();
            acc.Address = dt.Rows[i]["DiaChi"].ToString();
            acc.Image = dt.Rows[i]["Hinh"].ToString();
            acc.Id = dt.Rows[i]["Id"].ToString();
            acc.Cover = dt.Rows[i]["Cover"].ToString();
            return (object)acc;
        }
        public bool Login(String id)
        {
            connect();
            string query = "SELECT * FROM TAIKHOAN WHERE Id = " + id;
            IDataReader reader =  executeQuery(query);
            if (reader.Read())
            {
                return true;
            }
            return false;
        }
        public bool insertTaiKhoan(Account tk)
        {
            try
            {
                connect();
                string insertCommand = "INSERT INTO TAIKHOAN VALUES('" +
                    tk.Id + "', N'" +
                    tk.Name + "', " +
                    tk.Gender + ", '" +
                    tk.Birth + "', N'" +
                    tk.Address + "', '" +
                    tk.Image + "', '" +
                    tk.Email + "', '" +
                    tk.Cover +
                    "')";
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