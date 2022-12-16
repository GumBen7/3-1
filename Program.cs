namespace ThreeOne {
    class Program {
        static void Main(string[] args) {
            int b = System.Int32.Parse(System.Console.ReadLine());
            int number = System.Int32.Parse(System.Console.ReadLine());
            if (number == 0) {
                System.Console.WriteLine(0);
            }
            System.Text.StringBuilder SB = new System.Text.StringBuilder();
            char C;
            while (number > 1) {            
                if (number % b > 9) {
                    C = (char)(number % b + 'a' - 10);
                } 
                else {
                    C = (char)(number % b + '0');
                }
                SB.Append(C);
                number /= b;
            } 
            if (number > 0) {
                SB.Append(number);
            }
            char[] a = SB.ToString().ToCharArray();
            System.Array.Reverse(a);
            System.Console.WriteLine(a);
        }
    }
}