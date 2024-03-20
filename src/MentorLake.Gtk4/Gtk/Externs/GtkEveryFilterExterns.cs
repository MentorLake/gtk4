using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GtkEveryFilterExterns
{
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkEveryFilterHandle gtk_every_filter_new();
}
