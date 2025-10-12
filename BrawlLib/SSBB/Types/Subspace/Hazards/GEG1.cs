using BrawlLib.Internal;
using BrawlLib.SSBB.Types.Subspace.Triggers;
using System.Runtime.InteropServices;

namespace BrawlLib.SSBB.Types.Subspace.Hazards
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct GEG1Entry
    {
        public const int Size = 0x84;

        public MotionPathData _motionPathData;          // 0x00
        public bshort _epbmIndex;                       // 0x08
        public bshort _epspIndex;                       // 0x0A
        public bushort _connectedEnemyID;               // 0x0C
        public bshort _unknown0x0E;                     // 0x0E
        public buint _unknown0x10;
        public buint _unknown0x14;
        public buint _unknown0x18;
        public bushort _enemyID;                        // 0x1C
        public bshort _unknown0x1E;
        public buint _startingAction;                   // 0x20
        public buint _unknown0x24;
        public bfloat _spawnPosX;                       // 0x28
        public bfloat _spawnPosY;                       // 0x2C
        public bfloat _spawnPosZ;                       // 0x30
        public bfloat _unknown0x34;
        public bfloat _posX1;                           // 0x38
        public bfloat _posX2;                           // 0x3C
        public bfloat _posY1;                           // 0x40
        public bfloat _posY2;                           // 0x44
        public bfloat _initialSpawnProbability;         // 0x48
        public bfloat _initialSpawnDelayTimer;          // 0x4C
        public bfloat _initialSpawnDelayTimerVariance;  // 0x50
        public bfloat _initialSpawnDelayTimerOffset;    // 0x54
        public bfloat _subsequentSpawnTimer;            // 0x58
        public bfloat _subsequentSpawnProbability;      // 0x5C
        public bfloat _unknown0x60;
        public byte _difficultyValueTableIndex;         // 0x64
        public byte _minimumSpawnDifficulty;            // 0x65
        public byte _maximumSpawns;                     // 0x66
        public bool8 _isFacingRight;                    // 0x67
        public bool8 _canRespawn;                       // 0x68
        public bool8 _canReload;                        // 0x69
        public bool8 _unloadWhenOffscreen;              // 0x6A
        public byte _unknown0x6B;
        public bint _itemDropGenParamId;                // 0x6C
        public bint _rareItemDropGenParamId;            // 0x70
        public byte _respawnCount;                      // 0x74
        public byte _respawnOnlyIfRetriggered;          // 0x75
        public byte _unknown0x76;
        public byte _unknown0x77;
        public buint _unknown0x78;
        public TriggerData _spawnTrigger;               // 0x7C
        public TriggerData _defeatTrigger;              // 0x80

        private VoidPtr Address
        {
            get
            {
                fixed (void* ptr = &this)
                {
                    return ptr;
                }
            }
        }
    }
}