using System;
namespace Exercises
{
    public class IceCreams
    {
         //my class atrributes
        private string[] IceCreamFlavour { get; set; }
        public int IceCreamCode { get; set; }
        

        //my Constructors
        public IceCreams(string[] icecreamflavour, int icecreamcode)
        {
            IceCreamFlavour = icecreamflavour;
            IceCreamCode = icecreamcode;
         
        }
        

    }
    
}
