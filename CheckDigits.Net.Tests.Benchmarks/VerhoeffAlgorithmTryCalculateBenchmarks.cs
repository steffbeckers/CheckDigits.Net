﻿// Ignore Spelling: Verhoeff

namespace CheckDigits.Net.Tests.Benchmarks;

[MemoryDiagnoser]
public class VerhoeffAlgorithmTryCalculateBenchmarks
{
   private static readonly VerhoeffAlgorithm _algorithm = new();

   [Params("123", "1234567", "12345678901", "123456789012345")]
   public String Value { get; set; } = String.Empty;

   [Benchmark]
   public void TryCalculateCheckDigit()
   {
      _ = _algorithm.TryCalculateCheckDigit(Value, out var checkDigit);
   }
}