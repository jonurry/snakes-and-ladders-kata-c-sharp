using Xunit;
using SnakesLadders;

namespace SnakesLadders.UnitTests.MovingYourToken
{
  public class Game_PlayerCanWinTheGame
  {
    private readonly Game _game;

    public Game_PlayerCanWinTheGame()
    {
      _game = new Game(97);
    }

    [Fact]
    public void TokenLandsOn100()
    {
      _game.Move(3);
      Assert.True(_game.Position == 100, "Token did not land on 100");
    }

    [Fact]
    public void GameIsWonWhenTokenLandsOn100()
    {
      _game.Move(3);
      Assert.True(_game.IsWon, "Game was not won");
    }

    [Fact]
    public void TokenOvershoots100_RollIsForfeit()
    {
      _game.Move(4);
      Assert.True(_game.Position == 97, "Roll was not forfeit");
    }

    [Fact]
    public void TokenOvershoots100_GameIsNotWon()
    {
      _game.Move(4);
      Assert.False(_game.IsWon, "Game was not lost");
    }
  }
}