using System;

namespace Pets{
    public class Dog : IPet
    {
        public string TalkToOwner()
        {
            return "Woof!";
        }
    }
}
