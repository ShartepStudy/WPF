using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace WpfApplication3
{
    class LShapeGeometry : Animatable
    {
        private readonly StreamGeometry geometry = new StreamGeometry();
        #region h
        public double H
        {
            get { return (double)GetValue(HProperty); }
            set { SetValue(HProperty, value); }
        }

        public static readonly DependencyProperty HProperty = 
            DependencyProperty.Register("H", typeof(double), typeof(LShapeGeometry), new PropertyMetadata(default(double), HChanged));
            
        private static void HChanged(DependencyObject source, DependencyPropertyChangedEventArgs args)
        {
            LShapeGeometry instance = (LShapeGeometry) source;
            instance.RenderGeometry((double)args.NewValue, instance.L, instance.Bh, instance.Bl);
        }
        #endregion

        #region l
        public double L
        {
            get { return (double)GetValue(LProperty); }
            set { SetValue(LProperty, value); }
        }

        public static readonly DependencyProperty LProperty = 
            DependencyProperty.Register("L", typeof(double), typeof(LShapeGeometry), new PropertyMetadata(default(double), LChanged));
            
        private static void LChanged(DependencyObject source, DependencyPropertyChangedEventArgs args)
        {
            LShapeGeometry instance = (LShapeGeometry) source;
            instance.RenderGeometry(instance.H, (double) args.NewValue, instance.Bh, instance.Bl);
        }
        #endregion

        #region bl
        public double Bl
        {
            get { return (double)GetValue(BlProperty); }
            set { SetValue(BlProperty, value); }
        }

        public static readonly DependencyProperty BlProperty = 
            DependencyProperty.Register("Bl", typeof(double), typeof(LShapeGeometry), new PropertyMetadata(default(double), BlChanged));
            
        private static void BlChanged(DependencyObject source, DependencyPropertyChangedEventArgs args)
        {
            LShapeGeometry instance = (LShapeGeometry) source;
            instance.RenderGeometry(instance.H, instance.L, instance.Bh, (double) args.NewValue);
        }
        #endregion

        #region bh
        public double Bh
        {
            get { return (double)GetValue(BhProperty); }
            set { SetValue(BhProperty, value); }
        }

        public static readonly DependencyProperty BhProperty = 
            DependencyProperty.Register("Bh", typeof(double), typeof(LShapeGeometry), new PropertyMetadata(default(double), BhChanged));
            
        private static void BhChanged(DependencyObject source, DependencyPropertyChangedEventArgs args)
        {
            LShapeGeometry instance = (LShapeGeometry) source;
            instance.RenderGeometry(instance.H, instance.L, (double)args.NewValue, instance.Bl);
        }
        #endregion


        protected override System.Windows.Freezable CreateInstanceCore()
        {
            return new LShapeGeometry();
        }

        private void RenderGeometry(double h, double l, double Bh, double Bl)
        {
            using (var context = geometry.Open())
            {
                context.BeginFigure(new Point(0.0, 0.0), true, true);
                context.LineTo(new Point(Bl, 0.0), true, true);
                context.LineTo(new Point(Bl, Bh), true, true);
                context.LineTo(new Point(l, Bh), true, true);
                context.LineTo(new Point(l, h), true, true);
                context.LineTo(new Point(0.0, h), true, true);
                context.Close();
            }
        }

        public static implicit operator Geometry(LShapeGeometry lshape)
        {
            return lshape.geometry;
        }
    }
}
