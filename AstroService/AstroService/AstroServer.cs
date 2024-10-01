using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AstroMaths;

namespace AstroService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class AstroServer : IAstroContract
    {
        public double CalculateStarVelocity(double observedWavelength, double restWavelength)
        {
            return (observedWavelength - restWavelength) / restWavelength * 299792458;
        }

        public double CalculateStarDistance(double parallaxAngle)
        {
            return 1 / parallaxAngle;
        }

        public double ConvertToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        public double CalculateEventHorizon(double blackHoleMass)
        {
            double G = 6.674 * Math.Pow(10, -11);
            double C = 299792458;
            return (2 * G * blackHoleMass) / (C * C);
        }
    }
}
