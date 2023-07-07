using System;

namespace Pets
{
    public class PetsController : IPetsController
    {
        public List<IPet> GetPets()
        {
            return new List<IPet>
            {
                new Dog(),
                new Cat(),
                new Bird()
            };
        }

        /* Replace with factory method with Type, and IWriter */
        public void AllPetsTalkToOwner()
        {
            foreach (var pet in this.GetPets()) {
                Console.WriteLine(pet.TalkToOwner());
            }
        }
    }
}
