using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPUke2_Weather_Roulette
{
    internal class Outfit
    {
        public string OutfitName;
        public string CorrectWeather;
        public string CorrectOutfitMessage;
        public string WrongOutfitMessage;

        public Outfit(string outFitName, string correctWeather, string correctOutfitMessage, string wrongOutfitMessage)
        {
            OutfitName = outFitName;
            CorrectWeather = correctWeather;
            CorrectOutfitMessage = correctOutfitMessage;
            WrongOutfitMessage = wrongOutfitMessage;
        }
    }

    
    
}
