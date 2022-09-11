using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 177)]
    public partial class FabricationFetchAllRecipesResponse
    {
        [AeroArray(typeof(byte))] public uint[] Recipes;
    }
}