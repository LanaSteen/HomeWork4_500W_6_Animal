using System;
/*

6. Implement the following classes: Dog, Frog, Cat, Kitten and Tomcat. All of
them are animals (Animal). Animals are characterized by age, name and
gender.

 Each animal makes a sound (use a virtual method in the Animal
class). 

Create an array of different animals and print on the console their
name, age and the corresponding sound each one makes.*/

namespace HomeWork4_500W_6_Animal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog [] arrDog = new Dog [4];
            arrDog[0] = new Dog(2, "Jesi", "Female");
            arrDog[1] = new Dog(5, "Boob", "Male");
            arrDog[2] = new Dog(7, "Max", "Male");
            arrDog[3] = new Dog(3, "Rex", "Female");

            for (int i = 0; i < arrDog.Length; i++)
            {
                Console.WriteLine("The name is: " + arrDog[i].Name + " he/she is " + arrDog[i].Age + " years old " + "the gender is-" + arrDog[i].Gender + " ang he/she IS " + arrDog[i].Sound);
            }

            Console.WriteLine();

            Cat[] arrCat = new Cat[2];
            arrCat[0] = new Cat(2, "Miss", "Female");
            arrCat[1] = new Cat(7, "Garfild", "Male");
         

            for (int i = 0; i < arrCat.Length; i++)
            {
                Console.WriteLine("The name is: " + arrCat[i].Name + " he/she is " + arrCat[i].Age + " years old " + "the gender is-" + arrCat[i].Gender + " ang he/she IS " + arrCat[i].Sound);
            }

        }
    }
}
