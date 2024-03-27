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

public class GtkFileLauncherHandle : GObjectHandle
{
	public static GtkFileLauncherHandle New(GFileHandle file)
	{
		return GtkFileLauncherExterns.gtk_file_launcher_new(file);
	}
}

public static class GtkFileLauncherSignals
{
}

public static class GtkFileLauncherHandleExtensions
{
	public static bool GetAlwaysAsk(this GtkFileLauncherHandle self)
	{
		return GtkFileLauncherExterns.gtk_file_launcher_get_always_ask(self);
	}

	public static GFileHandle GetFile(this GtkFileLauncherHandle self)
	{
		return GtkFileLauncherExterns.gtk_file_launcher_get_file(self);
	}

	public static bool GetWritable(this GtkFileLauncherHandle self)
	{
		return GtkFileLauncherExterns.gtk_file_launcher_get_writable(self);
	}

	public static GtkFileLauncherHandle Launch(this GtkFileLauncherHandle self, GtkWindowHandle parent, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GtkFileLauncherExterns.gtk_file_launcher_launch(self, parent, cancellable, callback, user_data);
		return self;
	}

	public static bool LaunchFinish(this GtkFileLauncherHandle self, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GtkFileLauncherExterns.gtk_file_launcher_launch_finish(self, result, out error);
	}

	public static GtkFileLauncherHandle OpenContainingFolder(this GtkFileLauncherHandle self, GtkWindowHandle parent, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GtkFileLauncherExterns.gtk_file_launcher_open_containing_folder(self, parent, cancellable, callback, user_data);
		return self;
	}

	public static bool OpenContainingFolderFinish(this GtkFileLauncherHandle self, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GtkFileLauncherExterns.gtk_file_launcher_open_containing_folder_finish(self, result, out error);
	}

	public static GtkFileLauncherHandle SetAlwaysAsk(this GtkFileLauncherHandle self, bool always_ask)
	{
		GtkFileLauncherExterns.gtk_file_launcher_set_always_ask(self, always_ask);
		return self;
	}

	public static GtkFileLauncherHandle SetFile(this GtkFileLauncherHandle self, GFileHandle file)
	{
		GtkFileLauncherExterns.gtk_file_launcher_set_file(self, file);
		return self;
	}

	public static GtkFileLauncherHandle SetWritable(this GtkFileLauncherHandle self, bool writable)
	{
		GtkFileLauncherExterns.gtk_file_launcher_set_writable(self, writable);
		return self;
	}

}

internal class GtkFileLauncherExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_file_launcher_get_always_ask(GtkFileLauncherHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GFileHandle gtk_file_launcher_get_file(GtkFileLauncherHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_file_launcher_get_writable(GtkFileLauncherHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_launcher_launch(GtkFileLauncherHandle self, GtkWindowHandle parent, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_file_launcher_launch_finish(GtkFileLauncherHandle self, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_launcher_open_containing_folder(GtkFileLauncherHandle self, GtkWindowHandle parent, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_file_launcher_open_containing_folder_finish(GtkFileLauncherHandle self, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_launcher_set_always_ask(GtkFileLauncherHandle self, bool always_ask);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_launcher_set_file(GtkFileLauncherHandle self, GFileHandle file);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_launcher_set_writable(GtkFileLauncherHandle self, bool writable);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFileLauncherHandle gtk_file_launcher_new(GFileHandle file);
}
