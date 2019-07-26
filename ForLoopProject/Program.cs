using System;
//practice this MORE!
namespace ForLoopProject {
    class Program {
        static void Main(string[] args) {
            int[] numbers = { 859, 941, 223, 845,
                    417, 488, 346, 700, 789, 628, 491,
                    816, 538, 962, 931, 401, 566, 810,
                    974, 122, 174, 485, 953, 335, 463
            };
            string[] names = {"Brailee", "Briana", "Greg", "Jesse",
                "Alex", "Titus", "Maggie", "Marianne","Glenn" };


            string allNames = "";
            foreach (string name in names) {
                string upperName = name.ToUpper();
                allNames += upperName;
            }
            Console.WriteLine($"The Names all together are: {allNames}");
            


            //int total = 0;

            //foreach (int Fred in numbers) {
            //    total += Fred;
        }

            //decimal average = total / (decimal)numbers.Length;
            //Console.WriteLine($"Total: {total}" +
            //$" Average: {average}.");
            //for (int idx = 0; idx < ints.Length; idx++) {
            //    total += ints[idx] * 3 / 4;
            }
        //Casting allows for more accurate data to be collected when dealing with decimals
        //this is a cast - which means treat the value like something else just for this line


    }
    