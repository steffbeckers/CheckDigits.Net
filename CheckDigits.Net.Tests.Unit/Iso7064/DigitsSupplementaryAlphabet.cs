﻿namespace CheckDigits.Net.Tests.Unit.Iso7064;

public class DigitsSupplementaryAlphabet : IAlphabet
{
   private const String _checkCharacters = "0123456789X";

   public Int32 CharacterToInteger(Char ch)
   {
      var num = ch.ToIntegerDigit();
      return num >= 0 && num <= 9 ? num : -1;
   }

   public Int32 CheckCharacterToInteger(Char ch)
   {
      var num = ch.ToIntegerDigit();
      return num >= 0 && num <= 9 
         ? num 
         : ch == CharConstants.UpperCaseX ? 10 : -1;
   }

   public Char IntegerToCheckCharacter(Int32 checkDigit) => _checkCharacters[checkDigit];
}
