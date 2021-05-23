/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 5
    TypeName: Character::CombatController
    MsgId: 113
    MsgName: ForcedMovement
META_END
 */
using Aero.Gen.Attributes;
using System.Numerics;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Event_ForcedMovement
    {
        public byte Flags;

        [AeroArray(5)]
        public byte[] Unk2;

        [AeroIf(nameof(Flags), 0x01)]
        public Type1Data Data1;

        [AeroIf(nameof(Flags), 0x05)]
        public Type5Data Data5;

    }

    [AeroBlock]
    public struct Type1Data
    {
        public Vector3 Position;
        public Vector3 Direction;
        public Vector3 Velocity;
        public uint Time;
        public ushort ShortTime;
    }

    [AeroBlock]
    public struct Type5Data
    {
        public Vector3 Type5_Velocity; // These are a bit of an assumption
        public uint Time1;
        public uint Time2;
        public byte Unk2;
        public ushort ShortTime1;
    }
}