using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 159)]
    public partial class ListActiveBountyDetails
    {
        public uint Unk1;
        public byte Unk2;
    }
}