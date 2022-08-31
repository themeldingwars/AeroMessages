using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 139)]
    public partial class GeographicalReportResponse
    {
        public uint Unk1;
        public Vector3 Unk2;
        public byte Unk3;
        [AeroArray(typeof(byte))] public GeoReportData[] Data;
    }

    [AeroBlock]
    public struct GeoReportData
    {
        public uint Unk1;
        public ushort Unk2;
        public uint Unk3;   
    }
}