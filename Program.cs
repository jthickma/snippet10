// Jackson Hickman
// Snippet 10, classes and to string usage. zoo
// MIS 411


namespace hickmansnippet10

{

    public enum Coat  // ENUM list of possible types of coats for animals - feel free to add as necessary

    {

        skin,

        fur,

        feathers,

        scales,

        exoskeleton,

        other = 100  // allows for the addition of more coat types without renumbering

    }

    public enum Habitat //wanted to use an enum for habitat because i thought it would work better.
    {
    
        forest,

        grassland,

        wetland,

        savannah,

        other = 100
        } // allows for the addition of more habitat types without renumbering

    public enum Type  // ENUM list of categories of animals - feel free to add as necessary

    {

        mammal,

        bird,

        reptile,

        insect,

        fish,

        other = 100  // allows for the addition of more animal types without renumbering

    }



    public class Animal
    {
        public Coat animalcoat;
        public Type animaltype; //using the type enum defined above for animaltype variable, same thing is done for coat and habitat variables
        public string animalName;
        public int numFeet;
        public Habitat habitat;
    
        //Default constructor taking no parameters

        public Animal()
        {


        }

 

 

 

       // Constructor2 – A constructor where all variables are assigned using parameters

        public Animal(Coat coat, Type type, string name, int feet, Habitat animalHabitat) // used the enums defined above as parameters for the constructor, in addition to the other required parameters
        {
            animalcoat = coat;
            animaltype = type;
            animalName = name;
            numFeet = feet;
            habitat = animalHabitat;
        }


        // to string method allows printing for each instance of animal class, with labels for each variable. we call this below in main program to print our output.
        public override string ToString()
        {
            return $"Animal: {animalName}, Type: {animaltype}, Coat: {animalcoat}, Feet: {numFeet}, Habitat: {habitat}";
        }
    }
    
    internal class Program // enums and animal class defined before main program
    {

        static void Main(string[] args)

        {

            //Zoo list, animals added to list using constructor2.

            List<Animal> zoo = new List<Animal>();
            zoo.Add(new Animal(Coat.fur, Type.mammal, "Lion", 4, Habitat.grassland));
            zoo.Add(new Animal(Coat.feathers, Type.bird, "Eagle", 2, Habitat.savannah)); //uh just realized that eagle doesn't really live in the forest, it kinda just lives in the sky
            zoo.Add(new Animal(Coat.scales, Type.reptile, "Crocodile", 4, Habitat.wetland));
            zoo.Add(new Animal(Coat.exoskeleton, Type.insect, "Ant", 6, Habitat.forest));
            zoo.Add(new  Animal(Coat.fur, Type.mammal, "Rottweiler", 4, Habitat.other)); //rottweilers live in the house usually, so I put other for the habitat



 

 

 

            //  For each loop cycles through the zoo list and uses to string to print out the  of each animal in the list.

            foreach (Animal animal in zoo)
            {
                Console.WriteLine(animal.ToString());
            }

        }

    }
}    



 
