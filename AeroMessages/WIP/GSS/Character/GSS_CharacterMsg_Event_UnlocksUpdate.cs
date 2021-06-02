/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 130
    MsgName: UnlocksUpdate
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Event_UnlocksUpdate
    {
        public byte ClearExistingData; // 1 for full update, 0 for partitial

        [AeroArray(typeof(byte))]
        public UnlockGroup[] Groups;
    }

    [AeroBlock]
    public struct UnlockGroup
    {
        [AeroString]
        public string Key;

        [AeroArray(typeof(byte))] // TODO: Aero needs support for handling additional bytes if size is 255
        UnlockGroupEntry[] Entries;

        public byte UnkEndOfKeyByte;
    }

    [AeroBlock]
    public struct UnlockGroupEntry
    {
        [AeroSdb("dbitems::Certificate", "id")]
        public uint CertId;

        [AeroArray(typeof(byte))]
        public uint[] Unk1_Data;

        [AeroArray(typeof(byte))]
        public uint[] Unk2_Data;

        [AeroArray(typeof(byte))]
        public uint[] Unk3_Data;
    }
}