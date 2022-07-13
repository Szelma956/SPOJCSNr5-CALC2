using System;

namespace CALC2
{

    class Calc
    {
        public int[] cache = new int[10];
        public string operation;
        public int dataA;
        public int dataB;
        public string line = " ";

        public void ClearCache()
        {
            for (int i = 0; i < 10; i++)
            {

                cache[i] = 0;

            }
        }

        private void GetOrder()
        {
            line = Console.ReadLine();
            if (line != null)
            {
                string[] orders = line.Split(" ");
                operation = orders[0];
                dataA = int.Parse(orders[1]);
                dataB = int.Parse(orders[2]);
            }
        }

        private void LoadData()
        {
            cache[dataA] = dataB;
        }

        public void FollowTheOrder()
        {
            GetOrder();
            int wynik;

            if (line == null) { }
            else if (operation == "+")
            {
                wynik = cache[dataA] + cache[dataB];
                Console.WriteLine(wynik);
            }
            else if (operation == "-")
            {
                wynik = cache[dataA] - cache[dataB];
                Console.WriteLine(wynik);
            }
            else if (operation == "*")
            {
                wynik = cache[dataA] * cache[dataB];
                Console.WriteLine(wynik);
            }
            else if (operation == "/")
            {
                wynik = cache[dataA] / cache[dataB];
                Console.WriteLine(wynik);
            }
            else if (operation == "%")
            {
                wynik = cache[dataA] % cache[dataB];
                Console.WriteLine(wynik);
            }
            else if (operation == "z")
            {
                LoadData();
            }

        }

    }


class Program
{
    static void Main(string[] args)
    {
            Calc calc = new Calc();
            calc.ClearCache();

            while (calc.line != null)
            {
                calc.FollowTheOrder();
            }
        

    }
}

}
