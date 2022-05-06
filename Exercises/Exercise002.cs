using System;
namespace Exercises
{
    public class Exercise002
    {
        public bool IsFromManchester(Person person)
        {
            // Strat: Code added by Shery
            if (person.Fromlocation == "Manchester")
                    return true;
            else
                    return false;
            // End: Code added by Shery

        }

        public bool CanWatchFilm(Person person, int ageLimit)
        {
            // Strat: Code added by Shery
            if (ageLimit  < 18)
                return false;
            else
                return true;
            // End: Code added by Shery
        }
    }
}

