namespace Problem1
{
  class Problem1
  {
    // takes a sequence of integers and returns a sequence of integers
    // first removes all multiples of 5 greater than 50
    // then cubes each number
    // finally, removes any resulting integer that is even
    public static IEnumerable<int> myFilter(IEnumerable<int> input)
    {
      IEnumerable<int> result;
      
      result = input.Where(x => x % 5 != 0 || x <= 50).Select(x => x * x * x).Where(x => x % 2 != 0);

      return result;

    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Random rnd = new Random(5); // important to seed with 5 for repeatability.
      var listForProblem = Enumerable.Range(1, 100).Select(i => rnd.Next() % 101); // range 0 to 100
      var answer = Problem1.myFilter(listForProblem); // answer is an IEnumerable<int>

      foreach (int i in answer)
      {
        Console.WriteLine(i);
      }
    }
  }
}
