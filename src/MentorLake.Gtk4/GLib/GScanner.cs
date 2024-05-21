namespace MentorLake.Gtk4.GLib;

public class GScannerHandle : BaseSafeHandle
{
}


public static class GScannerHandleExtensions
{
	public static uint CurLine(this GScannerHandle scanner)
	{
		return GScannerExterns.g_scanner_cur_line(scanner);
	}

	public static uint CurPosition(this GScannerHandle scanner)
	{
		return GScannerExterns.g_scanner_cur_position(scanner);
	}

	public static GTokenType CurToken(this GScannerHandle scanner)
	{
		return GScannerExterns.g_scanner_cur_token(scanner);
	}

	public static GTokenValue CurValue(this GScannerHandle scanner)
	{
		return GScannerExterns.g_scanner_cur_value(scanner);
	}

	public static GScannerHandle Destroy(this GScannerHandle scanner)
	{
		GScannerExterns.g_scanner_destroy(scanner);
		return scanner;
	}

	public static bool Eof(this GScannerHandle scanner)
	{
		return GScannerExterns.g_scanner_eof(scanner);
	}

	public static GScannerHandle Error(this GScannerHandle scanner, string format, IntPtr @__arglist)
	{
		GScannerExterns.g_scanner_error(scanner, format, @__arglist);
		return scanner;
	}

	public static GTokenType GetNextToken(this GScannerHandle scanner)
	{
		return GScannerExterns.g_scanner_get_next_token(scanner);
	}

	public static GScannerHandle InputFile(this GScannerHandle scanner, int input_fd)
	{
		GScannerExterns.g_scanner_input_file(scanner, input_fd);
		return scanner;
	}

	public static GScannerHandle InputText(this GScannerHandle scanner, string text, uint text_len)
	{
		GScannerExterns.g_scanner_input_text(scanner, text, text_len);
		return scanner;
	}

	public static IntPtr LookupSymbol(this GScannerHandle scanner, string symbol)
	{
		return GScannerExterns.g_scanner_lookup_symbol(scanner, symbol);
	}

	public static GTokenType PeekNextToken(this GScannerHandle scanner)
	{
		return GScannerExterns.g_scanner_peek_next_token(scanner);
	}

	public static GScannerHandle ScopeAddSymbol(this GScannerHandle scanner, uint scope_id, string symbol, IntPtr value)
	{
		GScannerExterns.g_scanner_scope_add_symbol(scanner, scope_id, symbol, value);
		return scanner;
	}

	public static GScannerHandle ScopeForeachSymbol(this GScannerHandle scanner, uint scope_id, GHFunc func, IntPtr user_data)
	{
		GScannerExterns.g_scanner_scope_foreach_symbol(scanner, scope_id, func, user_data);
		return scanner;
	}

	public static IntPtr ScopeLookupSymbol(this GScannerHandle scanner, uint scope_id, string symbol)
	{
		return GScannerExterns.g_scanner_scope_lookup_symbol(scanner, scope_id, symbol);
	}

	public static GScannerHandle ScopeRemoveSymbol(this GScannerHandle scanner, uint scope_id, string symbol)
	{
		GScannerExterns.g_scanner_scope_remove_symbol(scanner, scope_id, symbol);
		return scanner;
	}

	public static uint SetScope(this GScannerHandle scanner, uint scope_id)
	{
		return GScannerExterns.g_scanner_set_scope(scanner, scope_id);
	}

	public static GScannerHandle SyncFileOffset(this GScannerHandle scanner)
	{
		GScannerExterns.g_scanner_sync_file_offset(scanner);
		return scanner;
	}

	public static GScannerHandle UnexpToken(this GScannerHandle scanner, GTokenType expected_token, string identifier_spec, string symbol_spec, string symbol_name, string message, int is_error)
	{
		GScannerExterns.g_scanner_unexp_token(scanner, expected_token, identifier_spec, symbol_spec, symbol_name, message, is_error);
		return scanner;
	}

	public static GScannerHandle Warn(this GScannerHandle scanner, string format, IntPtr @__arglist)
	{
		GScannerExterns.g_scanner_warn(scanner, format, @__arglist);
		return scanner;
	}

}
internal class GScannerExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern uint g_scanner_cur_line(GScannerHandle scanner);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_scanner_cur_position(GScannerHandle scanner);

	[DllImport(Libraries.GLib)]
	internal static extern GTokenType g_scanner_cur_token(GScannerHandle scanner);

	[DllImport(Libraries.GLib)]
	internal static extern GTokenValue g_scanner_cur_value(GScannerHandle scanner);

	[DllImport(Libraries.GLib)]
	internal static extern void g_scanner_destroy(GScannerHandle scanner);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_scanner_eof(GScannerHandle scanner);

	[DllImport(Libraries.GLib)]
	internal static extern void g_scanner_error(GScannerHandle scanner, string format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern GTokenType g_scanner_get_next_token(GScannerHandle scanner);

	[DllImport(Libraries.GLib)]
	internal static extern void g_scanner_input_file(GScannerHandle scanner, int input_fd);

	[DllImport(Libraries.GLib)]
	internal static extern void g_scanner_input_text(GScannerHandle scanner, string text, uint text_len);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_scanner_lookup_symbol(GScannerHandle scanner, string symbol);

	[DllImport(Libraries.GLib)]
	internal static extern GTokenType g_scanner_peek_next_token(GScannerHandle scanner);

	[DllImport(Libraries.GLib)]
	internal static extern void g_scanner_scope_add_symbol(GScannerHandle scanner, uint scope_id, string symbol, IntPtr value);

	[DllImport(Libraries.GLib)]
	internal static extern void g_scanner_scope_foreach_symbol(GScannerHandle scanner, uint scope_id, GHFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_scanner_scope_lookup_symbol(GScannerHandle scanner, uint scope_id, string symbol);

	[DllImport(Libraries.GLib)]
	internal static extern void g_scanner_scope_remove_symbol(GScannerHandle scanner, uint scope_id, string symbol);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_scanner_set_scope(GScannerHandle scanner, uint scope_id);

	[DllImport(Libraries.GLib)]
	internal static extern void g_scanner_sync_file_offset(GScannerHandle scanner);

	[DllImport(Libraries.GLib)]
	internal static extern void g_scanner_unexp_token(GScannerHandle scanner, GTokenType expected_token, string identifier_spec, string symbol_spec, string symbol_name, string message, int is_error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_scanner_warn(GScannerHandle scanner, string format, IntPtr @__arglist);

}

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
	public GScannerMsgFunc msg_handler;
}
