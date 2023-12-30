using System.Collections;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToDoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> _items = [];

        public MainWindow()
        {
            InitializeComponent();
            Input_Name.Focus();

            List_NameList.ItemsSource = _items;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Input_Name.Text))
            {
                _items.Add(Input_Name.Text);
                Input_Name.Text = string.Empty;
            }
            else 
            {                 
                MessageBox.Show("Please enter a name.");
            }
            
        }
    }
}