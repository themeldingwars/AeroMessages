/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 120
    MsgName: VendorProductsResponse
META_END
 */
[Aero]
public partial class Generic_Event_VendorProductsResponse
{
    public uint VendorId;
    public ulong Id;

    [AeroString]
    public string Title;

    [AeroSDB("dbcharacter::Faction", "id")]
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

    [AeroSDB("dbitems:RootItem", "sdb_id")]
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