using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aero.Gen;
using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Events
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 8)]
    public partial class RoutedMultipleMessage1
    {
        [AeroArray(0)] public RoutedBlockStorage[] DataBlocks = new RoutedBlockStorage[0];

        // Custom read handling
        int IAero.Unpack(ReadOnlySpan<byte> data)
        {
            int offset = 0;

            var items = new List<RoutedBlockStorage>();
            do {
                var block      = new RoutedBlockStorage();
                var buffer     = data[offset..];
                var amountRead = block.Unpack(buffer);
                offset += amountRead;

                items.Add(block);
            } while (offset < data.Length);

            DataBlocks = items.ToArray();

            return offset;
        }
    }

    [Aero]
    public partial class RoutedBlockStorage
    {
        public Vlq16  Size;
        public ushort ReffId;

        [AeroIf(nameof(ReffId), ushort.MaxValue)]
        public EntityId EntityId;

        [AeroArray(nameof(DataLength))] public byte[] Data;

        public int DataLength => Size.Length - (ReffId == ushort.MaxValue ? 10 : 2);
    }
}