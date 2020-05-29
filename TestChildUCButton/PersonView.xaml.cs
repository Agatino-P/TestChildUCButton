using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace TestChildUCButton
{
    /// <summary>
    /// Interaction logic for PersonView.xaml
    /// </summary>
    public partial class PersonView : UserControl
    {
        public ICommand Button1Cmd
        {
            get { return (ICommand)GetValue(Button1CmdProperty); }
            set { SetValue(Button1CmdProperty, value); }
        }
        public static readonly DependencyProperty Button1CmdProperty =
            DependencyProperty.Register("Button1Cmd", typeof(ICommand), typeof(PersonView), new PropertyMetadata(null));

        public ICommand Button2Cmd
        {
            get { return (ICommand)GetValue(Button2CmdProperty); }
            set { SetValue(Button2CmdProperty, value); }
        }
        public static readonly DependencyProperty Button2CmdProperty =
            DependencyProperty.Register("Button2Cmd", typeof(ICommand), typeof(PersonView), new PropertyMetadata(null));

        public string CustomLabel
        {
            get { return (string)GetValue(CustomLabelProperty); }
            set { SetValue(CustomLabelProperty, value); }
        }

        public static readonly DependencyProperty CustomLabelProperty =
            DependencyProperty.Register("CustomLabel", typeof(string), typeof(PersonView), new PropertyMetadata("custom-label"));



        public int CustomValue
        {
            get { return (int)GetValue(CustomValueProperty); }
            set { SetValue(CustomValueProperty, value); }
        }
        public static readonly DependencyProperty CustomValueProperty =
            DependencyProperty.Register("CustomValue", typeof(int), typeof(PersonView), new PropertyMetadata(42));



        public PersonView()
        {
            InitializeComponent();
        }
    }
}
