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

public class PangoAnalysisHandle : BaseSafeHandle
{
}

internal class PangoAnalysisExterns
{
}

public struct PangoAnalysis
{
	public IntPtr shape_engine;
	public IntPtr lang_engine;
	public PangoFontHandle font;
	public byte level;
	public byte gravity;
	public byte flags;
	public byte script;
	public PangoLanguageHandle language;
	public GSListHandle extra_attrs;
}
