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
            if (entry1.Text != null)
            {
                BinaryTree.Add(int.Parse(entry1.Text));
                label1.Text = BinaryTree.toString();
            }
        }

        public void post_Clicked(object sender, EventArgs e)
        {
            label1.Text = BinaryTree.TraversePostOrder();

        }

        public void pre_Clicked(object sender, EventArgs e)
        {
            label1.Text = BinaryTree.TraversePreOrder();
        }


        public void In_Clicked(object sender, EventArgs e)
        {
            label1.Text = BinaryTree.TraverseInOrder();
        }

        public void Clear(object sender, EventArgs e)
        {
            BinaryTree.clear();
            label1.Text = "Please add a node or toggle random mode";
        }

        public void RandomMode(object sender, EventArgs e)
        {
            if (entry1.Text != null)
            {
                BinaryTree.AddRandom(int.Parse(entry1.Text));
                label1.Text = BinaryTree.toString();
            }
                
        }

    }


}
