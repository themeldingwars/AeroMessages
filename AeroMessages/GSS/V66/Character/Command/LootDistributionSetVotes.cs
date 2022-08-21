using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 219)]
    public partial class LootDistributionSetVotes
    {
        public uint Unk1;
        [AeroArray(typeof(byte))] public ulong[] Unk2;
    }
}