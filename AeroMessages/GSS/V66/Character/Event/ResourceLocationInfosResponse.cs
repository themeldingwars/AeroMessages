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
        public uint Unk1;
        public uint Unk2;
        public uint Unk3;
        public uint Unk4;
        [AeroArray(typeof(byte))] public ResourceLocationInfoInner[] Unk5;
    }

    [AeroBlock]
    public struct ResourceLocationInfoInner
    {
        public uint Unk1;
        public byte Unk2;
    }
}