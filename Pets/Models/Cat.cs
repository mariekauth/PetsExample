using System;

namespace Pets
{
    public class Cat : IPet
    {
        public string TalkToOwner()
        {
            return "Meow!";
        }
    }
}
