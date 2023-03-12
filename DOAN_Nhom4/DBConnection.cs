﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;

namespace DOAN_Nhom4
{
    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        public DBConnection() { }
        public DataTable LayDanhSach(string sqlStr)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dt);
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public void xuLi(string kh, string tknh)
        {
            conn.Open();
            SqlTransaction transaction = conn.BeginTransaction();
            try
            {
                SqlCommand cmdKH = new SqlCommand(kh, conn);
                cmdKH.Transaction = transaction;
                cmdKH.ExecuteNonQuery();

                SqlCommand cmdNH = new SqlCommand(tknh, conn);
                cmdNH.Transaction = transaction;
                cmdNH.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Loi ket noi" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public void xuLi(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmdKH = new SqlCommand(sqlStr, conn);
                cmdKH.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public NguoiDung LayKhachHang(string Cot, string giaTri)
        {
            NguoiDung khachHang = new NguoiDung();
            try
            {
                conn.Open();
                string sql = string.Format("SELECT * FROM KhachHang WHERE {0} = @Giatri", Cot);
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@Giatri", giaTri);

                SqlDataReader reader = command.ExecuteReader();
                /*if (reader.HasRows)
                {
                    reader.Read();
                    khachHang.SoTK = reader.GetString(0);
                    khachHang.TenTK = reader.GetString(1);
                    khachHang.TenDN = reader.GetString(2);
                    khachHang.Pass = reader.GetString(3);
                    khachHang.NgaySinh = reader.GetDateTime(4);
                    khachHang.Cccd = reader.GetString(5);
                    khachHang.Sdt = reader.GetString(6);
                    khachHang.SoDu = reader.GetInt64(7);
                }
                else
                    return null;
                */
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return khachHang;
        }

        public bool IsPhone(string numberphone)
        {
            string strRegex = @"^(0?)(3[2-9]|5[6|8|9]|7[0|6-9]|8[0-6|8|9]|9[0-4|6-9])[0-9]{7}$";
            Regex regex = new Regex(strRegex);
            return regex.IsMatch(numberphone);
        }

    }
}
