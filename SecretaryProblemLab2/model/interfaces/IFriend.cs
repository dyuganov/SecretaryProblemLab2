namespace SecretaryProblem2.model.interfaces;

public interface IFriend
{
    public void RememberContender(IContender contender);
    public int CountBetterContenders(IContender contender);
}