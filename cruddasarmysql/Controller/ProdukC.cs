using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cruddasarmysql.Model;
using MySql.Data.MySqlClient;

namespace cruddasarmysql.Controller
{
    public class ProdukC
    {
        private string conString = "Server=localhost;Database=db_inventory;Uid=olis;Pwd=kopi;";

        public List<Produk> getAllProduk()
        {
            List<Produk> produk = new List<Produk> ();

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open ();
                string query = "SELECT * FROM produk";

                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            produk.Add(new Produk
                            {
                                kodeBarang = reader["kode_barang"].ToString(),
                                barcode = reader["barcode"].ToString(),
                                nama = reader["nama"].ToString(),
                                hBeli = Convert.ToDecimal(reader["h_beli"]),
                                hJual = Convert.ToDecimal(reader["h_jual"]),
                                kuantiti = Convert.ToDecimal(reader["kuantiti"]),
                            });
                        }
                    }
                }
            }

            return produk;
        }
    }
}
