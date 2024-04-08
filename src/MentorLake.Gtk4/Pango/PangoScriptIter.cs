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

namespace MentorLake.Gtk4.Pango;

public class PangoScriptIterHandle : BaseSafeHandle
{
	public static PangoScriptIterHandle New(string text, int length)
	{
		return PangoScriptIterExterns.pango_script_iter_new(text, length);
	}

}

internal class PangoScriptIterExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoScriptIterHandle pango_script_iter_new(string text, int length);
}

public struct PangoScriptIter
{
}
