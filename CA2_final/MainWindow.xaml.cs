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

namespace CA2_final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //List created for bike objects
        List<Activitys> allBikes = new List<Activitys>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Create Bike objects
            Activitys aProduct = new Activitys(1234, "road bike", 535.00m, Gender.Male);
            Activitys bProduct = new Activitys(1235, "road bike", 635.00m, Gender.Female);
            Activitys cProduct = new Activitys(1236, "mountain bike", 740.00m, Gender.Male);
            Activitys dProduct = new Activitys(1237, "mountain bike", 780.00m, Gender.Female);
            Activitys eProduct = new Activitys(1238, "hybrid bike", 155.00m, Gender.Male);
            Activitys fProduct = new Activitys(1239, "hybrid bike", 150.00m, Gender.Female);

            //Add to list
            allBikes.Add(aProduct);
            allBikes.Add(bProduct);
            allBikes.Add(cProduct);
            allBikes.Add(dProduct);
            allBikes.Add(eProduct);
            allBikes.Add(fProduct);

            //Display in Listbox
            lbxProducts.ItemsSource = allBikes;
        }
    }
}
