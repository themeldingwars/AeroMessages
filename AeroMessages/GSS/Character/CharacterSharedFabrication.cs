using Aero.Gen.Attributes;
using System.Numerics;

namespace AeroMessages.GSS.Character
{
    public enum FabricationResult : uint
    {
        Success = 0,
        InstanceNotFound = 1,
        NoActionsLeft = 2,
        Unknown = 3,
    }

    [AeroBlock]
    public struct FabricationCommonData1
    {
        public uint SequenceId;
        public uint RecipeId; // dbfabrication::Recipe
        public float ActionsLeft;
        public float TurnsUsed;
        public float BuildPoints;
        public float BuildPower;
        public float QualityPoints;
        public float QualityPower;
        public float Quantity;
        public float BuildTime;
        public float Level;
        public uint ResultIndex;
        public uint NextRarityAt;
        public float ResetCount;
        public float TinkeringChance;
        public float UpgradeChance;
        public uint Flags; // bits 0..2 rarity, bit 5 autogen, bit 6 soulbound
        public long StartedAt;
        public long EndsAt;
        public uint PrefixComponent; // item sdb id
        [AeroArray(typeof(uint))] public FabricationData_00d973d0[] ActionSet; // the client has room for 16 entries and doesn't check the count
        public uint LastActionUsed;
        public uint Rerolls;
        [AeroArray(typeof(byte))] public FabricationData_00d9aab0[] UsedActions;
        [AeroArray(typeof(byte))] public uint[] Modules; // item sdb ids
        [AeroArray(typeof(byte))] public FabricationData_00d9ad00[] IngredientMultipliers;
        [AeroArray(typeof(int))] public GenericKeyVariablePair[] LuaVars;
    }

    [AeroBlock]
    public struct FabricationData_00d973d0
    {
        public uint ActionId;
        public uint Flags; // rarity in the low 5 bits
        public float Cost;
        [AeroArray(typeof(byte))] public FabricationData_00d9a1a0[] Effects;
    }

    [AeroBlock]
    public struct FabricationData_00d9a1a0
    {
        public uint Type;
        public uint Value1; // uint or float depending on Type
        public float Value2;
    }

    [AeroBlock]
    public struct FabricationData_00d9aab0
    {
        public uint ActionId;
        public uint Count;
    }

    [AeroBlock]
    public struct FabricationData_00d9ad00
    {
        public uint IngredientId;
        public float Multiplier;
    }
}