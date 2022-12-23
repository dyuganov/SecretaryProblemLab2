using SecretaryProblem2.model;

namespace SecretaryProblem3;

public class HallTest
{
    [Test]
    public void NextContender()
    {
        var hall = new Hall(new ContenderGenerator());
        var contender1 = hall.NextContender();
        var contender2 = hall.NextContender();
        Assert.False(contender1.Equals(contender2));
    }

    [Test]
    public void LastContender()
    {
        var hall = new Hall(new ContenderGenerator());
        Contender? contender = null;
        for (int i = 0; i < Constants.ContendersNum; ++i)
        {
            hall.NextContender();
        }
        Assert.Throws<InvalidOperationException>(delegate { hall.NextContender(); });
    }

}