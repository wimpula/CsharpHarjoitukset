using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitukset
{
    // Super/Base/Parent class definition
    class Hooman
    {
        // Define properties of Hooman ie. fields
        public string name = "Essi Esimerkki";
        public int age = 30;
        public string gender = "Emäntä";

        // Default constructor w/o arguments
        // No need to define, will be crated automatically
        public Hooman()
        {

        }

        // Method to say something
        public void SayOpininon()
        {
            Console.WriteLine("Lemmikit ovat elämän suola");
        }
    }

    // Sub/Derived/Child class inherits Hooman class
    class CatOwner : Hooman
    {
        // Define the method differently in subclass
        public new void SayOpinion()
        {
            Console.WriteLine("Kissat ovat itsenäisiä ja pitävät hiiret loitolla");
        }
    }

    class DogOwner : Hooman 
    {
        public new void SayOpinion()
        {
            Console.WriteLine("Koira on ihmisen paras ystävä");
        }
    }

    class Pet
    {
        public void Eats()
        {
            Console.WriteLine("Syö ruokaa");
        }
    }

    class Hare : Pet
    {
        public new void Eats()
        {
            Console.WriteLine("Syö porkkanoita");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            DogOwner dogOwner = new DogOwner();
            dogOwner.SayOpinion();
            CatOwner catOwner = new CatOwner();
            catOwner.SayOpinion();
            Hare hare = new Hare();
            hare.Eats();
        }
    }
}
