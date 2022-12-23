using SecretaryProblem2.model;
using SecretaryProblem2.model.interfaces;

namespace SecretaryProblem3;


public class ContenderGeneratorTest
{
    [Test]
    public void UniqueContenders()
    {
        IContenderGenerator generator = new ContenderGenerator();
        var contenders = generator.GenerateContenders(100);
        ISet<IContender> contendersSet = new HashSet<IContender>(contenders);
        Assert.That(contenders, Has.Count.EqualTo(contenders.Count));
    }
}