/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 171
    MsgName: LevelUpEvent
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 171)]
    public partial class Character_Event_LevelUpEvent
    {
        public uint FrameId;
        public byte NewLevel;
        public byte NumberOfLevelsAdvanced;
        [AeroArray(typeof(byte))]
        public byte[] UnkByteArray;
    }
}