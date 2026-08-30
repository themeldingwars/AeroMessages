using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.SelectFireMode, GssCharacterView.CombatController, GssVersion.V1, GssVersion.V67)]
    public partial class SelectFireMode
    {
        public uint Time;
        public byte FireMode;
    }
}