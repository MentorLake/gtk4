using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkMediaFileAdaptors
{
    public static GtkMediaFileHandle Clear(this GtkMediaFileHandle self)
    {
        GtkMediaFileExterns.gtk_media_file_clear(self);
        return self;
    }

    public static GtkMediaFileHandle SetFilename(this GtkMediaFileHandle self, string filename)
    {
        GtkMediaFileExterns.gtk_media_file_set_filename(self, filename);
        return self;
    }

    public static GtkMediaFileHandle SetResource(this GtkMediaFileHandle self, string resource_path)
    {
        GtkMediaFileExterns.gtk_media_file_set_resource(self, resource_path);
        return self;
    }

    public static GtkMediaFileHandle SetFile(this GtkMediaFileHandle self, GFileHandle file)
    {
        GtkMediaFileExterns.gtk_media_file_set_file(self, file);
        return self;
    }

    public static GFileHandle GetFile(this GtkMediaFileHandle self)
    {
        return GtkMediaFileExterns.gtk_media_file_get_file(self);
    }

    public static GtkMediaFileHandle SetInputStream(this GtkMediaFileHandle self, GInputStreamHandle stream)
    {
        GtkMediaFileExterns.gtk_media_file_set_input_stream(self, stream);
        return self;
    }

    public static GInputStreamHandle GetInputStream(this GtkMediaFileHandle self)
    {
        return GtkMediaFileExterns.gtk_media_file_get_input_stream(self);
    }
}
