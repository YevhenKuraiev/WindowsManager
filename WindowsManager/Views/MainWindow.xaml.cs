using System;
using WindowsManager.ViewModels;
using MahApps.Metro.Controls;

namespace WindowsManager.Views
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

    }
}
