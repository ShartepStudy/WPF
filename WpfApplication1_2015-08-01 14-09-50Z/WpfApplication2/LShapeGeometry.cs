using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace WpfApplication2
{
    class LShapeGeometry : Animatable
    {
        private readonly StreamGeometry geometry = new StreamGeometry();

        #region h

        public static readonly DependencyProperty HProperty = DependencyProperty.Register("H", typeof(double), typeof(LShapeGeometry), new PropertyMetadata(0.0, new PropertyChangedCallback(OnHChanged)));

        private static void OnHChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            LShapeGeometry lShapeGeometry = o as LShapeGeometry;
            if (lShapeGeometry != null)
                lShapeGeometry.OnHChanged((double)e.OldValue, (double)e.NewValue);
        }

        protected virtual void OnHChanged(double oldValue, double newValue)
        {
            RenderGeometry(newValue, L, Bh, Bl);
        }
        public double H
        {
            get
            {
                return (double)GetValue(HProperty);
            }
            set
            {
                SetValue(HProperty, value);
            }
        }

        #endregion

        #region l

        public static readonly DependencyProperty LProperty = DependencyProperty.Register("L", typeof(double), typeof(LShapeGeometry), new PropertyMetadata(0.0, new PropertyChangedCallback(OnLChanged)));

        private static void OnLChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            LShapeGeometry lShapeGeometry = o as LShapeGeometry;
            if (lShapeGeometry != null)
                lShapeGeometry.OnLChanged((double)e.OldValue, (double)e.NewValue);
        }

        protected virtual void OnLChanged(double oldValue, double newValue)
        {
            RenderGeometry(H, newValue, Bh, Bl);
        }

        public double L
        {
            get
            {
                return (double)GetValue(LProperty);
            }
            set
            {
                SetValue(LProperty, value);
            }
        }

        #endregion

        #region bl

        public static readonly DependencyProperty BlProperty = DependencyProperty.Register("Bl", typeof(double), typeof(LShapeGeometry), new PropertyMetadata(0.0, new PropertyChangedCallback(OnBlChanged)));

        private static void OnBlChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            LShapeGeometry lShapeGeometry = o as LShapeGeometry;
            if (lShapeGeometry != null)
                lShapeGeometry.OnBlChanged((double)e.OldValue, (double)e.NewValue);
        }

        protected virtual void OnBlChanged(double oldValue, double newValue)
        {
            RenderGeometry(H, L, Bh, newValue);
        }
        public double Bl
        {
            get
            {
                return (double)GetValue(BlProperty);
            }
            set
            {
                SetValue(BlProperty, value);
            }
        }

        #endregion

        #region bh

        public static readonly DependencyProperty BhProperty = DependencyProperty.Register("Bh", typeof(double), typeof(LShapeGeometry), new PropertyMetadata(0.0, new PropertyChangedCallback(OnBhChanged)));

        private static void OnBhChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            LShapeGeometry lShapeGeometry = o as LShapeGeometry;
            if (lShapeGeometry != null)
                lShapeGeometry.OnBhChanged((double)e.OldValue, (double)e.NewValue);
        }

        protected virtual void OnBhChanged(double oldValue, double newValue)
        {
            RenderGeometry(H, L, newValue, Bl);
        }
        public double Bh
        {
            get
            {
                return (double)GetValue(BhProperty);
            }
            set
            {
                SetValue(BhProperty, value);
            }
        }

        #endregion

        protected override Freezable CreateInstanceCore()
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
