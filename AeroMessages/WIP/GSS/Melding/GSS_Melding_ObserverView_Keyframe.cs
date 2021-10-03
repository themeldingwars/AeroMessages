using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Melding
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 16, 3)]
    public partial class Melding_ObserverView_Keyframe
    {
        [AeroString]
        public string PerimiterSetName;

        public ActiveDataStruct ActiveData;
        public ScopeBubbleInfoData ScopeBubbleInfo;
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