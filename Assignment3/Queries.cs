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

        public static IEnumerable<(string, int?)> getUniqueHarryPotterWizardsExt(this IEnumerable<Wizard> wizards) 
        {
            return wizards.Where(x => x.Medium.StartsWith("Harry Potter")).Select(x => (x.Name, x.Year));
        }

        public static IEnumerable<(string name, int? Year)> getUniqueHarryPotterWizardsLinq(this IEnumerable<Wizard> wizards)
        {
            return from w in wizards
                   where w.Medium.StartsWith("Harry Potter")
                   select (w.Name, w.Year);
        }

        public static IEnumerable<string> getWizardsOrderedByCreatorAndNameExt(this IEnumerable<Wizard> wizards)
        {
            return wizards
                .GroupBy(w => new { w.Creator, w.Name })
                .OrderByDescending(w => w.Key.Creator)
                .ThenByDescending(w => w.Key.Name)
                .Select(w => w.Key.Name);

        }

        public static IEnumerable<string> getWizardsOrderedByCreatorAndNameLinq(this IEnumerable<Wizard> wizards)
        {
            return from w in wizards
                   group w by new { w.Creator, w.Name } into g
                   orderby g.Key.Creator descending, g.Key.Name descending
                   select g.Key.Name;

        }



    }
}
