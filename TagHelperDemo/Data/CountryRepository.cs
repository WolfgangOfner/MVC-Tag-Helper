using System.Collections.Generic;
using TagHelperDemo.Models;

namespace TagHelperDemo.Data
{
    public class CountryRepository : ICountryRepository
    {
        private readonly List<Country> _countries = new List<Country>
        {
            new Country
            {
                Name = "Austria",
                Population = 8764003
            },
            new Country
            {
                Name = "Switzerland",
                Population = 8484130
            },
            new Country
            {
                Name = "China",
                Population = 1419294833
            }
        };

        public IEnumerable<Country> Countries => _countries;

        public void AddCountry(Country country)
        {
            _countries.Add(country);
        }
    }
}