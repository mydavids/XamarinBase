using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Contracts.Services;
using BusinessApp.Models;
using BusinessApp.Repositories;
using BusinessApp.Services;
using MvvmCross.Core.ViewModels;
using System.Windows.Input;
using SQLite.Net;
namespace BusinessApp.ViewModels
{
   public class RegisterViewModel : MvxViewModel
    {
        private readonly IUserService _userService;
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; RaisePropertyChanged(() => Email); }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; RaisePropertyChanged(() => Password); }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; RaisePropertyChanged(() => Name); }
        }
        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; RaisePropertyChanged(() => Surname); }
        }
        private long _phoneNumber;
        public long PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; RaisePropertyChanged(() => PhoneNumber); }
        }
        public RegisterViewModel(IUserService userService)
        {
            _userService = userService;
        }


        public void isValid()
        {
            User user = _userService.GetUserByEmail(Email);
            if (user.Password == null && user.Email == null)
            {
                User newUser = new User();
                newUser.Email = Email;
                newUser.Password = Password;
                newUser.Name = Name;
                newUser.Surname = Surname;
                newUser.PhoneNumber = PhoneNumber;
                _userService.Save(newUser);
                ShowViewModel<MainMenuViewModel>();
              //  return true;
            }
            else
            {
                ShowViewModel<RegisterViewModel>();
                // return false;
            }
    
        }

        public ICommand RegisterCommand => new MvxCommand(isValid);
        public ICommand NavBack
        {
            get
            {
                return new MvxCommand(() => Close(this));
            }
        }

    }
}
