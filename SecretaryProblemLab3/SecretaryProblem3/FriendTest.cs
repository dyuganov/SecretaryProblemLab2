using SecretaryProblem2.model;

namespace SecretaryProblem3;

public class FriendTest
{
    [Test]
    public void ContendersComparison()
    {
        var first = new Contender("A", "A", 1);
        var second = new Contender("B", "B", 2);
        var friend1 = new Friend();
        friend1.RememberContender(first);
        Assert.That(friend1.CountBetterContenders(second) == 0);
        
        var friend2 = new Friend();
        friend2.RememberContender(second);
        Assert.That(friend2.CountBetterContenders(first) == 1);
    }
    
    [Test]
    public void FirstContenderTest()
    {
        var friend = new Friend();
        var first = new Contender("A", "A", 1);
        Assert.That(friend.CountBetterContenders(first) == 0);
    }
}