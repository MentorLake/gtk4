using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;

public struct GParamSpecOverride
{
	public GParamSpec parent_instance;
	public GParamSpecHandle overridden;
}

public struct GParamSpecUChar
{
	public GParamSpec parent_instance;
	public byte minimum;
	public byte maximum;
	public byte default_value;
}

public struct GTypeInstance
{
	public GTypeClassHandle g_class;
}

public struct GObjectClass
{
	public GTypeClass g_type_class;
	public GSListHandle construct_properties;
	public IntPtr constructor;
	public IntPtr set_property;
	public IntPtr get_property;
	public IntPtr dispose;
	public IntPtr finalize;
	public IntPtr dispatch_properties_changed;
	public IntPtr notify;
	public IntPtr constructed;
	public nuint flags;
	public IntPtr pdummy;

	public struct _pdummy_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
	}
}

public struct GClosure
{
	public uint _bitfield;

	public uint ref_count
	{
		readonly get => _bitfield & 0x7FFFu;

		set => _bitfield = (_bitfield & ~0x7FFFu) | (value & 0x7FFFu);
	}

	public uint meta_marshal_nouse
	{
		readonly get => (_bitfield >> 15) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 15)) | ((value & 0x1u) << 15);
	}

	public uint n_guards
	{
		readonly get => (_bitfield >> 16) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 16)) | ((value & 0x1u) << 16);
	}

	public uint n_fnotifiers
	{
		readonly get => (_bitfield >> 17) & 0x3u;

		set => _bitfield = (_bitfield & ~(0x3u << 17)) | ((value & 0x3u) << 17);
	}

	public uint n_inotifiers
	{
		readonly get => (_bitfield >> 19) & 0xFFu;

		set => _bitfield = (_bitfield & ~(0xFFu << 19)) | ((value & 0xFFu) << 19);
	}

	public uint in_inotify
	{
		readonly get => (_bitfield >> 27) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 27)) | ((value & 0x1u) << 27);
	}

	public uint floating
	{
		readonly get => (_bitfield >> 28) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 28)) | ((value & 0x1u) << 28);
	}

	public uint derivative_flag
	{
		readonly get => (_bitfield >> 29) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 29)) | ((value & 0x1u) << 29);
	}

	public uint in_marshal
	{
		readonly get => (_bitfield >> 30) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 30)) | ((value & 0x1u) << 30);
	}

	public uint is_invalid
	{
		readonly get => (_bitfield >> 31) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 31)) | ((value & 0x1u) << 31);
	}

	public IntPtr marshal;
	public IntPtr data;
	public GClosureNotifyDataHandle notifiers;
}

public struct GParamSpecTypeInfo
{
	public ushort instance_size;
	public ushort n_preallocs;
	public IntPtr instance_init;
	public GType value_type;
	public IntPtr finalize;
	public IntPtr value_set_default;
	public IntPtr value_validate;
	public IntPtr values_cmp;
}

public struct GParamSpecInt64
{
	public GParamSpec parent_instance;
	public nint minimum;
	public nint maximum;
	public nint default_value;
}

public struct GParamSpecDouble
{
	public GParamSpec parent_instance;
	public double minimum;
	public double maximum;
	public double default_value;
	public double epsilon;
}

public struct GParamSpecClass
{
	public GTypeClass g_type_class;
	public GType value_type;
	public IntPtr finalize;
	public IntPtr value_set_default;
	public IntPtr value_validate;
	public IntPtr values_cmp;
	public IntPtr dummy;

	public struct _dummy_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
	}
}

public struct GParamSpecValueArray
{
	public GParamSpec parent_instance;
	public GParamSpecHandle element_spec;
	public uint fixed_n_elements;
}

public struct GEnumValue
{
	public int value;
	public string value_name;
	public string value_nick;
}

public struct GParamSpecBoolean
{
	public GParamSpec parent_instance;
	public int default_value;
}

[Obsolete]
public struct GParameter
{
	public string name;
	public GValue value;
}

public struct GParamSpecLong
{
	public GParamSpec parent_instance;
	public nint minimum;
	public nint maximum;
	public nint default_value;
}

public struct GSignalGroup { }
public struct GParamSpecPool { }

public struct GParamSpecFloat
{
	public GParamSpec parent_instance;
	public float minimum;
	public float maximum;
	public float default_value;
	public float epsilon;
}

public struct GTypeQuery
{
	public GType type;
	public string type_name;
	public uint class_size;
	public uint instance_size;
}

public struct GParamSpecParam
{
	public GParamSpec parent_instance;
}

public struct GFlagsClass
{
	public GTypeClass g_type_class;
	public uint mask;
	public uint n_values;
	public GFlagsValueHandle values;
}

public struct GTypeClass
{
	public GType g_type;
}

public struct GEnumClass
{
	public GTypeClass g_type_class;
	public int minimum;
	public int maximum;
	public uint n_values;
	public GEnumValueHandle values;
}

public struct GParamSpecObject
{
	public GParamSpec parent_instance;
}

public struct GObjectConstructParam
{
	public GParamSpecHandle pspec;
	public GValueHandle value;
}

public struct GParamSpecVariant
{
	public GParamSpec parent_instance;
	public GVariantTypeHandle type;
	public GVariantHandle default_value;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
	}
}

public struct GTypePluginClass
{
	public GTypeInterface base_iface;
	public GTypePluginCompleteTypeInfo complete_type_info;
	public GTypePluginCompleteInterfaceInfo complete_interface_info;
}

public struct GTypePlugin { }

public struct GParamSpecBoxed
{
	public GParamSpec parent_instance;
}

public struct GParamSpecULong
{
	public GParamSpec parent_instance;
	public nuint minimum;
	public nuint maximum;
	public nuint default_value;
}

public struct GParamSpecChar
{
	public GParamSpec parent_instance;
	public sbyte minimum;
	public sbyte maximum;
	public sbyte default_value;
}

public struct GTypeModule
{
	public GObject parent_instance;
	public uint use_count;
	public GSListHandle type_infos;
	public GSListHandle interface_infos;
	public string name;
}

public struct GParamSpecString
{
	public GParamSpec parent_instance;
	public string default_value;
	public string cset_first;
	public string cset_nth;
	public char substitutor;
	public uint _bitfield;

	public uint null_fold_if_empty
	{
		readonly get => _bitfield & 0x1u;

		set => _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
	}

	public uint ensure_non_null
	{
		readonly get => (_bitfield >> 1) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
	}
}

public struct GParamSpecGType
{
	public GParamSpec parent_instance;
	public GType is_a_type;
}

public struct GObject
{
	public GTypeInstance g_type_instance;
	public uint ref_count;
	public GDataHandle qdata;
}

public struct GBinding { }

public struct GTypeFundamentalInfo
{
	public GTypeFundamentalFlags type_flags;
}

public struct GParamSpecUnichar
{
	public GParamSpec parent_instance;
	public uint default_value;
}

public struct GParamSpecUInt
{
	public GParamSpec parent_instance;
	public uint minimum;
	public uint maximum;
	public uint default_value;
}

public struct GFlagsValue
{
	public uint value;
	public string value_name;
	public string value_nick;
}

public struct GBindingGroup { }

public struct GParamSpecInt
{
	public GParamSpec parent_instance;
	public int minimum;
	public int maximum;
	public int default_value;
}

public struct GClosureNotifyData
{
	public IntPtr data;
	public GClosureNotify notify;
}

public struct GTypeValueTable
{
	public IntPtr value_init;
	public IntPtr value_free;
	public IntPtr value_copy;
	public IntPtr value_peek_pointer;
	public string collect_format;
	public IntPtr collect_value;
	public string lcopy_format;
	public IntPtr lcopy_value;
}

public struct GCClosure
{
	public GClosure closure;
	public IntPtr callback;
}

public struct GSignalQuery
{
	public uint signal_id;
	public string signal_name;
	public GType itype;
	public GSignalFlags signal_flags;
	public GType return_type;
	public uint n_params;
	public GTypeHandle param_types;
}

public struct GParamSpec
{
	public GTypeInstance g_type_instance;
	public string name;
	public GParamFlags flags;
	public GType value_type;
	public GType owner_type;
	public string _nick;
	public string _blurb;
	public GDataHandle qdata;
	public uint ref_count;
	public uint param_id;
}

public struct GValueArray
{
	public uint n_values;
	public GValueHandle values;
	public uint n_prealloced;
}

public struct GTypeInterface
{
	public GType g_type;
	public GType g_instance_type;
}

public struct GParamSpecUInt64
{
	public GParamSpec parent_instance;
	public nuint minimum;
	public nuint maximum;
	public nuint default_value;
}

public struct GParamSpecEnum
{
	public GParamSpec parent_instance;
	public GEnumClassHandle enum_class;
	public int default_value;
}

public struct GSignalInvocationHint
{
	public uint signal_id;
	public GQuark detail;
	public GSignalFlags run_type;
}

public struct GWeakRef
{
	public _priv_e__Union priv;

	[StructLayout(LayoutKind.Explicit)]
	public struct _priv_e__Union
	{
		[FieldOffset(0)] public IntPtr p;
	}
}

public struct GTypeModuleClass
{
	public GObjectClass parent_class;
	public IntPtr load;
	public IntPtr unload;
	public IntPtr reserved1;
	public IntPtr reserved2;
	public IntPtr reserved3;
	public IntPtr reserved4;
}

[StructLayout(LayoutKind.Explicit)]
public struct GTypeCValue { }

public struct GValue
{
	public GType g_type;
	public _data_e__FixedBuffer data;

	[StructLayout(LayoutKind.Explicit)]
	public struct _Anonymous_e__Union
	{
		[FieldOffset(0)] public int v_int;
		[FieldOffset(0)] public uint v_uint;
		[FieldOffset(0)] public nint v_long;
		[FieldOffset(0)] public nuint v_ulong;
		[FieldOffset(0)] public nint v_int64;
		[FieldOffset(0)] public nuint v_uint64;
		[FieldOffset(0)] public float v_float;
		[FieldOffset(0)] public double v_double;
		[FieldOffset(0)] public IntPtr v_pointer;
	}

	[InlineArray(2)]
	public struct _data_e__FixedBuffer
	{
		public _Anonymous_e__Union e0;
	}
}

public struct GParamSpecFlags
{
	public GParamSpec parent_instance;
	public GFlagsClassHandle flags_class;
	public uint default_value;
}

public struct GInterfaceInfo
{
	public GInterfaceInitFunc interface_init;
	public GInterfaceFinalizeFunc interface_finalize;
	public IntPtr interface_data;
}

public struct GTypeInfo
{
	public ushort class_size;
	public IntPtr class_data;
	public ushort instance_size;
	public ushort n_preallocs;
	public GTypeValueTableHandle value_table;
}

public struct GParamSpecPointer
{
	public GParamSpec parent_instance;
}
