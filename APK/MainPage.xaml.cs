using APK.Models;
using Microsoft.Maui.Handlers;
using System.Collections.ObjectModel;

namespace APK;

public partial class MainPage : ContentPage
{
    public ObservableCollection<FairyTale> FairyTales { get; set; }
    public ObservableCollection<FairyTale> FairyTales2 { get; set; }

    public MainPage()
	{
		InitializeComponent();

		ModifySearchBar();
        InitializeTales();
        BindingContext = this;

	}

    private void InitializeTales()
    {
        FairyTales = new ObservableCollection<FairyTale>
               {
                   new FairyTale { Name = "Expresos y Cafes", ReadTime = new TimeSpan(0, 35, 0), Image = "cofi.jpeg" },
                   new FairyTale { Name = "Exoticos Especialidades", ReadTime = new TimeSpan(0, 35, 0),  Image = "jugo.jpg" },
                   new FairyTale { Name = "Energizantes ", ReadTime = new TimeSpan(0, 20, 0),  Image = "monster.jpg" },
                   new FairyTale { Name = "Las mejores Compañias", ReadTime = new TimeSpan(0, 15, 0),  Image = "refresco.jpg" },
                   new FairyTale { Name = "Bebidas de Renombre", ReadTime = new TimeSpan(0, 35, 0),  Image = "starbucks.jpg" },
                   new FairyTale { Name = "Bebidas Alcoholicas", ReadTime = new TimeSpan(0, 35, 0),  Image = "guaro.jpg" },
               };
        FairyTales2 = new ObservableCollection<FairyTale>
               {
                   new FairyTale { Name = "Snow White", ReadTime = new TimeSpan(0, 25, 0),  Image = "cafesito.jpg" },
                   new FairyTale { Name = "Rapunzel", ReadTime = new TimeSpan(0, 20, 0),  Image = "fresa.jpg" },
                   new FairyTale { Name = "Little Red Riding Hood", ReadTime = new TimeSpan(0, 15, 0),  Image = "michelada.jpg" },
                   new FairyTale { Name = "Beauty and the Beast", ReadTime = new TimeSpan(0, 35, 0),  Image = "mosterblue.jpg" },
                   new FairyTale { Name = "Cinderella", ReadTime = new TimeSpan(0, 30, 0),  Image = "naranja.jpg" },
                    new FairyTale { Name = "Cinderella", ReadTime = new TimeSpan(0, 30, 0),  Image = "fresa.jpg" },
                     new FairyTale { Name = "Cinderella", ReadTime = new TimeSpan(0, 30, 0),  Image = "copa.jpg" },
               };

    }

    private void ModifySearchBar()
	{
        SearchBarHandler.Mapper.AppendToMapping("CustomSearchIconColor", (handler, view) =>
        {

#if ANDROID

            var context = handler.PlatformView.Context;
            var searchIconId = context.Resources.GetIdentifier("search_mag_icon", "id", context.PackageName);
            if (searchIconId != 0)
            {
                var searchIcon = handler.PlatformView.FindViewById<Android.Widget.ImageView>(searchIconId);
                searchIcon.SetColorFilter(Android.Graphics.Color.Rgb(172, 157, 185), Android.Graphics.PorterDuff.Mode.SrcIn);
            }
#endif
        });
    }

    private void home_Clicked(object sender, EventArgs e)
    {

    }

    private void menu_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new menu());
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Perfil());
    }
}

