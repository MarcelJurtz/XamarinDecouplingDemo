using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinDecouplingDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InputPage : ContentPage
	{
		public InputPage ()
		{
			InitializeComponent();
		}

        public EventHandler Confirmed;
        public EventHandler Cancelled;

        public String enteredText { get { return txtTextToReturn.Text; } }

        public void OnConfirm(object sender, EventArgs e)
        {
            Confirmed?.Invoke(this, EventArgs.Empty);
        }

        public void OnCancel(object sender, EventArgs e)
        {
            Cancelled?.Invoke(this, EventArgs.Empty);
        }
	}
}