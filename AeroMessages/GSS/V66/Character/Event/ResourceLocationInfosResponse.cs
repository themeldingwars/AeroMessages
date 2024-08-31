using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 140)]
    public partial class ResourceLocationInfosResponse
    {
        [AeroArray(typeof(byte))] public ResourceLocationInfo[] Data;
        public byte Unk;
    }

    [AeroBlock]
    public struct ResourceLocationInfo
    {
        public float Unk1; // x?
        public float Unk2; // y?
        public float Unk3; // z?
        public uint Unk4; // radius?
        [AeroArray(typeof(byte))] public ResourceLocationInfoInner[] Unk5; // 'composition'
    }

    [AeroBlock]
    public struct ResourceLocationInfoInner
    {
        public uint Unk1; // item type id?
        public byte Unk2; // percent?
    }
}