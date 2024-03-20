using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkEntryBufferAdaptors
{
	public static nuint GetBytes(this GtkEntryBufferHandle buffer)
	{
		return GtkEntryBufferExterns.gtk_entry_buffer_get_bytes(buffer);
	}

	public static uint GetLength(this GtkEntryBufferHandle buffer)
	{
		return GtkEntryBufferExterns.gtk_entry_buffer_get_length(buffer);
	}

	public static string GetText(this GtkEntryBufferHandle buffer)
	{
		return GtkEntryBufferExterns.gtk_entry_buffer_get_text(buffer);
	}

	public static GtkEntryBufferHandle SetText(this GtkEntryBufferHandle buffer, string chars, int n_chars)
	{
		GtkEntryBufferExterns.gtk_entry_buffer_set_text(buffer, chars, n_chars);
		return buffer;
	}

	public static GtkEntryBufferHandle SetMaxLength(this GtkEntryBufferHandle buffer, int max_length)
	{
		GtkEntryBufferExterns.gtk_entry_buffer_set_max_length(buffer, max_length);
		return buffer;
	}

	public static int GetMaxLength(this GtkEntryBufferHandle buffer)
	{
		return GtkEntryBufferExterns.gtk_entry_buffer_get_max_length(buffer);
	}

	public static uint InsertText(this GtkEntryBufferHandle buffer, uint position, string chars, int n_chars)
	{
		return GtkEntryBufferExterns.gtk_entry_buffer_insert_text(buffer, position, chars, n_chars);
	}

	public static uint DeleteText(this GtkEntryBufferHandle buffer, uint position, int n_chars)
	{
		return GtkEntryBufferExterns.gtk_entry_buffer_delete_text(buffer, position, n_chars);
	}

	public static GtkEntryBufferHandle EmitInsertedText(this GtkEntryBufferHandle buffer, uint position, string chars, uint n_chars)
	{
		GtkEntryBufferExterns.gtk_entry_buffer_emit_inserted_text(buffer, position, chars, n_chars);
		return buffer;
	}

	public static GtkEntryBufferHandle EmitDeletedText(this GtkEntryBufferHandle buffer, uint position, uint n_chars)
	{
		GtkEntryBufferExterns.gtk_entry_buffer_emit_deleted_text(buffer, position, n_chars);
		return buffer;
	}

	public static GtkEntryHandle GtkEntryNewWithBuffer(this GtkEntryBufferHandle buffer)
	{
		return GtkEntryBufferExterns.gtk_entry_new_with_buffer(buffer);
	}

	public static GtkTextHandle GtkTextNewWithBuffer(this GtkEntryBufferHandle buffer)
	{
		return GtkEntryBufferExterns.gtk_text_new_with_buffer(buffer);
	}

	public static GtkEntryBufferHandle GtkPasswordEntryBufferNew()
	{
		return GtkEntryBufferExterns.gtk_password_entry_buffer_new();
	}
}
