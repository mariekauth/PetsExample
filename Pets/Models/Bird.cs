using System;

namespace Pets{
    public class Bird : IPet
    {
        public string TalkToOwner()
        {
            return "Tweet!";
        }
    }
}
