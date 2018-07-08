using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WindowsManager.Helpers;

namespace WindowsManager.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {
        private readonly WindowsUpdateHelper _windowsUpdateHelper;
        public bool IsRunning { get; set; }
        public ICommand UpdateServiceChangeStateCommand => new Command(UpdateServiceChangeState);

        public MainWindowViewModel()
        {
            _windowsUpdateHelper = new WindowsUpdateHelper();
            CheckUpdateService();
        }


        private void CheckUpdateService()
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    IsRunning = _windowsUpdateHelper.GetWindowsUpdateServiceStatus();
                    await Task.Delay(1000);
                }
            });
        }


        private void UpdateServiceChangeState()
        {
            if (IsRunning)
            {
                _windowsUpdateHelper.StopWindowsUpdateService();
            }
            else
            {
                _windowsUpdateHelper.StartWindowsUpdateService();
            }
        }



    }
}
