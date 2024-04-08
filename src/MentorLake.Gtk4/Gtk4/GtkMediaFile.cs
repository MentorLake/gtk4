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

public class GtkMediaFileHandle : GtkMediaStreamHandle, GdkPaintableHandle
{
	public static GtkMediaFileHandle New()
	{
		return GtkMediaFileExterns.gtk_media_file_new();
	}

	public static GtkMediaFileHandle NewForFile(GFileHandle file)
	{
		return GtkMediaFileExterns.gtk_media_file_new_for_file(file);
	}

	public static GtkMediaFileHandle NewForFilename(string filename)
	{
		return GtkMediaFileExterns.gtk_media_file_new_for_filename(filename);
	}

	public static GtkMediaFileHandle NewForInputStream(GInputStreamHandle stream)
	{
		return GtkMediaFileExterns.gtk_media_file_new_for_input_stream(stream);
	}

	public static GtkMediaFileHandle NewForResource(string resource_path)
	{
		return GtkMediaFileExterns.gtk_media_file_new_for_resource(resource_path);
	}

}

public static class GtkMediaFileHandleExtensions
{
	public static GtkMediaFileHandle Clear(this GtkMediaFileHandle self)
	{
		GtkMediaFileExterns.gtk_media_file_clear(self);
		return self;
	}

	public static GFileHandle GetFile(this GtkMediaFileHandle self)
	{
		return GtkMediaFileExterns.gtk_media_file_get_file(self);
	}

	public static GInputStreamHandle GetInputStream(this GtkMediaFileHandle self)
	{
		return GtkMediaFileExterns.gtk_media_file_get_input_stream(self);
	}

	public static GtkMediaFileHandle SetFile(this GtkMediaFileHandle self, GFileHandle file)
	{
		GtkMediaFileExterns.gtk_media_file_set_file(self, file);
		return self;
	}

	public static GtkMediaFileHandle SetFilename(this GtkMediaFileHandle self, string filename)
	{
		GtkMediaFileExterns.gtk_media_file_set_filename(self, filename);
		return self;
	}

	public static GtkMediaFileHandle SetInputStream(this GtkMediaFileHandle self, GInputStreamHandle stream)
	{
		GtkMediaFileExterns.gtk_media_file_set_input_stream(self, stream);
		return self;
	}

	public static GtkMediaFileHandle SetResource(this GtkMediaFileHandle self, string resource_path)
	{
		GtkMediaFileExterns.gtk_media_file_set_resource(self, resource_path);
		return self;
	}

}

internal class GtkMediaFileExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkMediaFileHandle gtk_media_file_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkMediaFileHandle gtk_media_file_new_for_file(GFileHandle file);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkMediaFileHandle gtk_media_file_new_for_filename(string filename);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkMediaFileHandle gtk_media_file_new_for_input_stream(GInputStreamHandle stream);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkMediaFileHandle gtk_media_file_new_for_resource(string resource_path);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_file_clear(GtkMediaFileHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GFileHandle gtk_media_file_get_file(GtkMediaFileHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GInputStreamHandle gtk_media_file_get_input_stream(GtkMediaFileHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_file_set_file(GtkMediaFileHandle self, GFileHandle file);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_file_set_filename(GtkMediaFileHandle self, string filename);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_file_set_input_stream(GtkMediaFileHandle self, GInputStreamHandle stream);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_file_set_resource(GtkMediaFileHandle self, string resource_path);
}
