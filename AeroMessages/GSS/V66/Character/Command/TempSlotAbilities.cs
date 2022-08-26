using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 112)]
    public partial class TempSlotAbilities
    {
        [AeroArray(4)] public uint[] Unk1;
        [AeroArray(4)] public byte[] Unk2;
    }
}