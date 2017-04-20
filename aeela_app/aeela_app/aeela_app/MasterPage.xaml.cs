using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aeela_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }
        public MasterPage()
        {
            InitializeComponent();

            var masterPageItem = new List<MasterPageItem>();
            masterPageItem.Add(new MasterPageItem
            {
                Title = "HomePage",
                IconSource = "",
                TargetType = typeof(HomePage)
            });
            masterPageItem.Add(new MasterPageItem
            {
                Title = "Info",
                IconSource = "",
                TargetType = typeof(InfoPage)
            });
            masterPageItem.Add(new MasterPageItem
            {
                Title = "Pagar",
                IconSource = "icon_pay.png",
                TargetType = typeof(PayPage)
            });
            ListView.ItemsSource = masterPageItem;
        }
    }
}
