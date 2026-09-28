using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using AeroMessages.GSS.Character.Event;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.CurrentLoadoutResponse, GssVersion.V1, GssVersion.V74)]
    public partial class CurrentLoadoutResponse
    {
        public EntityId PlayerId;
        public int PveLoadoutId;
        public int PvpLoadoutId;
        [AeroString] public string LoadoutName;
        [AeroString] public string Unk5;
        public uint Unk6;
        [AeroArray(typeof(byte))] public LoadoutConfig[] LoadoutConfigs;
    }
}