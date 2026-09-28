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
        public float X;
        public float Y;
        public float Radius; // on the horizontal plane

        public uint Seed; // MT19937 seed for the random share of each resource of the NodeTypeId

        [AeroSdb("dbzonemetadata::ResourceNodeTypeResource", "node_type_id")]
        // [AeroSdb("dbzonemetadata::ResourceNodeType", "id")]
        public uint NodeTypeId;
    }
}