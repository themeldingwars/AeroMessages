using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 166)]
    public partial class SetBountyVar
    {
        public uint Unk1;
        [AeroString] public string Unk2;
        [AeroString] public string Unk3;
    }
}