using System.Collections;

namespace SecretaryProblem2.model.interfaces;

public interface IHall : IEnumerable
{
    public IContender NextContender();
}