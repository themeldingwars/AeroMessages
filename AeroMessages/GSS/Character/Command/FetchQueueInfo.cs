using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.FetchQueueInfo, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class FetchQueueInfo
    {
        [AeroArray(typeof(byte))]
        [AeroString]
        public string[] Keys;

        public ulong Unk2;

        [AeroSdb("dbitems::Battleframe", "id")]
        public uint ChassisId;
    }
}