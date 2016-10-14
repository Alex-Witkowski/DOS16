using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace UwpWorkshop.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string text;
        private int count;

        public MainViewModel()
        {
            this.Text = "Hallo Open Space";
        }

        public string Text
        {
            get { return text; }
            set { this.Set(ref text, value); }
        }

        public ICommand ClickCommand => new RelayCommand(this.HandleClickCommand);

        private void HandleClickCommand()
        {
            this.count++;
            this.Text = $"Hallo {this.count}";
        }
    }
}
