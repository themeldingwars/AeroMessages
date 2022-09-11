using Aero.Gen.Attributes;
using AeroMessages.Common;
using System;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 87)] // Uncertain controller
    public partial class DebugWeaponStats
    {
        public ushort Unk1;
        public ushort Unk2;
        public ushort Unk3;
        public ushort Unk4;
        public ushort Unk5;
        public ushort Unk6;
        public ushort Unk7;
        public ushort Unk8;
    }
}