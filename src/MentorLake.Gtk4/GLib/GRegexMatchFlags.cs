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

[Flags]
public enum GRegexMatchFlags
{
	G_REGEX_MATCH_DEFAULT = 0,
	G_REGEX_MATCH_ANCHORED = 1,
	G_REGEX_MATCH_NOTBOL = 2,
	G_REGEX_MATCH_NOTEOL = 4,
	G_REGEX_MATCH_NOTEMPTY = 8,
	G_REGEX_MATCH_PARTIAL = 16,
	G_REGEX_MATCH_NEWLINE_CR = 32,
	G_REGEX_MATCH_NEWLINE_LF = 64,
	G_REGEX_MATCH_NEWLINE_CRLF = 128,
	G_REGEX_MATCH_NEWLINE_ANY = 256,
	G_REGEX_MATCH_NEWLINE_ANYCRLF = 512,
	G_REGEX_MATCH_BSR_ANYCRLF = 1024,
	G_REGEX_MATCH_BSR_ANY = 2048,
	G_REGEX_MATCH_PARTIAL_SOFT = 4096,
	G_REGEX_MATCH_PARTIAL_HARD = 8192,
	G_REGEX_MATCH_NOTEMPTY_ATSTART = 16384
}
