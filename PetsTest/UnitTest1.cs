using Pets;

namespace PetsTest;

public class UnitTest1
{
    [Fact]
    public void DogTalkToOwnerReturnsWoof()
    {
        string expected = "Woof!";
        string actual = new Dog().TalkToOwner();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CatTalkToOwnerReturnsWoof()
    {
        string expected = "Meow!";
        string actual = new Cat().TalkToOwner();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void BirdTalkToOwnerReturnsTweet()
    {
        string expected = "Tweet!";
        string actual = new Bird().TalkToOwner();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PetsGetPetsReturnsListOfPets()
    {
        var petsController = new PetsController();

        var expectedPetType0 = typeof(Dog);
        var expectedPetType1 = typeof(Cat);
        var expectedPetType2 = typeof(Bird);

        var actualPets = petsController.GetPets();

        Assert.True(actualPets[0].GetType() == expectedPetType0);
        Assert.True(actualPets[1].GetType() == expectedPetType1);
        Assert.True(actualPets[2].GetType() == expectedPetType2);
    }
}
