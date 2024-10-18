

class StringInfo {
    public StringInfo() {    
        initClass();
    }

    public void initClass() {
        string name = "Wel";
        string welcomeMessage = $"Welcome {name}"; // string interpolation
        Console.WriteLine(welcomeMessage); 
    }
}