using Aero.Gen.Attributes;
using AeroMessages.Common;
using System;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 87)]
    public partial class DebugWeaponStats
    {
        public ushort Spawned;
        public ushort Reported1;
        public ushort Late;
        public ushort Dropped;
        public ushort Validated;
        public ushort Succeeded1;
        public ushort Reported2;
        public ushort Succeeded2;
    }
}