using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 176)]
    public partial class FabricationFetchAllInstancesResponse
    {
        [AeroArray(typeof(byte))] public FabricationCommonData1[] Data;
    }
}