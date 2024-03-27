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

public class GScannerHandle : BaseSafeHandle
{
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
