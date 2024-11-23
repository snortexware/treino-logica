public class FiboFn
{


    public List<int> Sequence { get; private set; } = new List<int>();

    public FiboFn(int x)
    {

        int a = 0, b = 1, next;


        for (int i = 2; i < x; i++)
        {


            next = a + b;
            Sequence.Add(next);
            a = b;
            b = next;



        }

    }



}


public class Square
{


    static void Main(String[] args)
    {
        Console.Write("Digite a quantidade de numeros perfeitos que precisa: ");
        string input = Console.ReadLine();

        int resultado = Int32.Parse(input);

        var square = GenerateSquares(resultado);
        FiboFn fibo = new FiboFn(10);



        foreach (int b in square)
        {
            Console.WriteLine(b);

        }

    }





    static List<int> GenerateSquares(int n)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < n; i++)
        {
            result.Add(i * i);
        }

        return result;
    }

}
