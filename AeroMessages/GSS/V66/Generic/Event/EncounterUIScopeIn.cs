using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using static Aero.Gen.Attributes.AeroIfAttribute;
using System;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 100)]
    public partial class EncounterUIScopeIn
    {
        public EntityId EncounterId;

        [AeroArray(typeof(ushort))]
        public byte[] BlobData; // Text keys with values inbetween or?

        public ushort Unk1;
        [AeroArray(typeof(byte))] public EncounterUIData[] Unk2;
        [AeroString] public string Unk3; // Consume remaining bytes, this is probably json?
    }

    [AeroBlock]
    public struct EncounterUIData
    {
        public ulong Unk1;
        public ulong Unk2;
        public int Unk3;
        [AeroArray(typeof(byte))] EncounterComplicatedData[] Unk4;
    }

    [AeroBlock]
    public struct EncounterComplicatedData
    {
        [Flags]
        public enum EncounterComplicatedDataFlags : byte
        {
            Long  = 1 << 1,
        }

        public byte Type;

        [AeroIf(nameof(Type), 0)]
        public uint Value0;

        [AeroIf(nameof(Type), 1)]
        public float Value1;

        [AeroIf(nameof(Type), 2)]
        public ulong Value2;

        [AeroIf(nameof(Type), 3)]
        public ulong Value3;

        [AeroIf(nameof(Type), 4)]
        public byte Value4;

        [AeroIf(nameof(Type), 6)]
        public short Value6;

        [AeroIf(nameof(Type), 7)]
        public EncounterComplicatedDataFlags Value7Flag;

        [AeroIf(nameof(Type), 7)]
        [AeroIf(nameof(Value7Flag), Ops.HasFlag, EncounterComplicatedDataFlags.Long)]
        public ulong Value7Long;

        [AeroIf(nameof(Type), 7)]
        [AeroIf(nameof(Value7Flag), Ops.DoesntHaveFlag, EncounterComplicatedDataFlags.Long)]
        public float Value7Float;
    }
}