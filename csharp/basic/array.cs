
public class ArraysBasic {

    public void initClass() {
        int[] initNumbers = new int[5]; // declarations for arrays
        initNumbers[0] = 1; initNumbers[1] = 2; initNumbers[2] = 3; initNumbers[3] = 4; initNumbers[4] = 5; // initialization after declaration of arrays

        for (int i = 0; i < initNumbers.Length; i++) {
            Console.WriteLine($"Init Number: {initNumbers[i]}");
        }


        int[] numbers = { 1, 2, 3, 4, 5 }; // initialization during declaration of arrays
        int sum = 0;
        foreach (var item in numbers)
        {
            Console.WriteLine($"Numbers: {item}");
        }
        // Loop through the array and add each number to the sum
        for (int i = 0; i < numbers.Length; i++) {
            sum += numbers[i];
        }
    }

}