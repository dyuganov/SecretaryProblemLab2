namespace SecretaryProblem2.model.interfaces;

public interface IContenderGenerator
{
    public Queue<IContender> GenerateContenders(int amount);
}