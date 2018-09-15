using AppTest1.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppTest1.Repos.Repositories
{
    public class TableRepository:ITableRepository
    {
        public List<string> GetMonday()
        {
            var list = new List<string>();
            list.Add(new string("Matematyka"));
            list.Add(new string("Geografia"));
            list.Add(new string("Język Polski"));
            list.Add(new string("WF"));
            list.Add(new string("Godzina wychowawcza"));
            list.Add(new string("Przyrka"));
            list.Add(new string("Fizyka"));
            list.Add(new string("ZPT"));
            return list;
        }
    }
}
