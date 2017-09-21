using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_Navigation.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo_Navigation.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public Beer BeerContent { get; set; }

        public DetailPage(Beer beer)
        {
            InitializeComponent();

            BeerContent = beer;
            ShowDetails();
        }

        /// <summary>
        /// Shows the details of this beer object in the associated labels in the GUI (see: MainPage.xaml).
        /// </summary>
        /// <param name="beer">The beer object whose details you wish to show.</param>
        private void ShowDetails()
        {
            this.Title = BeerContent.Name;      //set the TITLE in the title bar of this page
            lblBrewery.Text = BeerContent.Brewery;
            lblColor.Text = BeerContent.Color;

            //The text property only allows string objects,
            //  adding a string "%" to the alcohol property automatically converts the whole thing to a string
            lblAlcohol.Text = BeerContent.Alcohol + "%";
        }

    }
}