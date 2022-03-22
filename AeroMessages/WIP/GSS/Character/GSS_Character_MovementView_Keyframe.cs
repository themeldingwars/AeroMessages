/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 12
    TypeName: Character::MovementView
    MsgId: 3
    MsgName: Keyframe
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    /*[Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 12, 3)]
    public partial class MovementView
    {
        private MovementData Movement;
    }

    [AeroBlock]
    public struct MovementData
    {
        public Vector3 Position;
        public Quaternion Rotation;
        public Vector3 Aim;
        public ushort MovementState;
        public uint Time;
    }*/
}