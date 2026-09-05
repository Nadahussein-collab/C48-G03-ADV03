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
            #region Exercise3
            //Dictionary<string, string> phoneBook = new Dictionary<string, string>()
            //{
            //    { "Ahmed", "01012345678" },
            //    { "Sara", "01123456789" },
            //    { "Ali", "01234567890" },
            //    { "Mona", "01545678901" }
            //};

            //phoneBook["Omar"] = "01099988877";

            //try
            //{
            //    phoneBook.Add("Ahmed", "01000000000");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"Error using .Add(): {ex.Message}");
            //}

            //bool isAdded = phoneBook.TryAdd("Ahmed", "01000000000");
            //Console.WriteLine($"TryAdd succeeded: {isAdded}");

            //bool exists = phoneBook.ContainsKey("Kareem");
            //Console.WriteLine($"Search for Kareem: {exists}");

            //string phoneNumber = phoneBook.GetValueOrDefault("Kareem", "Not Found");
            //Console.WriteLine($"Kareem's Phone: {phoneNumber}");

            //Console.WriteLine("Keys: " + string.Join(", ", phoneBook.Keys));
            //Console.WriteLine("Values: " + string.Join(", ", phoneBook.Values));
            #endregion
            #region Exercise4
            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            //{
            //     "ahmed@test.com",
            //     "AHMED@test.com",
            //     "sara@test.com",
            //     "Sara@Test.Com"
            //};

            //Console.WriteLine($"Emails Count: {emails.Count}");
            //Console.WriteLine("Explanation: HashSet only stores unique elements. Because StringComparer.OrdinalIgnoreCase was passed, 'AHMED@test.com' is treated as identical to 'ahmed@test.com', so duplicates are ignored.\n");
            //HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            //HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };
            //HashSet<int> unionSet = new HashSet<int>(setA);
            //unionSet.UnionWith(setB);
            //Console.WriteLine("UnionWith (A ∪ B): " + string.Join(", ", unionSet));
            //HashSet<int> intersectSet = new HashSet<int>(setA);
            //intersectSet.IntersectWith(setB);
            //Console.WriteLine("IntersectWith (A ∩ B): " + string.Join(", ", intersectSet));
            //HashSet<int> exceptSet = new HashSet<int>(setA);
            //exceptSet.ExceptWith(setB);
            //Console.WriteLine("ExceptWith (A - B): " + string.Join(", ", exceptSet));
            //HashSet<int> subSet = new HashSet<int> { 1, 2 };
            //bool isSubset = subSet.IsSubsetOf(setA);
            //Console.WriteLine($"\nIs {{1, 2}} a subset of Set A? {isSubset}");
            #endregion
            #region Search of the session
            #region Sortedlist<T>
            /*Key-Value Pair Collection: It stores data as (Key, Value) pairs, just like a Dictionary.
             * Auto-Sorting: It automatically keeps the items sorted by their Keys in ascending order.
             * Array-Based: Internally, it uses two internal arrays (one for keys, one for values).
             * Key Benefit: Uses less memory than SortedDictionary, but inserting/removing items can be slower if the list is large because internal array elements have to shift.
            */
            //SortedList<int, string> students = new SortedList<int, string>();
            //students.Add(3, "Ali");
            //students.Add(1, "Ahmed");
            //students.Add(2, "Sara");
            //foreach (var student in students)
            //{
            //    Console.WriteLine($"{student.Key}: {student.Value}");
            //}
            #endregion
            #region Span<T>
            /*A High-Performance View of Memory: It lets you represent and manipulate contiguous regions of memory 
             * (like arrays, strings, or stack allocation) without copying data.
             * Zero Allocation / High Performance: Slice arrays or strings without creating new objects in heap memory.
             * Stack-Only (ref struct): Designed for extreme efficiency, avoiding Garbage Collector (GC) pressure.
            */
            //int[] numbers = { 10, 20, 30, 40, 50 };
            //Span<int> slice = numbers.AsSpan(1, 3); 
            //slice[0] = 99; 
            //Console.WriteLine(string.Join(", ", numbers));
            #endregion
            #endregion
        }
    }
}
