using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Motorcycles
{
    public class SpeedMotorcycle : Motorcycle
    {
        private const double PowerMotocycleCubicCentimetres = 125;
        private const double PowerMotocycleMinHP = 50;
        private const double PowerMotocycleMaxHP = 69;
        private int horsePower;
        public SpeedMotorcycle(string model, int horsePower)
            : base(model, horsePower, PowerMotocycleCubicCentimetres)
        {

        }

        public override int HorsePower
        {
            get
            {
                return horsePower;
            }
            protected set
            {
                if (value < PowerMotocycleMinHP || value > PowerMotocycleMaxHP)
                {
                    throw new ArgumentException($"Invalid horse power: {value}.");
                }
                this.horsePower = value;
            }
        }
    }
}
