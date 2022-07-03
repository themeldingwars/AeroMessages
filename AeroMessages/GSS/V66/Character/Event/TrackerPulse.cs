using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 135)]
    public partial class TrackerPulse
    {
        public EntityId Entity;

        public uint Unk1;
        public uint Unk2;

        [AeroArray(8)]
        public byte[] Unk3;

        public float Unk4_Current; // Semes to range 0.0 - 400.0 (could be Current)
        public float Unk4_Max; // Semes to range 0.0 - 400.0 (could be Max)
        
        public uint Unk5; // Often "0", sometimes 1, 3

        public Vector4 Unk6;
        public uint Unk7; // Often "6"
    }
}