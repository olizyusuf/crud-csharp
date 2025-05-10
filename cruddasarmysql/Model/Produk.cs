using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cruddasarmysql.Model
{
    public class Produk
    {
        public string kodeBarang {  get; set; }
        public string barcode { get; set; }
        public string nama { get; set; }
        public decimal hBeli { get; set; }
        public decimal hJual { get; set; }
        public decimal kuantiti { get; set; }
    }
}
