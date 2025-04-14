using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 199)]
    public partial class RequestTransfer
    {
        [AeroSdb("dbzonemetadata::ZoneRecord", "id")]
        public uint ZoneId;

        public sbyte Unk2;
    }
}