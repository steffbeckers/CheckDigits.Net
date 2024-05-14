﻿namespace CheckDigits.Net.GeneralAlgorithms;

/// <summary>
///   Modulus 10 algorithm where every digit is weighted by its position in the
///   value, starting with weight 2 for the right-most non-check digit position.
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
///   Maximum length allowed is 9 characters for calculating a new check digit 
///   and 10 characters for validating a value that contains a check digit.
///   </para>
/// </remarks>
public sealed class Modulus10_2Algorithm : ISingleCheckDigitAlgorithm
{
   private const Int32 _tryCalculateMaxLength = 9;
   private const Int32 _validateMinLength = 2;
   private const Int32 _validateMaxLength = 10;

   /// <inheritdoc/>
   public String AlgorithmDescription => Resources.Modulus10_2AlgorithmDescription;

   /// <inheritdoc/>
   public String AlgorithmName => Resources.Modulus10_2AlgorithmName;

   /// <inheritdoc/>
   public Boolean TryCalculateCheckDigit(String value, out Char checkDigit)
   {
      checkDigit = Chars.NUL;
      if (String.IsNullOrEmpty(value) || value.Length > _tryCalculateMaxLength)
      {
         return false;
      }

      var s = 0;
      var t = 0;
      for (var index = 0; index < value.Length; index++)
      {
         var currentDigit = value![index].ToIntegerDigit();
         if (currentDigit < 0 || currentDigit > 9)
         {
               return false;
         }
         t += currentDigit;
         s += t;
      }
      s += t;

      var mod = s % 10;
      checkDigit = mod.ToDigitChar();

      return true;
   }

   /// <inheritdoc/>
   public Boolean Validate(String value)
   {
      if (String.IsNullOrEmpty(value) 
         || value.Length < _validateMinLength 
         || value.Length > _validateMaxLength)
      {
         return false;
      }

      var s = 0;
      var t = 0;
      for (var index = 0; index < value.Length - 1; index++)
      {
         var currentDigit = value![index].ToIntegerDigit();
         if (currentDigit < 0 || currentDigit > 9)
         {
               return false;
         }
         t += currentDigit;
         s += t;
      }
      s += t;

      var checkDigit = s % 10;

      return value[^1].ToIntegerDigit() == checkDigit;
   }
}
