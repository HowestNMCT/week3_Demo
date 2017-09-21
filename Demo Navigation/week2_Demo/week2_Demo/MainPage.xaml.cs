using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

//make beer class accessible 
using Demo_Navigation.Model;

//make Debug.WriteLine possible to write to output
using System.Diagnostics;
using Demo_Navigation.View;

namespace Demo_Navigation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            LoadAllBeers();
        }
               

        /// <summary>
        /// Uses the static GetBeers method of the Beer class to:
        /// - get a list of beers from csv file
        /// - show the list in the associated listview
        /// </summary>
        private void LoadAllBeers()
        {
            //call static method GetBeers of Beer class
            List<Beer> allBeers = Beer.GetBeers();

            //print all beers to output window using PrintBeers method
            lstBeers.ItemsSource = allBeers;
        }

        private void lstBeers_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            NavigateToDetails(lstBeers.SelectedItem as Beer);
        }

        private void NavigateToDetails(Beer beer)
        {
            if (beer != null) //was there a beer selected?
            {
                Navigation.PushAsync(new DetailPage(beer));

                ////alternative for DetailPage IF constructor would have NO parameters:
                //DetailPage page = new DetailPage();
                //page.BeerContent = beer;
                //Navigation.PushAsync(page);
            }
        }
    }
}
