namespace MentorLake.Gtk4.GLib;

public class GStringHandle : BaseSafeHandle
{
	public static GStringHandle New(string init)
	{
		return GStringExterns.g_string_new(init);
	}

	public static GStringHandle NewLen(string init, UIntPtr len)
	{
		return GStringExterns.g_string_new_len(init, len);
	}

	public static GStringHandle NewTake(string init)
	{
		return GStringExterns.g_string_new_take(init);
	}

	public static GStringHandle SizedNew(UIntPtr dfl_size)
	{
		return GStringExterns.g_string_sized_new(dfl_size);
	}

}


public static class GStringHandleExtensions
{
	public static GStringHandle Append(this GStringHandle @string, string val)
	{
		return GStringExterns.g_string_append(@string, val);
	}

	public static GStringHandle AppendC(this GStringHandle @string, char c)
	{
		return GStringExterns.g_string_append_c(@string, c);
	}

	public static GStringHandle AppendLen(this GStringHandle @string, string val, UIntPtr len)
	{
		return GStringExterns.g_string_append_len(@string, val, len);
	}

	public static GStringHandle AppendPrintf(this GStringHandle @string, string format, IntPtr @__arglist)
	{
		GStringExterns.g_string_append_printf(@string, format, @__arglist);
		return @string;
	}

	public static GStringHandle AppendUnichar(this GStringHandle @string, char wc)
	{
		return GStringExterns.g_string_append_unichar(@string, wc);
	}

	public static GStringHandle AppendUriEscaped(this GStringHandle @string, string unescaped, string reserved_chars_allowed, bool allow_utf8)
	{
		return GStringExterns.g_string_append_uri_escaped(@string, unescaped, reserved_chars_allowed, allow_utf8);
	}

	public static GStringHandle AppendVprintf(this GStringHandle @string, string format, IntPtr args)
	{
		GStringExterns.g_string_append_vprintf(@string, format, args);
		return @string;
	}

	public static GStringHandle AsciiDown(this GStringHandle @string)
	{
		return GStringExterns.g_string_ascii_down(@string);
	}

	public static GStringHandle AsciiUp(this GStringHandle @string)
	{
		return GStringExterns.g_string_ascii_up(@string);
	}

	public static GStringHandle Assign(this GStringHandle @string, string rval)
	{
		return GStringExterns.g_string_assign(@string, rval);
	}

	public static GStringHandle Down(this GStringHandle @string)
	{
		return GStringExterns.g_string_down(@string);
	}

	public static bool Equal(this GStringHandle v, GStringHandle v2)
	{
		return GStringExterns.g_string_equal(v, v2);
	}

	public static GStringHandle Erase(this GStringHandle @string, UIntPtr pos, UIntPtr len)
	{
		return GStringExterns.g_string_erase(@string, pos, len);
	}

	public static string Free(this GStringHandle @string, bool free_segment)
	{
		return GStringExterns.g_string_free(@string, free_segment);
	}

	public static string FreeAndSteal(this GStringHandle @string)
	{
		return GStringExterns.g_string_free_and_steal(@string);
	}

	public static GBytesHandle FreeToBytes(this GStringHandle @string)
	{
		return GStringExterns.g_string_free_to_bytes(@string);
	}

	public static uint Hash(this GStringHandle str)
	{
		return GStringExterns.g_string_hash(str);
	}

	public static GStringHandle Insert(this GStringHandle @string, UIntPtr pos, string val)
	{
		return GStringExterns.g_string_insert(@string, pos, val);
	}

	public static GStringHandle InsertC(this GStringHandle @string, UIntPtr pos, char c)
	{
		return GStringExterns.g_string_insert_c(@string, pos, c);
	}

	public static GStringHandle InsertLen(this GStringHandle @string, UIntPtr pos, string val, UIntPtr len)
	{
		return GStringExterns.g_string_insert_len(@string, pos, val, len);
	}

	public static GStringHandle InsertUnichar(this GStringHandle @string, UIntPtr pos, char wc)
	{
		return GStringExterns.g_string_insert_unichar(@string, pos, wc);
	}

	public static GStringHandle Overwrite(this GStringHandle @string, UIntPtr pos, string val)
	{
		return GStringExterns.g_string_overwrite(@string, pos, val);
	}

	public static GStringHandle OverwriteLen(this GStringHandle @string, UIntPtr pos, string val, UIntPtr len)
	{
		return GStringExterns.g_string_overwrite_len(@string, pos, val, len);
	}

	public static GStringHandle Prepend(this GStringHandle @string, string val)
	{
		return GStringExterns.g_string_prepend(@string, val);
	}

	public static GStringHandle PrependC(this GStringHandle @string, char c)
	{
		return GStringExterns.g_string_prepend_c(@string, c);
	}

	public static GStringHandle PrependLen(this GStringHandle @string, string val, UIntPtr len)
	{
		return GStringExterns.g_string_prepend_len(@string, val, len);
	}

	public static GStringHandle PrependUnichar(this GStringHandle @string, char wc)
	{
		return GStringExterns.g_string_prepend_unichar(@string, wc);
	}

	public static GStringHandle Printf(this GStringHandle @string, string format, IntPtr @__arglist)
	{
		GStringExterns.g_string_printf(@string, format, @__arglist);
		return @string;
	}

	public static uint Replace(this GStringHandle @string, string find, string replace, uint limit)
	{
		return GStringExterns.g_string_replace(@string, find, replace, limit);
	}

	public static GStringHandle SetSize(this GStringHandle @string, UIntPtr len)
	{
		return GStringExterns.g_string_set_size(@string, len);
	}

	public static GStringHandle Truncate(this GStringHandle @string, UIntPtr len)
	{
		return GStringExterns.g_string_truncate(@string, len);
	}

	public static GStringHandle Up(this GStringHandle @string)
	{
		return GStringExterns.g_string_up(@string);
	}

	public static GStringHandle Vprintf(this GStringHandle @string, string format, IntPtr args)
	{
		GStringExterns.g_string_vprintf(@string, format, args);
		return @string;
	}

}
internal class GStringExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_new(string init);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_new_len(string init, UIntPtr len);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_new_take(string init);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_sized_new(UIntPtr dfl_size);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_append(GStringHandle @string, string val);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_append_c(GStringHandle @string, char c);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_append_len(GStringHandle @string, string val, UIntPtr len);

	[DllImport(Libraries.GLib)]
	internal static extern void g_string_append_printf(GStringHandle @string, string format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_append_unichar(GStringHandle @string, char wc);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_append_uri_escaped(GStringHandle @string, string unescaped, string reserved_chars_allowed, bool allow_utf8);

	[DllImport(Libraries.GLib)]
	internal static extern void g_string_append_vprintf(GStringHandle @string, string format, IntPtr args);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_ascii_down(GStringHandle @string);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_ascii_up(GStringHandle @string);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_assign(GStringHandle @string, string rval);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_down(GStringHandle @string);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_string_equal(GStringHandle v, GStringHandle v2);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_erase(GStringHandle @string, UIntPtr pos, UIntPtr len);

	[DllImport(Libraries.GLib)]
	internal static extern string g_string_free(GStringHandle @string, bool free_segment);

	[DllImport(Libraries.GLib)]
	internal static extern string g_string_free_and_steal(GStringHandle @string);

	[DllImport(Libraries.GLib)]
	internal static extern GBytesHandle g_string_free_to_bytes(GStringHandle @string);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_string_hash(GStringHandle str);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_insert(GStringHandle @string, UIntPtr pos, string val);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_insert_c(GStringHandle @string, UIntPtr pos, char c);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_insert_len(GStringHandle @string, UIntPtr pos, string val, UIntPtr len);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_insert_unichar(GStringHandle @string, UIntPtr pos, char wc);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_overwrite(GStringHandle @string, UIntPtr pos, string val);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_overwrite_len(GStringHandle @string, UIntPtr pos, string val, UIntPtr len);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_prepend(GStringHandle @string, string val);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_prepend_c(GStringHandle @string, char c);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_prepend_len(GStringHandle @string, string val, UIntPtr len);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_prepend_unichar(GStringHandle @string, char wc);

	[DllImport(Libraries.GLib)]
	internal static extern void g_string_printf(GStringHandle @string, string format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_string_replace(GStringHandle @string, string find, string replace, uint limit);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_set_size(GStringHandle @string, UIntPtr len);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_truncate(GStringHandle @string, UIntPtr len);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_up(GStringHandle @string);

	[DllImport(Libraries.GLib)]
	internal static extern void g_string_vprintf(GStringHandle @string, string format, IntPtr args);

}

public struct GString
{
	public string str;
	public UIntPtr len;
	public UIntPtr allocated_len;
}
