using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Navigation_Page
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void OnButtonClicked(object sender, EventArgs e)
        {
            bool isUserEmpty = string.IsNullOrEmpty(entryUsername.Text);
            bool isPassEmpty = string.IsNullOrEmpty(entryPassword.Text);

            if( isUserEmpty || isPassEmpty)
            {

            }
            else
            {
                //All conditions met to navigate forward
            }
        }

        private void btnClicked_Tool(object sender, EventArgs)
        {

        }

	}
}
