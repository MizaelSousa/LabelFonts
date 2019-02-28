using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LabelFonts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        Random random = new Random();
        
        string[] frases = {  
            "ShadowsIntoLight.ttf#ShadowsIntoLight",
            "IndieFlower.ttf#IndieFlower",
            "Pacifico-Regular.ttf#Pacifico-Regular"
        };
        
        void MudarFonte(Object sender, EventArgs e){

            Label_01.Text = frases[random.Next(0, (frases.Length - 1))];
            Label_02.Text = frases[random.Next(0, (frases.Length - 1))];
            Label_03.Text = frases[random.Next(0, (frases.Length - 1))];

        }
    }
}
