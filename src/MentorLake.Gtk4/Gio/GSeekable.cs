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

namespace MentorLake.Gtk4.Gio;

public interface GSeekableHandle
{
}

public static class GSeekableHandleExtensions
{
	public static bool CanSeek(this GSeekableHandle seekable)
	{
		return GSeekableExterns.g_seekable_can_seek(seekable);
	}

	public static bool CanTruncate(this GSeekableHandle seekable)
	{
		return GSeekableExterns.g_seekable_can_truncate(seekable);
	}

	public static bool Seek(this GSeekableHandle seekable, int offset, GSeekType type, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSeekableExterns.g_seekable_seek(seekable, offset, type, cancellable, out error);
	}

	public static int Tell(this GSeekableHandle seekable)
	{
		return GSeekableExterns.g_seekable_tell(seekable);
	}

	public static bool Truncate(this GSeekableHandle seekable, int offset, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSeekableExterns.g_seekable_truncate(seekable, offset, cancellable, out error);
	}

}

internal class GSeekableExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_seekable_can_seek(GSeekableHandle seekable);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_seekable_can_truncate(GSeekableHandle seekable);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_seekable_seek(GSeekableHandle seekable, int offset, GSeekType type, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern int g_seekable_tell(GSeekableHandle seekable);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_seekable_truncate(GSeekableHandle seekable, int offset, GCancellableHandle cancellable, out GErrorHandle error);
}
