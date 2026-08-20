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

        public AppRuntimeState(bool isRunAsAdmin) 
        {
            IsRunAsAdmin = isRunAsAdmin;
        }
    }
}
