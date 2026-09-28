using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.WorkbenchUpdate, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class WorkbenchUpdate
    {
        public sbyte ClearExistingData;
        [AeroArray(typeof(byte))] public ulong[] RemovedWorkbenchGuids;
        [AeroArray(typeof(byte))] public WorkbenchUpdateData[] Workbenches;
    }

    [AeroBlock]
    public struct WorkbenchUpdateData
    {
        public ulong WorkbenchGuid;
        public uint BlueprintId;
        public uint Repetitions;
        public uint Position; // workbench slot
        [AeroArray(typeof(byte))] public WorkbenchUpdateInner1[] Inputs;
        public byte MarkedComplete;
        public uint RbCompleteCost; // Red Beans to finish now
        [AeroArray(typeof(byte))] public WorkbenchUpdateInner2[] Outputs;
        public uint TotalSecondsRequired;
        public uint SecondsRemaining; // as of TimerReferenceTimeUs
        public byte Unk11;
        public ulong TimerReferenceTimeUs; // unix time in microseconds
    }

    [AeroBlock]
    public struct WorkbenchUpdateInner1
    {
        public uint Unk1;
        [AeroArray(typeof(byte))] public WorkbenchUpdateInner1_1[] Items;
    }

    [AeroBlock]
    public struct WorkbenchUpdateInner1_1
    {
        public uint ItemTypeId;
        public uint Quantity;
        public uint Quality;
        [AeroString] public string ResourceType;
    }

    [AeroBlock]
    public struct WorkbenchUpdateInner2
    {
        public uint ItemTypeId;
        public uint Quantity;
        public uint Quality;
        [AeroArray(typeof(byte))] public uint[] Modules;
    }
}