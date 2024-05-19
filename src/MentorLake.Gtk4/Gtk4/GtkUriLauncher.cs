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

namespace MentorLake.Gtk4.Gtk4;

public class GtkUriLauncherHandle : GObjectHandle
{
	public static GtkUriLauncherHandle New(string uri)
	{
		return GtkUriLauncherExterns.gtk_uri_launcher_new(uri);
	}

}

public static class GtkUriLauncherHandleExtensions
{
	public static string GetUri(this GtkUriLauncherHandle self)
	{
		return GtkUriLauncherExterns.gtk_uri_launcher_get_uri(self);
	}

	public static GtkUriLauncherHandle Launch(this GtkUriLauncherHandle self, GtkWindowHandle parent, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GtkUriLauncherExterns.gtk_uri_launcher_launch(self, parent, cancellable, callback, user_data);
		return self;
	}

	public static bool LaunchFinish(this GtkUriLauncherHandle self, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GtkUriLauncherExterns.gtk_uri_launcher_launch_finish(self, result, out error);
	}

	public static GtkUriLauncherHandle SetUri(this GtkUriLauncherHandle self, string uri)
	{
		GtkUriLauncherExterns.gtk_uri_launcher_set_uri(self, uri);
		return self;
	}

}

internal class GtkUriLauncherExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkUriLauncherHandle gtk_uri_launcher_new(string uri);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_uri_launcher_get_uri(GtkUriLauncherHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_uri_launcher_launch(GtkUriLauncherHandle self, GtkWindowHandle parent, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_uri_launcher_launch_finish(GtkUriLauncherHandle self, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_uri_launcher_set_uri(GtkUriLauncherHandle self, string uri);

}
