using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewTraining
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CVWithContextMenu : ContentPage
    {
        public CVWithContextMenu()
        {
            this.BindingContext = new StudentList();
            InitializeComponent();
        }

        private void SwipeItem_Invoked(object sender, EventArgs e)
        {

        }
    }
}