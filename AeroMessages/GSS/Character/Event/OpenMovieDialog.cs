using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.OpenMovieDialog, GssCharacterView.CombatController, GssVersion.V1, GssVersion.V67)]
    public partial class OpenMovieDialog
    {
        [AeroString] public string Unk;
    }
}