using RTURelayControl.Models;
using RTURelayControl.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTURelayControl
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Загрузка Сервисов
            var winIntegrationService = new WinIntegrationService();

            //Загрузка моделей
            var appRuntimeState = new AppRuntimeState(winIntegrationService.CheckAdminRights());
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(appRuntimeState, winIntegrationService));
        }
    }
}
