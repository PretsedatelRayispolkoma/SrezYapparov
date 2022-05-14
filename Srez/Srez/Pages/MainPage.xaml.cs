using Srez.Models;
using Srez.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Srez
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Role role = new Role()
            { Id = 1, Name = "Admin"};
            App.DataBase.SaveRole(role);
            Role role1 = new Role()
            { Id = 2, Name = "User" };
            App.DataBase.SaveRole(role1);
        }

        private void SignInBtn_Clicked(object sender, EventArgs e)
        {
            User user = App.DataBase.GetUsers().Where(p => p.Login == LoginEntry.Text && p.Password == PasswordEntry.Text).FirstOrDefault();
            if(user != null)
            {
                Application.Current.MainPage = new NavigationPage(new ListPage(user.RoleID));
            }
            else
            {
                DisplayAlert("Error", "Incorrect login or password", "Ok");
            }
        }

        private void SignUpBtn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new RegistrationPage());
        }
    }
}
