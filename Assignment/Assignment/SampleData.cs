using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment
{
    public class SampleData : ISampleData
    {
        // 1.
        public IEnumerable<string> CsvRows { get; private set; }

        IEnumerable<IPerson> ISampleData.People => throw new NotImplementedException();

        // 2.
        public IEnumerable<string> GetUniqueSortedListOfStatesGivenCsvRows()
        {
            List<string> uniqueStates = new();
            IEnumerable<string?> states = CsvRows.Select(l => (string?)l.Split(',').GetValue(7)).Distinct();
            return uniqueStates;
        }

        // 3.
        public string GetAggregateSortedListOfStatesUsingCsvRows()
            => throw new NotImplementedException();

        // 4.
        public IEnumerable<IPerson> People()
        {
            List<IPerson> people = new List<IPerson>();
            List<string[]> CsvArrayRows = CsvRows.Select(l => l.Split(',')).ToList();

            CsvArrayRows.ForEach(row =>
            {
                Address temp = new Address(row[4], row[5], row[6], row[7]);
                people.Add(new Person(row[1], row[2], temp, row[3]));
            });
            return people;
        }

        // 5.
        public IEnumerable<(string FirstName, string LastName)> FilterByEmailAddress(
            Predicate<string> filter) => throw new NotImplementedException();

        // 6.
        public string GetAggregateListOfStatesGivenPeopleCollection(
            IEnumerable<IPerson> people) => throw new NotImplementedException();

        public SampleData()
        {
            string filename = "People.csv";
            List<string> lines = File.ReadAllLines(filename).Skip(1).ToList();
            CsvRows = lines;
            //lines.Select(l => l.Split(',')).ToArray();

        }
    }
}
