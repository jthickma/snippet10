/*MIS 411 – Code Snippet 10
Classes and Objects (5 pts)

Skills Assessed
This assignment will focus on practicing the following programming concepts:

Create a CLASS data element based on the animal
Create a “constructor” for the CLASS and create objects in the code
Add the objects to a List or Array
Override the ToString() method
Cycle through the List/Array to print the data elements
Instructions
Copy the text below into a new program in Visual Studio.
This code should replace the code automatically generated, beginning with the Namespace command.  Note that you MAY keep your default Namespace, Program, and Main lines if desired, just be sure to remove the corresponding lines from the copied text.
Be sure to add a comment block at the top of the program providing your name and a brief description of the program.
Using the template provided, fill in the required code that will:
Create a CLASS element built around an animal
Give the CLASS variables, a default constructor (no arguments), a second constructor (all fields as arguments), and a new ToString() method that will display all the fields of the animal object in a readable format
Create a “zoo” List or Array made of the ANIMAL objects
Output all the animals in the “zoo” to the Console using the ToString() method.
Program Skeleton
Use the code below as an outline for your completed assignment.  Your task is to fill in the missing components (indicated by commented text) to create a working program that provides the demonstrated functionality and outputs described above. */

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

    public enum Habitat
    {
        savannah,
        
    }

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
        public Type animaltype;
        public string animalName;
        public int numFeet;
        public Habitat habitat;
    
    };
    // CLASS of animal, collecting all the necessary information to store for an animal entry.

                   // The animal CLASS must include the two ENUM data types created above.

                   // In addition, the CLASS should have a name, the number of feet, and a habitat, at a minimum.

    // {

 

 

        // Constructor1  - Default constructor taking no parameters

        public Animal()
        {


        }

 

 

 

       // Constructor2 – A constructor where all variables are assigned using parameters

        public Animal(Coat coat, Type type, string animalName, int feet, Habitat habitat)
        {
            animalcoat = coat;
            animaltype = type;
            animalName = name;
            numFeet = feet;
            habitat = animalHabitat;
        }

 

 

        // ToString() method

        // Include labels for the type of data being output.  For example:  an output may include 'Name:  Lion'.

 

 

 

    }

 

    internal class Program

    {

        static void Main(string[] args)

        {

            //  Create a "zoo" list or array and populate it with at least 5 animals.

 

 

 

            //  Using the new ToString() method, cycle through the list/array of animals and print all the fields of the animal in a concise, organized layout.

 

 

        }

    }



 