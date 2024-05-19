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

public class GFileIconHandle : GObjectHandle, GIconHandle, GLoadableIconHandle
{
	public static GFileIconHandle New(GFileHandle file)
	{
		return GFileIconExterns.g_file_icon_new(file);
	}

}

public static class GFileIconHandleExtensions
{
	public static GFileHandle GetFile(this GFileIconHandle icon)
	{
		return GFileIconExterns.g_file_icon_get_file(icon);
	}

}

internal class GFileIconExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GFileIconHandle g_file_icon_new(GFileHandle file);

	[DllImport(Libraries.Gio)]
	internal static extern GFileHandle g_file_icon_get_file(GFileIconHandle icon);

}
