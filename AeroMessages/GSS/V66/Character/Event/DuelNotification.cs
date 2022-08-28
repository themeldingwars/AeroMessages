using Aero.Gen.Attributes;
using AeroMessages.Common;
using System;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 142)] // Uncertain controller
    public partial class DuelNotification
    {
        public DuelData Unk1;
        public ulong Unk2;
    }
}