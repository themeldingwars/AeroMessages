using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.V66.Character
{
    [AeroBlock]
    public struct FabricationCommonData1
    {
        public uint Unk1;
        public uint Unk2;
        public Vector3 Unk3;
        public Vector3 Unk4;
        public Vector3 Unk5;
        public uint Unk6;
        public uint Unk7;
        public Vector3 Unk8;
        public uint Unk9;
        public long Unk10;
        public long Unk11;
        public uint Unk12;
        [AeroArray(typeof(uint))] public FabricationData_00d973d0[] Unk13;
        public uint Unk14;
        public uint Unk15;
        [AeroArray(typeof(byte))] public FabricationData_00d9aab0[] Unk16;
        [AeroArray(typeof(byte))] public uint[] Unk17;
        [AeroArray(typeof(byte))] public FabricationData_00d9ad00[] Unk18;
        [AeroArray(typeof(int))] public FabricationData_016f6360[] Unk19;
    }

    [AeroBlock]
    public struct FabricationData_00d973d0
    {
        public uint Unk1;
        public uint Unk2;
        public uint Unk3;
        [AeroArray(typeof(byte))] FabricationData_00d9a1a0[] Unk4;
    }

    [AeroBlock]
    public struct FabricationData_00d9a1a0
    {
        public uint Unk1;
        public uint Unk2;
        public uint Unk3;
    }

    [AeroBlock]
    public struct FabricationData_00d9aab0
    {
        public uint Unk1;
        public uint Unk2;
    }

    [AeroBlock]
    public struct FabricationData_00d9ad00
    {
        public uint Unk1;
        public uint Unk2;
    }

    [AeroBlock]
    public struct FabricationData_016f6360
    {
        [AeroString] public string Unk1;
        public FabricationData_VariableType_016f55c0 Unk2;
    }

    [AeroBlock]
    public struct FabricationData_VariableType_016f55c0
    {
        public uint TypeSelector;

        [AeroIf(nameof(TypeSelector), 1)]
        [AeroString] public string Value1;

        [AeroIf(nameof(TypeSelector), 2)]
        public sbyte Value2;

        [AeroIf(nameof(TypeSelector), 3)]
        public short Value3;

        [AeroIf(nameof(TypeSelector), 4)]
        public int Value4;

        [AeroIf(nameof(TypeSelector), 5)]
        public long Value5;

        [AeroIf(nameof(TypeSelector), 6)]
        public byte Value6;

        [AeroIf(nameof(TypeSelector), 7)]
        public ushort Value7;

        [AeroIf(nameof(TypeSelector), 8)]
        public uint Value8;

        [AeroIf(nameof(TypeSelector), 9)]
        public ulong Value9;

        [AeroIf(nameof(TypeSelector), 10)]
        public ushort Value10; // Half or Quantised Float?

        [AeroIf(nameof(TypeSelector), 0xb)]
        public float Value11;

        [AeroIf(nameof(TypeSelector), 0xc)]
        public double Value12; // Assumption

        [AeroIf(nameof(TypeSelector), 0xd)]
        public byte Value13;

        [AeroIf(nameof(TypeSelector), 0xe)]
        public ulong Value14; // ?

        // Tempt the devil and you shall face the wrath of six thousand errors
        /*
        [AeroIf(nameof(TypeSelector), 0xf)]
        [AeroArray(typeof(int))] public FabricationData_016f6360[] Value15; // Double Inception

        [AeroIf(nameof(TypeSelector), 0x10)]
        [AeroArray(typeof(byte))] public FabricationData_VariableType_016f55c0[] Value16; // Regular Inception
        */
    }
}