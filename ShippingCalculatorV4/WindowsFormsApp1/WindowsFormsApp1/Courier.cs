using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Courier : Company
    {
        // flags of what king of cargo the courier ships
        private bool shipsBox, shipsCrate, shipsSpecial;
        // basePrice: "standard price calculate in FrmCalculator
        // priceMultiplier: apply this multiplier to the "basePrice" to get final price
        private double basePrice, priceMultiplier;

        public Courier(string name, double basePrice, bool shipsBox, bool shipsCrate, bool shipsSpecial, double priceMultiplier) : base(name)
        {
            this.basePrice = basePrice;
            this.shipsBox = shipsBox;
            this.shipsCrate = shipsCrate;
            this.shipsSpecial = shipsSpecial;
            this.priceMultiplier = priceMultiplier;
        }

        // getters
        public bool ShipsBox { get => shipsBox; }
        public bool ShipsCrate { get => shipsCrate; }
        public bool ShipsSpecial { get => shipsSpecial; }

        public override double Price()
        {
            return basePrice * priceMultiplier;
        }

        public override string ToString()
        {
            return "Company Name: " + Name + ": " + "price: " + Price().ToString("F") + ", ships boxes : " + shipsBox + ", ships crate: " + shipsCrate +
                   ", ships others/special: " + shipsSpecial + ".";
        }
    }
}
