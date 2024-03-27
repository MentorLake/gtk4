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

[Flags]
public enum GFileCopyFlags
{
	G_FILE_COPY_NONE = 0,
	G_FILE_COPY_OVERWRITE = 1,
	G_FILE_COPY_BACKUP = 2,
	G_FILE_COPY_NOFOLLOW_SYMLINKS = 4,
	G_FILE_COPY_ALL_METADATA = 8,
	G_FILE_COPY_NO_FALLBACK_FOR_MOVE = 16,
	G_FILE_COPY_TARGET_DEFAULT_PERMS = 32,
	G_FILE_COPY_TARGET_DEFAULT_MODIFIED_TIME = 64
}
