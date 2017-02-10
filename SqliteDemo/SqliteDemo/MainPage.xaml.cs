using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SqliteDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GetSettings(object sender, EventArgs e)
        {
            SettingValue.Text = SqliteDemo.Helpers.Settings.GeneralSettings;
        }

        private void SetSettings(object sender, EventArgs e)
        {
            SqliteDemo.Helpers.Settings.GeneralSettings = SetText.Text;
        }
    }
}
