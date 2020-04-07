using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMQuete1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MVVMQuete1.MainWindow window = new MainWindow();
            ShopViewModel VM = new ShopViewModel();
            window.DataContext = VM;
            window.Show();
        }
    }
}
