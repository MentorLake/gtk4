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

public class GMappedFileHandle : BaseSafeHandle
{
	public static GMappedFileHandle New(string filename, bool writable, out GErrorHandle error)
	{
		return GMappedFileExterns.g_mapped_file_new(filename, writable, out error);
	}

	public static GMappedFileHandle NewFromFd(int fd, bool writable, out GErrorHandle error)
	{
		return GMappedFileExterns.g_mapped_file_new_from_fd(fd, writable, out error);
	}

}

internal class GMappedFileExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GMappedFileHandle g_mapped_file_new(string filename, bool writable, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GMappedFileHandle g_mapped_file_new_from_fd(int fd, bool writable, out GErrorHandle error);

}

public struct GMappedFile
{
}
