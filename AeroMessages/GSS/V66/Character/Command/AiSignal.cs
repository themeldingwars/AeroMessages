using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System;
using System.Numerics;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 192)] // Not sure what controller it would be assoicated with
    public partial class AiSignal
    {
        [AeroString] public string Unk1;
        [AeroString] public string Unk2;

        // FUN_00a093e0
        // Reads four four byte values, four times
        // Transform?
        [AeroArray(4)] public Vector4[] Unk3;
        // --
        public ulong Unk4;
    }
}