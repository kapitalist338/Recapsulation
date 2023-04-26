using System;
using System.Text;

namespace cs{
    class Program{
        public static void Main(string[] args){
            // example 1
                /*try{
                    int numOfSteps = System.Convert.ToInt32(System.Console.ReadLine());
                    walk(numOfSteps);
                } catch(FormatException) {
                    System.Console.WriteLine("Format error!");
                }

            // example 2
            try{
            float fact = System.Convert.ToSingle(System.Console.ReadLine());
            System.Console.WriteLine($"factorial of {fact} is -> {Program.factorialOf(fact)}");
                } catch(FormatException){System.Console.WriteLine("Format Exception ");}
            }*/
        }

        private static void walk(int steps){
            if(steps < 1) return;
            System.Console.WriteLine("You take a step");
            walk(steps - 1);
        }

        private static double factorialOf(float factorialNeedNumber){
            if (factorialNeedNumber == 0) return 1;
            return factorialNeedNumber * factorialOf(factorialNeedNumber - 1);
            // return (factorialNeedNumber == 0) ? 1 : factorialOf(factorialNeedNumber - 1) ;
        }
    }
}
