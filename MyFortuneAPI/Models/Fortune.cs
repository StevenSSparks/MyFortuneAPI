using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFortuneAPI.Models
{

    // this is the fortune object that is returned when someone called the api

    public class Fortune
    {
       public int id { get; set; }
       public string phrase { get; set; }
    }
}
