using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.UiQueryResponse, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class UiQueryResponse
    {
        public ulong QueryGuid;

        [AeroSdb("dbencounterdata::EncUiQueryOption", "id")]
        public uint SelectedOptionId;

        [AeroArray(typeof(byte))] public UiQueryResponseOutput[] Outputs;
    }

    [AeroBlock]
    public struct UiQueryResponseOutput
    {
        [AeroSdb("dbencounterdata::EncUiQueryOutput", "id")]
        public uint Id;

        public float Amount;
    }
}
