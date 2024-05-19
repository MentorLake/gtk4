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

public class GHmacHandle : BaseSafeHandle
{
	public static GHmacHandle New(GChecksumType digest_type, string key, int key_len)
	{
		return GHmacExterns.g_hmac_new(digest_type, key, key_len);
	}

}

internal class GHmacExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GHmacHandle g_hmac_new(GChecksumType digest_type, string key, int key_len);

}

public struct GHmac
{
}
