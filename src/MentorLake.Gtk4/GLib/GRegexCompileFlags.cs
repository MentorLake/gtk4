using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.GLib;

[Flags]
public enum GRegexCompileFlags
{
	G_REGEX_DEFAULT = 0,
	G_REGEX_CASELESS = 1,
	G_REGEX_MULTILINE = 2,
	G_REGEX_DOTALL = 4,
	G_REGEX_EXTENDED = 8,
	G_REGEX_ANCHORED = 16,
	G_REGEX_DOLLAR_ENDONLY = 32,
	G_REGEX_UNGREEDY = 64,
	G_REGEX_RAW = 128,
	G_REGEX_NO_AUTO_CAPTURE = 256,
	G_REGEX_OPTIMIZE = 512,
	G_REGEX_FIRSTLINE = 1024,
	G_REGEX_DUPNAMES = 2048,
	G_REGEX_NEWLINE_CR = 4096,
	G_REGEX_NEWLINE_LF = 8192,
	G_REGEX_NEWLINE_CRLF = 16384,
	G_REGEX_NEWLINE_ANYCRLF = 32768,
	G_REGEX_BSR_ANYCRLF = 65536,
	G_REGEX_JAVASCRIPT_COMPAT = 131072
}
