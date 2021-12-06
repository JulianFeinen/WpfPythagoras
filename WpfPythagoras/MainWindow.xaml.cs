using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfPythagoras
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public double Aa;
        public double Bb;
        public double Cc;

        public double flaeche;
        

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnBerechne(object sender, RoutedEventArgs e)
        {
            dreieickv2.Dreieck dreieckObjekt = new dreieickv2.Dreieck();
            //Fall 1? (Hypotenuse fehlt)
            if ((tbKatheteA.Text != string.Empty) && (tbKatheteB.Text != string.Empty))
            {
                
                
                    Aa = Convert.ToDouble(tbKatheteA.Text);
                    Bb = Convert.ToDouble(tbKatheteB.Text);

                    dreieckObjekt.a = Aa;
                    dreieckObjekt.b = Bb;
                    tbHypotenuse.Text = Convert.ToString(dreieckObjekt.BerechnungHypotenuse().ToString("#00.00"));
                


            }
            //Fall 2? (Kathete A fehlt)
            if ((tbHypotenuse.Text != string.Empty) && (tbKatheteB.Text != string.Empty))
            {
                
                    Cc = Convert.ToDouble(tbHypotenuse.Text);
                    Bb = Convert.ToDouble(tbKatheteB.Text);

                    dreieckObjekt.c = Cc;
                    dreieckObjekt.b = Bb;
                    tbKatheteA.Text = Convert.ToString(dreieckObjekt.BerechnungKatheteA().ToString("#00.00"));
                

            }
            //Fall 3? (Kathete B fehlt)
            if ((tbHypotenuse.Text != string.Empty) && (tbKatheteA.Text != string.Empty))
            {
                
                    Cc = Convert.ToDouble(tbHypotenuse.Text);
                    Aa = Convert.ToDouble(tbKatheteA.Text);

                    dreieckObjekt.c = Cc;
                    dreieckObjekt.a = Aa;
                    tbKatheteB.Text = Convert.ToString(dreieckObjekt.BerechnungKatheteB().ToString("#00.00"));
                    

            }

            flaeche = (dreieckObjekt.a) * (dreieckObjekt.b) / 2;
            tbFlaeche.Text = flaeche.ToString("#00.00");
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbKatheteA.Text = "";
            tbKatheteB.Text = "";
            tbHypotenuse.Text = "";
            tbFlaeche.Text = "";

        }

        private void btnAbbruch_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}


