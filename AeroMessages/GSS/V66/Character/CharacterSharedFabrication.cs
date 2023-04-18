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
        [AeroArray(typeof(int))] public GenericKeyVariablePair[] Unk19;
    }

    [AeroBlock]
    public struct FabricationData_00d973d0
    {
        public uint Unk1;
        public uint Unk2;
        public uint Unk3;
        [AeroArray(typeof(byte))] public FabricationData_00d9a1a0[] Unk4;
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
}