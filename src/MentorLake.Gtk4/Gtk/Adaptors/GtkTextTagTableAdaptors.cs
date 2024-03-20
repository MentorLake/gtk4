using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTextTagTableAdaptors
{
	public static int Add(this GtkTextTagTableHandle table, GtkTextTagHandle tag)
	{
		return GtkTextTagTableExterns.gtk_text_tag_table_add(table, tag);
	}

	public static GtkTextTagTableHandle Remove(this GtkTextTagTableHandle table, GtkTextTagHandle tag)
	{
		GtkTextTagTableExterns.gtk_text_tag_table_remove(table, tag);
		return table;
	}

	public static GtkTextTagHandle Lookup(this GtkTextTagTableHandle table, string name)
	{
		return GtkTextTagTableExterns.gtk_text_tag_table_lookup(table, name);
	}

	public static GtkTextTagTableHandle Foreach(this GtkTextTagTableHandle table, GtkTextTagTableForeach func, IntPtr data)
	{
		GtkTextTagTableExterns.gtk_text_tag_table_foreach(table, func, data);
		return table;
	}

	public static int GetSize(this GtkTextTagTableHandle table)
	{
		return GtkTextTagTableExterns.gtk_text_tag_table_get_size(table);
	}

	public static GtkTextBufferHandle GtkTextBufferNew(this GtkTextTagTableHandle table)
	{
		return GtkTextTagTableExterns.gtk_text_buffer_new(table);
	}
}
