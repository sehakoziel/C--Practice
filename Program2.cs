class Program2 {

    public string testy = "This is a string from Program2";
    public Program2() {
        Console.WriteLine("This is Program2");
    }

    public void runProgram() {
        // Put entire Test in here (including Funcs)
        // Get number of int (get the index)
        Console.WriteLine("Please Enter a single integer");
        int num = Convert.ToInt32(getInput());
            // Check 1 <= index <= 10
        while(!isValidRange(num, 1, 10)) {
            Console.WriteLine("Please Enter a valid integer (range 1 - 10)");
            num = Convert.ToInt32(getInput());
        }

        // Get array of numbers based on the index
        int[] nums = {};
        bool isValidNums = false;
        while(!isValidNums) {
            Console.WriteLine("Please Enter "+ num +" integers, having a space between each (range 1 - 100)");
            nums = Array.ConvertAll(getInput().Split(" "), Convert.ToInt32);
            if(num == nums.Length) {
                isValidNums = true;
                // Cycle over each nums[i], set isValidNums to false if any fail to be in range
                for(int i = 0; i < nums.Length; i++) {
                    // Check each # in range of 1 <= num[index] <= 100
                    if(!isValidRange(nums[i], 1, 100)) {
                        isValidNums = false;
                    }
                }
            }
        }

        // Get Smallest Num
        Console.WriteLine("Lowest Number is: " + getLowestNum(nums));

    // Functions
    String getInput() {
        string? input = Console.ReadLine();
        while(String.IsNullOrEmpty(input)) {
            input = Console.ReadLine();
        }
        return input;
    }

    int getLowestNum(int[] nums) {
        int smallest = 101;
        for(int i = 0; i<nums.Length; i++) {
            if(nums[i] < smallest) {
            smallest = nums[i];
            }
        }
        return smallest;
    }

    bool isValidRange(int num, int min, int max) {
        if( (num >= min) && (num <= max) ) {
            return true;
        }
        return false;
    }
    
    } // runProgram
} // Program