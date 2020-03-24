using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Motorcycles
{
    public class PowerMotorcycle : Motorcycle
    {
        private const double PowerMotocycleCubicCentimetres = 450;
        private const double PowerMotocycleMinHP = 70;
        private const double PowerMotocycleMaxHP = 100;
        private int horsePower;
        public PowerMotorcycle(string model, int horsePower)
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
                if (value < PowerMotocycleMinHP || value> PowerMotocycleMaxHP)
                {
                    throw new ArgumentException($"Invalid horse power: {value}.");
                }
                this.horsePower = value;
            }    
        }
    }
}
