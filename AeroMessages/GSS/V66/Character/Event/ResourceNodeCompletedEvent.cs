using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.ResourceNodeCompletedEvent, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class ResourceNodeCompletedEvent
    {
        public EntityId ResourceNodeId;
        public ThumpingCharacterInfoStruct ThumpingCharacterInfo; // Bit uncertain
        public float Completion;
        public byte Destroyed;
        public uint ScanId;
        public byte Unk9; // Empty?
        public uint Quantity;
        [AeroArray(typeof(byte))] public ResourceCompositionData[] Composition;
    }
}