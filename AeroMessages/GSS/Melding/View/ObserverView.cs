using Aero.Gen.Attributes;
using Aero.Protocol;
using System.Numerics;
using Aero.Gen;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Melding.View
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMeldingView.ObserverView, GssVersion.V1, GssVersion.V67)]
    public partial class ObserverView
    {
        [AeroString]
        private string PerimiterSetName;
        private ActiveDataStruct    ActiveData;
        private ScopeBubbleInfoData ScopeBubbleInfo;
    }

    [AeroBlock]
    public struct ActiveDataStruct
    {
        public ulong TimestampMicro;
        public ulong Unk2; // 1000000
        public byte Unk3;
        [AeroArray(typeof(byte))] public Vector3[] FromPoints;
        [AeroArray(typeof(byte))] public Vector3[] FromTangents;
        [AeroArray(typeof(byte))] public Vector3[] ToPoints;
        [AeroArray(typeof(byte))] public Vector3[] ToTangets;
    }
}