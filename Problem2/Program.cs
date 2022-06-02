namespace Problem2
{
    public class Problem2
    {
        static void Main()
        {
            var result = Incrementador(1.8);

            Console.WriteLine(result);
        }

        public static dynamic Incrementador(dynamic valor)
        {
                return valor += 1;
        }
    }
}
