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

public class GVariantDictHandle : BaseSafeHandle
{
	public static GVariantDictHandle New(GVariantHandle from_asv)
	{
		return GVariantDictExterns.g_variant_dict_new(from_asv);
	}

}

internal class GVariantDictExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GVariantDictHandle g_variant_dict_new(GVariantHandle from_asv);

}

public struct GVariantDict
{
}
