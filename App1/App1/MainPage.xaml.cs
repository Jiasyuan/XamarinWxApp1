using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ClassLibrary1.ClassLibrary1 csl = new ClassLibrary1.ClassLibrary1();
            int count = csl.add(4,7);
            //lb= count.ToString();
        }
    }
}
