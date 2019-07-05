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

namespace WpfAppCommands1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel vm = new MainWindowViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }
    }

    public class MainWindowViewModel : ObservableObject
    {
        private string text = "Hello!";
        public string Text { get => text; set => Set(ref text, value); }

        private RelayCommand testCommand;
        public RelayCommand TestCommand
        { get => testCommand ?? (testCommand = new RelayCommand(
            param =>
            {
                Text = "Test";
            }
            ));
        }
        public MainWindowViewModel()
        {
            ///TestCommand = new RelayCommand(param => Text = "Test");
        }

        //public RelayCommand TestCommand { get; set; }
    }
}
