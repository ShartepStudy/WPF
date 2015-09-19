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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Stack<ICommand> execCommands = new Stack<ICommand>();
        private IFigure copyF = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IFigure f = new Rect(this);
            ICommand c = new DrawCommand(f);
            c.Do();
            execCommands.Push(c);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            IFigure f = new Round(this);
            ICommand c = new DrawCommand(f);
            c.Do();
            execCommands.Push(c);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            IFigure f = new Triangle(this);
            ICommand c = new DrawCommand(f);
            c.Do();
            execCommands.Push(c);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if ( execCommands.Count() > 0 )
            {
                execCommands.Pop().Undo();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            IFigure f = this.GetCheckedFigure();
            if (f != null)
            {
                ICommand c = new HideCommand(f);
                c.Do();
                execCommands.Push(c);
            }
        }

        private IFigure GetCheckedFigure()
        {
            foreach (RadioButton rb in this.screenListBox.Items)
            {
                if (rb.IsChecked == true)
                {
                    return rb as IFigure;
                }
            }
            return null;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            copyF = GetCheckedFigure();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (copyF != null)
            {
                ICommand c = new DrawCommand(copyF.getCopy());
                c.Do();
                execCommands.Push(c);
            }
        }
    }




    interface ICommand
    {
        void Do();
        void Undo();
    }

    class DrawCommand : ICommand
    {
        private IFigure r = null;
        public DrawCommand(IFigure reciever)
        {
            r = reciever;
        }
        public void Do()
        {
            r.draw();
        }

        public void Undo()
        {
            r.hide();
        }
    }

    class HideCommand : ICommand
    {
        private IFigure r = null;
        public HideCommand(IFigure reciever)
        {
            r = reciever;
        }
        public void Do()
        {
            r.hide();
        }

        public void Undo()
        {
            r.draw();
        }
    }




    interface IFigure
    {
        void draw();
        void hide();
        IFigure getCopy();
    }

    abstract class Figure : RadioButton, IFigure
    {
        public MainWindow w = null;
        protected virtual int id {set; get;}
        public Figure(MainWindow window, int i)
        {
            w = window;
            id = i;
        }
        public void draw()
        {
            w.logTextBox.Text += "добавили " + Name() + " №" + id.ToString() + '\n';
            this.Content = Name() + " №" + id.ToString();
            w.screenListBox.Items.Add(this); 
        }

        public void hide()
        {
            w.logTextBox.Text += "удалили " + Name() + " №" + id.ToString() + '\n';
            w.screenListBox.Items.Remove(this);
        }

        protected abstract string Name();
        public abstract IFigure getCopy();
    }

    class Rect : Figure
    {
        public Rect(MainWindow window) : base(window, statId++) {}
        private static int statId = 0;
        protected override int id { set; get; }
        protected override string Name()
        {
            return "квадрат";
        }

        public override IFigure getCopy()
        {
            return new Rect(w);
        }
    }
    class Round : Figure
    {
        public Round(MainWindow window) : base(window, statId++) {}
        private static int statId = 0;
        protected override int id { set; get; }
        protected override string Name()
        {
            return "круг";
        }
        public override IFigure getCopy()
        {
            return new Round(w);
        }
    }
    class Triangle : Figure
    {
        public Triangle(MainWindow window) : base(window, statId++) {}
        private static int statId = 0;
        protected override int id { set; get; }
        protected override string Name()
        {
            return "треугольник";
        }
        public override IFigure getCopy()
        {
            return new Triangle(w);
        }
    }
    
}


// ivanchenko@itstep.org