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
    }
}
