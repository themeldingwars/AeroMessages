using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.MatchLoadingState, GssVersion.V1, GssVersion.V74)]
    public partial class MatchLoadingState
    {
        public sbyte Unk1;
        [AeroArray(typeof(byte))] public MatchLoadingStateData[] Players;
    }

    [AeroBlock]
    public struct MatchLoadingStateData
    {
        public EntityId Player;
        [AeroString] public string Name;
        public byte Unk3;
    }
}