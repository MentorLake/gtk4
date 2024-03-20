using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GScannerAdaptors
{
	public static GScannerHandle Destroy(this GScannerHandle scanner)
	{
		GScannerExterns.g_scanner_destroy(scanner);
		return scanner;
	}

	public static GScannerHandle InputFile(this GScannerHandle scanner, int input_fd)
	{
		GScannerExterns.g_scanner_input_file(scanner, input_fd);
		return scanner;
	}

	public static GScannerHandle SyncFileOffset(this GScannerHandle scanner)
	{
		GScannerExterns.g_scanner_sync_file_offset(scanner);
		return scanner;
	}

	public static GScannerHandle InputText(this GScannerHandle scanner, string text, uint text_len)
	{
		GScannerExterns.g_scanner_input_text(scanner, text, text_len);
		return scanner;
	}

	public static GTokenType GetNextToken(this GScannerHandle scanner)
	{
		return GScannerExterns.g_scanner_get_next_token(scanner);
	}

	public static GTokenType PeekNextToken(this GScannerHandle scanner)
	{
		return GScannerExterns.g_scanner_peek_next_token(scanner);
	}

	public static GTokenType CurToken(this GScannerHandle scanner)
	{
		return GScannerExterns.g_scanner_cur_token(scanner);
	}

	public static GTokenValue CurValue(this GScannerHandle scanner)
	{
		return GScannerExterns.g_scanner_cur_value(scanner);
	}

	public static uint CurLine(this GScannerHandle scanner)
	{
		return GScannerExterns.g_scanner_cur_line(scanner);
	}

	public static uint CurPosition(this GScannerHandle scanner)
	{
		return GScannerExterns.g_scanner_cur_position(scanner);
	}

	public static int Eof(this GScannerHandle scanner)
	{
		return GScannerExterns.g_scanner_eof(scanner);
	}

	public static uint SetScope(this GScannerHandle scanner, uint scope_id)
	{
		return GScannerExterns.g_scanner_set_scope(scanner, scope_id);
	}

	public static GScannerHandle ScopeAddSymbol(this GScannerHandle scanner, uint scope_id, string symbol, IntPtr value)
	{
		GScannerExterns.g_scanner_scope_add_symbol(scanner, scope_id, symbol, value);
		return scanner;
	}

	public static GScannerHandle ScopeRemoveSymbol(this GScannerHandle scanner, uint scope_id, string symbol)
	{
		GScannerExterns.g_scanner_scope_remove_symbol(scanner, scope_id, symbol);
		return scanner;
	}

	public static IntPtr ScopeLookupSymbol(this GScannerHandle scanner, uint scope_id, string symbol)
	{
		return GScannerExterns.g_scanner_scope_lookup_symbol(scanner, scope_id, symbol);
	}

	public static GScannerHandle ScopeForeachSymbol(this GScannerHandle scanner, uint scope_id, GHFunc func, IntPtr user_data)
	{
		GScannerExterns.g_scanner_scope_foreach_symbol(scanner, scope_id, func, user_data);
		return scanner;
	}

	public static IntPtr LookupSymbol(this GScannerHandle scanner, string symbol)
	{
		return GScannerExterns.g_scanner_lookup_symbol(scanner, symbol);
	}

	public static GScannerHandle UnexpToken(this GScannerHandle scanner, GTokenType expected_token, string identifier_spec, string symbol_spec, string symbol_name, string message, int is_error)
	{
		GScannerExterns.g_scanner_unexp_token(scanner, expected_token, identifier_spec, symbol_spec, symbol_name, message, is_error);
		return scanner;
	}

	public static GScannerHandle Error(this GScannerHandle scanner, string format, IntPtr @__argList)
	{
		GScannerExterns.g_scanner_error(scanner, format, @__argList);
		return scanner;
	}

	public static GScannerHandle Warn(this GScannerHandle scanner, string format, IntPtr @__argList)
	{
		GScannerExterns.g_scanner_warn(scanner, format, @__argList);
		return scanner;
	}
}
