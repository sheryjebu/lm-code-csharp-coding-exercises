using System;
namespace Exercises
{
    public class Exercise003
    {

        public string[] IceCreamFlavours => new string[6] { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };

        public int IceCreamCode(string iceCreamFlavour) =>
            iceCreamFlavour == "Mint Chocolate Chip" ? 3 : (
            iceCreamFlavour == "Mango Sorbet" ? 5 : (
            iceCreamFlavour == "Raspberry Ripple" ? 1: 0
            ));
      
    }
}