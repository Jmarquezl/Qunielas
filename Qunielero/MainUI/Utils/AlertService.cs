using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quinieleros.Utils
{
    public class AlertService : IAlertService
    {
        public Task ShowAlertAsync(string title, string message, string cancel = "OK")
        {
            return Application.Current.MainPage.DisplayAlert(title, message, cancel);
        }
        public Task<bool> ShowConfirmationAsync(string title, string message, string accept = "Yes", string cancel = "No")
        {
            return Application.Current.MainPage.DisplayAlert(title, message, accept, cancel);
        }
        public void ShowAlert(string title, string message, string cancel = "OK")
        {
            Application.Current.MainPage.Dispatcher.Dispatch(async () =>
                await ShowAlertAsync(title, message, cancel)
            );
        }
        public void ShowConfirmation(string title, string message, Action<bool> callback,
                                     string accept = "Yes", string cancel = "No")
        {
            Application.Current.MainPage.Dispatcher.Dispatch(async () =>
            {
                bool answer = await ShowConfirmationAsync(title, message, accept, cancel);
                callback(answer);
            });
        }
        public Task<string> DisplayPromptAsync(string title, string question, string accept, string cancel)
        {
            return Application.Current.MainPage.DisplayPromptAsync(title, question, accept, cancel);
        }
        public void DisplayPrompt(string title, string question, string accept, string cancel, Action<string> callback)
        {
            Application.Current.MainPage.Dispatcher.Dispatch(async () =>
            {
                string result = await DisplayPromptAsync(title, question, accept, cancel);
                callback(result);
            });
        }
    }
}
