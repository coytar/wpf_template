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

namespace wpf_template
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public class Student
    {
        public string Name { get; set; }
        public string ID { get; set; }
    }


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void LoadExample1()
        {
            List<Student> lst = new List<Student>{
                new Student{Name= "Marc",ID="01"},
                new Student{Name= "John",ID="02"},
                new Student{Name= "Robin",ID="03"},
                new Student{Name= "Amit",ID="04"
                }
            };
            lstStudents.ItemsSource = lst;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadExample1();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
