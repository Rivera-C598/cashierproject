using System;
using System.Collections.Generic;
using System.Text;
using cashierproject.Models;
using SQLite;

namespace cashierproject.Helpers
{
    public class DatabaseHelper
    {
        SQLiteConnection database;

        public DatabaseHelper(string dbPath)
        {
            database = new SQLiteConnection(dbPath);
            database.CreateTable<Product>();
        }

        public List<Product> GetProducts()
        {
            return database.Table<Product>().ToList();
        }

        public int InsertProduct(Product product)
        {
            return database.Insert(product);
        }

        public int UpdateProduct(Product product)
        {
            return database.Update(product);
        }

        public int DeleteProduct(Product product)
        {
            return database.Delete(product);
        }
    }
}
