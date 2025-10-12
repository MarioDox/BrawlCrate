using BrawlLib.Internal;
using BrawlLib.SSBB.Types.Subspace.Objects;
using System;
using System.ComponentModel;

namespace BrawlLib.SSBB.ResourceNodes
{
    public class GBLKNode : BLOCEntryNode
    {
        public override Type SubEntryType => typeof(GBLKEntryNode);
        public override ResourceType ResourceFileType => ResourceType.GBLK;
        protected override string baseName => "Breakable Blocks";

        internal static ResourceNode TryParse(DataSource source, ResourceNode parent)
        {
            return source.Tag == "GBLK" ? new GBLKNode() : null;
        }
    }

    public unsafe class GBLKEntryNode : ResourceNode
    {
        internal GBLKEntry Data;
        public override ResourceType ResourceFileType => ResourceType.Unknown;
        
        [Category("GBLK")]
        [TypeConverter(typeof(Vector3StringConverter))]
        public Vector3 Position
        {
            get => new Vector3(Data._posX, Data._posY, Data._posZ);
            set
            {
                Data._posX = value._x;
                Data._posY = value._y;
                Data._posZ = value._z;
                SignalPropertyChange();
            }
        }

        [Category("GBLK")]
        [TypeConverter(typeof(Vector3StringConverter))]
        public Vector3 StretchOffset
        {
            get => new Vector3(Data._stretchX, Data._stretchY, Data._stretchZ);
            set
            {
                Data._stretchX = value._x;
                Data._stretchY = value._y;
                Data._stretchZ = value._z;
                SignalPropertyChange();
            }
        }

        [Category("GBLK")]
        public float HurtboxSize
        {
            get => Data._hurtboxSize;
            set
            {
                Data._hurtboxSize = value;
                SignalPropertyChange();
            }
        }

        [Category("GBLK")]
        public bool CanStretch
        {
            get => Data._canStretch;
            set
            {
                Data._canStretch = value;
                SignalPropertyChange();
            }
        }

        [Flags]
        public enum GblkHitbits : byte
        {
            None = 0b0000,
            Player = 0b0001,
            Unknown = 0b0010,
            Gimmicks = 0b0100,
            SomeProjectiles = 0b1000,
        }

        [Category("GBLK")]
        [Description("Disables destruction from these sources")]
        public GblkHitbits HitBits
        {
            get => (GblkHitbits)Data._hitBits;
            set
            {
                Data._hitBits = (byte)value;
                SignalPropertyChange();
            }
        }

        [Category("GBLK")]
        public bool Indestructable
        {
            get => Data._indestructable;
            set
            {
                Data._indestructable = value;
                SignalPropertyChange();
            }
        }

        [Category("Unknown")]
        public byte Unknown0x1F
        {
            get => Data._unknown0x1F;
            set
            {
                Data._unknown0x1F = value;
                SignalPropertyChange();
            }
        }

        [Category("Unknown")]
        public int Unknown0x20
        {
            get => Data._unknown0x20;
            set
            {
                Data._unknown0x20 = value;
                SignalPropertyChange();
            }
        }

        [Category("Unknown")]
        public byte Unknown0x24
        {
            get => Data._unknown0x24;
            set
            {
                Data._unknown0x24 = value;
                SignalPropertyChange();
            }
        }

        [Category("Unknown")]
        public byte Unknown0x25
        {
            get => Data._unknown0x25;
            set
            {
                Data._unknown0x25 = value;
                SignalPropertyChange();
            }
        }

        [Category("Unknown")]
        public byte Unknown0x26
        {
            get => Data._unknown0x26;
            set
            {
                Data._unknown0x26 = value;
                SignalPropertyChange();
            }
        }

        [Category("Unknown")]
        public byte Unknown0x27
        {
            get => Data._unknown0x27;
            set
            {
                Data._unknown0x27 = value;
                SignalPropertyChange();
            }
        }

        [Category("Unknown")]
        public byte Unknown0x28
        {
            get => Data._unknown0x28;
            set
            {
                Data._unknown0x28 = value;
                SignalPropertyChange();
            }
        }

        [Category("GBLK")]
        public byte BaseModelIndex
        {
            get => Data._baseModelIndex;
            set
            {
                Data._baseModelIndex = value;
                SignalPropertyChange();
            }
        }

        [Category("GBLK")]
        [Description("Respawn when reloading an area")]
        public bool RespawnOnReload
        {
            get => Data._respawnOnReload;
            set
            {
                Data._respawnOnReload = value;
                SignalPropertyChange();
            }
        }

        [Category("GBLK")]
        [Description("Disables interactions with player hitboxes")]
        public bool DisablePlayerHitboxInteraction
        {
            get => Data._disablePlayerHitboxInteraction;
            set
            {
                Data._disablePlayerHitboxInteraction = value;
                SignalPropertyChange();
            }
        }

        [Category("GBLK")]
        public byte PositionModelIndex
        {
            get => Data._positionModelIndex;
            set
            {
                Data._positionModelIndex = value;
                SignalPropertyChange();
            }
        }

        [Category("GBLK")]
        public byte CollisionModelIndex
        {
            get => Data._collisionModelIndex;
            set
            {
                Data._collisionModelIndex = value;
                SignalPropertyChange();
            }
        }

        [Category("Unknown")]
        public byte Unknown0x2E
        {
            get => Data._unknown0x2E;
            set
            {
                Data._unknown0x2E = value;
                SignalPropertyChange();
            }
        }

        [Category("Unknown")]
        public byte Unknown0x2F
        {
            get => Data._unknown0x2F;
            set
            {
                Data._unknown0x2F = value;
                SignalPropertyChange();
            }
        }

        [Category("Unknown")]
        public int Unknown0x30
        {
            get => Data._unknown0x30;
            set
            {
                Data._unknown0x30 = value;
                SignalPropertyChange();
            }
        }

        [Category("Unknown")]
        public int Unknown0x34
        {
            get => Data._unknown0x34;
            set
            {
                Data._unknown0x34 = value;
                SignalPropertyChange();
            }
        }

        [Category("Unknown")]
        public short Unknown0x38
        {
            get => Data._unknown0x38;
            set
            {
                Data._unknown0x38 = value;
                SignalPropertyChange();
            }
        }

        [Category("Unknown")]
        public short Unknown0x3A
        {
            get => Data._unknown0x3A;
            set
            {
                Data._unknown0x3A = value;
                SignalPropertyChange();
            }
        }

        [Category("Unknown")]
        public int Unknown0x3C
        {
            get => Data._unknown0x3C;
            set
            {
                Data._unknown0x3C = value;
                SignalPropertyChange();
            }
        }

        public override bool OnInitialize()
        {
            Data = *(GBLKEntry*)WorkingUncompressed.Address;
            if (_name == null)
            {
                _name = $"Block Group [{Index}]";
            }

            return false;
        }

        public override int OnCalculateSize(bool force)
        {
            return GBLKEntry.Size;
        }

        public override void OnRebuild(VoidPtr address, int length, bool force)
        {
            GBLKEntry* hdr = (GBLKEntry*)address;
            *hdr = Data;
        }
    }
}