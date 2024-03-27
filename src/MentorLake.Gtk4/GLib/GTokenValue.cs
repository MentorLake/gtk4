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

public class GTokenValueHandle : BaseSafeHandle
{
}

public struct GTokenValue
{
	public IntPtr v_symbol;
	public string v_identifier;
	public ulong v_binary;
	public ulong v_octal;
	public ulong v_int;
	public ulong v_int64;
	public double v_float;
	public ulong v_hex;
	public string v_string;
	public string v_comment;
	public char v_char;
	public uint v_error;
}
