using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SQLite;
using ShoppingListV1.Models;
using Xamarin.Forms;

namespace ShoppingListV1.Data
{
     class Database
    {
        private readonly SQLiteConnection _connection;

        public Database()
        {
            var dep = DependencyService.Get<IPath>();
            string path = dep.GetPath("database.sqlite");
            _connection = new SQLiteConnection(path);
            _connection.CreateTable<Produto>();
        }

        public List<Produto> GetProduto()
        {
            return  _connection.Table<Produto>().ToList();
        }

        public List<Produto> Search(string nomeProduto)
        {
            return _connection.Table<Produto>().Where(a => a.NomeProduto.Contains(nomeProduto)).ToList();
        }


        public Produto GetProdutoByID(int id)
        {
            return _connection.Table<Produto>().Where(a => a.Id == id).FirstOrDefault();
        }

        public void Delete(Produto produto)
        {
            _connection.Delete(produto);
        }

        public void Update(Produto produto)
        {
            _connection.Update(produto);
        }

        public void AddProduto(Produto produto)
        {
            _connection.Insert(produto);
        }
    }
}
