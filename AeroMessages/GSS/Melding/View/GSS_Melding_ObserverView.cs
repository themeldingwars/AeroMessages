using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
using Aero.Gen;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Melding
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 16, 1)] // update
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 16, 3)] // view keyframe
    public partial class Melding_ObserverView
    {
        [AeroString]
        private string PerimiterSetName;
        private ActiveDataStruct    ActiveData;
        private ScopeBubbleInfoData ScopeBubbleInfo;
    }

    [AeroBlock]
    public struct ActiveDataStruct
    {
        [AeroArray(4)]
        public byte[] Unk1;

        [AeroArray(13)]
        public byte[] Unk2_Consistent;

        [AeroArray(typeof(byte))]
        public Vector3[] ControlPoints_1;

        [AeroArray(typeof(byte))]
        public Vector3[] Offsets_1;

        [AeroArray(typeof(byte))]
        public Vector3[] ControlPoints_2;

        [AeroArray(typeof(byte))]
        public Vector3[] Offsets_2;
    }
}