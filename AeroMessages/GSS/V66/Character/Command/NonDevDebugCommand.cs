using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 195)]
    public partial class NonDevDebugCommand
    {
        public enum NonDevDebugCommandType : byte
        {
            DEBUGWEAPON = 0,
            DEBUGEVENT = 1,
            DEBUGLAG = 2
        }
        public NonDevDebugCommandType Type;
        public byte Enabled;
        [AeroArray(3)] public byte[] Unk1;
        [AeroString] public string Unk2;
    }
}