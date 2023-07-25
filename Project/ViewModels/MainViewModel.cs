using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp3.Command;
using WpfApp3.Model;
using WpfApp3.Views;



namespace WpfApp16.ViewModels
{
    public class MainViewModel
    {
        public ICommand? NewWindow { get; set; }


        public ObservableCollection<string> markaNames { get; set; }
        public ObservableCollection<string> modelNames { get; set; }
        public ObservableCollection<string> yearNames { get; set; }


        public MainViewModel()
        {
            markaNames = new ObservableCollection<string>
            {
             
                "Mercedes",
                "BMW",
                "Toyota",
                "Ford",
              


            };
            modelNames = new ObservableCollection<string>
            {
                "4 goz",
                "60 kuza",
                "camry",
                "transit"

            };

            yearNames = new ObservableCollection<string>
            {
                "2002",
                "2007",
                "2020",
                "2009",
            };

        }

        void ExecuteNewWindow(object? parameter)
        {
            AddView addview = new AddView();
            addview.ShowDialog();
        }
        bool CanExecuteNewWindow(object? parameter)
        {
            return true;
        }



    }
}
