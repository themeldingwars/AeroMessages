/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 89
    MsgName: ProgressionXPRefresh
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Event_ProgressionXPRefresh
    {
        [AeroArray(typeof(byte))]
        public ProgressionFrameInfo[] Frames;
    }

    [AeroBlock]
    public struct ProgressionFrameInfo
    {
        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint ChassisID;

        public uint XpValue1;
        public uint XpValue2;
        public byte CurrentLevel;

        [AeroArray(7)]
        public byte[] Unk;
    }
}