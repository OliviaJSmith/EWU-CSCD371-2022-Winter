using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment
{
    public class SampleData : ISampleData
    {
        // 1.
        public IEnumerable<string> CsvRows => File.ReadAllLines("People.csv").Skip(1).ToList();

        // 2.
        public IEnumerable<string> GetUniqueSortedListOfStatesGivenCsvRows()
            => CsvRows.Select(l => l[6]).Distinct().ToArray();

        // 3.
        public string GetAggregateSortedListOfStatesUsingCsvRows()
            => throw new NotImplementedException();
            

        // 4.
        public IEnumerable<IPerson> People =>
            CsvRows.Select(a => new Person(a.Substring(0,), a[2], new Address(a[4], a[5], a[6], a[7]), a[3]));       

        // 5.
        public IEnumerable<(string FirstName, string LastName)> FilterByEmailAddress(
            Predicate<string> filter) => throw new NotImplementedException();

        // 6.
        public string GetAggregateListOfStatesGivenPeopleCollection(
            IEnumerable<IPerson> people) => throw new NotImplementedException();

        public SampleData()
        {
            SampleData data = new SampleData();
          

        }  
    }
}
