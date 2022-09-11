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
        public int Unk1;
        public int Unk2;
        public int Unk3;
        public int Unk4;
        public float Unk5_Current; // Semes to range 0.0 - 400.0 (could be Current)
        public float Unk5_Max; // Semes to range 0.0 - 400.0 (could be Max)
        public uint Unk6; // Often "0", sometimes 1, 3
        public Vector4 Unk7;
        public uint Unk8; // Often "6"
    }
}