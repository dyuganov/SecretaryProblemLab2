using System.Security.Principal;
using SecretaryProblem2.model.interfaces;

namespace SecretaryProblem2.model;

public class Princess : IPrincess
{
    private readonly IFriend _friend;
    private const int ContendersToSkip = 57;
    private uint _skippedContendersCnt = 0;
    private const int BetterContendersToSkip = 2;

    public Princess(IFriend friend)
    {
        _friend = friend;
    }
    
    // null == skip, contender == choose this 
    public IContender? MakeChoice(IContender? contender)
    {
        if (contender == null) return null;
        if (_skippedContendersCnt < ContendersToSkip)
        {
            _friend.RememberContender(contender);
            ++_skippedContendersCnt;
            return null;
        }
        return _friend.CountBetterContenders(contender) == BetterContendersToSkip ? contender : null;
    }
}