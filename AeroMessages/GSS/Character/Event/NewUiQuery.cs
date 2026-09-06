using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.NewUiQuery, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class NewUiQuery
    {
        public ulong QueryGuid;

        [AeroSdb("dbencounterdata::EncUiQuery", "id")]
        // [AeroSdb("dbencounterdata::EncUiQueryInput", "query_id")]
        public uint Type;

        [AeroSdb("dbencounterdata::EncUiQuery", "localized_text")]
        // [AeroSdb("dblocalization::LocalizedText", "id")]
        public uint Prompt;

        [AeroArray(typeof(byte))] public NewUiQueryInput[] Inputs;
    }

    [AeroBlock]
    public struct NewUiQueryInput
    {
        [AeroSdb("dbencounterdata::EncUiQueryInput", "id")]
        public uint Id;

        public uint Value;
    }
}
