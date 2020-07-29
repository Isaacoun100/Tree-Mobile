using MobileTree.Data_Structures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileTree
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Ejemplo_Clicked(object sender, EventArgs e)
        {
            BinaryTree.Add(7);
            BinaryTree.Add(8);
            BinaryTree.Add(6);
            BinaryTree.Add(9);
            BinaryTree.Add(5);
            label1.Text = BinaryTree.toString();
        }

        public void post_Clicked(object sender, EventArgs e)
        {
            label1.Text = "YO HAGO EL POST";

        }

        public void pre_Clicked(object sender, EventArgs e)
        {
            label1.Text = "YO HAGO EL PRE";
        }


        public void In_Clicked(object sender, EventArgs e)
        {
            label1.Text = "YO HAGO EL IN";
        }

    }


}
