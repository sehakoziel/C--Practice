class MainProgram {

public static void Main(string[] args) {
// Run Diff Programs
// Program prog = new Program();
// prog.runProgram();

Program2 prog2 = new Program2();
prog2.runProgram();
// Console.WriteLine("Prog2 String is: "+prog2.testy);


//Program3 prog3 = new Program3();
// Console.WriteLine("Prog3 String is: "+prog3.testy);
// Input
// First line contain number of integer N
// Second line contains N numbers separated by single space

// Output
// Print the minimum number in the N given integers

// Input Constraints
// 1 <= N <= 10
// 1 <= a_n <= 100

/* Working with Args 
// int num = Convert.ToInt32(args[0]);
    // * What do we do with this? who cares? it isn't in output...


// Console.WriteLine("Args length: "+args.Length);
int[] nums = Array.ConvertAll(args[1].Split(" "), Convert.ToInt32);
Console.WriteLine(getLowestNum(nums));

 // Functions
 int getLowestNum(int[] nums) {
        int smallest = 101;
        for(int i = 0; i<nums.Length; i++) {
            if(nums[i] < smallest) {
            smallest = nums[i];
            }
        }
        return smallest;
}
*/

 Console.ReadKey();
}}