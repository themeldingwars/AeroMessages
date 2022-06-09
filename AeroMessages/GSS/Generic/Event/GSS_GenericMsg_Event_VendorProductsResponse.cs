using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 120)]
    public partial class Generic_Event_VendorProductsResponse
    {
        public uint VendorId;
        public ulong Id;

        [AeroString]
        public string Title;

        [AeroSdb("dbcharacter::Faction", "id")]
        public uint FactionId;

        [AeroArray(typeof(byte))]
        public FactionDiscount[] FactionDiscounts;

        [AeroArray(typeof(byte))]
        public VendorProduct[] Products;
    }

    [AeroBlock]
    public struct FactionDiscount
    {
        public uint MinRep;
        public float Discount;
    }

    [AeroBlock]
    public struct VendorProductPrice
    {
        public ulong GUID;

        [AeroString]
        public string CurrencyType;

        [AeroSdb("dbitems:RootItem", "sdb_id")]
        public uint CurrencyRemoteId;

        public uint Amount;
    }

    [AeroBlock]
    public struct VendorProductRestriction
    {
        [AeroString]
        public string Type;

        [AeroString]
        public string OptionsJSON;
    }

    [AeroBlock]
    public struct VendorProduct
    {
        public ulong GUID;

        [AeroSdb("dbitems:RootItem", "sdb_id")]
        public uint SdbId;

        public uint Quantity;
        public uint Duration;

        [AeroArray(typeof(byte))]
        public VendorProductPrice[] Prices;

        [AeroArray(typeof(byte))]
        public VendorProductRestriction[] Restrictions;

        public byte Priority;
    }
}