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

namespace WpfApplication2
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
        public WebBrowser TabBrowser = new WebBrowser();
        private void button1_Click(object sender, RoutedEventArgs e)
        {

            
            TabItem item = new TabItem();
            tabControl.Items.Add(item);
            tabControl.SelectedItem = item;
            item.Content = TabBrowser;
            item.Header = "New Tab" ;
            TabBrowser.Navigate("https://www.google.de/");
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            string Search = Url.Text.ToString();
            if (Search.Substring(0,4) != "http")
            {
                string FinalUrl = "https://www.google.de/search?source=hp&ei=pso8W4ekPKqL6ASI1bHoDw&q=" + Search;
                TabBrowser.Navigate(FinalUrl);
            }
            else
            {
                TabBrowser.Navigate(Search);
            }
            
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
             tabControl.Items.Remove(tabControl.SelectedItem);
        }
    }
}
