namespace Problem3
{
  class Problem3
  {
    // takes four sequences of numbers as follows: 1 to 15, 2 to 42 evens, 3 to 21 odds, and 5 to 105 multiples of 5
    // merges the sequences with members that adhere to the following requirements:
    // 1. any multiple of 10
    // 2. is a member of all four lists
    public static IEnumerable<int> merge(IEnumerable<int> input1, IEnumerable<int> input2, IEnumerable<int> input3, IEnumerable<int> input4)
    {
      IEnumerable<int> result;

      result = input1.Intersect(input2).Intersect(input3).Intersect(input4).Where(x => x % 10 == 0);

      return result;
    }

  }

  class Program
  {
    static void Main(string[] args)
    {
      Random rnd = new Random();

      // generates a list of integers from 1 to 15
      var list1 = Enumerable.Range(1, 15).Select(i => rnd.Next() % 16);

      // generates a list of integers from 2 to 42, only even numbers
      var list2 = Enumerable.Range(2, 42).Select(i => rnd.Next() % 43).Where(i => (i % 2 == 0));

      // generates a list of integers from 3 to 21, only odd numbers
      var list3 = Enumerable.Range(3, 21).Select(i => rnd.Next() % 22).Where(i => (i % 2 != 0));

      // generates a list of integers from 5 to 105, only multiples of 5
      var list4 = Enumerable.Range(5, 105).Select(i => rnd.Next() % 106).Where(i => (i % 5 == 0));

      var answer = Problem3.merge(list1, list2, list3, list4);

      foreach (int i in answer)
      {
        Console.WriteLine(i);
      }
    }
  }
}
