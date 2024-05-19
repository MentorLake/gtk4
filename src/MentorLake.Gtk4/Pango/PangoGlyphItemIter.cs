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

namespace MentorLake.Gtk4.Pango;

public class PangoGlyphItemIterHandle : BaseSafeHandle
{
}

internal class PangoGlyphItemIterExterns
{
}

public struct PangoGlyphItemIter
{
	public PangoGlyphItemHandle glyph_item;
	public string text;
	public int start_glyph;
	public int start_index;
	public int start_char;
	public int end_glyph;
	public int end_index;
	public int end_char;
}
