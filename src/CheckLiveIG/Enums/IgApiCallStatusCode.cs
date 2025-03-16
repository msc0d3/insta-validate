using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLiveIG.Enums
{
    public enum IgApiCallStatusCode
    {
        Success,
        Checkpoint,
        Error,
        UnknownBlockType,
        Blocked,
        LimitedSpam
    }
}
