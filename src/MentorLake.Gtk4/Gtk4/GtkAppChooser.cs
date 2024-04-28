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

namespace MentorLake.Gtk4.Gtk4;

public interface GtkAppChooserHandle
{
}

internal class GtkAppChooserHandleImpl : BaseSafeHandle, GtkAppChooserHandle
{
}

public static class GtkAppChooserHandleExtensions
{
	public static GAppInfoHandle GetAppInfo(this GtkAppChooserHandle self)
	{
		return GtkAppChooserExterns.gtk_app_chooser_get_app_info(self);
	}

	public static string GetContentType(this GtkAppChooserHandle self)
	{
		return GtkAppChooserExterns.gtk_app_chooser_get_content_type(self);
	}

	public static GtkAppChooserHandle Refresh(this GtkAppChooserHandle self)
	{
		GtkAppChooserExterns.gtk_app_chooser_refresh(self);
		return self;
	}

}

internal class GtkAppChooserExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GAppInfoHandle gtk_app_chooser_get_app_info(GtkAppChooserHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_app_chooser_get_content_type(GtkAppChooserHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_app_chooser_refresh(GtkAppChooserHandle self);

}
