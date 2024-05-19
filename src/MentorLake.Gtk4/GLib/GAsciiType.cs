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
public enum GAsciiType
{
	G_ASCII_ALNUM = 0,
	G_ASCII_ALPHA = 1,
	G_ASCII_CNTRL = 2,
	G_ASCII_DIGIT = 4,
	G_ASCII_GRAPH = 8,
	G_ASCII_LOWER = 16,
	G_ASCII_PRINT = 32,
	G_ASCII_PUNCT = 64,
	G_ASCII_SPACE = 128,
	G_ASCII_UPPER = 256,
	G_ASCII_XDIGIT = 512
}
