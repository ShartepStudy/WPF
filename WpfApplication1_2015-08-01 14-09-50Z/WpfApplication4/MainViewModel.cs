using Microsoft.Practices.Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml;

namespace WpfApplication4
{
    class MainViewModel : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        private bool hasErrors;
        public bool HasErrors
        {
            get { return hasErrors; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public System.Collections.IEnumerable GetErrors(string propertyName)
        {
            if (hasErrors && propertyName == "Numbers")
                yield return "Ошибка!";
        }

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var propertyChanged = PropertyChanged;
            if (propertyChanged != null)
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        private void RaiseHasErrorsChanged([CallerMemberName] string propertyName = null)
        {
            var errorsChanged = ErrorsChanged;
            if (errorsChanged != null)
                errorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
        }

        public XmlDocument GetXmlDocument()
        {
            var document = new XmlDocument();
            document.LoadXml(string.Concat("<?xml version=\"1.0\" encoding=\"utf - 8\" ?>",
                @"<root>",
                    @"<item>",
                        "<item name=\"item1\">",
                        "</item>",
                        "<item name=\"item2\">",
                        "</item>",
                    @"</item>",
                    @"<item>",
                        "<item name=\"item2\">",
                        "</item>",
                        "<item name=\"item2\">",
                        "</item>",
                    @"</item>",
                @"</root>"
            ));
            return document;
        }

        private DelegateCommand command;
        public ICommand Command
        {
            get { return command; }
        }

        public MainViewModel()
        {
            command = new DelegateCommand(ExecuteCommand, () => !hasErrors);
        }

        private void ExecuteCommand()
        {
            var random = new Random();
            for (int i = 0; i < 5; i++)
            {
                numbers.Add(random.NextDouble());
            }
            hasErrors = true;
            command.RaiseCanExecuteChanged();
            //RaisePropertyChanged("HasErrors");
            RaiseHasErrorsChanged("Numbers");
        }

        private ObservableCollection<double> numbers = new ObservableCollection<double>
        {
            0.5, 0.7, 1.8, 2.2
        };
        public IReadOnlyList<double> Numbers
        {
            get { return numbers; }
        }
    }
}
