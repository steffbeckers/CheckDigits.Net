﻿// Ignore Spelling: Damm

namespace CheckDigits.Net.GeneralAlgorithms;

/// <summary>
///   Algorithm developed by H. Michael Damm that uses a quasigroup table 
///   instead of modulus operations.
/// </summary>
/// <remarks>
///   <para>
///   Valid characters are decimal digits (0-9).
///   </para>
///   <para>
///   Check digit calculated by the algorithm is a decimal digit (0-9).
///   </para>
///   <para>
///   Assumes that the check digit (if present) is the right-most digit in the
///   input value.
///   </para>
///   <para>
///   Will detect all single-digit transcription errors and all two digit 
///   transpositions of adjacent digits
///   </para>
/// </remarks>
public sealed class DammAlgorithm : ISingleCheckDigitAlgorithm
{
   private static readonly DammQuasigroupTable _quasigroupTable =
      DammQuasigroupTable.Instance;
   private const Int32 _validateMinLength = 2;

   /// <inheritdoc/>
   public String AlgorithmDescription => Resources.DammAlgorithmDescription;

   /// <inheritdoc/>
   public String AlgorithmName => Resources.DammAlgorithmName;

   /// <inheritdoc/>
   public Boolean TryCalculateCheckDigit(String value, out Char checkDigit)
   {
      checkDigit = Chars.NUL;
      if (String.IsNullOrEmpty(value))
      {
         return false;
      }

      var interim = 0;
      for (var index = 0; index < value.Length; index++)
      {
         var current = value![index].ToIntegerDigit();
         if (current < 0 || current > 9)
         {
               return false;
         }
         interim = _quasigroupTable[interim, current];
      }

      checkDigit = interim.ToDigitChar();
      return true;
   }

   /// <inheritdoc/>
   public Boolean Validate(String value)
   {
      if (String.IsNullOrEmpty(value) || value.Length < _validateMinLength)
      {
         return false;
      }

      var interim = 0;
      for (var index = 0; index < value.Length; index++)
      {
         var current = value![index].ToIntegerDigit();
         if (current < 0 || current > 9)
         {
            return false;
         }
         interim = _quasigroupTable[interim, current];
      }

      return interim == 0;
   }
}
