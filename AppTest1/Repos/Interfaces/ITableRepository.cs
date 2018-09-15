using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppTest1.Repos.Interfaces
{
    public interface ITableRepository
    {
        List<string> GetMonday();
    }
}
