using Bitter;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 0, 120, true)]
    public class GenericVendorProductsResponse : BaseScript
    {

        public uint VendorId;
        public ulong Id;
        public string Title;
        public uint FactionId;
        public byte NumberOfFactionDiscounts;
        public FactionDiscount[] FactionDiscounts;
        public byte NumberOfProducts;
        public VendorProduct[] Products;


        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            MyExtensions.BStream = Stream;
    
            VendorId = Stream.Read.UInt();
            Id = Stream.Read.ULong();
            Title = Stream.Read.StringZ();
            FactionId = Stream.Read.UInt();
            NumberOfFactionDiscounts = Stream.Read.Byte();
            FactionDiscounts = Stream.Read.FactionDiscountArray(NumberOfFactionDiscounts);
            NumberOfProducts = Stream.Read.Byte();
            Products = Stream.Read.VendorProductArray(NumberOfProducts);
        }
    }

    public struct FactionDiscount
    {
        public uint MinRep;
        public float Discount;

        public FactionDiscount(Bitter.BinaryReader R)
        {
            MinRep = R.UInt();
            Discount = R.Float();
        }

        public override string ToString() => $"MinRep: {MinRep}, Discount: {Discount}";
    }

    public struct VendorProductPrice
    {
        public ulong GUID;
        public string CurrencyType;
        public uint CurrencyRemoteId;
        public uint Amount;


        public VendorProductPrice(Bitter.BinaryReader R)
        {
            GUID = R.ULong();
            CurrencyType = R.StringZ();
            CurrencyRemoteId = R.UInt();
            Amount = R.UInt();
        }

        public override string ToString() => $"{Amount}x CurrencyRemoteId: {CurrencyRemoteId}";
    }

    public struct VendorProductRestriction
    {
        public string Type;
        public string OptionsJSON;


        public VendorProductRestriction(Bitter.BinaryReader R)
        {
            Type = R.StringZ();
            OptionsJSON = R.StringZ();
        }

        public override string ToString() => $"Type: {Type}, Options: {OptionsJSON}";
    }

    public struct VendorProduct
    {
        public ulong GUID;
        public uint SdbId;
        public uint Quantity;
        public uint Duration;
        public byte NumberOfPrices;
        public VendorProductPrice[] Prices;
        public byte NumberOfRestrictions;
        public VendorProductRestriction[] Restrictions;
        public byte Priority;


        public VendorProduct(Bitter.BinaryReader R)
        {
            GUID = R.ULong();
            SdbId = R.UInt();
            Quantity = R.UInt();
            Duration = R.UInt();
            NumberOfPrices = R.Byte();
            Prices = R.VendorProductPriceArray(NumberOfPrices);
            NumberOfRestrictions = R.Byte();
            Restrictions = R.VendorProductRestrictionArray(NumberOfRestrictions);
            Priority = R.Byte();
        }

        public override string ToString() => $"SdbId: {SdbId}, Prices: ${NumberOfPrices}, Restrictions: ${NumberOfRestrictions}";
    }

    public static class MyExtensions {
        public static Bitter.BinaryStream BStream;

        public static string StringZ(this Bitter.BinaryReader rdr) {
            string ret = "";
            do
            {
                byte b = rdr.Byte();
                if (b == 0x00)
                    break;
                ret += (char)b;
            }
            while (BStream.baseStream.ByteOffset < BStream.baseStream.Length);
            return ret;
        }

        public static VendorProduct VendorProduct(this Bitter.BinaryReader R)
        {
            return new VendorProduct(R);
        }

        public static VendorProduct[] VendorProductArray(this Bitter.BinaryReader R, int num)
        {
            List<VendorProduct> list = new List<VendorProduct>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.VendorProduct());
            }
            return list.ToArray();
        }

        public static FactionDiscount FactionDiscount(this Bitter.BinaryReader R)
        {
            return new FactionDiscount(R);
        }

        public static FactionDiscount[] FactionDiscountArray(this Bitter.BinaryReader R, int num)
        {
            List<FactionDiscount> list = new List<FactionDiscount>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.FactionDiscount());
            }
            return list.ToArray();
        }

        public static VendorProductPrice VendorProductPrice(this Bitter.BinaryReader R)
        {
            return new VendorProductPrice(R);
        }

        public static VendorProductPrice[] VendorProductPriceArray(this Bitter.BinaryReader R, int num)
        {
            List<VendorProductPrice> list = new List<VendorProductPrice>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.VendorProductPrice());
            }
            return list.ToArray();
        }

        public static VendorProductRestriction VendorProductRestriction(this Bitter.BinaryReader R)
        {
            return new VendorProductRestriction(R);
        }

        public static VendorProductRestriction[] VendorProductRestrictionArray(this Bitter.BinaryReader R, int num)
        {
            List<VendorProductRestriction> list = new List<VendorProductRestriction>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.VendorProductRestriction());
            }
            return list.ToArray();
        }


    }
}