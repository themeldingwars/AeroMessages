using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.GSS.Character.Command;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Encounter.Command
{
    // Not seen in any capture, layout taken from Character.Command.UiQueryResponse (same name and id 59 in 19551)
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssEncounterCommand.UiQueryResponse, GssVersion.V74, GssVersion.V74)]
    public partial class UiQueryResponse
    {
        public ulong QueryGuid;

        [AeroSdb("dbencounterdata::EncUiQueryOption", "id")]
        public uint SelectedOptionId;

        [AeroArray(typeof(byte))] public UiQueryResponseOutput[] Outputs;
    }
}
