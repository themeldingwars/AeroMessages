namespace AeroMessages.Common
{
    public enum Controller : byte
    {
        Generic                 = 0x00,
        Character               = 0x01,
        Melding                 = 0x0f,
        MeldingBubble           = 0x11,
        AreaVisualData          = 0x13,
        Vehicle                 = 0x1a,
        Anchor                  = 0x20,
        Deployable              = 0x22,
        Turret                  = 0x26,
        TinyObjectType          = 0x29,
        CharacterAbilityPhysics = 0x2a,
        ProjectileObjectType    = 0x2b,
        Outpost                 = 0x2c,
        ResourceArea            = 0x2e,
        ResourceNode            = 0x2f,
        Encounter               = 0x31,
        Carryable               = 0x32,
        LootStoreExtension      = 0x34,
        TeamManager             = 0x36,
    }
}