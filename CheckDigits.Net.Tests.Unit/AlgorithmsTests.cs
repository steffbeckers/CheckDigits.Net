﻿// Ignore Spelling: Aba Cusip Damm Figi Iban Icao Isan Isin Luhn Ncd Nhs Npi Rtn Sedol Verhoeff

namespace CheckDigits.Net.Tests.Unit;

public class AlgorithmsTests
{
   #region AbaRtn Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_AbaRtn_ShouldNotBeNull()
      => Algorithms.AbaRtn.Should().NotBeNull();

   [Fact]
   public void Algorithms_AbaRtn_ShouldBeExpectedType()
      => Algorithms.AbaRtn.Should().BeOfType<AbaRtnAlgorithm>();

   #endregion

   #region AlphanumericMod97_10 Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_AlphanumericMod97_10_ShouldNotBeNull()
      => Algorithms.AlphanumericMod97_10.Should().NotBeNull();

   [Fact]
   public void Algorithms_AlphanumericMod97_10_ShouldBeExpectedType()
      => Algorithms.AlphanumericMod97_10.Should().BeOfType<AlphanumericMod97_10Algorithm>();

   #endregion

   #region Cusip Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Cusip_ShouldNotBeNull()
      => Algorithms.Cusip.Should().NotBeNull();

   [Fact]
   public void Algorithms_Cusip_ShouldBeExpectedType()
      => Algorithms.Cusip.Should().BeOfType<CusipAlgorithm>();

   #endregion

   #region Damm Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Damm_ShouldNotBeNull()
      => Algorithms.Damm.Should().NotBeNull();

   [Fact]
   public void Algorithms_Damm_ShouldBeExpectedType()
      => Algorithms.Damm.Should().BeOfType<DammAlgorithm>();

   #endregion

   #region Figi Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Figi_ShouldNotBeNull()
      => Algorithms.Figi.Should().NotBeNull();

   [Fact]
   public void Algorithms_Figi_ShouldBeExpectedType()
      => Algorithms.Figi.Should().BeOfType<FigiAlgorithm>();

   #endregion

   #region Iban Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Iban_ShouldNotBeNull()
      => Algorithms.Iban.Should().NotBeNull();

   [Fact]
   public void Algorithms_Iban_ShouldBeExpectedType()
      => Algorithms.Iban.Should().BeOfType<IbanAlgorithm>();

   #endregion

   #region Icao9303 Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Icao9303_ShouldNotBeNull()
      => Algorithms.Icao9303.Should().NotBeNull();

   [Fact]
   public void Algorithms_Icao9303_ShouldBeExpectedType()
      => Algorithms.Icao9303.Should().BeOfType<Icao9303Algorithm>();

   #endregion

   #region Icao9303MachineReadableVisa Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Icao9303MachineReadableVisa_ShouldNotBeNull()
      => Algorithms.Icao9303MachineReadableVisa.Should().NotBeNull();

   [Fact]
   public void Algorithms_Icao9303MachineReadableVisa_ShouldBeExpectedType()
      => Algorithms.Icao9303MachineReadableVisa.Should().BeOfType<Icao9303MachineReadableVisaAlgorithm>();

   #endregion

   #region Icao9303SizeTD1 Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Icao9303SizeTD1_ShouldNotBeNull()
      => Algorithms.Icao9303SizeTD1.Should().NotBeNull();

   [Fact]
   public void Algorithms_Icao9303SizeTD1_ShouldBeExpectedType()
      => Algorithms.Icao9303SizeTD1.Should().BeOfType<Icao9303SizeTD1Algorithm>();

   #endregion

   #region Icao9303SizeTD2 Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Icao9303SizeTD2_ShouldNotBeNull()
      => Algorithms.Icao9303SizeTD2.Should().NotBeNull();

   [Fact]
   public void Algorithms_Icao9303SizeTD2_ShouldBeExpectedType()
      => Algorithms.Icao9303SizeTD2.Should().BeOfType<Icao9303SizeTD2Algorithm>();

   #endregion

   #region Icao9303SizeTD3 Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Icao9303SizeTD3_ShouldNotBeNull()
      => Algorithms.Icao9303SizeTD3.Should().NotBeNull();

   [Fact]
   public void Algorithms_Icao9303SizeTD3_ShouldBeExpectedType()
      => Algorithms.Icao9303SizeTD3.Should().BeOfType<Icao9303SizeTD3Algorithm>();

   #endregion

   #region Isan Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Isan_ShouldNotBeNull()
      => Algorithms.Isan.Should().NotBeNull();

   [Fact]
   public void Algorithms_Isan_ShouldBeExpectedType()
      => Algorithms.Isan.Should().BeOfType<IsanAlgorithm>();

   #endregion

   #region Isin Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Isin_ShouldNotBeNull()
      => Algorithms.Isin.Should().NotBeNull();

   [Fact]
   public void Algorithms_Isin_ShouldBeExpectedType()
      => Algorithms.Isin.Should().BeOfType<IsinAlgorithm>();

   #endregion

   #region Iso6346 Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Iso6346_ShouldNotBeNull()
      => Algorithms.Iso6346.Should().NotBeNull();

   [Fact]
   public void Algorithms_Iso6346_ShouldBeExpectedType()
      => Algorithms.Iso6346.Should().BeOfType<Iso6346Algorithm>();

   #endregion

   #region Iso7064Mod11_10 Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Iso7064Mod11_10_ShouldNotBeNull()
      => Algorithms.Iso7064Mod11_10.Should().NotBeNull();

   [Fact]
   public void Algorithms_Iso7064Mod11_10_ShouldBeExpectedType()
      => Algorithms.Iso7064Mod11_10.Should().BeOfType<Iso7064Mod11_10Algorithm>();

   #endregion

   #region Iso7064Mod11_2 Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Iso7064Mod11_2_ShouldNotBeNull()
      => Algorithms.Iso7064Mod11_2.Should().NotBeNull();

   [Fact]
   public void Algorithms_Iso7064Mod11_2_ShouldBeExpectedType()
      => Algorithms.Iso7064Mod11_2.Should().BeOfType<Iso7064Mod11_2Algorithm>();

   #endregion

   #region Iso7064Mod1271_36 Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Iso7064Mod1271_36_ShouldNotBeNull()
      => Algorithms.Iso7064Mod1271_36.Should().NotBeNull();

   [Fact]
   public void Algorithms_Iso7064Mod1271_36_ShouldBeExpectedType()
      => Algorithms.Iso7064Mod1271_36.Should().BeOfType<Iso7064Mod1271_36Algorithm>();

   #endregion

   #region Iso7064Mod27_26 Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Iso7064Mod27_26_ShouldNotBeNull()
      => Algorithms.Iso7064Mod27_26.Should().NotBeNull();

   [Fact]
   public void Algorithms_Iso7064Mod27_26_ShouldBeExpectedType()
      => Algorithms.Iso7064Mod27_26.Should().BeOfType<Iso7064Mod27_26Algorithm>();

   #endregion

   #region Iso7064Mod37_2 Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Iso7064Mod37_2_ShouldNotBeNull()
      => Algorithms.Iso7064Mod37_2.Should().NotBeNull();

   [Fact]
   public void Algorithms_Iso7064Mod37_2_ShouldBeExpectedType()
      => Algorithms.Iso7064Mod37_2.Should().BeOfType<Iso7064Mod37_2Algorithm>();

   #endregion

   #region Iso7064Mod37_36 Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Iso7064Mod37_36_ShouldNotBeNull()
      => Algorithms.Iso7064Mod37_36.Should().NotBeNull();

   [Fact]
   public void Algorithms_Iso7064Mod37_36_ShouldBeExpectedType()
      => Algorithms.Iso7064Mod37_36.Should().BeOfType<Iso7064Mod37_36Algorithm>();

   #endregion

   #region Iso7064Mod661_26 Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Iso7064Mod661_26_ShouldNotBeNull()
      => Algorithms.Iso7064Mod661_26.Should().NotBeNull();

   [Fact]
   public void Algorithms_Iso7064Mod661_26_ShouldBeExpectedType()
      => Algorithms.Iso7064Mod661_26.Should().BeOfType<Iso7064Mod661_26Algorithm>();

   #endregion

   #region Iso7064Mod97_10 Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Iso7064Mod97_10_ShouldNotBeNull()
      => Algorithms.Iso7064Mod97_10.Should().NotBeNull();

   [Fact]
   public void Algorithms_Iso7064Mod97_10_ShouldBeExpectedType()
      => Algorithms.Iso7064Mod97_10.Should().BeOfType<Iso7064Mod97_10Algorithm>();

   #endregion

   #region Luhn Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Luhn_ShouldNotBeNull()
      => Algorithms.Luhn.Should().NotBeNull();

   [Fact]
   public void Algorithms_Luhn_ShouldBeExpectedType()
      => Algorithms.Luhn.Should().BeOfType<LuhnAlgorithm>();

   #endregion

   #region Modulus10_1 Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Modulus10_1_ShouldNotBeNull()
      => Algorithms.Modulus10_1.Should().NotBeNull();

   [Fact]
   public void Algorithms_Modulus10_1_ShouldBeExpectedType()
      => Algorithms.Modulus10_1.Should().BeOfType<Modulus10_1Algorithm>();

   #endregion

   #region Modulus10_2 Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Modulus10_2_ShouldNotBeNull()
      => Algorithms.Modulus10_2.Should().NotBeNull();

   [Fact]
   public void Algorithms_Modulus10_2_ShouldBeExpectedType()
      => Algorithms.Modulus10_2.Should().BeOfType<Modulus10_2Algorithm>();

   #endregion

   #region Modulus10_13 Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Modulus10_13_ShouldNotBeNull()
      => Algorithms.Modulus10_13.Should().NotBeNull();

   [Fact]
   public void Algorithms_Modulus10_13_ShouldBeExpectedType()
      => Algorithms.Modulus10_13.Should().BeOfType<Modulus10_13Algorithm>();

   #endregion

   #region Modulus11 Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Modulus11_ShouldNotBeNull()
      => Algorithms.Modulus11.Should().NotBeNull();

   [Fact]
   public void Algorithms_Modulus11_ShouldBeExpectedType()
      => Algorithms.Modulus11.Should().BeOfType<Modulus11Algorithm>();

   #endregion

   #region Ncd Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Ncd_ShouldNotBeNull()
      => Algorithms.Ncd.Should().NotBeNull();

   [Fact]
   public void Algorithms_Ncd_ShouldBeExpectedType()
      => Algorithms.Ncd.Should().BeOfType<NcdAlgorithm>();

   #endregion

   #region Nhs Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Nhs_ShouldNotBeNull()
      => Algorithms.Nhs.Should().NotBeNull();

   [Fact]
   public void Algorithms_Nhs_ShouldBeExpectedType()
      => Algorithms.Nhs.Should().BeOfType<NhsAlgorithm>();

   #endregion

   #region Npi Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Npi_ShouldNotBeNull()
      => Algorithms.Npi.Should().NotBeNull();

   [Fact]
   public void Algorithms_Npi_ShouldBeExpectedType()
      => Algorithms.Npi.Should().BeOfType<NpiAlgorithm>();

   #endregion

   #region Sedol Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Sedol_ShouldNotBeNull()
      => Algorithms.Sedol.Should().NotBeNull();

   [Fact]
   public void Algorithms_Sedol_ShouldBeExpectedType()
      => Algorithms.Sedol.Should().BeOfType<SedolAlgorithm>();

   #endregion

   #region Verhoeff Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Verhoeff_ShouldNotBeNull()
      => Algorithms.Verhoeff.Should().NotBeNull();

   [Fact]
   public void Algorithms_Verhoeff_ShouldBeExpectedType()
      => Algorithms.Verhoeff.Should().BeOfType<VerhoeffAlgorithm>();

   #endregion

   #region Vin Property Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void Algorithms_Vin_ShouldNotBeNull()
      => Algorithms.Vin.Should().NotBeNull();

   [Fact]
   public void Algorithms_Vin_ShouldBeExpectedType()
      => Algorithms.Vin.Should().BeOfType<VinAlgorithm>();

   #endregion
}
