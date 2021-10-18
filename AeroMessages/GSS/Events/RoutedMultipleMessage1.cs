using System;
using System.Buffers.Binary;
using System.Collections.Generic;
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
            int offset   = 0;

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

        /*int IAero.GetPackedSize()
        {
            throw new NotImplementedException();
        }

        int IAero.Pack(Span<byte> buffer)
        {
            throw new NotImplementedException();
        }*/
    }

    [Aero]
    public partial class RoutedBlockStorage
    {
        [Flags]
        public enum HasMore : byte
        {
            Yes = 0x80
        }

        public HasMore LengthByte1;

        [AeroIf(nameof(LengthByte1), AeroIfAttribute.Ops.HasFlag, HasMore.Yes)]
        public byte LengthByte2;

        public ushort ReffId;
        
        [AeroIf(nameof(ReffId), AeroIfAttribute.Ops.NotEqual, ushort.MaxValue)]
        [AeroArray(nameof(Length))] public byte[] Data;

        [AeroIf(nameof(ReffId), ushort.MaxValue)]
        public RefIdAssignMessage ReffIdAssign;

        // Be careful if doing this style, it can break the inspector, should be fine for array or string lengths, but not in ifs
        public int Length => (LengthByte2 != 0 ? (LengthByte2 | ((byte) LengthByte1 ^ 0x80) << 8) : (int) LengthByte1) - 2;
    }

    [AeroBlock]
    public struct RefIdAssignMessage
    {
        public EntityId EntityId;
        public byte     Op;
        public ushort   RefId;
    }
}