﻿namespace CheckDigits.Net.GeneralAlgorithms;

/// <summary>
///   Variation of the ISO/IEC 7064 MOD 97-10 algorithm where alphabetic 
///   characters (A-Z) are mapped to integers (10-35) before calculating the 
///   check digit. The algorithm is case insensitive and lowercase letters are 
///   mapped to their uppercase equivalent before conversion to integers.
/// </summary>
/// <remarks>
///   <para>
///   Valid characters are alphanumeric characters (0-9, A-Z).
///   </para>
///   <para>
///   Check characters calculated by the algorithm are decimal digits (0-9).
///   </para>
///   <para>
///   Assumes that the check characters (if present) are the two right-most 
///   characters in the input value.
///   </para>
/// </remarks>
public class AlphanumericMod97_10Algorithm : IDoubleCheckDigitAlgorithm
{
    private const Int32 _minimumLength = 3;
    private const Int32 _modulus = 97;
    private const Int32 _radix = 10;
    private const Int32 _reduceThreshold = Int32.MaxValue / _radix;

    /// <inheritdoc/>
    public String AlgorithmDescription => Resources.AlphanumericMod97_10AlgorithmDescription;

    /// <inheritdoc/>
    public String AlgorithmName => Resources.AlphanumericMod97_10AlgorithmName;

    /// <inheritdoc/>
    public Boolean TryCalculateCheckDigits(
      String value,
      out Char first,
      out Char second)
   {
      first = Chars.NUL;
      second = Chars.NUL;

      if (String.IsNullOrEmpty(value))
      {
         return false;
      }

      var sum = 0;
      for (var index = 0; index < value.Length; index++)
      {
         var ch = value[index];
         if (ch >= '0' && ch <= '9')
         {
            var digit = ch.ToIntegerDigit();
            sum = (sum + digit) * _radix;
         }
         else if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
         {
            var number = ch - (ch < 'a' ? 55 : 87);
            var firstDigit = number / 10;
            var secondDigit = number % 10;
            sum = (sum + firstDigit) * _radix;
            if (sum >= _reduceThreshold)
            {
               sum %= _modulus;
            }
            sum = (sum + secondDigit) * _radix;
         }
         else
         {
            return false;
         }
         if (sum >= _reduceThreshold)
         {
            sum %= _modulus;
         }
      }

      // Per ISO/IEC 7064, two character algorithms perform one final pass with
      // effective character value of zero.
      sum = sum * _radix % _modulus;

      var checkSum = _modulus - sum + 1;
      var quotient = checkSum / _radix;
      var remainder = checkSum % _radix;

      first = quotient.ToDigitChar();
      second = remainder.ToDigitChar();

      return true;
   }

   /// <inheritdoc/>
   public Boolean Validate(String value)
    {
      if (String.IsNullOrEmpty(value) || value.Length < _minimumLength)
      {
         return false;
      }

      var sum = 0;
        for (var index = 0; index < value.Length - 1; index++)
        {
            var ch = value[index];
            if (ch >= '0' && ch <= '9')
            {
                var digit = ch.ToIntegerDigit();
                sum = (sum + digit) * _radix;
            }
            else if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
            {
                var number = ch - (ch < 'a' ? 55 : 87);
                var firstDigit = number / 10;
                var secondDigit = number % 10;
                sum = (sum + firstDigit) * _radix;
                if (sum >= _reduceThreshold)
                {
                    sum %= _modulus;
                }
                sum = (sum + secondDigit) * _radix;
            }
            else
            {
                return false;
            }
            if (sum >= _reduceThreshold)
            {
                sum %= _modulus;
            }
        }

        // Add value for second check character. Check characters are always
        // digits.
        var num = value[^1].ToIntegerDigit();
        if (num < 0 || num > 9)
        {
            return false;
        }
        sum += num;

        return sum % _modulus == 1;
    }
}
