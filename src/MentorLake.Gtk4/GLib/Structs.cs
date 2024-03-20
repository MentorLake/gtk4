using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public struct GHook
{
	public IntPtr data;
	public GHookHandle next;
	public GHookHandle prev;
	public uint ref_count;
	public nuint hook_id;
	public uint flags;
	public IntPtr func;
	public GDestroyNotify destroy;
}

[Obsolete]
public struct GThreadFunctions
{
	public IntPtr mutex_new;
	public IntPtr mutex_lock;
	public IntPtr mutex_trylock;
	public IntPtr mutex_unlock;
	public IntPtr mutex_free;
	public IntPtr cond_new;
	public IntPtr cond_signal;
	public IntPtr cond_broadcast;
	public IntPtr cond_wait;
	public IntPtr cond_timed_wait;
	public IntPtr cond_free;
	public IntPtr private_new;
	public IntPtr private_get;
	public IntPtr private_set;
	public IntPtr thread_create;
	public IntPtr thread_yield;
	public IntPtr thread_join;
	public IntPtr thread_exit;
	public IntPtr thread_set_priority;
	public IntPtr thread_self;
	public IntPtr thread_equal;
}

public struct GData { }

public struct GNode
{
	public IntPtr data;
	public GNodeHandle next;
	public GNodeHandle prev;
	public GNodeHandle parent;
	public GNodeHandle children;
}

public struct GMatchInfo { }

public struct GRWLock
{
	public IntPtr p;
	public _i_e__FixedBuffer i;

	[InlineArray(2)]
	public struct _i_e__FixedBuffer
	{
		public uint e0;
	}
}

public struct GLogField
{
	public string key;
	public IntPtr value;
	public nint length;
}

public struct GPollFD
{
	public int fd;
	public ushort events;
	public ushort revents;
}

[Obsolete]
public struct GTrashStack
{
	public GTrashStackHandle next;
}

[StructLayout(LayoutKind.Explicit)]
public struct GMutex
{
	[FieldOffset(0)] public IntPtr p;
	[FieldOffset(0)] public _i_e__FixedBuffer i;

	[InlineArray(2)]
	public struct _i_e__FixedBuffer
	{
		public uint e0;
	}
}

public struct GThread
{
	public GThreadFunc func;
	public IntPtr data;
	public int joinable;
	[Obsolete] public GThreadPriority priority;
}

[StructLayout(LayoutKind.Explicit)]
public struct GTokenValue
{
	[FieldOffset(0)] public IntPtr v_symbol;
	[FieldOffset(0)] public string v_identifier;
	[FieldOffset(0)] public nuint v_binary;
	[FieldOffset(0)] public nuint v_octal;
	[FieldOffset(0)] public nuint v_int;
	[FieldOffset(0)] public nuint v_int64;
	[FieldOffset(0)] public double v_float;
	[FieldOffset(0)] public nuint v_hex;
	[FieldOffset(0)] public string v_string;
	[FieldOffset(0)] public string v_comment;
	[FieldOffset(0)] public char v_char;
	[FieldOffset(0)] public uint v_error;
}

public struct GOptionContext { }

public struct GHookList
{
	public nuint seq_id;
	public uint _bitfield;

	public uint hook_size
	{
		readonly get => _bitfield & 0xFFFFu;

		set => _bitfield = (_bitfield & ~0xFFFFu) | (value & 0xFFFFu);
	}

	public uint is_setup
	{
		readonly get => (_bitfield >> 16) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 16)) | ((value & 0x1u) << 16);
	}

	public GHookHandle hooks;
	public IntPtr dummy3;
	public GHookFinalizeFunc finalize_hook;
	public IntPtr dummy;

	public struct _dummy_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
	}
}

public struct GSourceCallbackFuncs
{
	public IntPtr @ref;
	public IntPtr unref;
	public IntPtr get;
}

public struct GAllocator { }
public struct GBytes { }

public struct GString
{
	public string str;
	public nuint len;
	public nuint allocated_len;
}

public struct GMemVTable
{
	public IntPtr malloc;
	public IntPtr realloc;
	public IntPtr free;
	public IntPtr calloc;
	public IntPtr try_malloc;
	public IntPtr try_realloc;
}

public struct GStrvBuilder { }

public struct GVariantDict
{
	public _u_e__Union u;

	[StructLayout(LayoutKind.Explicit)]
	public struct _u_e__Union
	{
		[FieldOffset(0)] public _s_e__Struct s;
		[FieldOffset(0)] public _x_e__FixedBuffer x;

		public struct _s_e__Struct
		{
			public GVariantHandle asv;
			public nuint partial_magic;
			public _y_e__FixedBuffer y;

			[InlineArray(14)]
			public struct _y_e__FixedBuffer
			{
				public nuint e0;
			}
		}

		[InlineArray(16)]
		public struct _x_e__FixedBuffer
		{
			public nuint e0;
		}
	}
}

public struct GTestSuite { }

public struct GOnce
{
	public GOnceStatus status;
	public IntPtr retval;
}

public struct GIOFuncs
{
	public IntPtr io_read;
	public IntPtr io_write;
	public IntPtr io_seek;
	public IntPtr io_close;
	public IntPtr io_create_watch;
	public IntPtr io_free;
	public IntPtr io_set_flags;
	public IntPtr io_get_flags;
}

public struct GTree { }

public struct GPtrArray
{
	public IntPtr[] pdata;
	public uint len;
}

public struct GError
{
	public GQuark domain;
	public int code;
	public string message;
}

public struct GChecksum { }
public struct GCache { }

public struct GSList
{
	public IntPtr data;
	public GSListHandle next;
}

public struct GHashTableIter
{
	public IntPtr dummy1;
	public IntPtr dummy2;
	public IntPtr dummy3;
	public int dummy4;
	public int dummy5;
	public IntPtr dummy6;
}

public struct GPrivate
{
	public IntPtr p;
	public GDestroyNotify notify;
	public IntPtr future;

	public struct _future_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
	}
}

public struct GArray
{
	public string data;
	public uint len;
}

public struct GVariantType { }
public struct GSourcePrivate { }

public struct GList
{
	public IntPtr data;
	public GListHandle next;
	public GListHandle prev;
}

public struct GCompletion
{
	public GListHandle items;
	public GCompletionFunc func;
	public string prefix;
	public GListHandle cache;
	public GCompletionStrncmpFunc strncmp_func;
}

public struct GDir { }
public struct GTestCase { }

public struct GRecMutex
{
	public IntPtr p;
	public _i_e__FixedBuffer i;

	[InlineArray(2)]
	public struct _i_e__FixedBuffer
	{
		public uint e0;
	}
}

public struct GVariantBuilder
{
	public _u_e__Union u;

	[StructLayout(LayoutKind.Explicit)]
	public struct _u_e__Union
	{
		[FieldOffset(0)] public _s_e__Struct s;
		[FieldOffset(0)] public _x_e__FixedBuffer x;

		public struct _s_e__Struct
		{
			public nuint partial_magic;
			public GVariantTypeHandle type;
			public _y_e__FixedBuffer y;

			[InlineArray(14)]
			public struct _y_e__FixedBuffer
			{
				public nuint e0;
			}
		}

		[InlineArray(16)]
		public struct _x_e__FixedBuffer
		{
			public nuint e0;
		}
	}
}

public struct GHashTable { }
public struct GRand { }
public struct GBookmarkFile { }

[Obsolete]
public struct GStaticRecMutex
{
	[Obsolete] public GStaticMutex mutex;
	public uint depth;
	public _unused_e__Union unused;

	[StructLayout(LayoutKind.Explicit)]
	public struct _unused_e__Union
	{
		[FieldOffset(0)] public nuint owner;
		[FieldOffset(0)] public double dummy;
	}
}

public struct GTuples
{
	public uint len;
}

public struct GDebugKey
{
	public string key;
	public uint value;
}

public struct GTimeZone { }
public struct GMarkupParseContext { }

public struct GDate
{
	public uint _bitfield1;

	public uint julian_days
	{
		readonly get => _bitfield1 & 0x0u;

		set => _bitfield1 = (_bitfield1 & ~0x0u) | (value & 0x0u);
	}

	public uint _bitfield2;

	public uint julian
	{
		readonly get => _bitfield2 & 0x1u;

		set => _bitfield2 = (_bitfield2 & ~0x1u) | (value & 0x1u);
	}

	public uint dmy
	{
		readonly get => (_bitfield2 >> 1) & 0x1u;

		set => _bitfield2 = (_bitfield2 & ~(0x1u << 1)) | ((value & 0x1u) << 1);
	}

	public uint day
	{
		readonly get => (_bitfield2 >> 2) & 0x3Fu;

		set => _bitfield2 = (_bitfield2 & ~(0x3Fu << 2)) | ((value & 0x3Fu) << 2);
	}

	public uint month
	{
		readonly get => (_bitfield2 >> 8) & 0xFu;

		set => _bitfield2 = (_bitfield2 & ~(0xFu << 8)) | ((value & 0xFu) << 8);
	}

	public uint year
	{
		readonly get => (_bitfield2 >> 12) & 0xFFFFu;

		set => _bitfield2 = (_bitfield2 & ~(0xFFFFu << 12)) | ((value & 0xFFFFu) << 12);
	}
}

[StructLayout(LayoutKind.Explicit)]
public struct GFloatIEEE754
{
	[FieldOffset(0)] public float v_float;
	[FieldOffset(0)] public _mpn_e__Struct mpn;

	public struct _mpn_e__Struct
	{
		public uint _bitfield;

		public uint mantissa
		{
			readonly get => _bitfield & 0x7FFFFFu;

			set => _bitfield = (_bitfield & ~0x7FFFFFu) | (value & 0x7FFFFFu);
		}

		public uint biased_exponent
		{
			readonly get => (_bitfield >> 23) & 0xFFu;

			set => _bitfield = (_bitfield & ~(0xFFu << 23)) | ((value & 0xFFu) << 23);
		}

		public uint sign
		{
			readonly get => (_bitfield >> 31) & 0x1u;

			set => _bitfield = (_bitfield & ~(0x1u << 31)) | ((value & 0x1u) << 31);
		}
	}
}

[Obsolete]
public struct GStaticMutex
{
	public GMutexHandle mutex;
	public nuint unused;
}

public struct GIOChannel
{
	public int ref_count;
	public GIOFuncsHandle funcs;
	public string encoding;
	public GIConv read_cd;
	public GIConv write_cd;
	public string line_term;
	public uint line_term_len;
	public nuint buf_size;
	public GStringHandle read_buf;
	public GStringHandle encoded_read_buf;
	public GStringHandle write_buf;
	public _partial_write_buf_e__FixedBuffer partial_write_buf;
	public uint _bitfield;

	public uint use_buffer
	{
		readonly get => _bitfield & 0x1u;

		set => _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
	}

	public uint do_encode
	{
		readonly get => (_bitfield >> 1) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
	}

	public uint close_on_unref
	{
		readonly get => (_bitfield >> 2) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
	}

	public uint is_readable
	{
		readonly get => (_bitfield >> 3) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3);
	}

	public uint is_writeable
	{
		readonly get => (_bitfield >> 4) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4);
	}

	public uint is_seekable
	{
		readonly get => (_bitfield >> 5) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5);
	}

	public IntPtr reserved1;
	public IntPtr reserved2;

	[InlineArray(6)]
	public struct _partial_write_buf_e__FixedBuffer
	{
		public sbyte e0;
	}
}

public struct GIConv { }
public struct GAsyncQueue { }
public struct GKeyFile { }
public struct GMainContext { }

public struct GMarkupParser
{
	public IntPtr start_element;
	public IntPtr end_element;
	public IntPtr text;
	public IntPtr passthrough;
	public IntPtr error;
}

[Obsolete]
public struct GTimeVal
{
	public nint tv_sec;
	public nint tv_usec;
}

public struct GMemChunk { }
public struct GTreeNode { }
public struct GMappedFile { }
public struct GPatternSpec { }
public struct GSequenceNode : GSequenceIter { }
public struct GSequence { }

public struct GSourceFuncs
{
	public IntPtr prepare;
	public IntPtr check;
	public IntPtr dispatch;
	public IntPtr finalize;
	public GSourceFunc closure_callback;
	public GSourceDummyMarshal closure_marshal;
}

public struct GTestConfig
{
	public int test_initialized;
	public int test_quick;
	public int test_perf;
	public int test_verbose;
	public int test_quiet;
	public int test_undefined;
}

public struct GDateTime { }

public struct GSource
{
	public IntPtr callback_data;
	public GSourceCallbackFuncsHandle callback_funcs;
	public GSourceFuncsHandle source_funcs;
	public uint ref_count;
	public GMainContextHandle context;
	public int priority;
	public uint flags;
	public uint source_id;
	public GSListHandle poll_fds;
	public GSourceHandle prev;
	public GSourceHandle next;
	public string name;
	public GSourcePrivateHandle priv;
}

public struct GTestLogBuffer
{
	public GStringHandle data;
	public GSListHandle msgs;
}

public struct GRegex { }
public struct GStringChunk { }

public struct GUriParamsIter
{
	public int dummy0;
	public IntPtr dummy1;
	public IntPtr dummy2;
	public _dummy3_e__FixedBuffer dummy3;

	[InlineArray(256)]
	public struct _dummy3_e__FixedBuffer
	{
		public byte e0;
	}
}

[Obsolete]
public struct GStaticPrivate
{
	public uint index;
}

[Obsolete]
public struct GStaticRWLock
{
	[Obsolete] public GStaticMutex mutex;
	public GCondHandle read_cond;
	public GCondHandle write_cond;
	public uint read_counter;
	public int have_writer;
	public uint want_to_read;
	public uint want_to_write;
}

public struct GThreadPool
{
	public IntPtr func;
	public IntPtr user_data;
	public int exclusive;
}

public struct GQueue
{
	public GListHandle head;
	public GListHandle tail;
	public uint length;
}

public struct GOptionEntry
{
	public string long_name;
	public char short_name;
	public int flags;
	public GOptionArg arg;
	public IntPtr arg_data;
	public string description;
	public string arg_description;
}

public struct GVariantIter
{
	public _x_e__FixedBuffer x;

	[InlineArray(16)]
	public struct _x_e__FixedBuffer
	{
		public nuint e0;
	}
}

public struct GOptionGroup { }

public struct GScanner
{
	public IntPtr user_data;
	public uint max_parse_errors;
	public uint parse_errors;
	public string input_name;
	public GDataHandle qdata;
	public GScannerConfigHandle config;
	public GTokenType token;
	public GTokenValue value;
	public uint line;
	public uint position;
	public GTokenType next_token;
	public GTokenValue next_value;
	public uint next_line;
	public uint next_position;
	public GHashTableHandle symbol_table;
	public int input_fd;
	public string text;
	public string text_end;
	public string buffer;
	public uint scope_id;
	public GScannerMsgFunc msg_handler;
}

public struct GTimer { }
public struct GRelation { }
public struct GVariant { }

[StructLayout(LayoutKind.Explicit)]
public struct GDoubleIEEE754
{
	[FieldOffset(0)] public double v_double;
	[FieldOffset(0)] public _mpn_e__Struct mpn;

	public struct _mpn_e__Struct
	{
		public uint _bitfield1;

		public uint mantissa_low
		{
			readonly get => _bitfield1 & 0x0u;

			set => _bitfield1 = (_bitfield1 & ~0x0u) | (value & 0x0u);
		}

		public uint _bitfield2;

		public uint mantissa_high
		{
			readonly get => _bitfield2 & 0xFFFFFu;

			set => _bitfield2 = (_bitfield2 & ~0xFFFFFu) | (value & 0xFFFFFu);
		}

		public uint biased_exponent
		{
			readonly get => (_bitfield2 >> 20) & 0x7FFu;

			set => _bitfield2 = (_bitfield2 & ~(0x7FFu << 20)) | ((value & 0x7FFu) << 20);
		}

		public uint sign
		{
			readonly get => (_bitfield2 >> 31) & 0x1u;

			set => _bitfield2 = (_bitfield2 & ~(0x1u << 31)) | ((value & 0x1u) << 31);
		}
	}
}

public struct GTestLogMsg
{
	public GTestLogType log_type;
	public uint n_strings;
	public string[] strings;
	public uint n_nums;
	public decimal[] nums;
}

public struct GMainLoop { }

public struct GCond
{
	public IntPtr p;
	public _i_e__FixedBuffer i;

	[InlineArray(2)]
	public struct _i_e__FixedBuffer
	{
		public uint e0;
	}
}

public struct GScannerConfig
{
	public string cset_skip_characters;
	public string cset_identifier_first;
	public string cset_identifier_nth;
	public string cpair_comment_single;
	public uint _bitfield;

	public uint case_sensitive
	{
		readonly get => _bitfield & 0x1u;

		set => _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
	}

	public uint skip_comment_multi
	{
		readonly get => (_bitfield >> 1) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
	}

	public uint skip_comment_single
	{
		readonly get => (_bitfield >> 2) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
	}

	public uint scan_comment_multi
	{
		readonly get => (_bitfield >> 3) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3);
	}

	public uint scan_identifier
	{
		readonly get => (_bitfield >> 4) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4);
	}

	public uint scan_identifier_1char
	{
		readonly get => (_bitfield >> 5) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5);
	}

	public uint scan_identifier_NULL
	{
		readonly get => (_bitfield >> 6) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6);
	}

	public uint scan_symbols
	{
		readonly get => (_bitfield >> 7) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 7)) | ((value & 0x1u) << 7);
	}

	public uint scan_binary
	{
		readonly get => (_bitfield >> 8) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 8)) | ((value & 0x1u) << 8);
	}

	public uint scan_octal
	{
		readonly get => (_bitfield >> 9) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 9)) | ((value & 0x1u) << 9);
	}

	public uint scan_float
	{
		readonly get => (_bitfield >> 10) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 10)) | ((value & 0x1u) << 10);
	}

	public uint scan_hex
	{
		readonly get => (_bitfield >> 11) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 11)) | ((value & 0x1u) << 11);
	}

	public uint scan_hex_dollar
	{
		readonly get => (_bitfield >> 12) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 12)) | ((value & 0x1u) << 12);
	}

	public uint scan_string_sq
	{
		readonly get => (_bitfield >> 13) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 13)) | ((value & 0x1u) << 13);
	}

	public uint scan_string_dq
	{
		readonly get => (_bitfield >> 14) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 14)) | ((value & 0x1u) << 14);
	}

	public uint numbers_2_int
	{
		readonly get => (_bitfield >> 15) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 15)) | ((value & 0x1u) << 15);
	}

	public uint int_2_float
	{
		readonly get => (_bitfield >> 16) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 16)) | ((value & 0x1u) << 16);
	}

	public uint identifier_2_string
	{
		readonly get => (_bitfield >> 17) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 17)) | ((value & 0x1u) << 17);
	}

	public uint char_2_token
	{
		readonly get => (_bitfield >> 18) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 18)) | ((value & 0x1u) << 18);
	}

	public uint symbol_2_token
	{
		readonly get => (_bitfield >> 19) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 19)) | ((value & 0x1u) << 19);
	}

	public uint scope_0_fallback
	{
		readonly get => (_bitfield >> 20) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 20)) | ((value & 0x1u) << 20);
	}

	public uint store_int64
	{
		readonly get => (_bitfield >> 21) & 0x1u;

		set => _bitfield = (_bitfield & ~(0x1u << 21)) | ((value & 0x1u) << 21);
	}

	public uint padding_dummy;
}

public struct GUri { }
public struct GHmac { }

public struct GByteArray
{
	public byte[] data;
	public uint len;
}

public interface GSequenceIter { }

[StructLayout(LayoutKind.Sequential)]
public struct GTimeSpan
{
	public nint Value;
}

[StructLayout(LayoutKind.Sequential)]
public struct GDateDay
{
	public byte Value;
}

[StructLayout(LayoutKind.Sequential)]
public struct GDateYear
{
	public ushort Value;
}

[StructLayout(LayoutKind.Sequential)]
public struct time_t
{
	public nint Value;
}

[StructLayout(LayoutKind.Sequential)]
public struct GQuark
{
	public uint Value;

	public static implicit operator nuint(GQuark t) => new(t.Value);
	public static implicit operator nint(GQuark t) => new(t.Value);
	public static implicit operator uint(GQuark t) => t.Value;
}

[StructLayout(LayoutKind.Sequential)]
public struct GTime
{
	public int Value;
}

[StructLayout(LayoutKind.Sequential)]
public struct GStrv
{
	public string[] Value;
}

[StructLayout(LayoutKind.Sequential)]
public struct GPid
{
	public int Value;
}

[StructLayout(LayoutKind.Sequential)]
public struct GType
{
	public uint Value;

	public static implicit operator nuint(GType t) => new(t.Value);
	public static implicit operator nint(GType t) => new(t.Value);
}
