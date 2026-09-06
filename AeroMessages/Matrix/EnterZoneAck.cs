using System;
using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, MatrixMessage.EnterZoneAck, MatrixVersion.V1, MatrixVersion.V32)]
    public partial class EnterZoneAck
    {
        [Flags]
        public enum ClientLoginFlags : byte
        {
            ConnectAsSuperSpectator = 1 << 0,
            ConnectAsSpectator = 1 << 1,
            ConnectAsReferee = 1 << 2,
        }

        public ClientLoginFlags Flags;
        public ulong SpectatorTargetGuid;
    }
}