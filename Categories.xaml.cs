using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proiect_Aplicatia_Mobila
{
    public partial class Categories : ContentPage
    {
        public List<Models.Categories> categories { get; set; }

        public Categories()
        {
            InitializeComponent();
            categories = new List<Models.Categories>
            {
                new Models.Categories { Name = "Laptop",  Image = "laptop2.png", Details = "Categoria noastra de laptopuri include modele pentru utilizatorii business si pentru gaming. \nAvem laptopuri cu procesoare Intel Core i5 si i7 de ultima generatie, placi video dedicate si ecran de rezolutie 4K.\n Toate modelele au conectivitate wireless rapida si baterii cu durata lunga de viata.\n Oferta noastra include laptopuri de la branduri precum Dell, Lenovo si MSI."},
                new Models.Categories { Name = "Telefoane",  Image = "mobile2.png", Details = "Categoria noastra de telefoane include modele de top din gama flagship si modele mid-range cu caracteristici excelente.\n Avem telefoane cu ecran AMOLED, camere principale de 48MP si senzori de amprenta in ecran.\n Toate modelele suporta conectivitate 5G si au baterii cu durata lunga de viata.\n Oferta noastra include telefoane de la branduri precum Samsung, Apple, Huawei si OnePlus." },
            };
            BindingContext = this;
        }
    }
}
