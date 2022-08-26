using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 208)]
    public partial class SlotVisualMultiRequest
    {
        public uint LoadoutId;
        public uint ConfigId; // Assumption. If so, 0: PvE, 1: PvP

        [AeroArray(typeof(byte))]
        public LoadoutConfig_Visual[] Visuals;

        [AeroArray(typeof(byte))]
        public UnkLastVisualsRequestData[] UnkLast; // Maybe something related to purchasing visuals?
    }

    [AeroBlock]
    public struct UnkLastVisualsRequestData
    {
        public uint Unk1;
        [AeroString] public string Unk2;
        public uint Unk3;
        public uint Unk4;
        [AeroString] public string Unk5;
        public uint Unk6;
        public uint Unk7;
    }
}