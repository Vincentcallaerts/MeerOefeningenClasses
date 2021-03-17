using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeerOefeningenClasses
{
    class Meetlat
    {
        public double LengteInM { get; private set; }
        public double LengteInCm { get; private set; }
        public double LengteInKm { get; private set; }
        public double LengteInVoet { get; private set; }

        private double beginLengte;
        public Meetlat(double beginLengte)
        {
            BeginLengte = beginLengte;
        }
        public double BeginLengte
        {
            private get { return beginLengte; }
            set 
            { 
                beginLengte = value;
                LengteInM = value;
                LengteInCm = value * 100;
                LengteInKm = value / 1000;
                LengteInVoet = value * 3.2808;          
            
            }
        }
        public void ShowMeetlat() 
        {

            Console.WriteLine($"lengte in cm = {LengteInCm}");
            Console.WriteLine($"lengte in m = {LengteInM}");
            Console.WriteLine($"lengte in km = {LengteInKm}");
            Console.WriteLine($"lengte in voet = {LengteInVoet}");
        }

    }
}
