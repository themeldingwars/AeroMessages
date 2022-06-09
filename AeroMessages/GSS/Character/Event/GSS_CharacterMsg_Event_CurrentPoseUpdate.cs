using Aero.Gen.Attributes;
using System.Numerics;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 12, 110)]
    public partial class Character_Event_CurrentPoseUpdate
    {
        public byte Flags;
        public ushort ShortTime;

        [AeroIf(nameof(Flags), 0x00)]
        public FullDataVersion Data;

        // Cba to implement these atm
        /*
        if ((Flags & 1) == 0) {
            Unk1 = Stream.Read.Byte();
        }
        if ((Flags & 2) == 0) {
            MovementState = Stream.Read.UShort();
        }

        if (Flags == 0x62 || Flags == 0x30) {
            Position = Stream.Read.FloatArray(3); // Looks right to me
        }
        */

        // This was working well until I found an ent where (Flags & 4).
        // That ent had many other messages that broke the pattern.
        // So I guess either the other flags or the value of Unk1 has an impact as well.
        /*
        if ((Flags & 8) == 0) {
            Flag_3_Value = Stream.Read.ByteArray(3);
        }
        if ((Flags & 16) == 0) {
            Flag_4_Value = Stream.Read.ByteArray(3);
        }
        if ((Flags & 32) == 0) {
            Flag_5_Value = Stream.Read.ByteArray(1);
        }
        if ((Flags & 64) == 0) {
            Flag_6_Value = Stream.Read.ByteArray(3);
        }
        if ((Flags & 128) == 0) {
            Flag_7_Value = Stream.Read.ByteArray(3);
        }
         */


    }

    [AeroBlock]
    public struct FullDataVersion
    {
        public byte Unk1;
        public ushort MovementState;
        public Vector3 Position;
        public QuantisedQuaternion Rotation;
        public QuantisedVector3 Aim;
    }
}