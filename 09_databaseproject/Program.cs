﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_databaseproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net
            Console.WriteLine("****c# veri tabanlı ürün-kategori bilgi sistemi ***** ");
            Console.WriteLine();
            Console.WriteLine();
            string tableNumber;
            Console.WriteLine("---------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("lütfen getirmek istediğiniz tablo numarasını giriniz:");
            tableNumber = Console.ReadLine();
            Console.WriteLine("---------------------");


            SqlConnection connection = new SqlConnection("Data Source=SULTANINBILGISA\\SQLEXPRESS; Initial Catalog=EgitimKampiDB; Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Table_Category",connection);//databasemizde birden fazla tablo olduğu için connection ile bağladık ki bizim üzerinde çalıştığımız database gitsin
           
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach(DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }//var türünü bilmediğimiz zaman kullanılır sayı mı char mı diyerekten


            Console.Read();

        }
    }
}
