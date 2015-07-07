﻿namespace mapbox.vector.tile
{
    [System.Serializable, ProtoBuf.ProtoContract(Name = @"tile")]
    public class Tile : ProtoBuf.IExtensible
    {
        private readonly System.Collections.Generic.List<Layer> _layers = new System.Collections.Generic.List<Layer>();
        [ProtoBuf.ProtoMember(3, Name = @"layers", DataFormat = ProtoBuf.DataFormat.Default)]
        public System.Collections.Generic.List<Layer> Layers
        {
            get { return _layers; }
        }

        [System.Serializable, ProtoBuf.ProtoContract(Name = @"value")]
        public class Value : ProtoBuf.IExtensible
        {
            private string _stringValue = "";

            public bool HasStringValue { get; set; }
            public bool HasFloatValue { get; set; }
            public bool HasDoubleValue { get; set; }
            public bool HasIntValue { get; set; }
            public bool HasUIntValue { get; set; }
            public bool HasSIntValue { get; set; }
            public bool HasBoolValue { get; set; }

            [ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"string_value", DataFormat = ProtoBuf.DataFormat.Default)]
            [System.ComponentModel.DefaultValue("")]
            public string StringValue
            {
                get { return _stringValue; }
                set
                {
                    HasStringValue = true;
                    _stringValue = value;
                }
            }
            private float _floatValue = default(float);
            [ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"float_value", DataFormat = ProtoBuf.DataFormat.FixedSize)]
            [System.ComponentModel.DefaultValue(default(float))]
            public float FloatValue
            {
                get
                {
                    return _floatValue;
                }
                set
                {
                    _floatValue = value;
                    HasFloatValue = true;

                }
            }
            private double _doubleValue = default(double);
            [ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"double_value", DataFormat = ProtoBuf.DataFormat.TwosComplement)]
            [System.ComponentModel.DefaultValue(default(double))]
            public double DoubleValue
            {
                get { return _doubleValue; }
                set
                {
                    _doubleValue = value;
                    HasDoubleValue = true;
                }
            }
            private long _intValue = default(long);
            [ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"int_value", DataFormat = ProtoBuf.DataFormat.TwosComplement)]
            [System.ComponentModel.DefaultValue(default(long))]
            public long IntValue
            {
                get { return _intValue; }
                set
                {
                    _intValue = value;
                    HasIntValue = true;
                }
            }
            private ulong _uintValue = default(ulong);
            [ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"uint_value", DataFormat = ProtoBuf.DataFormat.TwosComplement)]
            [System.ComponentModel.DefaultValue(default(ulong))]
            public ulong UintValue
            {
                get { return _uintValue; }
                set
                {
                    _uintValue = value;
                    HasUIntValue = true;
                }
            }
            private long _sintValue = default(long);
            [ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"sint_value", DataFormat = ProtoBuf.DataFormat.ZigZag)]
            [System.ComponentModel.DefaultValue(default(long))]
            public long SintValue
            {
                get { return _sintValue; }
                set
                {
                    _sintValue = value;
                    HasSIntValue = true;
                }
            }
            private bool _boolValue = default(bool);
            [ProtoBuf.ProtoMember(7, IsRequired = false, Name = @"bool_value", DataFormat = ProtoBuf.DataFormat.Default)]
            [System.ComponentModel.DefaultValue(default(bool))]
            public bool BoolValue
            {
                get { return _boolValue; }
                set
                {
                    _boolValue = value;
                    HasBoolValue = true;
                }
            }
            private ProtoBuf.IExtension _extensionObject;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return ProtoBuf.Extensible.GetExtensionObject(ref _extensionObject, createIfMissing); }
        }

        [System.Serializable, ProtoBuf.ProtoContract(Name = @"feature")]
        public class Feature : ProtoBuf.IExtensible
        {
            private ulong _id = default(ulong);
            [ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"id", DataFormat = ProtoBuf.DataFormat.TwosComplement)]
            [System.ComponentModel.DefaultValue(default(ulong))]
            public ulong Id
            {
                get { return _id; }
                set { _id = value; }
            }
            private readonly System.Collections.Generic.List<uint> _tags = new System.Collections.Generic.List<uint>();
            [ProtoBuf.ProtoMember(2, Name = @"tags", DataFormat = ProtoBuf.DataFormat.TwosComplement, Options = ProtoBuf.MemberSerializationOptions.Packed)]
            public System.Collections.Generic.List<uint> Tags
            {
                get { return _tags; }
            }

            private GeomType _type = GeomType.Unknown;
            [ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"type", DataFormat = ProtoBuf.DataFormat.TwosComplement)]
            [System.ComponentModel.DefaultValue(GeomType.Unknown)]
            public GeomType Type
            {
                get { return _type; }
                set { _type = value; }
            }
            private readonly System.Collections.Generic.List<uint> _geometry = new System.Collections.Generic.List<uint>();
            [ProtoBuf.ProtoMember(4, Name = @"geometry", DataFormat = ProtoBuf.DataFormat.TwosComplement, Options = ProtoBuf.MemberSerializationOptions.Packed)]
            public System.Collections.Generic.List<uint> Geometry
            {
                get { return _geometry; }
            }

            private ProtoBuf.IExtension _extensionObject;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return ProtoBuf.Extensible.GetExtensionObject(ref _extensionObject, createIfMissing); }
        }

        [System.Serializable, ProtoBuf.ProtoContract(Name = @"layer")]
        public class Layer : ProtoBuf.IExtensible
        {
            private uint _version;
            [ProtoBuf.ProtoMember(15, IsRequired = true, Name = @"version", DataFormat = ProtoBuf.DataFormat.TwosComplement)]
            public uint Version
            {
                get { return _version; }
                set { _version = value; }
            }
            private string _name;
            [ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"name", DataFormat = ProtoBuf.DataFormat.Default)]
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            private readonly System.Collections.Generic.List<Feature> _features = new System.Collections.Generic.List<Feature>();
            [ProtoBuf.ProtoMember(2, Name = @"features", DataFormat = ProtoBuf.DataFormat.Default)]
            public System.Collections.Generic.List<Feature> Features
            {
                get { return _features; }
            }

            private readonly System.Collections.Generic.List<string> _keys = new System.Collections.Generic.List<string>();
            [ProtoBuf.ProtoMember(3, Name = @"keys", DataFormat = ProtoBuf.DataFormat.Default)]
            public System.Collections.Generic.List<string> Keys
            {
                get { return _keys; }
            }

            private readonly System.Collections.Generic.List<Value> _values = new System.Collections.Generic.List<Value>();
            [ProtoBuf.ProtoMember(4, Name = @"values", DataFormat = ProtoBuf.DataFormat.Default)]
            public System.Collections.Generic.List<Value> Values
            {
                get { return _values; }
            }

            private uint _extent = 4096;
            [ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"extent", DataFormat = ProtoBuf.DataFormat.TwosComplement)]
            [System.ComponentModel.DefaultValue((uint)4096)]
            public uint Extent
            {
                get { return _extent; }
                set { _extent = value; }
            }
            private ProtoBuf.IExtension _extensionObject;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return ProtoBuf.Extensible.GetExtensionObject(ref _extensionObject, createIfMissing); }
        }

        [ProtoBuf.ProtoContract(Name = @"GeomType")]
        public enum GeomType
        {

            [ProtoBuf.ProtoEnum(Name = @"Unknown", Value = 0)]
            Unknown = 0,

            [ProtoBuf.ProtoEnum(Name = @"Point", Value = 1)]
            Point = 1,

            [ProtoBuf.ProtoEnum(Name = @"LineString", Value = 2)]
            LineString = 2,

            [ProtoBuf.ProtoEnum(Name = @"Polygon", Value = 3)]
            Polygon = 3
        }

        private ProtoBuf.IExtension _extensionObject;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return ProtoBuf.Extensible.GetExtensionObject(ref _extensionObject, createIfMissing); }
    }
}