using System;
using System.IO;
using Proiect_Aplicatia_Mobila.Data;

namespace Proiect_Aplicatia_Mobila;

public partial class App : Application
{
    static ShoppingListDatabase database;
    public static ShoppingListDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new
               ShoppingListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
               LocalApplicationData), "ShoppingList.db3"));
            }
            return database;
        }
    }

	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
