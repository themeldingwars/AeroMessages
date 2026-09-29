using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.ResourceLocationInfosResponse, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class ResourceLocationInfosResponse
    {
        [AeroArray(typeof(byte))] public ResourceLocationInfo[] Data;
        public byte IsFinal; // the last response, the client updates the heatmap
    }

    [AeroBlock]
    public struct ResourceLocationInfo
    {
        public float X;
        public float Y;
        public float Z;
        public uint Unk4;
        [AeroArray(typeof(byte))] public ResourceLocationInfoInner[] Composition;
    }

    [AeroBlock]
    public struct ResourceLocationInfoInner
    {
        public uint ItemTypeId;
        public byte Percent;
    }
}