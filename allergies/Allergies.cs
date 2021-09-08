using System;
using System.Collections.Generic;
using System.Linq;

namespace AllergenSpace
{

    public enum Allergen
    {
        Eggs,
        Peanuts,
        Shellfish,
        Strawberries,
        Tomatoes,
        Chocolate,
        Pollen,
        Cats
    }

    public class Allergies
    {
        private int mask;
        private List<Allergen> allergens = new List<Allergen>();

        public Allergies(int mask)
        {
            this.mask = mask;
        }

        public bool IsAllergicTo(Allergen allergen)
        {
            List();
            return allergens.Contains(allergen);
        }

        public Allergen[] List()
        {
            mask %= 256;

            for (int i = 7; i >= 0; i--)
            {
                int divisor = (int)Math.Pow(2, i);
                int remnant = mask % divisor;
                int divide = mask / divisor;
                if (divide == 1)
                {
                    mask -= divisor;
                    allergens.Add((Allergen)i);
                }

                if (remnant == 0)
                {
                    break;
                }
            }
            allergens.Reverse();
            return allergens.ToArray();
        }
    }
}