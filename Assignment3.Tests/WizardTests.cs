using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace BDSA2021.Assignment03.Tests
{
    public class WizardTests
    {
        [Fact]
        public void Wizards_contains_2_wizards()
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Equal(13, wizards.Count);
        }

        [Theory]
        [InlineData("Darth Vader", "Star Wars", 1977, "George Lucas")]
        [InlineData("Sauron", "The Fellowship of the Ring", 1954, "J.R.R. Tolkien")]
        public void Spot_check_wizards(string name, string medium, int year, string creator)
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Contains(wizards, w =>
                w.Name == name &&
                w.Medium == medium &&
                w.Year == year &&
                w.Creator == creator
            );
        }

        [Fact]
        public void Returns_only_wizard_names_invented_by_rowling_extension_method()
        {
            var expected = new[] {"Harry Potter", "Albus Dumbledore"};
            var result = Wizard.Wizards.Value.GetRowlingExt();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Returns_only_wizard_names_invented_by_rowling_linq_method()
        {
            var expected = new[] {"Harry Potter", "Albus Dumbledore"};
            var result = Wizard.Wizards.Value.GetRowlingLinq();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Return_the_year_the_first_sith_lord_was_introduced_extension_method()
        {
            var expected = 1977;
            var result = Wizard.Wizards.Value.GetFirstSithExt();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Return_the_year_the_first_sith_lord_was_introduced_linq_method()
        {
            var expected = 1977;
            var result = Wizard.Wizards.Value.GetFirstSithLinq();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Return_unique_wizards_from_harry_potter_extension_method()
        {
            var expected = new List<(string, int)>() {("Harry Potter", 1997), ("Albus Dumbledore", 1997)};
            var result = Wizard.Wizards.Value.getUniqueHarryPotterWizards();

            Assert.Equal(expected, result);
        }
    }
}

