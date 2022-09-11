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
        [AeroArray(typeof(byte))] SinCardFieldData[] Unk4;
    }
}