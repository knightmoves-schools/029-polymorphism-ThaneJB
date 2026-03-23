namespace knightmoves;

public class Trainer{
    public string Listen(Animal[] animals) {
        string sounds = "";

        foreach(Animal animal in animals){
            if(typeof(Cat).IsInstanceOfType(animal))
            {
                sounds += ((Cat) animal).Say() + ", ";
            } 
            else if (typeof(Dog).IsInstanceOfType(animal))
            {   
                sounds += ((Dog) animal).Say() + ", ";
            } 
            else if (typeof(Bird).IsInstanceOfType(animal))
            {
                sounds += ((Bird) animal).Say() + ", ";
            }
        }

        return sounds;
    }
}

public abstract class Animal {
    
}

public class Cat : Animal{
    public string Say() {
        return "meow";
    }
}

public class Dog : Animal{
    public string Say() {
        return "woof";
    }
}

public class Bird  : Animal{
    public string Say() {
        return "chirp";
    }
}

