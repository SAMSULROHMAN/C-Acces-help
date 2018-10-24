using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Souce=d:/ramayanti_swalayan_teori.accdb");
            Console.Write("Kode Kasir          :");
            string kdKasir = Console.ReadLine();
            Console.Write("Nama Kasir     :");
            string NKasir = Console.ReadLine();
            Console.Write("Alamat        :");
            string alamat = Console.ReadLine();


            string sql = "insert into tabel_kasir (kd_ksr,nama,alamat,jk,kota kasir,Foto Dlri) values ('" + kdKasir + "','" + NKasir + "','" + alamat + "')";
                
            OleDbCommand cm = new OleDbCommand(sql, conn);
            MessageBox.Show(sql);

            cm.ExecuteNonQuery();
            
          
            Console.ReadKey();

        }
    }
}
        
