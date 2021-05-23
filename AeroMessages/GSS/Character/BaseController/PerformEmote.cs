using Aero.Gen.Attributes;

namespace AeroMessages.GSS.Character.BaseController
{
    [Aero]
    public partial class PerformEmote
    {
        public uint   Time;
        public ushort EmoteId; // Sdb table 73, id column
    }
}