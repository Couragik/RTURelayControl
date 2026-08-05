using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using RTURelayControl.Properties;

namespace RTURelayControl
{
    public static class AppSettings
    {
        public static SettingsData Current {  get; private set; }

        /*
        public static string WavPath => GetString("WavPath", "");
        public static string FullWavPath;
        public static int MuteKeyNum => GetInt("MuteKeyNum", 1);
        public static bool DebugMode => GetBool("DebugMode", false);

        public static FileInfo WavFileInfo;
        public static Keys MuteKey;
        public static string WorkingPath = Directory.GetCurrentDirectory();
        */

        //public string ProgramPath = System.IO.Path.Combine(Directory.GetCurrentDirectory());
        //openFileDialogWAV.InitialDirectory = System.IO.Path.GetFullPath(CombinedPath);

        /// <summary>
        /// Загрузка настроек из файла конфигурации в AppSettings.Current
        /// </summary>
        public static void Load()
        {
            Current = new SettingsData
            {
                AutoStart = GetBool("AutoStart", false),
                AutoScan = GetBool("AutoScan", false),
                CyclePollInterval = GetInt("CyclePollInterval", 100),
                DevicePollInterval = GetInt("DevicePollInterval", 50)
            };
            
            //LoadWav();

            //SetMuteButton();
        }

        /// <summary>
        /// Сохранение в файл и применение текущих настроек
        /// </summary>
        /// <param name="settings">
        /// Экземпляр класса SettingsData
        /// </param>
        public static void SaveAndApply(SettingsData settings)
        {
            List<string> errors;

            if (!settings.IsValid(out errors))
            {
                throw new ArgumentException(
                    string.Join(Environment.NewLine, errors),
                    nameof(settings));
            }

            //Открытие файла конфигурации
            Configuration config = ConfigurationManager.OpenExeConfiguration(
                ConfigurationUserLevel.None);

            // Создаем коллекцию значений из открытой конфигурации
            KeyValueConfigurationCollection values = config.AppSettings.Settings;

            //Поочереди заносим все параметры
            SetValue(values, "AutoStart", settings.AutoStart.ToString());
            SetValue(values, "AutoScan", settings.AutoScan.ToString());
            SetValue(values, "CyclePollInterval", settings.CyclePollInterval.ToString());
            SetValue(values, "DevicePollInterval", settings.DevicePollInterval.ToString());
            //SetValue(values, "WavPath", settings.WavPath ?? "");

            //Записываем изменения и обновляем файл App.config
            config.Save(ConfigurationSaveMode.Minimal);
            ConfigurationManager.RefreshSection("appSettings");

            Current = settings.Clone();
        }
        /// <summary>
        /// Занесение в файл конфигурации параметра со значением, при отсутствии, создается 
        /// </summary>
        /// <param name="settings">
        /// Коллекция значений конфигурации для изменения
        /// </param>
        /// <param name="key">
        /// Имя ключа для поиска параметра
        /// </param>
        /// <param name="value">
        /// Вносимое значение для указанного параметра
        /// </param>
        private static void SetValue(
            KeyValueConfigurationCollection settings, 
            string key, string value)
        {
            if (settings[key] == null)
                settings.Add(key, value);
            else
                settings[key].Value = value;
        }

        /// <summary>
        /// Получение параметра типа bool c config файла с проверкой
        /// </summary>
        /// <param name="key">
        /// Имя ключа в config файле
        /// </param>
        /// <param name="defaultValue">
        /// Значение возвращаемое по умолчанию
        /// </param>
        /// <returns>
        /// Возвращает параметр типа bool из файла конфигурации
        /// </returns>
        private static bool GetBool(string key, bool defaultValue)
        {
            return bool.TryParse(ConfigurationManager.AppSettings[key], out var value)
                ? value
                : defaultValue;
        }

        /// <summary>
        /// Получение параметра типа int c config файла с проверкой
        /// </summary>
        /// <param name="key">
        /// Имя ключа в config файле
        /// </param>
        /// <param name="defaultValue">
        /// Значение возвращаемое по умолчанию
        /// </param>
        /// <returns>
        /// Возвращает параметр типа int из файла конфигурации
        /// </returns>
        private static int GetInt(string key, int defaultValue)
        {
            return int.TryParse(ConfigurationManager.AppSettings[key], out var value)
                ? value
                : defaultValue;
        }

        /// <summary>
        /// Получение параметра типа string c config файла с проверкой
        /// </summary>
        /// <param name="key">
        /// Имя ключа в config файле
        /// </param>
        /// <param name="defaultValue">
        /// Значение возвращаемое по умолчанию
        /// </param>
        /// <returns>
        /// Возвращает параметр типа string из файла конфигурации
        /// </returns>
        private static string GetString(string key, string defaultValue)
        {
            return ConfigurationManager.AppSettings[key] ?? defaultValue;
        }

        //Проверка наличия указанного файла WAV на ПК и загрузка его в плеер
        /*public static void LoadWav()
        {
            if (CheckWav(WavPath))
            {
                WavFileInfo = new FileInfo(WavPath);
                FullWavPath = System.IO.Path.GetFullPath(WavPath);
            }
            else
            {
                //WavPath = string.Empty;
                WavFileInfo = null;
            }
        }*/

        /// <summary>
        /// Задаем кнопку для отключения звука по ее номеру
        /// </summary>
        /// <param name="numKey">
        /// 0 - NumLock, 1 - CapsLock, 2 - ScrollLock
        /// </param>
        /*public static void SetMuteButton(int numKey = -1)
        {
            if (numKey == -1) numKey = MuteKeyNum;

            switch (numKey)
            {
                case 0:
                    MuteKey = Keys.NumLock;
                    break;
                case 1:
                    MuteKey = Keys.CapsLock;
                    break;
                case 2:
                    MuteKey = Keys.Scroll;
                    break;
            }
        }*/
        
        /// <summary>
        /// Проверка правильности пути и формата WAV файла
        /// </summary>
        /// <param name="filePath">
        /// Путь до WAV файла
        /// </param>
        /// <returns>
        /// Возвращает true в случае подходящего файла
        /// </returns>
        /*public static bool CheckWav(string filePath)
        {
            if (!System.IO.File.Exists(filePath)) return false;

            FileInfo fileInf = new FileInfo(filePath);

            if (fileInf.Extension == ".wav")
                return true;
            else
                return false;
        }*/
    }
}
