using System.Numerics;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 138)]
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