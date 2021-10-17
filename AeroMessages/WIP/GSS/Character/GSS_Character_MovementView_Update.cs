using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
using AeroMessages.GSS.Character.MovementView;

namespace AeroMessages.GSS.Character
{
    [AeroBlock]
    public struct Character_MovementView_ShadowFieldUpdate
    {
        public enum ShadowFieldIndex : byte
        {
            Movement = 0x00,
        }

        public ShadowFieldIndex Idx;

        [AeroIf(nameof(Idx), ShadowFieldIndex.Movement)]
        public MovementData Movement;
    }

    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 12, 1)]
    public partial class Character_MovementView_Update
    {
        [AeroArray(-2)]
        public Character_MovementView_ShadowFieldUpdate[] Updates;
    }
}