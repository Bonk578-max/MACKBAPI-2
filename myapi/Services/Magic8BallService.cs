using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapi.Services
{
    public class Magic8BallService
    {
    public string Fortune(string Question)
    {
    
        Random rng=new Random();
        int Magic = rng.Next(0, 8);
        
        string[] answers=[
        "Signs point to no",
        "Absolutley not",
        "Possibly?",
        "Your luck isnt looking so well",
        "Positively",
        "I cant tell you now. Try again later",
        "No doubt about it",
        "Fortune is in your favor"
        ];
        return answers[Magic];
    }
    }
}