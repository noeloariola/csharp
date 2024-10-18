




interface IWeapon {
    void sound();
}

class Gun : IWeapon
{
    public void sound()
    {
        Console.WriteLine("Pew! pew!");
    }
    public void reload() {
        Console.WriteLine("Gun is reloading!");
    }
}

class Canon : IWeapon 
{
    public void sound()
    {
        Console.WriteLine("Bannnnng!");
    }
    public void reload() {
        Console.WriteLine("Gun is reloading!");
    }
}

class Lazer: IWeapon
{
    public void sound()
    {
        Console.WriteLine("Zizzzzzzhh!");
    }    
    public void reload() {
        Console.WriteLine("Lazer is reloading!");
    }
}

class Bomb: IWeapon
{
    public void sound()
    {
        Console.WriteLine("Boom!");
    }    
    public void reload() {
        Console.WriteLine("Bomb is reloading!");
    }
}

// if generateWeapon use public instead of internal it will throw error message below
// Inconsistent accessibility: return type 'IWeapon' is less accessible than method 'Weapons.generateWeapon()'
// another aproach to fix the error above is by making the IWeapon interface to public.
public class Weapons {
    internal IWeapon generateWeapon() {
        Random random = new();
        int index = random.Next(1, 5);
        Console.WriteLine("Index: " + index);
        IWeapon weapon = index switch
        {
            1 => new Gun(),
            2 => new Canon(),
            3 => new Lazer(),
            _ => new Bomb()
        };
        return weapon;
    }
}


// ******************************************************************************
// USING ABSTRACT CLASS
// In this case, you’d use the abstract and override keywords in the respective code segments

abstract class Animal
{
    public abstract void Sound();
}

class Tiger : Animal
{
 public override void Sound()
 {
    Console.WriteLine("Tigers roar.");
 }
}




// ******************************************************************************
// Using a concrete parent class and want its derived classes to redefine its
// method(s), you see the use of virtual keywords in the parent class.
class Animal2
{
 public virtual void Sound()
 {
    Console.WriteLine("I make sounds.");
 }
}
class Tiger2 : Animal2
{
 public override void Sound()
 {
    Console.WriteLine("Tigers roar.");
 }
}
