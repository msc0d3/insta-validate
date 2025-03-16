using CheckLiveIG.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLiveIG.Models
{
    public class IGApiQueryResult : BaseIgApiCallResult
    {

    }
    public class BaseIgApiCallResult
    {
        public IgApiCallStatusCode IgStatusCode { get; set; }
    }
}
