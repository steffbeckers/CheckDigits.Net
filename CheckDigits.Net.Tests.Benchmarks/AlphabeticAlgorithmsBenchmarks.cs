﻿#pragma warning disable IDE0022 // Use expression body for method
#pragma warning disable IDE0059 // Unnecessary assignment of a value
#pragma warning disable IDE0060 // Remove unused parameter if it is not part of shipped public API

namespace CheckDigits.Net.Tests.Benchmarks;

//[SimpleJob(RuntimeMoniker.Net70, baseline: true)]
//[SimpleJob(RuntimeMoniker.Net80)]
[MemoryDiagnoser]
public class AlphabeticAlgorithmsBenchmarks
{
   public static IEnumerable<Object[]> TryCalculateCheckDigitArguments()
   {
      yield return new Object[] { Algorithms.Iso7064Mod27_26, Algorithms.Iso7064Mod27_26.AlgorithmName, "EGR" };
      yield return new Object[] { Algorithms.Iso7064Mod27_26, Algorithms.Iso7064Mod27_26.AlgorithmName, "EGRNML" };
      yield return new Object[] { Algorithms.Iso7064Mod27_26, Algorithms.Iso7064Mod27_26.AlgorithmName, "EGRNMLJOC" };
      yield return new Object[] { Algorithms.Iso7064Mod27_26, Algorithms.Iso7064Mod27_26.AlgorithmName, "EGRNMLJOCECU" };
      yield return new Object[] { Algorithms.Iso7064Mod27_26, Algorithms.Iso7064Mod27_26.AlgorithmName, "EGRNMLJOCECUJIK" };
      yield return new Object[] { Algorithms.Iso7064Mod27_26, Algorithms.Iso7064Mod27_26.AlgorithmName, "EGRNMLJOCECUJIKNWW" };
      yield return new Object[] { Algorithms.Iso7064Mod27_26, Algorithms.Iso7064Mod27_26.AlgorithmName, "EGRNMLJOCECUJIKNWWVVO" };
   }

   public static IEnumerable<Object[]> TryCalculateCheckDigitsArguments()
   {
      yield return new Object[] { Algorithms.Iso7064Mod661_26, Algorithms.Iso7064Mod661_26.AlgorithmName, "EGR" };
      yield return new Object[] { Algorithms.Iso7064Mod661_26, Algorithms.Iso7064Mod661_26.AlgorithmName, "EGRNML" };
      yield return new Object[] { Algorithms.Iso7064Mod661_26, Algorithms.Iso7064Mod661_26.AlgorithmName, "EGRNMLJOC" };
      yield return new Object[] { Algorithms.Iso7064Mod661_26, Algorithms.Iso7064Mod661_26.AlgorithmName, "EGRNMLJOCECU" };
      yield return new Object[] { Algorithms.Iso7064Mod661_26, Algorithms.Iso7064Mod661_26.AlgorithmName, "EGRNMLJOCECUJIK" };
      yield return new Object[] { Algorithms.Iso7064Mod661_26, Algorithms.Iso7064Mod661_26.AlgorithmName, "EGRNMLJOCECUJIKNWW" };
      yield return new Object[] { Algorithms.Iso7064Mod661_26, Algorithms.Iso7064Mod661_26.AlgorithmName, "EGRNMLJOCECUJIKNWWVVO" };
   }

   public static IEnumerable<Object[]> ValidateArguments()
   {
      yield return new Object[] { Algorithms.Iso7064Mod27_26, Algorithms.Iso7064Mod27_26.AlgorithmName, "EGRS" };
      yield return new Object[] { Algorithms.Iso7064Mod27_26, Algorithms.Iso7064Mod27_26.AlgorithmName, "EGRNMLU" };
      yield return new Object[] { Algorithms.Iso7064Mod27_26, Algorithms.Iso7064Mod27_26.AlgorithmName, "EGRNMLJOCB" };
      yield return new Object[] { Algorithms.Iso7064Mod27_26, Algorithms.Iso7064Mod27_26.AlgorithmName, "EGRNMLJOCECUA" };
      yield return new Object[] { Algorithms.Iso7064Mod27_26, Algorithms.Iso7064Mod27_26.AlgorithmName, "EGRNMLJOCECUJIKA" };
      yield return new Object[] { Algorithms.Iso7064Mod27_26, Algorithms.Iso7064Mod27_26.AlgorithmName, "EGRNMLJOCECUJIKNWWY" };
      yield return new Object[] { Algorithms.Iso7064Mod27_26, Algorithms.Iso7064Mod27_26.AlgorithmName, "EGRNMLJOCECUJIKNWWVVOQ" };

      yield return new Object[] { Algorithms.Iso7064Mod661_26, Algorithms.Iso7064Mod661_26.AlgorithmName, "EGRSE" };
      yield return new Object[] { Algorithms.Iso7064Mod661_26, Algorithms.Iso7064Mod661_26.AlgorithmName, "EGRNMLDR" };
      yield return new Object[] { Algorithms.Iso7064Mod661_26, Algorithms.Iso7064Mod661_26.AlgorithmName, "EGRNMLJOCCK" };
      yield return new Object[] { Algorithms.Iso7064Mod661_26, Algorithms.Iso7064Mod661_26.AlgorithmName, "EGRNMLJOCECUZJ" };
      yield return new Object[] { Algorithms.Iso7064Mod661_26, Algorithms.Iso7064Mod661_26.AlgorithmName, "EGRNMLJOCECUJIKFQ" };
      yield return new Object[] { Algorithms.Iso7064Mod661_26, Algorithms.Iso7064Mod661_26.AlgorithmName, "EGRNMLJOCECUJIKNWWQN" };
      yield return new Object[] { Algorithms.Iso7064Mod661_26, Algorithms.Iso7064Mod661_26.AlgorithmName, "EGRNMLJOCECUJIKNWWVVORC" };
   }

   [Benchmark]
   [ArgumentsSource(nameof(TryCalculateCheckDigitArguments))]
   public void TryCalculateCheckDigit(ISingleCheckDigitAlgorithm algorithm, String name, String value)
   {
      algorithm.TryCalculateCheckDigit(value, out var checkDigit);
   }

   [Benchmark]
   [ArgumentsSource(nameof(TryCalculateCheckDigitsArguments))]
   public void TryCalculateCheckDigits(IDoubleCheckDigitAlgorithm algorithm, String name, String value)
   {
      algorithm.TryCalculateCheckDigits(value, out var first, out var second);
   }

   [Benchmark]
   [ArgumentsSource(nameof(ValidateArguments))]
   public void Validate(ICheckDigitAlgorithm algorithm, String name, String value)
   {
      algorithm.Validate(value);
   }
}
