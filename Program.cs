// Only one compilation unit can have top-level statements.
// any code that's executed/intanceciated outside the class will throw error above


ArraysBasic arr = new ArraysBasic();
arr.initClass(); // Call the method to run your array logic

// Random random = new Random();
// string[] orderIDs = new string[5];
// // Loop through each blank orderID
// for (int i = 0; i < orderIDs.Length; i++)
// {
//     // Get a random value that equates to ASCII letters A through E
//     int prefixValue = random.Next(65, 70);
//     // Convert the random value into a char, then a string
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     // Create a random number, pad with zeroes
//     string suffix = random.Next(1, 1000).ToString("000");
//     // Combine the prefix and suffix together, then assign to current OrderID
//     orderIDs[i] = prefix + suffix;
// }
// // Print out each orderID
// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
//     Console.WriteLine($"Rand: {random.Next()}");
// }
// string strs = "4";
// int nValue;
// bool res = int.TryParse(strs, out nValue);
// Console.WriteLine("Result: " + res);
// Console.WriteLine(nValue);

// int result = 3 + 1 * 5 / 2;
// Console.WriteLine(result);

// StudentGradingApp app = new StudentGradingApp();
// BasicCodes.tupplesImp("wel", "Mid Dev");

// Message message = new Message("Hello Niga!");
// message.printMessage();


// PARENT AND CLASS INHERITANCE
// Circle circle = new Circle("shit!", 100, 400);
// circle.printAreaOfCircle();

// ArraysBasic arrs = new ArraysBasic();


List<IWeapon> weapons = new List<IWeapon>();
for (int i = 0; i < 3; i++) {
    IWeapon weapon = new Weapons().generateWeapon();
    weapons.Add(weapon);
}
foreach(IWeapon weapon in weapons) {
    weapon.sound();
}


testMethod();
void testMethod() {
    Console.WriteLine("Test method.");
}
