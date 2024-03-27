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

public class GUnixCredentialsMessageHandle : GSocketControlMessageHandle
{
	public static GUnixCredentialsMessageHandle New()
	{
		return GUnixCredentialsMessageExterns.g_unix_credentials_message_new();
	}
	public static GUnixCredentialsMessageHandle NewWithCredentials(GCredentialsHandle credentials)
	{
		return GUnixCredentialsMessageExterns.g_unix_credentials_message_new_with_credentials(credentials);
	}
}

public static class GUnixCredentialsMessageSignals
{
}

public static class GUnixCredentialsMessageHandleExtensions
{
	public static GCredentialsHandle GetCredentials(this GUnixCredentialsMessageHandle message)
	{
		return GUnixCredentialsMessageExterns.g_unix_credentials_message_get_credentials(message);
	}

}

internal class GUnixCredentialsMessageExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GCredentialsHandle g_unix_credentials_message_get_credentials(GUnixCredentialsMessageHandle message);
	[DllImport(Libraries.Gio)]
	internal static extern GUnixCredentialsMessageHandle g_unix_credentials_message_new();
	[DllImport(Libraries.Gio)]
	internal static extern GUnixCredentialsMessageHandle g_unix_credentials_message_new_with_credentials(GCredentialsHandle credentials);
}
