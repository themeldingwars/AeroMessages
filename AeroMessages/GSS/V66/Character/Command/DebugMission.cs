using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 154)]
    public partial class DebugMission
    {
        public uint Unk1; // Mission I imagine
        [AeroString] public string Unk2;
    }
}