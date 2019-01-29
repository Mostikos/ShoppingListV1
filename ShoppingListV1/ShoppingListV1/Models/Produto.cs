using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ShoppingListV1.Models
{
    [Table("Produto")]
    public class Produto
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public bool Status { get; set; }


    }
}
