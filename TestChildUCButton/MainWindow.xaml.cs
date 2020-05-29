using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TestChildUCButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : UserControl
    {
        public ICommand Command1
        {
            get { return (ICommand)GetValue(Command1Property); }
            set { SetValue(Command1Property, value); }
        }
        public static readonly DependencyProperty Command1Property =
            DependencyProperty.Register("Command1", typeof(ICommand), typeof(MainWindow), new PropertyMetadata(null));

        public ICommand Command2
        {
            get { return (ICommand)GetValue(Command2Property); }
            set { SetValue(Command2Property, value); }
        }
        public static readonly DependencyProperty Command2Property =
            DependencyProperty.Register("Command2", typeof(ICommand), typeof(MainWindow), new PropertyMetadata(null));




        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
