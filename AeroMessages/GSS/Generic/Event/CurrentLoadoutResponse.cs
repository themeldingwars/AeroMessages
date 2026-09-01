using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using AeroMessages.GSS.Character.Event;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.CurrentLoadoutResponse, GssVersion.V1, GssVersion.V67)]
    public partial class CurrentLoadoutResponse
    {
        public EntityId PlayerId;
        public int Unk2;
        public int Unk3;
        [AeroString] public string Unk4;
        [AeroString] public string Unk5;
        public uint Unk6;
        [AeroArray(typeof(byte))] public LoadoutConfig[] LoadoutConfigs;
    }
}