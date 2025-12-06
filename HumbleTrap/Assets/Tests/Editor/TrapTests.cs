using NUnit.Framework;
using NSubstitute;

public class TrapTests
{
    [Test]
    public void PlayerEnteringTrap_ReducesHealthByOne()
    {
        Trap trap = new Trap();
        IPlayer player = Substitute.For<IPlayer>();
        trap.HandleCharacterEntered(player);
        Assert.AreEqual(-1, player.Health);
    }
}
