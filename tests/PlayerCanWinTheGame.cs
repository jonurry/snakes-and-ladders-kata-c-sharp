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
    }

    [Fact]
    public void TokenLandsOn100()
    {
      _game.Position = 97;
      _game.Move(3);
      Assert.True(_game.Position == 100, "Token did not land on 100");
    }

  }
}