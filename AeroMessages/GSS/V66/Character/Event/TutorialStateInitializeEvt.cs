using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 173)]
    public partial class TutorialStateInitializeEvt
    {
        [AeroArray(typeof(byte))] public TutorialState2x4[] Data;
    }

    [AeroBlock]
    public struct TutorialState2x4
    {
        public uint Unk1;
        public uint Unk2;
    }
}