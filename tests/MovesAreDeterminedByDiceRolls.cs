using Xunit;
using Moq;
using SnakesLadders;

namespace SnakesLadders.UnitTests.MovingYourToken
{
  public class Game_MovesAreDeterminedByDiceRolls
  {
    private Game _game;

    public Game_MovesAreDeterminedByDiceRolls()
    {
      //_game = new Game();
    }

    [Fact]
    public void ItShouldRollMinimumValueOf1()
    {
      var dieRollerStub = new Mock<IRandomDieRoller>();
      dieRollerStub.Setup(rdr => rdr.RollDie()).Returns(1);
      _game = new Game(dieRollerStub.Object);
      _game.RollDie();
      Assert.True(_game.Position == 2, "User did not roll a 1");
    }

    [Fact]
    public void ItShouldRollMaximumValueOf6()
    {
      var dieRollerStub = new Mock<IRandomDieRoller>();
      dieRollerStub.Setup(rdr => rdr.RollDie()).Returns(6);
      _game = new Game(dieRollerStub.Object);
      _game.RollDie();
      Assert.True(_game.Position == 7, "User did not roll a 6");
    }
  }
}