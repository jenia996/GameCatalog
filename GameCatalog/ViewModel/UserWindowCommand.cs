using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using GameCatalog.View;

namespace GameCatalog.ViewModel
{
    class UserWindowCommand : ObservableObject
    {
        private UserSettings userSettings;
        private ICommand dialogCancelCommand;
        private ICommand dialogResultCommand;
        private UserSettingsService settingsService;
        public UserSettings UserSettings
        {
            get { return userSettings; }
            set { userSettings = value; }
        }
        public ICommand DialogCancelCommand
        {
            get { return dialogCancelCommand; }
        }
        public ICommand DialogResultCommand
        {
            get { return dialogResultCommand; }
        }
        public String MinMark
        {
            get { return userSettings.minMark.ToString(); }
            set
            {
                double temp = userSettings.minMark;
                Double.TryParse(value, out temp);
                if(temp >=0 && temp <= 10)
                {
                    userSettings.minMark = temp;
                }
            }
        }

        public UserWindowCommand()
        {
            userSettings = new UserSettings() { minMark = 9.0 };
            dialogCancelCommand = new DelegateCommand<Window>(dialogClose);
            dialogResultCommand = new DelegateCommand<Window>(dialodOkResult);
            settingsService = new UserSettingsService();
        }
        private void dialodOkResult(Window window)
        {
           // settingsService.update(userSettings);
            window.DialogResult = true;
        }
        private void dialogClose(Window window)
        {
            window.Close();
        }
    }
}
