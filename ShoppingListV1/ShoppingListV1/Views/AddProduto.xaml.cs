using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ShoppingListV1.Models;
using ShoppingListV1.Data;


namespace ShoppingListV1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddProduto : ContentPage
	{
        
        List<Produto> ListaProdutos { get; set; }
		public AddProduto ()
		{
			InitializeComponent ();
            Database database = new Database();
                     
		}

        public void AdicionarProduto(object sender, EventArgs args)
        {                  
            Produto p = new Produto();
            p.NomeProduto = NomeProduto.Text;
            Database database = new Database();
            database.AddProduto(p);
            ListaProdutos = database.GetProduto();
        }
    }
}