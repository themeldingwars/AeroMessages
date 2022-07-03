using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 238)]
    public partial class VendorPurchaseRequest
    {
        public ulong Unk1;

        public EntityId Buyer;
        public ulong ProductID;
        public ulong PriceID;

        public byte Unk2;

        public uint ScuffedVendorID; // Half of the ulong...?

        public byte Unk3;

        public uint VendorRemoteID;

        public byte Unk4;
    }
}