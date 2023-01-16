using Proiect_Aplicatia_Mobila.Models;
namespace Proiect_Aplicatia_Mobila;

public partial class Categories : ContentPage
{

    public List<Category> categories { get; set; }


    public Categories()
    {
        InitializeComponent();
        categories = new List<Category>
            {
            
                new Category { Name = "Laptop",  Image = "laptop.png", Details = "Include baia cu șampon special pentru câini, tunderea blănii și periajul. "},
                new Category { Name = "Telefoane",  Image = "mobile.png", Details = "Include tăierea unghiilor câinilor și periajul. " },
               
    };
        BindingContext = this;
    }

}