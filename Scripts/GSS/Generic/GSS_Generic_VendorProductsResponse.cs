[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Server, 0, 120, Ver: 1962)]
public partial class GenericVendorProductsResponse : AeroBase
{
    public uint VendorId;
    public ulong Id;

    [AeroNullTermString]
    public string Title;

    [AeroSDB("dbcharacter::Faction", "id")]
    public uint FactionId;

    [AeroArray(typeof(byte))]
    public FactionDiscount[] FactionDiscounts;

    [AeroArray(typeof(byte))]
    public VendorProduct[] Products;
}

[Aero(AeroType.Block)]
public partial class FactionDiscount : AeroBase
{
    public uint MinRep;
    public float Discount;
}

[Aero(AeroType.Block)]
public partial class VendorProductPrice : AeroBase
{
    public ulong GUID;

    [AeroNullTermString]
    public string CurrencyType;

    [AeroSDB("dbitems:RootItem", "sdb_id")]
    public uint CurrencyRemoteId;

    public uint Amount;
}

[Aero(AeroType.Block)]
public partial class VendorProductRestriction : AeroBase
{
    [AeroNullTermString]
    public string Type;

    [AeroNullTermString]
    public string OptionsJSON;
}

[Aero(AeroType.Block)]
public partial class VendorProduct : AeroBase
{
    public ulong GUID;

    [AeroSDB("dbitems:RootItem", "sdb_id")]
    public uint SdbId;

    public uint Quantity;
    public uint Duration;

    [AeroArray(typeof(byte))]
    public VendorProductPrice[] Prices;

    [AeroArray(typeof(byte))]
    public VendorProductRestriction[] Restrictions;

    public byte Priority;
}