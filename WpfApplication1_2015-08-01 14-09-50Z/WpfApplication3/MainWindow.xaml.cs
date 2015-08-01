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
using System.Windows.Media.Animation;
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
        LShapeGeometry geometry = new LShapeGeometry();
        public MainWindow()
        {
            DefaultStyleKey = typeof(MainWindow);

            InitializeComponent();

            geometry.BeginAnimation(LShapeGeometry.LProperty, new DoubleAnimation(200.0, TimeSpan.FromSeconds(15.0)));
            geometry.BeginAnimation(LShapeGeometry.HProperty, new DoubleAnimation(400.0, TimeSpan.FromSeconds(15.0)));
            geometry.BeginAnimation(LShapeGeometry.BlProperty, new DoubleAnimation(300.0, TimeSpan.FromSeconds(15.0)));
            geometry.BeginAnimation(LShapeGeometry.BhProperty, new DoubleAnimation(100.0, TimeSpan.FromSeconds(15.0)));
        }

        Pen pen = new Pen(Brushes.BlueViolet, 5);

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            //StreamGeometry geometry = new StreamGeometry();

            //using (var context = geometry.Open())
            //{
            //    context.BeginFigure(new Point(0.0, 0.0), true, true);
            //    context.LineTo(new Point(100.0, 0.0), true, true);
            //    context.LineTo(new Point(100.0, 50.0), true, true);
            //    context.LineTo(new Point(70.0, 50.0), true, true);
            //    context.LineTo(new Point(70.0, 250.0), true, true);
            //    context.LineTo(new Point(100.0, 250.0), true, true);
            //    context.LineTo(new Point(100.0, 300.0), true, true);
            //    context.LineTo(new Point(0.0, 300.0), true, true);
            //    context.LineTo(new Point(0.0, 250.0), true, true);
            //    context.LineTo(new Point(30.0, 250.0), true, true);
            //    context.LineTo(new Point(30.0, 50.0), true, true);
            //    context.LineTo(new Point(0.0, 50.0), true, true);
            //    context.Close();
            //}

            //geometry.Transform = new ScaleTransform(2.0, 1.0);

            drawingContext.DrawGeometry(Brushes.GreenYellow, pen, geometry);
        }
    }
}
