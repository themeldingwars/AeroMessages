using System;
using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, 18)]
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
        public ulong Unk2;
    }
}