using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapi.Services
{
    public class MadLibService
    {
         public string Madlib(string yourName, string mood, string food, string animal, string adjective, string item, string place, string activity)
        {
             return $"{yourName} Was feeling very {mood}. They felt like going out for {food} so went out to go get some. On the way there they were pushed by a {adjective} {animal}. Shocked they grabbed a {item} from the store nearby and threw it at the {animal} Hopefully scaring it off. Then they continued on there journey to {place} to eat {food} and {activity}.";
        }
    }
}