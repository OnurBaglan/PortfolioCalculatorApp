using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalDataProvider.DTO;


public class RedDayStatusDTO
{
    public string s { get; set; }
    public List<int> date { get; set; }
    public List<string> status { get; set; }
}


