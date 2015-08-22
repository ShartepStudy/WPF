using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WpfApplication2
{
    public class ArrowShape : FrameworkElement
    {
        private ArrowVisual arrow = new ArrowVisual();
        private DrawingVisual circle = new DrawingVisual();

        // Сделать круг
        // Объявить 2 события на нажатие стрелки и круга
        // Отлавливать событие отжатия клавши и делать HitTest Visual-ам
        // Если HitTest успешен, то отправляем соответствующее событие и ставим Handled = true

        static ArrowShape()
        {
            //WidthProperty.OverrideMetadata(typeof(ArrowShape), new FrameworkPropertyMetadata(OnWidthChanged));
            //HeightProperty.OverrideMetadata(typeof(ArrowShape), new FrameworkPropertyMetadata(OnHeightChanged));
        }

        public ArrowShape()
        {
            arrow.Brush = Brushes.BlueViolet;
        }


        protected override int VisualChildrenCount
        {
            get
            {
                return 1;
            }
        }

        protected override Visual GetVisualChild(int index)
        {
            if (index == 0) return arrow;
            else throw new ArgumentOutOfRangeException(nameof(index));
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            arrow.Width = finalSize.Width;
            arrow.LineWidth = finalSize.Width / 2.0;
            arrow.Height = finalSize.Height;
            arrow.ArrowHeight = finalSize.Height / 2.0;

            using (var context = circle.RenderOpen())
            {
                // рисуем круг
            }

            return base.ArrangeOverride(finalSize);
        }

        private static void OnWidthChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            ArrowShape arrowShape = o as ArrowShape;
            ArrowVisual arrow = arrowShape.arrow;
            double newWith = (double)e.NewValue;
            arrow.Width = newWith;
            arrow.LineWidth = newWith / 2.0;
        }

        private static void OnHeightChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            ArrowShape arrowShape = o as ArrowShape;
            ArrowVisual arrow = arrowShape.arrow;
            double newHeight = (double)e.NewValue;
            arrow.Height = newHeight;
            arrow.ArrowHeight = newHeight / 2.0;
        }
    }

    public class ArrowVisual : DrawingVisual
    {
        #region Width

        public static readonly DependencyProperty WidthProperty = DependencyProperty.Register("Width", typeof(double), typeof(ArrowVisual), new FrameworkPropertyMetadata(0.0, new PropertyChangedCallback(OnWidthChanged), OnCoerceWidth));

        private static object OnCoerceWidth(DependencyObject d, object baseValue)
        {
            double value = (double)baseValue;
            ArrowVisual arrowVisual = d as ArrowVisual;
            var lineWidth = arrowVisual.LineWidth;
            if (value < lineWidth)
                return lineWidth;
            else
                return baseValue;
        }

        private static void OnWidthChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            ArrowVisual arrowVisual = o as ArrowVisual;
            if (arrowVisual != null)
                arrowVisual.OnWidthChanged((double)e.OldValue, (double)e.NewValue);
        }

        protected virtual void OnWidthChanged(double oldValue, double newValue)
        {
            DrawArrow(newValue, Height, ArrowHeight, LineWidth, Pen, Brush);
        }
        public double Width
        {
            get
            {
                return (double)GetValue(WidthProperty);
            }
            set
            {
                SetValue(WidthProperty, value);
            }
        }

        #endregion

        #region Height

        public static readonly DependencyProperty HeightProperty = DependencyProperty.Register("Height", typeof(double), typeof(ArrowVisual), new PropertyMetadata(0.0, new PropertyChangedCallback(OnHeightChanged), OnCoerceHeight));

        private static object OnCoerceHeight(DependencyObject d, object baseValue)
        {
            double value = (double)baseValue;
            ArrowVisual arrowVisual = d as ArrowVisual;
            var arrowHeight = arrowVisual.ArrowHeight;
            if (value < arrowHeight)
                return arrowHeight;
            else
                return baseValue;
        }

        private static void OnHeightChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            ArrowVisual arrowVisual = o as ArrowVisual;
            if (arrowVisual != null)
                arrowVisual.OnHeightChanged((double)e.OldValue, (double)e.NewValue);
        }

        protected virtual void OnHeightChanged(double oldValue, double newValue)
        {
            DrawArrow(Width, newValue, ArrowHeight, LineWidth, Pen, Brush);
        }
        public double Height
        {
            get
            {
                return (double)GetValue(HeightProperty);
            }
            set
            {
                SetValue(HeightProperty, value);
            }
        }

        #endregion

        #region ArrowHeight

        public static readonly DependencyProperty ArrowHeightProperty = DependencyProperty.Register("ArrowHeight", typeof(double), typeof(ArrowVisual), new PropertyMetadata(0.0, new PropertyChangedCallback(OnArrowHeightChanged), new CoerceValueCallback(OnCoerceArrowHeight)));

        private static object OnCoerceArrowHeight(DependencyObject d, object baseValue)
        {
            double value = (double)baseValue;
            ArrowVisual arrowVisual = d as ArrowVisual;
            var height = arrowVisual.Height;
            if (value > height)
                return height;
            else
                return baseValue;
        }


        private static void OnArrowHeightChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            ArrowVisual arrowVisual = o as ArrowVisual;
            if (arrowVisual != null)
                arrowVisual.OnArrowHeightChanged((double)e.OldValue, (double)e.NewValue);
        }

        protected virtual void OnArrowHeightChanged(double oldValue, double newValue)
        {
            DrawArrow(Width, Height, newValue, LineWidth, Pen, Brush);
        }
        public double ArrowHeight
        {
            get
            {
                return (double)GetValue(ArrowHeightProperty);
            }
            set
            {
                SetValue(ArrowHeightProperty, value);
            }
        }

        #endregion

        #region LineWidth

        public static readonly DependencyProperty LineWidthProperty = DependencyProperty.Register("LineWidth", typeof(double), typeof(ArrowVisual), new PropertyMetadata(0.0, new PropertyChangedCallback(OnLineWidthChanged), OnCoerceLineWidth));

        private static object OnCoerceLineWidth(DependencyObject d, object baseValue)
        {
            double value = (double)baseValue;
            ArrowVisual arrowVisual = d as ArrowVisual;
            var width = arrowVisual.Width;
            if (value > width)
                return width;
            else
                return baseValue;
        }


        private static void OnLineWidthChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            ArrowVisual arrowVisual = o as ArrowVisual;
            if (arrowVisual != null)
                arrowVisual.OnLineWidthChanged((double)e.OldValue, (double)e.NewValue);
        }

        protected virtual void OnLineWidthChanged(double oldValue, double newValue)
        {
            DrawArrow(Width, Height, ArrowHeight, newValue, Pen, Brush);
        }
        public double LineWidth
        {
            get
            {
                return (double)GetValue(LineWidthProperty);
            }
            set
            {
                SetValue(LineWidthProperty, value);
            }
        }

        #endregion

        #region Pen

        public static readonly DependencyProperty PenProperty = DependencyProperty.Register("Pen", typeof(Pen), typeof(ArrowVisual), new PropertyMetadata(null, new PropertyChangedCallback(OnPenChanged)));

        private static void OnPenChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            ArrowVisual arrowVisual = o as ArrowVisual;
            if (arrowVisual != null)
                arrowVisual.OnPenChanged((Pen)e.OldValue, (Pen)e.NewValue);
        }

        protected virtual void OnPenChanged(Pen oldValue, Pen newValue)
        {
            DrawArrow(Width, Height, ArrowHeight, LineWidth, newValue, Brush);
        }
        public Pen Pen
        {
            get
            {
                return (Pen)GetValue(PenProperty);
            }
            set
            {
                SetValue(PenProperty, value);
            }
        }

        #endregion

        #region Brush

        public static readonly DependencyProperty BrushProperty = DependencyProperty.Register("Brush", typeof(Brush), typeof(ArrowVisual), new PropertyMetadata(null, new PropertyChangedCallback(OnBrushChanged)));

        private static void OnBrushChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            ArrowVisual arrowVisual = o as ArrowVisual;
            if (arrowVisual != null)
                arrowVisual.OnBrushChanged((Brush)e.OldValue, (Brush)e.NewValue);
        }

        protected virtual void OnBrushChanged(Brush oldValue, Brush newValue)
        {
            DrawArrow(Width, Height, ArrowHeight, LineWidth, Pen, newValue);
        }
        public Brush Brush
        {
            get
            {
                return (Brush)GetValue(BrushProperty);
            }
            set
            {
                SetValue(BrushProperty, value);
            }
        }

        #endregion

        private void DrawArrow(double width, double height, double arrowHeight, double lineWidth, Pen pen, Brush brush)
        {
            using (var vcontext = RenderOpen())
            {
                var geometry = new StreamGeometry();
                using (var gcontext = geometry.Open())
                {
                    double extend = (width - lineWidth) / 2.0;

                    gcontext.BeginFigure(new Point(width / 2.0, 0.0), true, true);
                    gcontext.PolyLineTo(new Point[]
                    {
                        new Point(width, arrowHeight),
                        new Point(width - extend, arrowHeight),
                        new Point(width - extend, height),
                        new Point(extend, height),
                        new Point(extend, arrowHeight),
                        new Point(0.0, arrowHeight),
                    }, true, true);
                    gcontext.Close();
                }
                vcontext.DrawGeometry(brush, pen, geometry);
                vcontext.Close();
            }
        }
    }
}
