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

public class GCredentialsHandle : GObjectHandle
{
	public static GCredentialsHandle New()
	{
		return GCredentialsExterns.g_credentials_new();
	}

}

public static class GCredentialsHandleExtensions
{
	public static IntPtr GetNative(this GCredentialsHandle credentials, GCredentialsType native_type)
	{
		return GCredentialsExterns.g_credentials_get_native(credentials, native_type);
	}

	public static int GetUnixPid(this GCredentialsHandle credentials, out GErrorHandle error)
	{
		return GCredentialsExterns.g_credentials_get_unix_pid(credentials, out error);
	}

	public static int GetUnixUser(this GCredentialsHandle credentials, out GErrorHandle error)
	{
		return GCredentialsExterns.g_credentials_get_unix_user(credentials, out error);
	}

	public static bool IsSameUser(this GCredentialsHandle credentials, GCredentialsHandle other_credentials, out GErrorHandle error)
	{
		return GCredentialsExterns.g_credentials_is_same_user(credentials, other_credentials, out error);
	}

	public static GCredentialsHandle SetNative(this GCredentialsHandle credentials, GCredentialsType native_type, IntPtr native)
	{
		GCredentialsExterns.g_credentials_set_native(credentials, native_type, native);
		return credentials;
	}

	public static bool SetUnixUser(this GCredentialsHandle credentials, int uid, out GErrorHandle error)
	{
		return GCredentialsExterns.g_credentials_set_unix_user(credentials, uid, out error);
	}

	public static string ToString(this GCredentialsHandle credentials)
	{
		return GCredentialsExterns.g_credentials_to_string(credentials);
	}

}

internal class GCredentialsExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GCredentialsHandle g_credentials_new();
	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_credentials_get_native(GCredentialsHandle credentials, GCredentialsType native_type);
	[DllImport(Libraries.Gio)]
	internal static extern int g_credentials_get_unix_pid(GCredentialsHandle credentials, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern int g_credentials_get_unix_user(GCredentialsHandle credentials, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_credentials_is_same_user(GCredentialsHandle credentials, GCredentialsHandle other_credentials, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_credentials_set_native(GCredentialsHandle credentials, GCredentialsType native_type, IntPtr native);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_credentials_set_unix_user(GCredentialsHandle credentials, int uid, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern string g_credentials_to_string(GCredentialsHandle credentials);
}
