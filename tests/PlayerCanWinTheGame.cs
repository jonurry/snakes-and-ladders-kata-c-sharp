using System;
using Xunit;
using SnakesLadders;

namespace SnakesLadders.UnitTests.MovingYourToken
{
  public class Game_PlayerCanWinTheGame
  {
    private readonly Game _game;

    public Game_PlayerCanWinTheGame()
    {
      _game = new Game();
      _game.Position = 97;
      _game.Move(3);
    }

    [Fact]
    public void TokenLandsOn100()
    {
      Assert.True(_game.Position == 100, "Token did not land on 100");
    }

    [Fact]
    public void GameIsWonWhenTokenLandsOn100()
    {
      Assert.True(_game.IsWon, "Game was not won");
    }
  }
}