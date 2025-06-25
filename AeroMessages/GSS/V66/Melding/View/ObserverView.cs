using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
using Aero.Gen;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Melding.View
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 16, 1)] // update
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 16, 3)] // view keyframe
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