using System;
using System.Collections;
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

namespace Collection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
                hashtable.Add(TEXTBOX1.Text, TEXTBOX2.Text);
        }

        private void Remove(object sender, RoutedEventArgs e)
        {
            hashtable.Remove(TEXTBOX1.Text);
        }
        private void ShowAll(object sender, RoutedEventArgs e)
        {
            ICollection icollection = hashtable.Keys;
            int i = 1;
            if (hashtable.Count == 0)
            {
                MessageBox.Show("Not Found Key");
            }
            else
            {
                MessageBox.Show(hashtable.Count.ToString() +" Key"+ " Found");
            }
            foreach (string key in icollection)
            {
                MessageBox.Show(hashtable[key].ToString(), "Key Number " + i.ToString());
                i++;
            }
        }


    }
}
