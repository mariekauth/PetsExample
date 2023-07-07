using System;

namespace Pets
{
    public interface IPetsController {
        List<IPet> GetPets();
        void AllPetsTalkToOwner();
    }
}
