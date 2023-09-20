class Program {

    public Program() {
    }

    public void runProgram() {
    //// Get a number input
    int num = Convert.ToInt32(getInput());
    // Check range between 1 && 10
    while (!isValidRange(num, 1, 10))
    {
        num = Convert.ToInt32(getInput());
    }

//// Get a space separated int[]

// public static TOutput[] ConvertAll<TInput,TOutput> (TInput[] array, Converter<TInput,TOutp
int[] nums = {};
// Ensure nums.Length == num
bool isValidArray = false;
while (!isValidArray) {
    nums = Array.ConvertAll(getInput().Split(" "), Convert.ToInt32);
    if (nums.Length == num) {
        isValidArray = true;
        // Check each number to be between 1 && 100 (max size of int)
        for (int i = 0; i < nums.Length; i++)
        {
            if (!isValidRange(nums[i], 1, 100))
            {
                isValidArray = false;
            }
        }
    }
}


// Print lowest number
Console.WriteLine("" + getLowestNumber(nums));


Console.ReadKey();

bool isValidRange(int num, int min, int max)
{
    if ((num >= min) && (num <= max))
    {
        return true;
    }
    return false;
}

String getInput()
{
    string? input = Console.ReadLine();
    while (String.IsNullOrEmpty(input))
    {
        input = Console.ReadLine();  // Repeat getting input until a non null is returned
    }
    return input;
}

// Function return lowest number
int getLowestNumber(int[] num_arr)
{
    // Scan through the list of numbers, and insert the lowest into a temp num
    int num_lowest = 101;
    for (int i = 0; i < num_arr.Length; i++)
    {
        if (num_arr[i] < num_lowest)
        {
            num_lowest = num_arr[i];
        }
    }
    return num_lowest;
}

    
    }}