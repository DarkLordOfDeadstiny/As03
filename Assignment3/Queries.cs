using System.Linq;
using System.Collections.Generic;
using System;

namespace BDSA2021.Assignment03
{
    public static class Queries
    {
        public static IEnumerable<string> GetRowlingExt(this IEnumerable<Wizard> wizards)
        {
            foreach(var wizard in wizards.Where(x => x.Creator.Contains("Rowling")))
            {
                yield return wizard.Name;
            }
        }

        public static IEnumerable<string> GetRowlingLinq(this IEnumerable<Wizard> wizards)
        {
            return from w in wizards
            where w.Creator.Contains("Rowling")
            select w.Name;
        }

        public static int GetFirstSithExt(this IEnumerable<Wizard> wizards)
        {
            return wizards.Where(x => x.Name.StartsWith("Darth"))
                            .Min(x => x.Year).GetValueOrDefault();
        }

        public static int GetFirstSithLinq(this IEnumerable<Wizard> wizards)
        {
            return (from w in wizards
            where w.Name.StartsWith("Darth")
            select w.Year).Min().GetValueOrDefault();
        }

        public static IEnumerable<(string, int?)> getUniqueHarryPotterWizards(this IEnumerable<Wizard> wizards) 
        {
            return wizards.Where(x => x.Medium.StartsWith("Harry Potter")).Select(x => (x.Name, x.Year)).AsEnumerable();
        }
    }
}
