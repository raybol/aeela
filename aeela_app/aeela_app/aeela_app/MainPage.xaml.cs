using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace aeela_app
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            masterpage.ListView.ItemSelected += OnItemSelected;
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if(item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                masterpage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
