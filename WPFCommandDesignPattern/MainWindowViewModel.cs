using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCommandDesignPattern
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            CurrentViewModel = new Users.UserListViewModel();
        }
        public object CurrentViewModel { get; set; }
    }
}
