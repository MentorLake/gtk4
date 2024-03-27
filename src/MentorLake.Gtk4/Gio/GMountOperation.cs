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

public class GMountOperationHandle : GObjectHandle
{
	public static GMountOperationHandle New()
	{
		return GMountOperationExterns.g_mount_operation_new();
	}
}

public class GMountOperationSignal
{
	public string Value { get; set; }
	public GMountOperationSignal(string value) => Value = value;
}

public static class GMountOperationSignals
{
	public static GMountOperationSignal Aborted = new("aborted");
	public static GMountOperationSignal AskPassword = new("ask-password");
	public static GMountOperationSignal AskQuestion = new("ask-question");
	public static GMountOperationSignal Reply = new("reply");
	public static GMountOperationSignal ShowProcesses = new("show-processes");
	public static GMountOperationSignal ShowUnmountProgress = new("show-unmount-progress");
}

public static class GMountOperationHandleExtensions
{
	public static bool GetAnonymous(this GMountOperationHandle op)
	{
		return GMountOperationExterns.g_mount_operation_get_anonymous(op);
	}

	public static int GetChoice(this GMountOperationHandle op)
	{
		return GMountOperationExterns.g_mount_operation_get_choice(op);
	}

	public static string GetDomain(this GMountOperationHandle op)
	{
		return GMountOperationExterns.g_mount_operation_get_domain(op);
	}

	public static bool GetIsTcryptHiddenVolume(this GMountOperationHandle op)
	{
		return GMountOperationExterns.g_mount_operation_get_is_tcrypt_hidden_volume(op);
	}

	public static bool GetIsTcryptSystemVolume(this GMountOperationHandle op)
	{
		return GMountOperationExterns.g_mount_operation_get_is_tcrypt_system_volume(op);
	}

	public static string GetPassword(this GMountOperationHandle op)
	{
		return GMountOperationExterns.g_mount_operation_get_password(op);
	}

	public static GPasswordSave GetPasswordSave(this GMountOperationHandle op)
	{
		return GMountOperationExterns.g_mount_operation_get_password_save(op);
	}

	public static uint GetPim(this GMountOperationHandle op)
	{
		return GMountOperationExterns.g_mount_operation_get_pim(op);
	}

	public static string GetUsername(this GMountOperationHandle op)
	{
		return GMountOperationExterns.g_mount_operation_get_username(op);
	}

	public static GMountOperationHandle Reply(this GMountOperationHandle op, GMountOperationResult result)
	{
		GMountOperationExterns.g_mount_operation_reply(op, result);
		return op;
	}

	public static GMountOperationHandle SetAnonymous(this GMountOperationHandle op, bool anonymous)
	{
		GMountOperationExterns.g_mount_operation_set_anonymous(op, anonymous);
		return op;
	}

	public static GMountOperationHandle SetChoice(this GMountOperationHandle op, int choice)
	{
		GMountOperationExterns.g_mount_operation_set_choice(op, choice);
		return op;
	}

	public static GMountOperationHandle SetDomain(this GMountOperationHandle op, string domain)
	{
		GMountOperationExterns.g_mount_operation_set_domain(op, domain);
		return op;
	}

	public static GMountOperationHandle SetIsTcryptHiddenVolume(this GMountOperationHandle op, bool hidden_volume)
	{
		GMountOperationExterns.g_mount_operation_set_is_tcrypt_hidden_volume(op, hidden_volume);
		return op;
	}

	public static GMountOperationHandle SetIsTcryptSystemVolume(this GMountOperationHandle op, bool system_volume)
	{
		GMountOperationExterns.g_mount_operation_set_is_tcrypt_system_volume(op, system_volume);
		return op;
	}

	public static GMountOperationHandle SetPassword(this GMountOperationHandle op, string password)
	{
		GMountOperationExterns.g_mount_operation_set_password(op, password);
		return op;
	}

	public static GMountOperationHandle SetPasswordSave(this GMountOperationHandle op, GPasswordSave save)
	{
		GMountOperationExterns.g_mount_operation_set_password_save(op, save);
		return op;
	}

	public static GMountOperationHandle SetPim(this GMountOperationHandle op, uint pim)
	{
		GMountOperationExterns.g_mount_operation_set_pim(op, pim);
		return op;
	}

	public static GMountOperationHandle SetUsername(this GMountOperationHandle op, string username)
	{
		GMountOperationExterns.g_mount_operation_set_username(op, username);
		return op;
	}

	public static GMountOperationHandle Connect(this GMountOperationHandle instance, GMountOperationSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GMountOperationExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_mount_operation_get_anonymous(GMountOperationHandle op);
	[DllImport(Libraries.Gio)]
	internal static extern int g_mount_operation_get_choice(GMountOperationHandle op);
	[DllImport(Libraries.Gio)]
	internal static extern string g_mount_operation_get_domain(GMountOperationHandle op);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_mount_operation_get_is_tcrypt_hidden_volume(GMountOperationHandle op);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_mount_operation_get_is_tcrypt_system_volume(GMountOperationHandle op);
	[DllImport(Libraries.Gio)]
	internal static extern string g_mount_operation_get_password(GMountOperationHandle op);
	[DllImport(Libraries.Gio)]
	internal static extern GPasswordSave g_mount_operation_get_password_save(GMountOperationHandle op);
	[DllImport(Libraries.Gio)]
	internal static extern uint g_mount_operation_get_pim(GMountOperationHandle op);
	[DllImport(Libraries.Gio)]
	internal static extern string g_mount_operation_get_username(GMountOperationHandle op);
	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_operation_reply(GMountOperationHandle op, GMountOperationResult result);
	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_operation_set_anonymous(GMountOperationHandle op, bool anonymous);
	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_operation_set_choice(GMountOperationHandle op, int choice);
	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_operation_set_domain(GMountOperationHandle op, string domain);
	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_operation_set_is_tcrypt_hidden_volume(GMountOperationHandle op, bool hidden_volume);
	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_operation_set_is_tcrypt_system_volume(GMountOperationHandle op, bool system_volume);
	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_operation_set_password(GMountOperationHandle op, string password);
	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_operation_set_password_save(GMountOperationHandle op, GPasswordSave save);
	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_operation_set_pim(GMountOperationHandle op, uint pim);
	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_operation_set_username(GMountOperationHandle op, string username);
	[DllImport(Libraries.Gio)]
	internal static extern GMountOperationHandle g_mount_operation_new();
}
