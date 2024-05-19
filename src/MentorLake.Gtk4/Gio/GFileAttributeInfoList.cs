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

namespace MentorLake.Gtk4.Gio;

public class GFileAttributeInfoListHandle : BaseSafeHandle
{
	public static GFileAttributeInfoListHandle New()
	{
		return GFileAttributeInfoListExterns.g_file_attribute_info_list_new();
	}

}

internal class GFileAttributeInfoListExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GFileAttributeInfoListHandle g_file_attribute_info_list_new();

}

public struct GFileAttributeInfoList
{
	public GFileAttributeInfoHandle infos;
	public int n_infos;
}
