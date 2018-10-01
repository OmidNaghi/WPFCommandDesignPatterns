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
    public class UserListViewModel
    {
        private IUsersRepository _repo = new UsersRepository();

        public UserListViewModel()
        {
            if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject())) return;
            
             Users = new ObservableCollection<SecurityDataAccess.Users>(_repo.GetUsersAsync().Result);
            DeleteCommand = new RelayCommand(OnDelete,CanDelete);
        }

        private void OnDelete()
        {
            Users.Remove(SelectedUser);
        }

        private bool CanDelete()
        {
            return SelectedUser != null;
        }

        public RelayCommand DeleteCommand { get; private set; }

        public ObservableCollection<SecurityDataAccess.Users> Users { get; set; }

        private SecurityDataAccess.Users _SelectedUser;

        public SecurityDataAccess.Users SelectedUser
        {
            get
            {
                return _SelectedUser;
            }
            set
            {
                _SelectedUser = value;
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }

    }
}
