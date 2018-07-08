using System;
using System.ServiceProcess;

namespace WindowsManager.Helpers
{
    internal class WindowsUpdateHelper
    {
        private readonly ServiceController _serviceController;
        public WindowsUpdateHelper()
        {
            _serviceController = new ServiceController("wuauserv");

        }


        public bool GetWindowsUpdateServiceStatus()
        {
            _serviceController.Refresh();
            return _serviceController.Status == ServiceControllerStatus.Running;
        }

        public bool StopWindowsUpdateService()
        {
            try
            {
                _serviceController.Stop();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool StartWindowsUpdateService()
        {
            try
            {
                _serviceController.Start();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
