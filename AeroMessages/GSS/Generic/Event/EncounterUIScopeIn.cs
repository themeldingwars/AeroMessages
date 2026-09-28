using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.EncounterUIScopeIn, GssVersion.V1, GssVersion.V74)]
    public partial class EncounterUIScopeIn
    {
        // Size is ignored, kept for compatibility
        public EncounterUIScopeIn(int size)
        {
        }

        public EncounterUIScopeIn()
        {
        }

        public EntityId EncounterId;

        [AeroArray(typeof(ushort))]
        public byte[] Header;

        public ushort SchemaVersion; // must be equal to 2

        [AeroArray(typeof(byte))] public SinCardData[] SinCard;

        // Shadow field changes of the encounter view described by Header, parse with AeroEncounters.GetEncounterClass(name).UnpackChanges
        [AeroBlob] public byte[] ShadowFieldValues;
    }

    [AeroBlock]
    public struct SinCardData
    {
        public ulong Guid;

        public EntityId Target;

        [AeroSdb("dbencounterdata::SinCardTemplate", "Id")]
        //[AeroSdb("dbencounterdata::SinCardFields", "TemplateId")]
        public uint Type;

        [AeroArray(typeof(byte))] public SinCardFieldData[] Fields;
    }
}