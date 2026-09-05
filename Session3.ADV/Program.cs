namespace Session3.ADV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1
            //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };
            //Console.WriteLine("Grades: " + string.Join(", ", grades));
            //Console.WriteLine($"Count: {grades.Count}");
            //Console.WriteLine($"First Grade: {grades[0]}");
            //Console.WriteLine($"Last Grade: {grades[grades.Count - 1]}");
            //Console.WriteLine("----------------------------------");
            //grades.Sort();
            //Console.WriteLine("Sorted Grades: " + string.Join(", ", grades));
            //Console.WriteLine("----------------------------------");
            //int firstAbove90 = grades.Find(g => g > 90);
            //Console.WriteLine($"First grade above 90: {firstAbove90}");
            //List<int> failingGrades = grades.FindAll(g => g < 75);
            //Console.WriteLine("Failing grades: " + string.Join(", ", failingGrades));
            //grades.RemoveAll(g => g < 75);
            //Console.WriteLine("Grades after removing failing: " + string.Join(", ", grades));
            //Console.WriteLine("----------------------------------");
            //bool has100 = grades.Contains(100);
            //Console.WriteLine($"Contains 100? {has100}");
            //List<string> formattedGrades = grades.ConvertAll(g => $"Grade: {g}");
            //Console.WriteLine("\nFormatted Grades:");
            //foreach (var item in formattedGrades)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Exercise2
            //SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>
            //{
            //        { 500, "Ahmed" },
            //        { 200, "Sara" },
            //        { 800, "Ali" },
            //        { 350, "Mona" }
            //};

            //foreach (KeyValuePair<int, string> player in leaderboard)
            //{
            //    Console.WriteLine($"{player.Key}: {player.Value}");
            //}

            //using var enumerator = leaderboard.GetEnumerator();
            //enumerator.MoveNext();
            //Console.WriteLine($"First Key: {enumerator.Current.Key}");
            //Console.WriteLine($"First Value: {enumerator.Current.Value}");

            //bool exists = leaderboard.ContainsKey(500);
            //Console.WriteLine($"Score 500 exists: {exists}");

            //bool hasPlayer = leaderboard.TryGetValue(999, out string player999);
            //Console.WriteLine($"Player with score 999: {player999 ?? "Not Found"}");

            //leaderboard.Remove(200);

            //Console.WriteLine("\nUpdated Leaderboard:");
            //foreach (var player in leaderboard)
            //{
            //    Console.WriteLine($"{player.Key}: {player.Value}");
            //}
            #endregion
        }
    }
}
