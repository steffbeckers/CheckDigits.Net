﻿namespace CheckDigits.Net.Iso7064;

/// <summary>
///   ISO/IEC 7064 MOD 11,10 check digit algorithm. Hybrid system algorithm with
///   modulus 10.
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
///   Will detect all single digit transcription errors, all or nearly all two 
///   digit transposition errors, all or nearly all jump transposition errors,
///   all or nearly all circular shift errors and a high proportion of double 
///   digit transcription errors (two separate single digit transcription errors
///   in the same value).
///   </para>
/// </remarks>
public class Iso7064Mod11_10Algorithm : ISingleCheckDigitAlgorithm
{
   private readonly Int32 _modulus = 10;
   private readonly Int32 _modulusPlus1 = 11;

   /// <inheritdoc/>
   public String AlgorithmDescription => Resources.Iso7064Mod11_10AlgorithmDescription;

   /// <inheritdoc/>
   public String AlgorithmName => Resources.Iso7064Mod11_10AlgorithmName;

   /// <inheritdoc/>
   public Boolean TryCalculateCheckDigit(String value, out Char checkDigit)
   {
      checkDigit = CharConstants.NUL;
      if (String.IsNullOrEmpty(value))
      {
         return false;
      }

      var product = _modulus;
      for (var index = 0; index < value.Length; index++)
      {
         var num = value[index].ToIntegerDigit();
         if (num < 0 || num > 9)
         {
            return false;
         }
         product = (product + num) % _modulus;
         if (product == 0)
         {
            product = _modulus;
         }
         product = (product * 2) % _modulusPlus1;
      }

      var x = (_modulus - product + 1) % _modulus;
      checkDigit = x == 10 ? CharConstants.DigitZero : x.ToDigitChar();

      return true;
   }

   /// <inheritdoc/>
   public Boolean Validate(String value)
   {
      if (String.IsNullOrEmpty(value) || value.Length < 2)
      {
         return false;
      }

      var product = _modulus;
      Int32 num;
      for (var index = 0; index < value.Length - 1; index++)
      {
         num = value[index].ToIntegerDigit();
         if (num < 0 || num > 9)
         {
            return false;
         }
         product = (product + num) % _modulus;
         if (product == 0)
         {
            product = _modulus;
         }
         product = (product * 2) % _modulusPlus1;
      }

      num = value[^1].ToIntegerDigit();
      if (num < 0 || num > 9)
      {
         return false;
      }

      product += num;

      return product % _modulus == 1;
   }
}
