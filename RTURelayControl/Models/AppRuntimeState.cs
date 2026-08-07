using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace RTURelayControl.Models
{
    public sealed class AppRuntimeState
    {
        public bool IsRunAsAdmin {  get; private set; }
        public DateTime StartedAt { get; private set; } = DateTime.Now;

        public AppRuntimeState() 
        {
            IsRunAsAdmin = CheckAdminRights();
        }

        /// <summary>
        /// Проверка запуска приложения от имени администратора
        /// </summary
        /// <returns>
        /// True - если приложение запущено от имени администратора
        /// </returns>
        private static bool CheckAdminRights()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }
    }
}
