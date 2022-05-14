using Srez.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Srez.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private async void GoBackBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void OkBtn_Clicked(object sender, EventArgs e)
        {
            User user = new User();

            if(newLogEntry.Text != string.Empty && NewPasswordEntry.Text != string.Empty && RepPasswordEntry.Text != string.Empty)
            {
                if(NewPasswordEntry.Text == RepPasswordEntry.Text)
                {
                    user.Login = newLogEntry.Text;
                    user.Password = NewPasswordEntry.Text;
                    user.RoleID = 2;
                    App.DataBase.SaveUser(user);
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Error", "Passwords are not the same", "OK");
                }
            }
            else
            {
                await DisplayAlert("Error", "Fill all fields", "OK");
            }
        }
    }
}