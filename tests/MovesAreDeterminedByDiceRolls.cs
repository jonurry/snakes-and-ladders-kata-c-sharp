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
      var randomDieRollerStub = new Mock<IRandomDieRoller>();
      randomDieRollerStub.Setup(rdr => rdr.RollDie()).Returns(1);
      _game = new Game(randomDieRollerStub.Object);
      _game.RollDie();
      Assert.True(_game.Position == 2, "User did not roll a 1");
    }

    [Fact]
    public void ItShouldRollMaximumValueOf6()
    {
      var randomDieRollerStub = new Mock<IRandomDieRoller>();
      randomDieRollerStub.Setup(rdr => rdr.RollDie()).Returns(6);
      _game = new Game(randomDieRollerStub.Object);
      _game.RollDie();
      Assert.True(_game.Position == 7, "User did not roll a 6");
    }

    [Fact]
    public void ItShouldRoll4_AndMove4Spaces()
    {
      var randomDieRollerStub = new Mock<IRandomDieRoller>();
      randomDieRollerStub.Setup(rdr => rdr.RollDie()).Returns(4);
      _game = new Game(randomDieRollerStub.Object);
      _game.RollDie();
      Assert.True(_game.Position == 5, "User did not roll a 4");
    }

    [Fact]
    public void ItShouldCall_RollDie_WhenRollingADie()
    {
      var randomDieRollerStub = new Mock<IRandomDieRoller>();
      _game = new Game(randomDieRollerStub.Object);
      _game.RollDie();
      randomDieRollerStub.Verify(rdr => rdr.RollDie(), "RollDie() should have been called");
    }
  }
}