using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Security;
using System.IO;
using System.Security.Principal;

namespace RTURelayControl.Services
{
    public sealed class WinIntegrationService
    {
        private const string RunKeyPath =
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

        //Имя параметра для автозапуска приложения
        private const string ValueName = "RTU Relay Control";

        /*
        public WinIntegrationService()
        {

        }
        */

        /// <summary>
        /// Метод проверяет наличие в реестре записи для автозагрузки приложения
        /// </summary>
        /// <returns>true - в случае наличия записи и доступа к ней</returns>
        public bool AutoStartIsEnabled()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RunKeyPath))
            {
                if (key != null && key.GetValue(ValueName, null) != null)
                        return true;
            }
            return false;
        }

        /// <summary>
        /// Метод для удаления или создания ключа в реестре для добавления
        /// приложения в автозагрузку Windows
        /// </summary>
        /// <param name="enabled">
        /// True - Если нужно добавить приложение в автозагрузку Windows
        /// False - Если нужно убрать из автозагрузки
        /// </param>
        /// <returns>True в случае успешности операции</returns>
        public bool AutoStartSetEnabled(bool enabled)
        {
            try
            {
                //Создаем или открываем раздел
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(
                    RunKeyPath, writable: true))
                {
                    //Проверка удалось ли получить или создать раздел реестра
                    if (key == null)
                    { return false; }

                    //Если enabled - true, добавляем в реестр параметр автозагрузки, иначе удаляем
                    if (enabled)
                    {
                        string commandPath = $"\"{Application.ExecutablePath}\"";
                        key.SetValue(ValueName, commandPath, RegistryValueKind.String);
                    }
                    else
                    {
                        //false - не считаем отсутствие ключа за ошибку
                        key.DeleteValue(ValueName, throwOnMissingValue: false);
                    }

                    return true;
                }
            }
            catch (UnauthorizedAccessException)
            { return false; }
            catch (SecurityException)
            { return false; }
            catch (IOException)
            { return false; }
        }

        /// <summary>
        /// Проверка запуска приложения от имени администратора
        /// </summary>
        /// <returns>
        /// True - если приложение запущено от имени администратора
        /// </returns>
        public bool CheckAdminRights()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }
    }
}
