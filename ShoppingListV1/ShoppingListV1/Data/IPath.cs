using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingListV1.Data
{
    public interface IPath
    {
         string GetPath(string NomeDatabaseFile);
    }
}
