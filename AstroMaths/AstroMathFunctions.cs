using System;

namespace AstroMaths
{
    /// <summary>
    /// Date : May 2022
    /// Class library used to calculate Astronomical functions
    /// </summary>
    public class AstroMathFunctions
    {
        /// <summary>
        /// Returns the velocity of a star in m/sec based on the doppler effect, it uses
        /// the rest and observed wavelength of light from star. The wave length is measured 
        /// in nanometres = 1 x 10^-9, speed of light = 3 x 10^8 m/s. If a star has 500.0 nm at rest
        /// and 500.1 nm observed then velocity is 60,000 m/s
        /// </summary>
        /// <param name="observedWaveLength">wave length of observed light from star</param>
        /// <param name="atRestWavelength">wave length of light at rest</param>
        /// <returns>Velocity in m/sec</returns>
        public double StarVelocity(double observedWaveLength, double atRestWavelength)
        {
            double c = 2.99792458 * Math.Pow(10, 8); //300000000;
            double waveDelta = (observedWaveLength - atRestWavelength);
            return c * (waveDelta/ atRestWavelength);
        }
        /// <summary>
        /// Returns the distance to a star in parsecs (3.26 light years).
        /// Barnard's Star has parallax angle of 0.547 arcseconds and has 
        /// a distance = 1.83 parsec
        /// </summary>
        /// <param name="parallaxAngle">parallex angle in arcsecs (1/3600 degrees)</param>
        /// <returns>Distance in parsecs</returns>
        public double StarDistance(double parallaxAngle)
        {
            if (parallaxAngle <= 0)
            {
                throw new ArgumentOutOfRangeException("parallaxAngle", "Parallax angle must be greater than zero.");
            }

            // 1 parsec = 1 / parallax angle in arcseconds
            double distance = 1 / parallaxAngle;
            return distance;
        }
        /// <summary>
        /// Returns the temperature in degrees Kelvin. refered to as
        /// the absolute temperature. The daily temp = 27 deg celsius
        /// which is Kelvin = 300 deg K
        /// </summary>
        /// <param name="celsius">Temperature in Celsius</param>
        /// <returns>Temperature in degrees Kelvin</returns>
        public double Kelvin(double celsius)
        {
            const double kelvinOffset = 273.15;
            if (celsius < -273.15)
            {
                throw new ArgumentOutOfRangeException("celsius", "Temperature cannot be less than absolute zero (-273.15°C).");
            }

            double kelvin = celsius + kelvinOffset;
            return kelvin;
        }
        /// <summary>
        /// Returns the balck hole event horizon in metres. This is the Schwarzschild Radius 
        /// which uses the gravitational constant G = 6.674 x 10^-11 and the 
        /// Speed of light = 2.99792458 x 10^8 m/s. Sagittarius A* has a mass of 8.2 x 10^36 kgs and
        /// the event radius = 1.21780635 x 10^10 metres
        /// </summary>
        /// <param name="blackHoleMass">mass of black hole in kgs</param>
        /// <returns>Event Horizon in meters</returns>
        public double EventHorizon(double blackHoleMass)
        {
            double M = blackHoleMass;
            double G = 6.6743 * Math.Pow(10, -11); 
            double c = 2.99792458 * Math.Pow(10, 8);
            //double c2 = Math.Pow(c, 2); 
            return (2 * G * M) / (c * c); 
        }
    }
}
