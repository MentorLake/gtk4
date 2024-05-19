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

public class GSocketAddressEnumeratorHandle : GObjectHandle
{
}

public static class GSocketAddressEnumeratorHandleExtensions
{
	public static GSocketAddressHandle Next(this GSocketAddressEnumeratorHandle enumerator, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketAddressEnumeratorExterns.g_socket_address_enumerator_next(enumerator, cancellable, out error);
	}

	public static GSocketAddressEnumeratorHandle NextAsync(this GSocketAddressEnumeratorHandle enumerator, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GSocketAddressEnumeratorExterns.g_socket_address_enumerator_next_async(enumerator, cancellable, callback, user_data);
		return enumerator;
	}

	public static GSocketAddressHandle NextFinish(this GSocketAddressEnumeratorHandle enumerator, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GSocketAddressEnumeratorExterns.g_socket_address_enumerator_next_finish(enumerator, result, out error);
	}

}

internal class GSocketAddressEnumeratorExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSocketAddressHandle g_socket_address_enumerator_next(GSocketAddressEnumeratorHandle enumerator, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_address_enumerator_next_async(GSocketAddressEnumeratorHandle enumerator, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketAddressHandle g_socket_address_enumerator_next_finish(GSocketAddressEnumeratorHandle enumerator, GAsyncResultHandle result, out GErrorHandle error);

}
