﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;
using Npgsql;

namespace Friperies_2
{
    public static class dbConfig
    {
        static dbConfig()
        {
            try
            {
                // Memuat file .env
                DotNetEnv.Env.Load();
                Console.WriteLine("File .env loaded successfully.");
                Console.WriteLine($"Password from .env: {Env.GetString("DB_PASSWORD")}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading .env: {ex.Message}");
            }
        }
        public static string ConnectionString => $"User Id=postgres.zlbsnnkwupvwnuhyovfm;" +
                                                 $"Password=PfrzBsk$4!*hGRs;" +
                                                 $"Server=aws-0-ap-southeast-1.pooler.supabase.com;" +
                                                 $"Port=5432;" +
                                                 $"Database=postgres;";

        public static bool ExecuteNonQuery(string query, Dictionary<string, object> parameters, string successMessage, string failureMessage)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(dbConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        // Tambahkan semua parameter
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(successMessage);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show(failureMessage);
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                    return false;
                }
            }
        }

        public static DataTable LoadData(string query, Dictionary<string, object> parameters)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(dbConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        // Tambahkan parameter ke query
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }

                        // Eksekusi query dan isi DataTable
                        using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            return dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan saat memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
    }
}
