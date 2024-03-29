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

public class GUnixFDListHandle : GObjectHandle
{
	public static GUnixFDListHandle GUnixFdListNew()
	{
		return GUnixFDListExterns.g_unix_fd_list_new();
	}

	public static GUnixFDListHandle GUnixFdListNewFromArray(int[] fds, int n_fds)
	{
		return GUnixFDListExterns.g_unix_fd_list_new_from_array(fds, n_fds);
	}

}

public static class GUnixFDListHandleExtensions
{
	public static int GUnixFdListAppend(this GUnixFDListHandle list, int fd, out GErrorHandle error)
	{
		return GUnixFDListExterns.g_unix_fd_list_append(list, fd, out error);
	}

	public static int GUnixFdListGet(this GUnixFDListHandle list, int index_, out GErrorHandle error)
	{
		return GUnixFDListExterns.g_unix_fd_list_get(list, index_, out error);
	}

	public static int GUnixFdListGetLength(this GUnixFDListHandle list)
	{
		return GUnixFDListExterns.g_unix_fd_list_get_length(list);
	}

	public static int[] GUnixFdListPeekFds(this GUnixFDListHandle list, out int length)
	{
		return GUnixFDListExterns.g_unix_fd_list_peek_fds(list, out length);
	}

	public static int[] GUnixFdListStealFds(this GUnixFDListHandle list, out int length)
	{
		return GUnixFDListExterns.g_unix_fd_list_steal_fds(list, out length);
	}

}

internal class GUnixFDListExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GUnixFDListHandle g_unix_fd_list_new();
	[DllImport(Libraries.Gio)]
	internal static extern GUnixFDListHandle g_unix_fd_list_new_from_array(int[] fds, int n_fds);
	[DllImport(Libraries.Gio)]
	internal static extern int g_unix_fd_list_append(GUnixFDListHandle list, int fd, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern int g_unix_fd_list_get(GUnixFDListHandle list, int index_, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern int g_unix_fd_list_get_length(GUnixFDListHandle list);
	[DllImport(Libraries.Gio)]
	internal static extern int[] g_unix_fd_list_peek_fds(GUnixFDListHandle list, out int length);
	[DllImport(Libraries.Gio)]
	internal static extern int[] g_unix_fd_list_steal_fds(GUnixFDListHandle list, out int length);
}
