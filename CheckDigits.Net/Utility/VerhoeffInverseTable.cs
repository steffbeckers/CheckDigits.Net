﻿// Ignore Spelling: Verhoeff

namespace CheckDigits.Net.Utility;

public sealed class VerhoeffInverseTable : IOneDimensionalLookupTable
{
    private static readonly Int32[] _inverseTable = [0, 4, 3, 2, 1, 5, 6, 7, 8, 9];

    private static readonly Lazy<VerhoeffInverseTable> _lazy
       = new(() => new VerhoeffInverseTable());

    // Force singleton.
    private VerhoeffInverseTable() { }

    /// <summary>
    ///   Reference to the single instance of the 
    ///   <see cref="VerhoeffInverseTable"/>
    /// </summary>
    public static VerhoeffInverseTable Instance => _lazy.Value;

    /// <inheritdoc/>
    public Int32 this[Int32 index] => _inverseTable[index];
}
