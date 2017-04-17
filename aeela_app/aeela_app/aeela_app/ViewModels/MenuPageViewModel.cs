using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace aeela_app.ModelViews
{
    public class MenuPageViewModel : ContentPage
    {
        public MenuPageViewModel()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello Page" }
                }
            };
        }
    }
}
