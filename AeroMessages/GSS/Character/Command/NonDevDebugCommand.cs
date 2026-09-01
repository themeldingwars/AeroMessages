using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.NonDevDebugCommand, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class NonDevDebugCommand
    {
        public enum NonDevDebugCommandType : byte
        {
            DEBUGWEAPON = 0,
            DEBUGEVENT = 1,
            DEBUGLAG = 2
        }
        public NonDevDebugCommandType Type;
        public int Value;
        [AeroString] public string Unk2;
    }
}