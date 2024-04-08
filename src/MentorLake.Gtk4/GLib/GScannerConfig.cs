using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.GLib;

public class GScannerConfigHandle : BaseSafeHandle
{
}

internal class GScannerConfigExterns
{
}

public struct GScannerConfig
{
	public string cset_skip_characters;
	public string cset_identifier_first;
	public string cset_identifier_nth;
	public string cpair_comment_single;
	public uint case_sensitive;
	public uint skip_comment_multi;
	public uint skip_comment_single;
	public uint scan_comment_multi;
	public uint scan_identifier;
	public uint scan_identifier_1char;
	public uint scan_identifier_NULL;
	public uint scan_symbols;
	public uint scan_binary;
	public uint scan_octal;
	public uint scan_float;
	public uint scan_hex;
	public uint scan_hex_dollar;
	public uint scan_string_sq;
	public uint scan_string_dq;
	public uint numbers_2_int;
	public uint int_2_float;
	public uint identifier_2_string;
	public uint char_2_token;
	public uint symbol_2_token;
	public uint scope_0_fallback;
	public uint store_int64;
}
