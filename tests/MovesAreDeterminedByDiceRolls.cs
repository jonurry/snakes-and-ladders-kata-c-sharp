using Xunit;
using SnakesLadders;

namespace SnakesLadders.UnitTests.MovingYourToken
{
  public class Game_MovesAreDeterminedByDiceRolls
  {
    private readonly Game _game;

    public Game_MovesAreDeterminedByDiceRolls()
    {
      _game = new Game();
    }

    [Fact]
    public void ItShouldRollMinimumValueOf1()
    {
      _game.RollDie();
      Assert.True(_game.Position == 2, "User did not roll a 1");
    }
  }
}