using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.TrackerPulse, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class TrackerPulse
    {
        public EntityId Entity;
        public int Health;
        public int MaxHealth;
        public int Unk3;
        public int Unk4;
        public float Unk5_Current; // 0 - 400 on characters, drains and refills like jet energy, 0 on deployables
        public float Unk5_Max;
        public uint ScopeLayer;
        public Vector3 Position;
        public float Heading; // Yaw in degrees
        public uint Unk8; // 6, 0 in the all-zero pulse sent when tracking starts
    }
}