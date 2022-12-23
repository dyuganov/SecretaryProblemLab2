using System.Collections;
using SecretaryProblem2.model.interfaces;

namespace SecretaryProblem2.model;

public class Hall : IHall
{
    private readonly Queue<IContender> _contenders;

    public Hall(IContenderGenerator contenderGenerator)
    {
        _contenders = contenderGenerator.GenerateContenders(Constants.ContendersNum);
    }

    public IContender NextContender()
    {
        return _contenders.Dequeue();
    }
    
    public IEnumerator GetEnumerator()
    {
        return GetEnumerator();
    }
}