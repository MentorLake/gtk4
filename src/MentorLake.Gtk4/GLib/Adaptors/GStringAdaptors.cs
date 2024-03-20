using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GStringAdaptors
{
	public static string Free(this GStringHandle @string, int free_segment)
	{
		return GStringExterns.g_string_free(@string, free_segment);
	}

	public static GBytesHandle FreeToBytes(this GStringHandle @string)
	{
		return GStringExterns.g_string_free_to_bytes(@string);
	}

	public static int Equal(this GStringHandle v, GStringHandle v2)
	{
		return GStringExterns.g_string_equal(v, v2);
	}

	public static uint Hash(this GStringHandle str)
	{
		return GStringExterns.g_string_hash(str);
	}

	public static GStringHandle Assign(this GStringHandle @string, string rval)
	{
		return GStringExterns.g_string_assign(@string, rval);
	}

	public static GStringHandle Truncate(this GStringHandle @string, nuint len)
	{
		return GStringExterns.g_string_truncate(@string, len);
	}

	public static GStringHandle SetSize(this GStringHandle @string, nuint len)
	{
		return GStringExterns.g_string_set_size(@string, len);
	}

	public static GStringHandle InsertLen(this GStringHandle @string, nint pos, string val, nint len)
	{
		return GStringExterns.g_string_insert_len(@string, pos, val, len);
	}

	public static GStringHandle Append(this GStringHandle @string, string val)
	{
		return GStringExterns.g_string_append(@string, val);
	}

	public static GStringHandle AppendLen(this GStringHandle @string, string val, nint len)
	{
		return GStringExterns.g_string_append_len(@string, val, len);
	}

	public static GStringHandle AppendC(this GStringHandle @string, char c)
	{
		return GStringExterns.g_string_append_c(@string, c);
	}

	public static GStringHandle AppendUnichar(this GStringHandle @string, uint wc)
	{
		return GStringExterns.g_string_append_unichar(@string, wc);
	}

	public static GStringHandle Prepend(this GStringHandle @string, string val)
	{
		return GStringExterns.g_string_prepend(@string, val);
	}

	public static GStringHandle PrependC(this GStringHandle @string, char c)
	{
		return GStringExterns.g_string_prepend_c(@string, c);
	}

	public static GStringHandle PrependUnichar(this GStringHandle @string, uint wc)
	{
		return GStringExterns.g_string_prepend_unichar(@string, wc);
	}

	public static GStringHandle PrependLen(this GStringHandle @string, string val, nint len)
	{
		return GStringExterns.g_string_prepend_len(@string, val, len);
	}

	public static GStringHandle Insert(this GStringHandle @string, nint pos, string val)
	{
		return GStringExterns.g_string_insert(@string, pos, val);
	}

	public static GStringHandle InsertC(this GStringHandle @string, nint pos, char c)
	{
		return GStringExterns.g_string_insert_c(@string, pos, c);
	}

	public static GStringHandle InsertUnichar(this GStringHandle @string, nint pos, uint wc)
	{
		return GStringExterns.g_string_insert_unichar(@string, pos, wc);
	}

	public static GStringHandle Overwrite(this GStringHandle @string, nuint pos, string val)
	{
		return GStringExterns.g_string_overwrite(@string, pos, val);
	}

	public static GStringHandle OverwriteLen(this GStringHandle @string, nuint pos, string val, nint len)
	{
		return GStringExterns.g_string_overwrite_len(@string, pos, val, len);
	}

	public static GStringHandle Erase(this GStringHandle @string, nint pos, nint len)
	{
		return GStringExterns.g_string_erase(@string, pos, len);
	}

	public static uint Replace(this GStringHandle @string, string find, string replace, uint limit)
	{
		return GStringExterns.g_string_replace(@string, find, replace, limit);
	}

	public static GStringHandle AsciiDown(this GStringHandle @string)
	{
		return GStringExterns.g_string_ascii_down(@string);
	}

	public static GStringHandle AsciiUp(this GStringHandle @string)
	{
		return GStringExterns.g_string_ascii_up(@string);
	}

	public static GStringHandle Vprintf(this GStringHandle @string, string format, IntPtr @__argList)
	{
		GStringExterns.g_string_vprintf(@string, format, @__argList);
		return @string;
	}

	public static GStringHandle Printf(this GStringHandle @string, string format, IntPtr @__argList)
	{
		GStringExterns.g_string_printf(@string, format, @__argList);
		return @string;
	}

	public static GStringHandle AppendVprintf(this GStringHandle @string, string format, IntPtr @__argList)
	{
		GStringExterns.g_string_append_vprintf(@string, format, @__argList);
		return @string;
	}

	public static GStringHandle AppendPrintf(this GStringHandle @string, string format, IntPtr @__argList)
	{
		GStringExterns.g_string_append_printf(@string, format, @__argList);
		return @string;
	}

	public static GStringHandle AppendUriEscaped(this GStringHandle @string, string unescaped, string reserved_chars_allowed, int allow_utf8)
	{
		return GStringExterns.g_string_append_uri_escaped(@string, unescaped, reserved_chars_allowed, allow_utf8);
	}

	public static GStringHandle Down(this GStringHandle @string)
	{
		return GStringExterns.g_string_down(@string);
	}

	public static GStringHandle Up(this GStringHandle @string)
	{
		return GStringExterns.g_string_up(@string);
	}

	public static GStringHandle NewLen(string init, nint len)
	{
		return GStringExterns.g_string_new_len(init, len);
	}

	public static GStringHandle SizedNew(nuint dfl_size)
	{
		return GStringExterns.g_string_sized_new(dfl_size);
	}
}
