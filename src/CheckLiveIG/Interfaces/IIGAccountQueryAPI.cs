using CheckLiveIG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLiveIG.Interfaces
{
    public interface IIGAccountQueryAPI
    {
        IGApiQueryResult QueryInfoAccount(string accountId);
    }
}
