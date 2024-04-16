using MauiMvvmUserValidationExample.Interfaces;
using MauiMvvmUserValidationExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMvvmUserValidationExample.Services
{
    public class ExampleService : IExampleService
    {
        private IAlertDialogService _dialogService;

        public ExampleService(IAlertDialogService dialogService) { 
        
            _dialogService = dialogService;
        
        }

        public async void ExampleSave(Profile profile)
        {
            await _dialogService.ShowAlertAsync("Save", $"{profile.FullName} Saved", "Ok");
        }
    }
}
