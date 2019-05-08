using System.Collections.Generic;
using TagHelperDemo.Models;

namespace TagHelperDemo.Data
{
    public interface ICountryRepository
    {
        IEnumerable<Country> Countries { get; }

        void AddCountry(Country country);
    }
}