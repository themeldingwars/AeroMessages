using Bitter;
using System;
using System.Collections.Generic;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 6, 1, true)]
    public class CharacterLocalEffectsControllerUpdate : BaseScript
    {
        enum ShadowFieldIndex : byte
        {
            LocalStatusEffects_0 = 0x00,
            LocalStatusEffects_1 = 0x01,
            LocalStatusEffects_2 = 0x02,
            LocalStatusEffects_3 = 0x03,
            LocalStatusEffects_4 = 0x04,
            LocalStatusEffects_5 = 0x05,
            LocalStatusEffects_6 = 0x06,
            LocalStatusEffects_7 = 0x07,
            LocalStatusEffects_8 = 0x08,
            LocalStatusEffects_9 = 0x09,
            LocalStatusEffects_10 = 0x0a,
            LocalStatusEffects_11 = 0x0b,
            LocalStatusEffects_12 = 0x0c,
            LocalStatusEffects_13 = 0x0d,
            LocalStatusEffects_14 = 0x0e,
            LocalStatusEffects_15 = 0x0f,
            LocalStatusEffects_16 = 0x10,
            LocalStatusEffects_17 = 0x11,
            LocalStatusEffects_18 = 0x12,
            LocalStatusEffects_19 = 0x13,
            LocalStatusEffects_20 = 0x14,
            LocalStatusEffects_21 = 0x15,
            LocalStatusEffects_22 = 0x16,
            LocalStatusEffects_23 = 0x17,
            LocalStatusEffects_24 = 0x18,
            LocalStatusEffects_25 = 0x19,
            LocalStatusEffects_26 = 0x1a,
            LocalStatusEffects_27 = 0x1b,
            LocalStatusEffects_28 = 0x1c,
            LocalStatusEffects_29 = 0x1d,
            LocalStatusEffects_30 = 0x1e,
            LocalStatusEffects_31 = 0x1f,
            LocalStatusEffects_32 = 0x20,
            LocalStatusEffects_33 = 0x21,
            LocalStatusEffects_34 = 0x22,
            LocalStatusEffects_35 = 0x23,
            LocalStatusEffects_36 = 0x24,
            LocalStatusEffects_37 = 0x25,
            LocalStatusEffects_38 = 0x26,
            LocalStatusEffects_39 = 0x27,
            LocalStatusEffects_40 = 0x28,
            LocalStatusEffects_41 = 0x29,
            LocalStatusEffects_42 = 0x2a,
            LocalStatusEffects_43 = 0x2b,
            LocalStatusEffects_44 = 0x2c,
            LocalStatusEffects_45 = 0x2d,
            LocalStatusEffects_46 = 0x2e,
            LocalStatusEffects_47 = 0x2f,
            LocalStatusEffects_48 = 0x30,
            LocalStatusEffects_49 = 0x31,
            LocalStatusEffects_50 = 0x32,
            LocalStatusEffects_51 = 0x33,
            LocalStatusEffects_52 = 0x34,
            LocalStatusEffects_53 = 0x35,
            LocalStatusEffects_54 = 0x36,
            LocalStatusEffects_55 = 0x37,
            LocalStatusEffects_56 = 0x38,
            LocalStatusEffects_57 = 0x39,
            LocalStatusEffects_58 = 0x3a,
            LocalStatusEffects_59 = 0x3b,
            LocalStatusEffects_60 = 0x3c,
            LocalStatusEffects_61 = 0x3d,
            LocalStatusEffects_62 = 0x3e,
            LocalStatusEffects_63 = 0x3f,

            Unk_0x80 = 0x80,
            Unk_0x81 = 0x81,
        }

        public string PeepWarning; // Will be set if we encounter an unhandled shadowfield

        public LocalStatusEffectsData? LocalStatusEffects_0;
        public LocalStatusEffectsData? LocalStatusEffects_1;
        public LocalStatusEffectsData? LocalStatusEffects_2;
        public LocalStatusEffectsData? LocalStatusEffects_3;
        public LocalStatusEffectsData? LocalStatusEffects_4;
        public LocalStatusEffectsData? LocalStatusEffects_5;
        public LocalStatusEffectsData? LocalStatusEffects_6;
        public LocalStatusEffectsData? LocalStatusEffects_7;
        public LocalStatusEffectsData? LocalStatusEffects_8;
        public LocalStatusEffectsData? LocalStatusEffects_9;
        public LocalStatusEffectsData? LocalStatusEffects_10;
        public LocalStatusEffectsData? LocalStatusEffects_11;
        public LocalStatusEffectsData? LocalStatusEffects_12;
        public LocalStatusEffectsData? LocalStatusEffects_13;
        public LocalStatusEffectsData? LocalStatusEffects_14;
        public LocalStatusEffectsData? LocalStatusEffects_15;
        public LocalStatusEffectsData? LocalStatusEffects_16;
        public LocalStatusEffectsData? LocalStatusEffects_17;
        public LocalStatusEffectsData? LocalStatusEffects_18;
        public LocalStatusEffectsData? LocalStatusEffects_19;
        public LocalStatusEffectsData? LocalStatusEffects_20;
        public LocalStatusEffectsData? LocalStatusEffects_21;
        public LocalStatusEffectsData? LocalStatusEffects_22;
        public LocalStatusEffectsData? LocalStatusEffects_23;
        public LocalStatusEffectsData? LocalStatusEffects_24;
        public LocalStatusEffectsData? LocalStatusEffects_25;
        public LocalStatusEffectsData? LocalStatusEffects_26;
        public LocalStatusEffectsData? LocalStatusEffects_27;
        public LocalStatusEffectsData? LocalStatusEffects_28;
        public LocalStatusEffectsData? LocalStatusEffects_29;
        public LocalStatusEffectsData? LocalStatusEffects_30;
        public LocalStatusEffectsData? LocalStatusEffects_31;
        public LocalStatusEffectsData? LocalStatusEffects_32;
        public LocalStatusEffectsData? LocalStatusEffects_33;
        public LocalStatusEffectsData? LocalStatusEffects_34;
        public LocalStatusEffectsData? LocalStatusEffects_35;
        public LocalStatusEffectsData? LocalStatusEffects_36;
        public LocalStatusEffectsData? LocalStatusEffects_37;
        public LocalStatusEffectsData? LocalStatusEffects_38;
        public LocalStatusEffectsData? LocalStatusEffects_39;
        public LocalStatusEffectsData? LocalStatusEffects_40;
        public LocalStatusEffectsData? LocalStatusEffects_41;
        public LocalStatusEffectsData? LocalStatusEffects_42;
        public LocalStatusEffectsData? LocalStatusEffects_43;
        public LocalStatusEffectsData? LocalStatusEffects_44;
        public LocalStatusEffectsData? LocalStatusEffects_45;
        public LocalStatusEffectsData? LocalStatusEffects_46;
        public LocalStatusEffectsData? LocalStatusEffects_47;
        public LocalStatusEffectsData? LocalStatusEffects_48;
        public LocalStatusEffectsData? LocalStatusEffects_49;
        public LocalStatusEffectsData? LocalStatusEffects_50;
        public LocalStatusEffectsData? LocalStatusEffects_51;
        public LocalStatusEffectsData? LocalStatusEffects_52;
        public LocalStatusEffectsData? LocalStatusEffects_53;
        public LocalStatusEffectsData? LocalStatusEffects_54;
        public LocalStatusEffectsData? LocalStatusEffects_55;
        public LocalStatusEffectsData? LocalStatusEffects_56;
        public LocalStatusEffectsData? LocalStatusEffects_57;
        public LocalStatusEffectsData? LocalStatusEffects_58;
        public LocalStatusEffectsData? LocalStatusEffects_59;
        public LocalStatusEffectsData? LocalStatusEffects_60;
        public LocalStatusEffectsData? LocalStatusEffects_61;
        public LocalStatusEffectsData? LocalStatusEffects_62;
        public LocalStatusEffectsData? LocalStatusEffects_63;

        public bool? Unk_0x80; // Cancel for 0x00?
        public bool? Unk_0x81; // Cancel for 0x00?


        public byte[] UnableToParse;

        public override void Read(Bitter.BinaryStream Stream)
        {
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            do
            {
                ShadowFieldIndex sfidx = (ShadowFieldIndex) (Stream.Read.Byte());
                switch (sfidx)
                {
                    case ShadowFieldIndex.LocalStatusEffects_0:
                        LocalStatusEffects_0 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_1:
                        LocalStatusEffects_1 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_2:
                        LocalStatusEffects_2 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_3:
                        LocalStatusEffects_3 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_4:
                        LocalStatusEffects_4 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_5:
                        LocalStatusEffects_5 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_6:
                        LocalStatusEffects_6 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_7:
                        LocalStatusEffects_7 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_8:
                        LocalStatusEffects_8 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_9:
                        LocalStatusEffects_9 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_10:
                        LocalStatusEffects_10 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_11:
                        LocalStatusEffects_11 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_12:
                        LocalStatusEffects_12 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_13:
                        LocalStatusEffects_13 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_14:
                        LocalStatusEffects_14 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_15:
                        LocalStatusEffects_15 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_16:
                        LocalStatusEffects_16 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_17:
                        LocalStatusEffects_17 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_18:
                        LocalStatusEffects_18 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_19:
                        LocalStatusEffects_19 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_20:
                        LocalStatusEffects_20 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_21:
                        LocalStatusEffects_21 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_22:
                        LocalStatusEffects_22 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_23:
                        LocalStatusEffects_23 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_24:
                        LocalStatusEffects_24 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_25:
                        LocalStatusEffects_25 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_26:
                        LocalStatusEffects_26 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_27:
                        LocalStatusEffects_27 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_28:
                        LocalStatusEffects_28 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_29:
                        LocalStatusEffects_29 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_30:
                        LocalStatusEffects_30 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_31:
                        LocalStatusEffects_31 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_32:
                        LocalStatusEffects_32 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_33:
                        LocalStatusEffects_33 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_34:
                        LocalStatusEffects_34 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_35:
                        LocalStatusEffects_35 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_36:
                        LocalStatusEffects_36 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_37:
                        LocalStatusEffects_37 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_38:
                        LocalStatusEffects_38 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_39:
                        LocalStatusEffects_39 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_40:
                        LocalStatusEffects_40 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_41:
                        LocalStatusEffects_41 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_42:
                        LocalStatusEffects_42 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_43:
                        LocalStatusEffects_43 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_44:
                        LocalStatusEffects_44 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_45:
                        LocalStatusEffects_45 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_46:
                        LocalStatusEffects_46 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_47:
                        LocalStatusEffects_47 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_48:
                        LocalStatusEffects_48 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_49:
                        LocalStatusEffects_49 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_50:
                        LocalStatusEffects_50 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_51:
                        LocalStatusEffects_51 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_52:
                        LocalStatusEffects_52 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_53:
                        LocalStatusEffects_53 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_54:
                        LocalStatusEffects_54 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_55:
                        LocalStatusEffects_55 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_56:
                        LocalStatusEffects_56 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_57:
                        LocalStatusEffects_57 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_58:
                        LocalStatusEffects_58 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_59:
                        LocalStatusEffects_59 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_60:
                        LocalStatusEffects_60 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_61:
                        LocalStatusEffects_61 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_62:
                        LocalStatusEffects_62 = Stream.Read.LocalStatusEffectsData();
                        break;
                    case ShadowFieldIndex.LocalStatusEffects_63:
                        LocalStatusEffects_63 = Stream.Read.LocalStatusEffectsData();
                        break;

                    case ShadowFieldIndex.Unk_0x80:
                        Unk_0x80 = true;
                        break;

                    case ShadowFieldIndex.Unk_0x81:
                        Unk_0x81 = true;
                        break;

                    default:
                        PeepWarning += $"Dont know how to parse shadowfield {sfidx}";
                        int remaining = (int)(Stream.baseStream.Length - Stream.baseStream.ByteOffset);
                        UnableToParse = Stream.Read.ByteArray(remaining);
                        break;
                }
            }
            while (Stream.baseStream.ByteOffset < Stream.baseStream.Length);

        }
    }

    public struct LocalStatusEffectsData
    {
        public byte[] Entity;
        public uint? Value;
        public uint? Time;

        public LocalStatusEffectsData(Bitter.BinaryReader R)
        {
           Entity = R.ByteArray(8);
           Value = R.UInt();
           Time = R.UInt();
        }

        public override string ToString() => $"Value: {Value}, Time: {Time}, Entity: [{(Entity != null ? String.Join(", ", Entity) : "null")}]";
    }

    public static class MyExtensions
    {
        public static LocalStatusEffectsData LocalStatusEffectsData(this Bitter.BinaryReader R)
        {
            return new LocalStatusEffectsData(R);
        }

        public static LocalStatusEffectsData[] LocalStatusEffectsDataArray(this Bitter.BinaryReader R, int num)
        {
            List<LocalStatusEffectsData> list = new List<LocalStatusEffectsData>();
            for (int i = 1; i <= num; i++)
            {
                list.Add(R.LocalStatusEffectsData());
            }
            return list.ToArray();
        }
    }
}