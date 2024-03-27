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

namespace MentorLake.Gtk4.GdkPixbuf;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GdkPixbufModuleBeginLoadFunc(GdkPixbufModuleSizeFunc size_func, GdkPixbufModulePreparedFunc prepared_func, GdkPixbufModuleUpdatedFunc updated_func, IntPtr user_data, out GErrorHandle error);
