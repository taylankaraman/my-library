class ArrayLeftShifter {

    static void main(String[] args) {

        int[] input_array = [ 1, 2, 3, 4, 5 ]
        int k = 6
        int n = input_array.size()

        // Mod the number of rotations
        k = k % n

        if(k == 0)
        {
            int[] result_array = input_array.clone()
        }
        else
        {
            int[] result_array = LeftShift(input_array, k)
        }

        println("Input Array: ")
        for(int i in input_array)
        {
            print("${i} ")
        }

        print("\n")
        print("Result Array: ")
        for (int i in result_array)
        {
            print("${i} ")
        }
    }

    // Left shift k times
    static int[] LeftShift(int[] input_array, int k)
    {
        int[] result_array = new int[input_array.size()]

        for (int i = 0; i < input_array.size(); i++)
        {
            if (i < k)
            {
                result_array[i - k + input_array.size()] = input_array[i]
            }
            else
            {
                result_array[i - k] = input_array[i]
            }
        }
        return result_array
    }
}