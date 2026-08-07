using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTURelayControl
{
    public class SettingsData
    {
        //Программа
        public bool AutoStart { get; set; }
        //Интерфейс
        //Опрос и таймауты
        public bool AutoScan { get; set; }
        public int CyclePollInterval { get; set; }
        public int DevicePollInterval { get; set; }
        //Автоматизация

        public SettingsData Clone() 
        {
            return new SettingsData
            {
                AutoStart = AutoStart,
                AutoScan = AutoScan,
                CyclePollInterval = CyclePollInterval,
                DevicePollInterval = DevicePollInterval
            };
        }

        /// <summary>
        /// Проверка используемых параметров на правильность значений
        /// </summary>
        /// <param name="errors">
        /// Дополнительно возвращаемая переменная с списком ошибок если такие найдены
        /// </param>
        /// <returns>
        /// Возвращает параметр типа bool сообщающий о правильности введенных значений
        /// </returns>
        public bool IsValid(out List<string> errors)
        {
            errors = new List<string>();

            if(CyclePollInterval < 100)
            {
                errors.Add(Resources.ErrorMessages.LowCyclePollIntervalSet);
            }

            if (DevicePollInterval < 50)
            {
                errors.Add(Resources.ErrorMessages.LowDevicePollIntervalSet);
            }

            return errors.Count == 0;
        }
    }
}
