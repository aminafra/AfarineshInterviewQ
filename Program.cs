namespace AfarineshInterviewQ
{
    internal class Program
    {
        private static string check(IList<int>? numbersList, int sumOfNumbers)
        {
            for (var i = 0; i < numbersList!.Count; i++)
            {
                var firstNumber = numbersList[i];

                if (firstNumber + numbersList[numbersList.IndexOf(firstNumber) + 1] == sumOfNumbers)
                {
                    return $"index [{numbersList.IndexOf(firstNumber)}] and [{numbersList.IndexOf(firstNumber) + 1}]";
                }

                if (firstNumber == sumOfNumbers)
                {
                    return $"index [{numbersList[firstNumber]}]";
                }

                for (var j = 0; j < numbersList.Count; j++)
                {
                    var secondNumber = numbersList[j];

                    if (firstNumber != secondNumber && firstNumber + secondNumber == sumOfNumbers)
                    {
                        return $"index [{numbersList.IndexOf(firstNumber)}] = {numbersList[firstNumber]} and [{numbersList.IndexOf(secondNumber)}] = {numbersList[secondNumber]}";
                    }

                }
            }

            return "not found!";
        }


        static void Main(string[] args)
        {
            Console.WriteLine("inter numbers with space:");
            var array = Console.ReadLine();

            Console.WriteLine("inter a number:");
            var goalNumber = Convert.ToInt32(Console.ReadLine());

            var numbersList = new List<int>();

            numbersList = array?.Trim().Split(" ").ToList().Select(int.Parse).ToList();

            var result = check(numbersList, goalNumber);

            Console.WriteLine(result);
        }

    }
}