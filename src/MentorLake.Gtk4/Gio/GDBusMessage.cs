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

public class GDBusMessageHandle : GObjectHandle
{
	public static GDBusMessageHandle GDbusMessageNew()
	{
		return GDBusMessageExterns.g_dbus_message_new();
	}

	public static GDBusMessageHandle GDbusMessageNewFromBlob(string blob, int blob_len, GDBusCapabilityFlags capabilities, out GErrorHandle error)
	{
		return GDBusMessageExterns.g_dbus_message_new_from_blob(blob, blob_len, capabilities, out error);
	}

	public static GDBusMessageHandle GDbusMessageNewMethodCall(string name, string path, string interface_, string method)
	{
		return GDBusMessageExterns.g_dbus_message_new_method_call(name, path, interface_, method);
	}

	public static GDBusMessageHandle GDbusMessageNewSignal(string path, string interface_, string signal)
	{
		return GDBusMessageExterns.g_dbus_message_new_signal(path, interface_, signal);
	}

	public static int GDbusMessageBytesNeeded(string blob, int blob_len, out GErrorHandle error)
	{
		return GDBusMessageExterns.g_dbus_message_bytes_needed(blob, blob_len, out error);
	}

}

public static class GDBusMessageHandleExtensions
{
	public static GDBusMessageHandle GDbusMessageCopy(this GDBusMessageHandle message, out GErrorHandle error)
	{
		return GDBusMessageExterns.g_dbus_message_copy(message, out error);
	}

	public static string GDbusMessageGetArg0(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_arg0(message);
	}

	public static string GDbusMessageGetArg0Path(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_arg0_path(message);
	}

	public static GVariantHandle GDbusMessageGetBody(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_body(message);
	}

	public static GDBusMessageByteOrder GDbusMessageGetByteOrder(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_byte_order(message);
	}

	public static string GDbusMessageGetDestination(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_destination(message);
	}

	public static string GDbusMessageGetErrorName(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_error_name(message);
	}

	public static GDBusMessageFlags GDbusMessageGetFlags(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_flags(message);
	}

	public static GVariantHandle GDbusMessageGetHeader(this GDBusMessageHandle message, GDBusMessageHeaderField header_field)
	{
		return GDBusMessageExterns.g_dbus_message_get_header(message, header_field);
	}

	public static string GDbusMessageGetHeaderFields(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_header_fields(message);
	}

	public static string GDbusMessageGetInterface(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_interface(message);
	}

	public static bool GDbusMessageGetLocked(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_locked(message);
	}

	public static string GDbusMessageGetMember(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_member(message);
	}

	public static GDBusMessageType GDbusMessageGetMessageType(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_message_type(message);
	}

	public static uint GDbusMessageGetNumUnixFds(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_num_unix_fds(message);
	}

	public static string GDbusMessageGetPath(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_path(message);
	}

	public static uint GDbusMessageGetReplySerial(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_reply_serial(message);
	}

	public static string GDbusMessageGetSender(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_sender(message);
	}

	public static uint GDbusMessageGetSerial(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_serial(message);
	}

	public static string GDbusMessageGetSignature(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_signature(message);
	}

	public static GUnixFDListHandle GDbusMessageGetUnixFdList(this GDBusMessageHandle message)
	{
		return GDBusMessageExterns.g_dbus_message_get_unix_fd_list(message);
	}

	public static GDBusMessageHandle GDbusMessageLock(this GDBusMessageHandle message)
	{
		GDBusMessageExterns.g_dbus_message_lock(message);
		return message;
	}

	public static GDBusMessageHandle GDbusMessageNewMethodError(this GDBusMessageHandle method_call_message, string error_name, string error_message_format, IntPtr @__arglist)
	{
		return GDBusMessageExterns.g_dbus_message_new_method_error(method_call_message, error_name, error_message_format, @__arglist);
	}

	public static GDBusMessageHandle GDbusMessageNewMethodErrorLiteral(this GDBusMessageHandle method_call_message, string error_name, string error_message)
	{
		return GDBusMessageExterns.g_dbus_message_new_method_error_literal(method_call_message, error_name, error_message);
	}

	public static GDBusMessageHandle GDbusMessageNewMethodErrorValist(this GDBusMessageHandle method_call_message, string error_name, string error_message_format, IntPtr var_args)
	{
		return GDBusMessageExterns.g_dbus_message_new_method_error_valist(method_call_message, error_name, error_message_format, var_args);
	}

	public static GDBusMessageHandle GDbusMessageNewMethodReply(this GDBusMessageHandle method_call_message)
	{
		return GDBusMessageExterns.g_dbus_message_new_method_reply(method_call_message);
	}

	public static string GDbusMessagePrint(this GDBusMessageHandle message, uint indent)
	{
		return GDBusMessageExterns.g_dbus_message_print(message, indent);
	}

	public static GDBusMessageHandle GDbusMessageSetBody(this GDBusMessageHandle message, GVariantHandle body)
	{
		GDBusMessageExterns.g_dbus_message_set_body(message, body);
		return message;
	}

	public static GDBusMessageHandle GDbusMessageSetByteOrder(this GDBusMessageHandle message, GDBusMessageByteOrder byte_order)
	{
		GDBusMessageExterns.g_dbus_message_set_byte_order(message, byte_order);
		return message;
	}

	public static GDBusMessageHandle GDbusMessageSetDestination(this GDBusMessageHandle message, string value)
	{
		GDBusMessageExterns.g_dbus_message_set_destination(message, value);
		return message;
	}

	public static GDBusMessageHandle GDbusMessageSetErrorName(this GDBusMessageHandle message, string value)
	{
		GDBusMessageExterns.g_dbus_message_set_error_name(message, value);
		return message;
	}

	public static GDBusMessageHandle GDbusMessageSetFlags(this GDBusMessageHandle message, GDBusMessageFlags flags)
	{
		GDBusMessageExterns.g_dbus_message_set_flags(message, flags);
		return message;
	}

	public static GDBusMessageHandle GDbusMessageSetHeader(this GDBusMessageHandle message, GDBusMessageHeaderField header_field, GVariantHandle value)
	{
		GDBusMessageExterns.g_dbus_message_set_header(message, header_field, value);
		return message;
	}

	public static GDBusMessageHandle GDbusMessageSetInterface(this GDBusMessageHandle message, string value)
	{
		GDBusMessageExterns.g_dbus_message_set_interface(message, value);
		return message;
	}

	public static GDBusMessageHandle GDbusMessageSetMember(this GDBusMessageHandle message, string value)
	{
		GDBusMessageExterns.g_dbus_message_set_member(message, value);
		return message;
	}

	public static GDBusMessageHandle GDbusMessageSetMessageType(this GDBusMessageHandle message, GDBusMessageType type)
	{
		GDBusMessageExterns.g_dbus_message_set_message_type(message, type);
		return message;
	}

	public static GDBusMessageHandle GDbusMessageSetNumUnixFds(this GDBusMessageHandle message, uint value)
	{
		GDBusMessageExterns.g_dbus_message_set_num_unix_fds(message, value);
		return message;
	}

	public static GDBusMessageHandle GDbusMessageSetPath(this GDBusMessageHandle message, string value)
	{
		GDBusMessageExterns.g_dbus_message_set_path(message, value);
		return message;
	}

	public static GDBusMessageHandle GDbusMessageSetReplySerial(this GDBusMessageHandle message, uint value)
	{
		GDBusMessageExterns.g_dbus_message_set_reply_serial(message, value);
		return message;
	}

	public static GDBusMessageHandle GDbusMessageSetSender(this GDBusMessageHandle message, string value)
	{
		GDBusMessageExterns.g_dbus_message_set_sender(message, value);
		return message;
	}

	public static GDBusMessageHandle GDbusMessageSetSerial(this GDBusMessageHandle message, uint serial)
	{
		GDBusMessageExterns.g_dbus_message_set_serial(message, serial);
		return message;
	}

	public static GDBusMessageHandle GDbusMessageSetSignature(this GDBusMessageHandle message, string value)
	{
		GDBusMessageExterns.g_dbus_message_set_signature(message, value);
		return message;
	}

	public static GDBusMessageHandle GDbusMessageSetUnixFdList(this GDBusMessageHandle message, GUnixFDListHandle fd_list)
	{
		GDBusMessageExterns.g_dbus_message_set_unix_fd_list(message, fd_list);
		return message;
	}

	public static string GDbusMessageToBlob(this GDBusMessageHandle message, out int out_size, GDBusCapabilityFlags capabilities, out GErrorHandle error)
	{
		return GDBusMessageExterns.g_dbus_message_to_blob(message, out out_size, capabilities, out error);
	}

	public static bool GDbusMessageToGerror(this GDBusMessageHandle message, out GErrorHandle error)
	{
		return GDBusMessageExterns.g_dbus_message_to_gerror(message, out error);
	}

}

internal class GDBusMessageExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageHandle g_dbus_message_new();

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageHandle g_dbus_message_new_from_blob(string blob, int blob_len, GDBusCapabilityFlags capabilities, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageHandle g_dbus_message_new_method_call(string name, string path, string interface_, string method);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageHandle g_dbus_message_new_signal(string path, string interface_, string signal);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageHandle g_dbus_message_copy(GDBusMessageHandle message, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_message_get_arg0(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_message_get_arg0_path(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_dbus_message_get_body(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageByteOrder g_dbus_message_get_byte_order(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_message_get_destination(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_message_get_error_name(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageFlags g_dbus_message_get_flags(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_dbus_message_get_header(GDBusMessageHandle message, GDBusMessageHeaderField header_field);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_message_get_header_fields(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_message_get_interface(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_dbus_message_get_locked(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_message_get_member(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageType g_dbus_message_get_message_type(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern uint g_dbus_message_get_num_unix_fds(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_message_get_path(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern uint g_dbus_message_get_reply_serial(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_message_get_sender(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern uint g_dbus_message_get_serial(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_message_get_signature(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern GUnixFDListHandle g_dbus_message_get_unix_fd_list(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_lock(GDBusMessageHandle message);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageHandle g_dbus_message_new_method_error(GDBusMessageHandle method_call_message, string error_name, string error_message_format, IntPtr @__arglist);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageHandle g_dbus_message_new_method_error_literal(GDBusMessageHandle method_call_message, string error_name, string error_message);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageHandle g_dbus_message_new_method_error_valist(GDBusMessageHandle method_call_message, string error_name, string error_message_format, IntPtr var_args);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageHandle g_dbus_message_new_method_reply(GDBusMessageHandle method_call_message);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_message_print(GDBusMessageHandle message, uint indent);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_body(GDBusMessageHandle message, GVariantHandle body);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_byte_order(GDBusMessageHandle message, GDBusMessageByteOrder byte_order);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_destination(GDBusMessageHandle message, string value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_error_name(GDBusMessageHandle message, string value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_flags(GDBusMessageHandle message, GDBusMessageFlags flags);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_header(GDBusMessageHandle message, GDBusMessageHeaderField header_field, GVariantHandle value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_interface(GDBusMessageHandle message, string value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_member(GDBusMessageHandle message, string value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_message_type(GDBusMessageHandle message, GDBusMessageType type);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_num_unix_fds(GDBusMessageHandle message, uint value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_path(GDBusMessageHandle message, string value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_reply_serial(GDBusMessageHandle message, uint value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_sender(GDBusMessageHandle message, string value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_serial(GDBusMessageHandle message, uint serial);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_signature(GDBusMessageHandle message, string value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_message_set_unix_fd_list(GDBusMessageHandle message, GUnixFDListHandle fd_list);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_message_to_blob(GDBusMessageHandle message, out int out_size, GDBusCapabilityFlags capabilities, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_dbus_message_to_gerror(GDBusMessageHandle message, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern int g_dbus_message_bytes_needed(string blob, int blob_len, out GErrorHandle error);

}
