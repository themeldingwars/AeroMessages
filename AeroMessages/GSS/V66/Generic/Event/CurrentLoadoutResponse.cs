using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
using AeroMessages.Common;
using AeroMessages.GSS.V66.Character.Event;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 119)]
    public partial class CurrentLoadoutResponse
    {
        public EntityId Unk1;
        public int Unk2;
        public int Unk3;
        [AeroString] public string Unk4;
        [AeroString] public string Unk5;
        public uint Unk6;
        [AeroArray(typeof(byte))] public LoadoutConfig[] LoadoutConfigs;
    }
}