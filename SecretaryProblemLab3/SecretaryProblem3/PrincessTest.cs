using SecretaryProblem2.model;
using SecretaryProblem2.model.interfaces;

namespace SecretaryProblem3;

public class PrincessTest
{
    [Test]
    public void CorrectStrategy()
    {
        var friend = new Friend();
        var princess = new Princess(friend);
        var contenders = new Queue<Contender>(new List<Contender>
        {
            new Contender("A", "A", 100), 
            new Contender("B", "B", 99), 
            new Contender("C", "C", 98), 
            new Contender("D", "D", 97)
        });

        int contendersCount = contenders.Count;
        for (int i = 0; i < contendersCount; ++i)
        {
            var currentContender = contenders.Dequeue();
            if (princess.MakeChoice(currentContender) != null)
            {
                Assert.Equals(i, 3);
            }
            friend.RememberContender(currentContender);
        }
    }

    [Test]
    public void LastContender()
    {
        var friend = new Friend();
        var princess = new Princess(friend);
        Assert.That(null == princess.MakeChoice(null));
    }
}