using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.Fabrication_Claim_Response, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class FabricationClaimResponse
    {
        public FabricationCommonData1 Response;
        public uint Unk2;
    }
}