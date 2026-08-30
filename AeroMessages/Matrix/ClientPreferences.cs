using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, MatrixMessage.ClientPreferences, MatrixVersion.V1, MatrixVersion.V26)]
    public partial class ClientPreferences
    {
        public ClientPreferencesData Data;
    }
}