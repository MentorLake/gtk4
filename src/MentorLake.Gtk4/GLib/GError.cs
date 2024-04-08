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

namespace MentorLake.Gtk4.GLib;

public class GErrorHandle : BaseSafeHandle
{
	public static GErrorHandle New(GQuark domain, int code, string format, IntPtr @__arglist)
	{
		return GErrorExterns.g_error_new(domain, code, format, @__arglist);
	}

	public static GErrorHandle NewLiteral(GQuark domain, int code, string message)
	{
		return GErrorExterns.g_error_new_literal(domain, code, message);
	}

	public static GErrorHandle NewValist(GQuark domain, int code, string format, IntPtr args)
	{
		return GErrorExterns.g_error_new_valist(domain, code, format, args);
	}

}

internal class GErrorExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GErrorHandle g_error_new(GQuark domain, int code, string format, IntPtr @__arglist);
	[DllImport(Libraries.GLib)]
	internal static extern GErrorHandle g_error_new_literal(GQuark domain, int code, string message);
	[DllImport(Libraries.GLib)]
	internal static extern GErrorHandle g_error_new_valist(GQuark domain, int code, string format, IntPtr args);
}

public struct GError
{
	public GQuark domain;
	public int code;
	public string message;
}
