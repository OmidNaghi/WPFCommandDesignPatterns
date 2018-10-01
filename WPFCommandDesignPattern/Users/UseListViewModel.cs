using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCommandDesignPattern.Services;

namespace WPFCommandDesignPattern.Users
{
    public class UseListViewModel
    {
        private IUsersRepository _repo = new UsersRepository();

        public UseListViewModel()
        {
            if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject())) return;
            
             Users = new ObservableCollection<SecurityDataAccess.Users>(_repo.GetUsersAsync().Result);
        }
        public ObservableCollection<SecurityDataAccess.Users> Users { get; set; }
    }
}
