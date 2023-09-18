class Program3 {

    public string testy = "This is a string from Program3";
    public Program3() {
        Console.WriteLine("This is Program3");
    }

    public int getLowestNum(int[] nums) {
        int smallest = 101;
        for(int i = 0; i<nums.Length; i++) {
            if(nums[i] < smallest) {
            smallest = nums[i];
            }
        }
        return smallest;
    }
}