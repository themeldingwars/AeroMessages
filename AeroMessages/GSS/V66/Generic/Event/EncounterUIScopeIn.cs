using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 100)]
    public partial class EncounterUIScopeIn
    {
        public EncounterUIScopeIn(int size)
        {
            _size = size;
        }

        public EncounterUIScopeIn()
        {
        }

        public EntityId EncounterId;

        [AeroArray(typeof(ushort))]
        public byte[] Header;

        public ushort SchemaVersion; // must be equal to 2

        [AeroArray(typeof(byte))] public SinCardData[] SinCard;

        private int _size;

        [AeroArray(nameof(_size))]
        public byte[] ShadowFieldValues;
    }

    [AeroBlock]
    public struct SinCardData
    {
        public ulong Guid;

        public EntityId Target;

        [AeroSdb("dbencounterdata::SinCardTemplate", "Id")]
        //[AeroSdb("dbencounterdata::SinCardFields", "TemplateId")]
        public int Type;

        [AeroArray(typeof(byte))] public SinCardFieldData[] Fields;
    }
}