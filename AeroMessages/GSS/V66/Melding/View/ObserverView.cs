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
        public ulong Unk1;
        public ulong Unk2;
        public byte Unk3;
        // FromTangents / FromPoints?
        [AeroArray(typeof(byte))] public Vector3[] ControlPoints_1;
        [AeroArray(typeof(byte))] public Vector3[] Offsets_1;
        // ToTangents / ToPoints?
        [AeroArray(typeof(byte))] public Vector3[] ControlPoints_2;
        [AeroArray(typeof(byte))] public Vector3[] Offsets_2;
    }
}