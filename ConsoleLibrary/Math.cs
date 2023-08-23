namespace ConsoleLibrary
{
    public class Math
    {
        public static int Add(int x, int y) {
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }

        public static int Mult(int x, int y)
        {
            return x * y;
        }

        public static int Div(int x, int y)
        {
            return x / y;
        }

        public static double Inverse(double a) {
            if (a == 0) throw new DivideByZeroException("x cannot be zero");
            return 1 / a;
        }

        public static int Modulo(int a, int b) {
            
            
            return a - (a / b * b);
            
        }

        public static long Cubed(int a) {
            return a * a * a;
        }

        public static int Power(int a, int b)
        {
            var pow = 1;
            for(int i = 1; i <= b; i++)
            {
                pow *= a;
            }
            return pow;

        }




    }
}