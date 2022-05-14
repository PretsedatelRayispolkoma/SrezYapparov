using Srez.SQLConnection;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Srez
{
    public partial class App : Application
    {
        private const string DATABASE_NAME = "holdthestreet.db";

        private static SQLDB _database;

        public static SQLDB DataBase
        {
            get
            {
                if (_database == null)
                {
                    _database = new SQLDB(Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return _database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
