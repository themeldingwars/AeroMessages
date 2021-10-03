/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 89
    MsgName: FetchQueueInfo
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 89)]
    public partial class Character_Command_FetchQueueInfo
    {
        [AeroArray(typeof(byte))]
        [AeroString]
        public string[] Keys;

        [AeroArray(12)]
        public byte[] Unk;
    }
}