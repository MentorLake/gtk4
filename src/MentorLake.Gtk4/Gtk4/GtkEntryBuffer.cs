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

namespace MentorLake.Gtk4.Gtk4;

public class GtkEntryBufferHandle : GObjectHandle
{
	public static GtkEntryBufferHandle New(string initial_chars, int n_initial_chars)
	{
		return GtkEntryBufferExterns.gtk_entry_buffer_new(initial_chars, n_initial_chars);
	}
}

public class GtkEntryBufferSignal
{
	public string Value { get; set; }
	public GtkEntryBufferSignal(string value) => Value = value;
}

public static class GtkEntryBufferSignals
{
	public static GtkEntryBufferSignal DeletedText = new("deleted-text");
	public static GtkEntryBufferSignal InsertedText = new("inserted-text");
}

public static class GtkEntryBufferHandleExtensions
{
	public static uint DeleteText(this GtkEntryBufferHandle buffer, uint position, int n_chars)
	{
		return GtkEntryBufferExterns.gtk_entry_buffer_delete_text(buffer, position, n_chars);
	}

	public static GtkEntryBufferHandle EmitDeletedText(this GtkEntryBufferHandle buffer, uint position, uint n_chars)
	{
		GtkEntryBufferExterns.gtk_entry_buffer_emit_deleted_text(buffer, position, n_chars);
		return buffer;
	}

	public static GtkEntryBufferHandle EmitInsertedText(this GtkEntryBufferHandle buffer, uint position, string chars, uint n_chars)
	{
		GtkEntryBufferExterns.gtk_entry_buffer_emit_inserted_text(buffer, position, chars, n_chars);
		return buffer;
	}

	public static int GetBytes(this GtkEntryBufferHandle buffer)
	{
		return GtkEntryBufferExterns.gtk_entry_buffer_get_bytes(buffer);
	}

	public static uint GetLength(this GtkEntryBufferHandle buffer)
	{
		return GtkEntryBufferExterns.gtk_entry_buffer_get_length(buffer);
	}

	public static int GetMaxLength(this GtkEntryBufferHandle buffer)
	{
		return GtkEntryBufferExterns.gtk_entry_buffer_get_max_length(buffer);
	}

	public static string GetText(this GtkEntryBufferHandle buffer)
	{
		return GtkEntryBufferExterns.gtk_entry_buffer_get_text(buffer);
	}

	public static uint InsertText(this GtkEntryBufferHandle buffer, uint position, string chars, int n_chars)
	{
		return GtkEntryBufferExterns.gtk_entry_buffer_insert_text(buffer, position, chars, n_chars);
	}

	public static GtkEntryBufferHandle SetMaxLength(this GtkEntryBufferHandle buffer, int max_length)
	{
		GtkEntryBufferExterns.gtk_entry_buffer_set_max_length(buffer, max_length);
		return buffer;
	}

	public static GtkEntryBufferHandle SetText(this GtkEntryBufferHandle buffer, string chars, int n_chars)
	{
		GtkEntryBufferExterns.gtk_entry_buffer_set_text(buffer, chars, n_chars);
		return buffer;
	}

	public static GtkEntryBufferHandle Connect(this GtkEntryBufferHandle instance, GtkEntryBufferSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkEntryBufferExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_entry_buffer_delete_text(GtkEntryBufferHandle buffer, uint position, int n_chars);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_buffer_emit_deleted_text(GtkEntryBufferHandle buffer, uint position, uint n_chars);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_buffer_emit_inserted_text(GtkEntryBufferHandle buffer, uint position, string chars, uint n_chars);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_entry_buffer_get_bytes(GtkEntryBufferHandle buffer);
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_entry_buffer_get_length(GtkEntryBufferHandle buffer);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_entry_buffer_get_max_length(GtkEntryBufferHandle buffer);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_entry_buffer_get_text(GtkEntryBufferHandle buffer);
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_entry_buffer_insert_text(GtkEntryBufferHandle buffer, uint position, string chars, int n_chars);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_buffer_set_max_length(GtkEntryBufferHandle buffer, int max_length);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_buffer_set_text(GtkEntryBufferHandle buffer, string chars, int n_chars);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEntryBufferHandle gtk_entry_buffer_new(string initial_chars, int n_initial_chars);
}
