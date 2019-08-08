using System;

  public static class TwoFer
  {
      public static string Name(string input = null)
      {
          var you = input ?? "you";
          return $"One for {you}, one for me.";
      }
  }
