using System.Collections.Generic;

namespace AdapterDemo2
{
    public static class SectionIndexerBuilder
    {
        // builds an array of unique section headers, data must be sorted by name
        public static Java.Lang.Object[] BuildSectionHeaders(List<Movie> data)
        {
            var results = new List<string>();
            var used = new SortedSet<string>();

            foreach (var item in data)
            {
                var letter = item.Title[0].ToString();

                if (!used.Contains(letter))
                    results.Add(letter);

                used.Add(letter);
            }

            var jobjects = new Java.Lang.Object[results.Count];

            for (int i = 0; i < results.Count; i++)
            {
                jobjects[i] = results[i];
            }

            return jobjects;
        }

        // builds a map to answer: position --> section, data must be sorted by name
        public static Dictionary<int, int> BuildSectionForPositionMap(List<Movie> movies)
        {
            var results = new Dictionary<int, int>();
            var used = new SortedSet<string>();
            int section = -1;

            for (int i = 0; i < movies.Count; i++)
            {
                var letter = movies[i].Title[0].ToString();

                if (!used.Contains(letter))
                {
                    section++;
                    used.Add(letter);
                }

                results.Add(i, section);
            }

            return results;
        }

        // builds a map to answer: section --> position, data must be sorted by name
        public static Dictionary<int, int> BuildPositionForSectionMap(List<Movie> movies)
        {
            var results = new Dictionary<int, int>();
            var used = new SortedSet<string>();
            int section = -1;

            for (int i = 0; i < movies.Count; i++)
            {
                var letter = movies[i].Title[0].ToString();

                if (!used.Contains(letter))
                {
                    section++;
                    used.Add(letter);
                    results.Add(section, i);
                }
            }

            return results;
        }
    }
}