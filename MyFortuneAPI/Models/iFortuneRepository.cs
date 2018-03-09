using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFortuneAPI.Models
{
    public interface IFortuneRepository
    {
        IEnumerable<Fortune> GetAllFortunes();
        Fortune GetFortuneById(int fortuneId);
        Fortune GetFortune();


    }
}
