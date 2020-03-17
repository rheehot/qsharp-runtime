// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Microsoft.Quantum.Simulation.Core
{
    /// <summary>
    /// Base class containing information about a Q# entry point.
    /// </summary>
    public class EntryPointInfo<I, O>
    {
        public Type Operation { get; }
        public Type InType => typeof(I);
        public Type OutType => typeof(O);

        public EntryPointInfo(Type operation) => 
            this.Operation = operation;
    }

    /// <summary>
    /// Base class containing information about an entry point 
    /// for a Q# executable targeted for a Honeywell quantum processor.
    /// </summary>
    public class HoneywellExecutable<I, O> 
    : EntryPointInfo<I, O>
    {
        public HoneywellExecutable(Type operation) 
        : base(operation)
        { }
    }

    /// <summary>
    /// Base class containing information about an entry point 
    /// for a Q# executable targeted for a IonQ quantum processor.
    /// </summary>
    public class IonQExecutable<I, O>
    : EntryPointInfo<I, O>
    {
        public IonQExecutable(Type operation)
        : base(operation)
        { }
    }

    /// <summary>
    /// Base class containing information about an entry point 
    /// for a Q# executable targeted for a QCI quantum processor.
    /// </summary>
    public class QCIExecutable<I, O>
    : EntryPointInfo<I, O>
    {
        public QCIExecutable(Type operation)
        : base(operation)
        { }
    }
}
