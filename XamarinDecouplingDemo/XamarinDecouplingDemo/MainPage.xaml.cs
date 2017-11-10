using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinDecouplingDemo
{
	public partial class MainPage : ContentPage, IRequireDialogInteraction
	{
        private InputPage _InputPage;

		public MainPage()
		{
			InitializeComponent();
		}

        public void OnDialogCancellation(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        public void OnDialogConfirmation(object sender, EventArgs e)
        {
            Navigation.PopAsync();
            lblInputText.Text = _InputPage.enteredText ?? "No text entered.";
        }

        public void OnLoadButtonClick(object sender, EventArgs e)
        {
            lblInputText.Text = "";

            _InputPage = new InputPage();
            _InputPage.Confirmed += OnDialogConfirmation;
            _InputPage.Cancelled += OnDialogCancellation;

            Navigation.PushAsync(_InputPage);
        }
    }
}
