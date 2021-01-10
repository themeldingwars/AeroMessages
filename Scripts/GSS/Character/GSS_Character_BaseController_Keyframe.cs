using System.Collections.Generic;
using Bitter;
namespace PacketPeepScript
{
    [Script(MessageType.GSS, 2, 4, true)]
    public class CharacterBaseControllerKeyframe : BaseScript
    {
        public ulong InstanceID;
        public uint UnkInt1;
        public uint UnkInt2;
        public uint UsedInvSlots;
        public uint MaxInvSlots;
        // Skip Zeros
        public string DisplayName;
        public string UniqueName;
        public byte Gender;
        public byte Race;
        public uint CharInfoID;
        public uint HeadMain;
        public uint Eyes;
        public byte IsNPC;
        public byte IsStaff;
        public uint CharTypeID;
        public uint VoiceSet;
        public ushort TitleID;
        public uint NameLocaliztionID;
        public byte NumHeadAccessories;
        public uint[] HeadAccessories;
        public uint VehicleLoadout;
        public uint GliderLoadout;
        
        public Visuals CharacterVisuals;
        
        public string ArmyName;
        
        public uint KeyFrameTime_0;
        public uint KeyFrameTime_1;
        public uint KeyFrameTime_2;
        public uint KeyFrameTime_3;
        public uint KeyFrameTime_4;
        public uint KeyFrameTime_5;
        
        public uint ChassisLoadout;
        public byte NumGear;
        public IList<Gear> Gear;
        public Visuals ChassisVisuals;
        
        public uint BackpackLoadout;
        public byte NumAbilities;
        public IList<Ability> Abilities;
        public byte NumAbilityModules;
        public IList<AbilityModule> AbilityModules;
        
        public uint PrimaryWeaponID;
        public byte NumPrimaryWeaponModules;
        public IList<WeaponModule> PrimaryWeaponModules;
        public Visuals PrimaryWeaponVisuals;
        
        public uint SecondaryWeaponID;
        public byte NumSecondaryWeaponModules;
        public IList<WeaponModule> SecondaryWeaponModules;
        public Visuals SecondaryWeaponVisuals;
        
        public uint LoadoutID;
        
        public uint UnkSfxID_0a;
        public uint UnkSfxID_0b;
        
        public float PosX;
        public float PosY;
        public float PosZ;
        
        public float RotW;
        public float RotX;
        public float RotY;
        public float RotZ;
        
        public float AimX;
        public float AimY;
        public float AimZ;
        
        public float VelX;
        public float VelY;
        public float VelZ;
        
        public ushort MovementState;
        public ushort Jets;
        public ushort AirGroundTimer;
        public ushort JumpTimer;
        
        public uint UnkSfxID_0d;
        
        public byte CharacterState;
        
        public byte FactionMode;
        public byte FactionID;
        
        public uint CurrentHealth;
        public uint MaxHealth;
        
        public float JumpJetEnergy;
        public uint MaxJumpJetEnergy;
        public float JumpJetRecharge;
        
        public ushort NumItemStats;
        public List<StatValue> ItemStatValues;
        
        public ushort NumWeapon1Stats;
        public List<StatValue> Weapon1StatValues;
        
        public ushort NumWeapon2Stats;
        public List<StatValue> Weapon2StatValues;
        
        public ushort NumAttribCats1;
        public List<StatValue> AttribCats1;
        
        public ushort NumAttribCats2;
        public List<StatValue> AttribCats2;
        
        public ulong ArmyID;
        
        public override void Read(Bitter.BinaryStream Stream)
        {
            MyExtensions.BStream = Stream;
            //KeyFrameTime = new uint[32];
            Stream.ByteOrder = BinaryStream.Endianness.LittleEndian;
            //Stream.ByteOrder = BinaryStream.Endianness.BigEndian; 530239
            
            InstanceID = Stream.Read.ULong();
            UnkInt1 = Stream.Read.UInt();
            UnkInt2 = Stream.Read.UInt();
            
            /*_ = */Stream.Read.Byte();
            
            UsedInvSlots = Stream.Read.UInt();
            MaxInvSlots = Stream.Read.UInt();
            
            Stream.Read.SkipZeros();
            
            DisplayName = Stream.Read.StringZ();
            UniqueName = Stream.Read.StringZ();
            Gender = Stream.Read.Byte();
            Race = Stream.Read.Byte();
            CharInfoID = Stream.Read.UInt();
            HeadMain = Stream.Read.UInt();
            Eyes = Stream.Read.UInt();
            
            /*_ = */Stream.Read.Byte();
            
            IsNPC = Stream.Read.Byte();
            IsStaff = Stream.Read.Byte();
            CharTypeID = Stream.Read.UInt();
            VoiceSet = Stream.Read.UInt();
            TitleID = Stream.Read.UShort();
            NameLocaliztionID = Stream.Read.UInt();
            
            NumHeadAccessories = Stream.Read.Byte();
            HeadAccessories = Stream.Read.UIntArray((int)NumHeadAccessories);
            
            VehicleLoadout = Stream.Read.UInt();
            GliderLoadout = Stream.Read.UInt();
            
            CharacterVisuals = Stream.Read.Type<Visuals>();
            
            Stream.Read.SkipZeros();
            ArmyName = Stream.Read.StringZ();
            
            KeyFrameTime_0 = Stream.Read.UInt();
            
            /*_ = */Stream.Read.Byte();     // 0 something, as in count?
            
            ChassisLoadout = Stream.Read.UInt();
            /*_ = */Stream.Read.ByteArray(3);   // ???
            
            NumGear = Stream.Read.Byte();
            Gear = Stream.Read.TypeList<Gear>(NumGear);
            
            ChassisVisuals = Stream.Read.Type<Visuals>();
            ///*_ = */Stream.Read.ByteArray(3); // ???
            
            BackpackLoadout = Stream.Read.UInt();
            /*_ = */Stream.Read.ByteArray(3);   // ???
            
            NumAbilities = Stream.Read.Byte();
            Abilities = Stream.Read.TypeList<Ability>(NumAbilities);
            
            NumAbilityModules = Stream.Read.Byte();
            AbilityModules = Stream.Read.TypeList<AbilityModule>(NumAbilityModules);
            
            /*_ = */Stream.Read.UInt();
            /*_ = */Stream.Read.UInt();
            /*_ = */Stream.Read.UInt();
            
            PrimaryWeaponID = Stream.Read.UInt();
            /*_ = */Stream.Read.ByteArray(3);   // ???
            
            NumPrimaryWeaponModules = Stream.Read.Byte();
            PrimaryWeaponModules = Stream.Read.TypeList<WeaponModule>(NumPrimaryWeaponModules);
            PrimaryWeaponVisuals = Stream.Read.Type<Visuals>();
            ///*_ = */Stream.Read.ByteArray(3); // ???

            /*_ = */Stream.Read.UInt();
            /*_ = */Stream.Read.UInt();
            
            SecondaryWeaponID = Stream.Read.UInt();
            /*_ = */Stream.Read.ByteArray(3);   // ???
            
            NumSecondaryWeaponModules = Stream.Read.Byte();
            SecondaryWeaponModules = Stream.Read.TypeList<WeaponModule>(NumSecondaryWeaponModules);
            SecondaryWeaponVisuals = Stream.Read.Type<Visuals>();
            
            ///*_ = */Stream.Read.ByteArray(3); // ???
            /*_ = */Stream.Read.UIntArray(3);
            /*_ = */Stream.Read.Byte();
            LoadoutID = Stream.Read.UInt();
            
            UnkSfxID_0a = Stream.Read.UInt();   // sfidx 0x0a
            UnkSfxID_0b = Stream.Read.UInt();   // sfidx 0x0b
            /*_ = */Stream.Read.UInt();
            
            
            // Movement
            KeyFrameTime_1 = Stream.Read.UInt();
            
            PosX = Stream.Read.Float();
            PosY = Stream.Read.Float();
            PosZ = Stream.Read.Float();
            
            RotW = Stream.Read.Float();
            RotX = Stream.Read.Float();
            RotY = Stream.Read.Float();
            RotZ = Stream.Read.Float();
            
            AimX = Stream.Read.Float();
            AimY = Stream.Read.Float();
            AimZ = Stream.Read.Float();
            
            VelX = Stream.Read.Float();
            VelY = Stream.Read.Float();
            VelZ = Stream.Read.Float();
            
            MovementState = Stream.Read.UShort();
            /*_ = */Stream.Read.UShort();
            Jets = Stream.Read.UShort();
            AirGroundTimer = Stream.Read.UShort();
            JumpTimer = Stream.Read.UShort();
            /*_ = */Stream.Read.Byte();
            
            UnkSfxID_0d = Stream.Read.UInt(); // sfidx 0x0d
            
            /*_ = */Stream.Read.Byte();
            
            CharacterState = Stream.Read.Byte();
            
            KeyFrameTime_2 = Stream.Read.UInt();
            
            FactionMode = Stream.Read.Byte();
            FactionID = Stream.Read.Byte();

            ///*_ = */Stream.Read.UInt();   // ?
            ///*_ = */Stream.Read.UInt();
            
            CurrentHealth = Stream.Read.UInt();
            
            /*_ = */Stream.Read.UInt(); // ??? sfidx 0x14
            
            /*_ = */Stream.Read.UInt(); // ??? sfidx 0x15
            KeyFrameTime_3 = Stream.Read.UInt(); // gametime?
            
            MaxHealth = Stream.Read.UInt();
            KeyFrameTime_4 = Stream.Read.UInt(); // gametime?
            
            /*_ = */Stream.Read.Byte(); // ??? sfidx 0x17 effects flag?
            
            JumpJetEnergy = Stream.Read.Float();
            MaxJumpJetEnergy = Stream.Read.UInt();
            JumpJetRecharge = Stream.Read.Float();
            KeyFrameTime_5 = Stream.Read.UInt(); // gametime?
            
            ///*_ = */Stream.Read.UIntArray(4);
            
            NumItemStats = Stream.Read.UShort();
            ItemStatValues = Stream.Read.TypeList<StatValue>(NumItemStats);
            
            /*_ = */Stream.Read.UInt(); // ???
            
            NumWeapon1Stats = Stream.Read.UShort();
            Weapon1StatValues = Stream.Read.TypeList<StatValue>(NumWeapon1Stats);
            
            /*_ = */Stream.Read.UInt(); // ???
            
            NumWeapon2Stats = Stream.Read.UShort();
            Weapon2StatValues = Stream.Read.TypeList<StatValue>(NumWeapon2Stats);
            
            /*_ = */Stream.Read.UInt(); // ???
            
            NumAttribCats1 = Stream.Read.UShort();
            AttribCats1 = Stream.Read.TypeList<StatValue>(NumAttribCats1);
            
            NumAttribCats2 = Stream.Read.UShort();
            AttribCats2 = Stream.Read.TypeList<StatValue>(NumAttribCats2);
            
            /*_ = */Stream.Read.UInt(); // ???
            /*_ = */Stream.Read.UInt(); // ???
            
            /*_ = */Stream.Read.Byte();
            
            ArmyID = Stream.Read.ULong();
            
            
        }
    }

    // Add "MyExtensions.BStream = Stream;" as first line in Packet Read function.
    public static class MyExtensions
    {
        public static Bitter.BinaryStream BStream;
        
        public static string StringZ(this Bitter.BinaryReader rdr)
        {
            string ret = "";
            
            do {
                byte b = rdr.Byte();
                if (b == 0x00)
                    break;
                
                ret += (char)b;
            } while (BStream.baseStream.ByteOffset < BStream.baseStream.Length);
            
            return ret;
        }
        
        public static void SkipZeros(this Bitter.BinaryReader rdr)
        {
            byte b;
            do {
                b = rdr.Byte();
            } while( b == 0 );
            
            BStream.baseStream.ByteOffset--;
        }
    }
    
    public class Palette : Bitter.BinaryWrapper.ReadWrite
    {
        public byte Type;
        public uint ID;
        
        public void Read(BinaryStream Stream)
        {
            Type = Stream.Read.Byte();
            ID = Stream.Read.UInt();
        }
        
        public void Write(BinaryStream Stream)
        {
            Stream.Write.Byte(Type);
            Stream.Write.UInt(ID);
        }
        
        public override string ToString() => $"Type: {Type}, ID: {ID}";
    }
    
    public class StatValue : Bitter.BinaryWrapper.ReadWrite
    {
        public ushort StatID;
        public float Value;
        
        public void Read(BinaryStream Stream)
        {
            StatID = Stream.Read.UShort();
            Value = Stream.Read.Float();
        }
        
        public void Write(BinaryStream Stream)
        {
            throw new System.NotImplementedException();
        }
        
        public override string ToString() => $"StatID: {StatID}, Value: {Value}";
    }
    
    public class Pattern : Bitter.BinaryWrapper.ReadWrite
    {
        public uint ID;
        public ushort[] Transform;
        public byte Usage;
        
        
        public void Read(BinaryStream Stream)
        {
            ID = Stream.Read.UInt();
            Transform = Stream.Read.UShortArray(4);
            Usage = Stream.Read.Byte();
        }
        
        public void Write(BinaryStream Stream)
        {
            throw new System.NotImplementedException();
        }
        
        public override string ToString() => $"ID: {ID}, Usage: {Usage}";
    }
    
    public class Visuals : Bitter.BinaryWrapper.ReadWrite
    {
        public byte NumDecals;
        public IList<Decal> Decals;
        
        public byte NumDecalGradients;
        public IList<DecalGradient> DecalGradients;
        
        public byte NumColors;
        public uint[] Colors;
        
        public byte NumPalettes;
        public IList<Palette> Palettes;
        
        public byte NumPatterns;
        public IList<Pattern> Patterns;
        
        public byte NumOrnamentGroups;
        public uint[] OrnamentGroups;
        
        public byte NumUnk1;
        public uint[] ItemsUnk1;
        
        public byte NumUnk2;
        public uint[] ItemsUnk2;
        
        public byte NumUnk3;
        public uint[] ItemsUnk3;
        
        public void Read(BinaryStream Stream)
        {
            NumDecals = Stream.Read.Byte();
            Decals = Stream.Read.TypeList<Decal>(NumDecals);
            
            NumDecalGradients = Stream.Read.Byte();
            DecalGradients = Stream.Read.TypeList<DecalGradient>(NumDecalGradients);
            
            NumColors = Stream.Read.Byte();
            Colors = Stream.Read.UIntArray((int)NumColors);
            
            NumPalettes = Stream.Read.Byte();
            Palettes = Stream.Read.TypeList<Palette>((int)NumPalettes);
            
            NumPatterns = Stream.Read.Byte();
            Patterns = Stream.Read.TypeList<Pattern>((int)NumPatterns);
            
            NumOrnamentGroups = Stream.Read.Byte();
            OrnamentGroups = Stream.Read.UIntArray((int)NumOrnamentGroups);
            
            NumUnk1 = Stream.Read.Byte();
            if( NumUnk1 > 0 )
                throw new System.NotImplementedException();
            ItemsUnk1 = Stream.Read.UIntArray((int)NumUnk1);
            
            NumUnk2 = Stream.Read.Byte();
            if( NumUnk2 > 0 )
                throw new System.NotImplementedException();
            ItemsUnk2 = Stream.Read.UIntArray((int)NumUnk2);
            
            NumUnk3 = Stream.Read.Byte();
            if( NumUnk3 > 0 )
                throw new System.NotImplementedException();
            ItemsUnk3 = Stream.Read.UIntArray((int)NumUnk3);
        }
        
        public void Write(BinaryStream Stream)
        {
            throw new System.NotImplementedException();
        }
        
        public override string ToString() => $"Colors: {Colors}, Palettes: {Palettes}, Patterns: {Patterns}";
    }
    
    public class Gear : Bitter.BinaryWrapper.ReadWrite
    {
        public uint ID;
        public byte[] Unk;
        
        public void Read(BinaryStream Stream)
        {
            ID = Stream.Read.UInt();
            Unk = Stream.Read.ByteArray(3);
        }
        
        public void Write(BinaryStream Stream)
        {
            throw new System.NotImplementedException();
        }
        
        public override string ToString() => $"ID: {ID}";
    }
    
    public class Ability : Bitter.BinaryWrapper.ReadWrite
    {
        public uint ID;
        public byte Slot;
        
        public void Read(BinaryStream Stream)
        {
            ID = Stream.Read.UInt();
            Slot = Stream.Read.Byte();
        }
        
        public void Write(BinaryStream Stream)
        {
            throw new System.NotImplementedException();
        }
        
        public override string ToString() => $"ID: {ID}, Slot: {Slot}";
    }
    
    public class AbilityModule : Bitter.BinaryWrapper.ReadWrite
    {
        public uint Unk;
        public uint ID;
        
        public void Read(BinaryStream Stream)
        {
            Unk = Stream.Read.UInt();
            ID = Stream.Read.UInt();
        }
        
        public void Write(BinaryStream Stream)
        {
            throw new System.NotImplementedException();
        }
        
        public override string ToString() => $"ID: {ID}, Unk: {Unk}";
    }
    
    public class Decal : Bitter.BinaryWrapper.ReadWrite
    {
        public uint ID;
        public uint Color;
        public ushort[] Transform;
        public byte Usage;
        
        public void Read(BinaryStream Stream)
        {
            ID = Stream.Read.UInt();
            Color = Stream.Read.UInt();
            Transform = Stream.Read.UShortArray(12);
            Usage = Stream.Read.Byte();
        }
        
        public void Write(BinaryStream Stream)
        {
            throw new System.NotImplementedException();
        }
        
        public override string ToString() => $"ID: {ID}, Color: {Color}, Usage: {Usage}";
    }
    
    public class DecalGradient : Bitter.BinaryWrapper.ReadWrite
    {
        public void Read(BinaryStream Stream)
        {
            /*_ = */Stream.Read.ByteArray(1);
        }
        
        public void Write(BinaryStream Stream)
        {
            throw new System.NotImplementedException();
        }
        
        public override string ToString() => $"ID: ";
    }
    
    public class WeaponModule : Bitter.BinaryWrapper.ReadWrite
    {
        public uint ID;
        public byte[] Unk;
        
        public void Read(BinaryStream Stream)
        {
            ID = Stream.Read.UInt();
            Unk = Stream.Read.ByteArray(3);
        }
        
        public void Write(BinaryStream Stream)
        {
            throw new System.NotImplementedException();
        }
        
        public override string ToString() => $"ID: {ID}, Unk: {Unk}";
    }
}