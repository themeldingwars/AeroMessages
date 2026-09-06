using System.Numerics;
using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.FoundResourceAreas, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class FoundResourceAreas
    {
        [AeroArray(typeof(byte))] public ResourceArea[] Data;
    }

    [AeroBlock]
    public struct ResourceArea
    {
        public Vector3 Center;

        public uint Unk4;

        [AeroSdb("dbzonemetadata::ResourceNodeTypeResource", "node_type_id")]
        // [AeroSdb("dbzonemetadata::ResourceNodeType", "id")]
        public uint NodeTypeId;
    }
}