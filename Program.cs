namespace _0313
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                a = 15;
                b = 5;
                c = a/b;

                string[] names = new string[5];
                string id = names[6];

                if (b > 10)
                {
                    throw new ArithmeticException("大於10");
                }
                if (b > 10)
                {
                    throw new MyExce("大於10");
                }
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Erro");
                Console.WriteLine(ex.ToString());
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Erro");
                Console.WriteLine(ex.ToString());
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Erro");
                Console.WriteLine(ex.ToString());
            }
            catch (MyExce ex)
            {
                Console.WriteLine("Erro");
                Console.WriteLine(ex.ToString());
            }
            finally 
            {
                Console.WriteLine("無論跑甚麼都執行");
            }








        }
    }
}
