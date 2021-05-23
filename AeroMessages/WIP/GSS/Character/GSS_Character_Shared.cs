using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Character
{
    [AeroBlock]
    public struct EliteAvailableUpgradeInfo
    {
        public uint UpgradeId; // TODO: Pinpoint sdb table
        public uint Unk_1;
        public float StatValue;

        [AeroArray(typeof(byte))]
        public uint[] AdditionalInfo;
        //public uint? Count; // first additional info entry
        //public uint? ItemSDBId; // second additional info entry
        // ... more potentially

        //[AeroSDB("dblocalization::LocalizedText", "id")]
        public uint LocalizationId;
    }

    [AeroBlock]
    public struct ElitePreviousUpgradeInfo
    {
        public uint UpgradeId; // TODO: Pinpoint sdb table
        public uint Count;
    }
}