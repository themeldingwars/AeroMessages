using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 116)]
    public partial class AbilityActivated
    {   
        [AeroSdb("apt::AbilityData", "id")]
        public uint Activated_AbilityId;
        public uint Activated_Time;

        [AeroArray(typeof(uint))]
        public ActiveCooldown[] ActiveCooldowns_Group1; // Don't know the logic

        [AeroArray(typeof(uint))]
        public ActiveCooldown[] ActiveCooldowns_Group2; // Don't know the logic

        public uint GlobalCooldown_Activated_Time;
        public uint GlobalCooldown_ReadyAgain_Time;

        public byte Unk;
    }

    [AeroBlock]
    public struct ActiveCooldown
    {
        [AeroSdb("apt::AbilityData", "id")]
        public uint AbilityId;
        public uint Activated_Time;
        public uint ReadyAgain_Time;

        [AeroArray(5)]
        public byte[] Unk;
    }
}