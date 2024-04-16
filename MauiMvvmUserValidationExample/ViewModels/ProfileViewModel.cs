using CommunityToolkit.Mvvm.Input;
using MauiAppShellMvvm.ViewModels;
using MauiMvvmUserValidationExample.Interfaces;
using MauiMvvmUserValidationExample.Models;

namespace MauiMvvmUserValidationExample.ViewModels
{
    public partial class ProfileViewModel : BaseViewModel
    {
        private IExampleService _exampleService;


        private string _emailAddress;

        public string EmailAddress
        {
            get { return _emailAddress; }
            set
            {
                _emailAddress = value;

                OnPropertyChanged();
            }
        }

        private bool _isEmailValid;

        public bool IsEmailValid
        {
            get { return _isEmailValid; }
            set
            {
                _isEmailValid = value;

                OnPropertyChanged();
            }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;

                OnPropertyChanged();
            }
        }

        private bool _isPasswordValid;

        public bool IsPasswordValid
        {
            get { return _isPasswordValid; }
            set
            {
                _isPasswordValid = value;

                OnPropertyChanged();
            }
        }

        private string _confirmedPassword;

        public string ConfirmedPassword
        {
            get { return _confirmedPassword; }
            set
            {
                _confirmedPassword = value;

                OnPropertyChanged();
            }
        }

        private bool _isConfirmedPasswordValid;

        public bool IsConfirmedPasswordValid
        {
            get { return _isConfirmedPasswordValid; }
            set
            {
                _isConfirmedPasswordValid = value;

                OnPropertyChanged();
            }
        }

        private string _fullName;

        public string FullName
        {
            get { return _fullName; }
            set
            {
                _fullName = value;

                OnPropertyChanged();
            }
        }

        private bool _isFullNameValid;

        public bool IsFullNameValid
        {
            get { return _isFullNameValid; }
            set
            {
                _isFullNameValid = value;

                OnPropertyChanged();
            }
        }

        private string _blogUrl;

        public string BlogUrl
        {
            get { return _blogUrl; }
            set
            {
                _blogUrl = value;

                OnPropertyChanged();
            }
        }

        private bool _isBlogUrlValid;

        public bool IsBlogUrlValid
        {
            get { return _isBlogUrlValid; }
            set
            {
                _isBlogUrlValid = value;

                OnPropertyChanged();
            }
        }

        public ProfileViewModel(IExampleService exampleService)
        {
            _exampleService = exampleService;
        }

        [RelayCommand]
        public void Save()
        {
            if (IsConfirmedPasswordValid && IsEmailValid && IsFullNameValid && IsPasswordValid && IsBlogUrlValid)
            {
                var profile = new Profile()
                {
                    BlogUrl = this.BlogUrl,
                    EmailAddress = this.EmailAddress,
                    FullName = this.FullName,
                    Password = this.Password
                };
                _exampleService.ExampleSave(profile);
            }
        }
    }
}
