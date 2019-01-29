using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using ShoppingListV1.Data;
using System.IO;
using ShoppingListV1.Droid.Data;

[assembly: Dependency(typeof(Caminho))]
namespace ShoppingListV1.Droid.Data
{
    public class Caminho : IPath
    {
        public string GetPath(string NomeDatabaseFile)
        {
            var caminhoDoBanco = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            string caminhoBanco = Path.Combine(caminhoDoBanco, NomeDatabaseFile);

            return caminhoBanco;
        }

    }
}