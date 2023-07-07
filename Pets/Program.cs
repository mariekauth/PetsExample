using System;
using System.Collections.Generic;

namespace Pets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var controller = new PetsController();
            controller.AllPetsTalkToOwner();
        }
    }
}
