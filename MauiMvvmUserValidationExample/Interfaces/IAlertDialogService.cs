namespace MauiMvvmUserValidationExample.Interfaces
{
    public interface IAlertDialogService
    {
        Task ShowAlertAsync(string title, string message, string cancel = "OK");
    }
}
