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

public class GChecksumHandle : BaseSafeHandle
{
	public static GChecksumHandle New(GChecksumType checksum_type)
	{
		return GChecksumExterns.g_checksum_new(checksum_type);
	}

}

internal class GChecksumExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GChecksumHandle g_checksum_new(GChecksumType checksum_type);

}

public struct GChecksum
{
}
