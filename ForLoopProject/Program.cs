using System;

namespace ForLoopProject {
    class Program {
        static void Main(string[] args) {
            int[] ints = { 859, 941, 223, 845,
                    417, 488, 346, 700, 789, 628, 491,
                    816, 538, 962, 931, 401, 566, 810,
                    974, 122, 174, 485, 953, 335, 463
            };
            int total = 0;
            for(int idx = 0; idx<ints.Length; idx++) {
                total += ints[idx];
            }

            decimal average = total / ints.Length;
            Console.WriteLine($"Total: {total}" + 
                $" Average: {average}.");
                
        }
    }
}
