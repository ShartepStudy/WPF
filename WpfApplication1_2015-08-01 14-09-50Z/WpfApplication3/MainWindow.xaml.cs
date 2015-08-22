using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            AddHandler(MainWindow.PreviewMouseDownEvent, new RoutedEventHandler(ButtonEventHandler), true);
            AddHandler(MainWindow.MouseDownEvent, new RoutedEventHandler(ButtonEventHandler), true);
            AddHandler(MainWindow.PreviewMouseUpEvent, new RoutedEventHandler(ButtonEventHandler), true);
            AddHandler(MainWindow.MouseUpEvent, new RoutedEventHandler(ButtonEventHandler), true);

            AddHandler(ButtonBase.ClickEvent, new RoutedEventHandler(ButtonEventHandler), true);

            AddHandler(MainWindow.MouseUpEvent, new RoutedEventHandler(SeparatorHandler), true);
        }

        private void ButtonEventHandler(object sender, RoutedEventArgs e)
        {
            eventsListBox.Items.Add(e);
        }

        private void SeparatorHandler(object sender, RoutedEventArgs e)
        {
            eventsListBox.Items.Add(new Separator());
        }
    }
}
