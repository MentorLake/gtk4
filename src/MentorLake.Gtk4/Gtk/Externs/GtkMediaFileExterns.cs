using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;

public static class GtkMediaFileExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_media_file_clear")]
	internal static extern void gtk_media_file_clear(this GtkMediaFileHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_media_file_set_filename")]
	internal static extern void gtk_media_file_set_filename(this GtkMediaFileHandle self, string filename);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_media_file_set_resource")]
	internal static extern void gtk_media_file_set_resource(this GtkMediaFileHandle self, string resource_path);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_media_file_set_file")]
	internal static extern void gtk_media_file_set_file(this GtkMediaFileHandle self, GFileHandle file);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_media_file_get_file")]
	internal static extern GFileHandle gtk_media_file_get_file(this GtkMediaFileHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_media_file_set_input_stream")]
	internal static extern void gtk_media_file_set_input_stream(this GtkMediaFileHandle self, GInputStreamHandle stream);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_media_file_get_input_stream")]
	internal static extern GInputStreamHandle gtk_media_file_get_input_stream(this GtkMediaFileHandle self);
}
