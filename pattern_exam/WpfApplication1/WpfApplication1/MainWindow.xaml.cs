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
    }

    abstract class Figure : IFigure
    {
        MainWindow w = null;
        protected virtual int id {set; get;}
        public Figure(MainWindow window, int i)
        {
            w = window;
            id = i;
        }
        public void draw()
        {
            w.logTextBox.Text += "добавили " + Name() + " №" + id.ToString() + '\n';
        }

        public void hide()
        {
            w.logTextBox.Text += "удалили " + Name() + " №" + id.ToString() + '\n';
        }

        protected abstract string Name();
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
    }
    
}


// ivanchenko@itstep.org