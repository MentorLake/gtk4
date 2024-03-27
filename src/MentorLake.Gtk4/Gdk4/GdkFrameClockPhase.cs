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

namespace MentorLake.Gtk4.Gdk4;

[Flags]
public enum GdkFrameClockPhase
{
	GDK_FRAME_CLOCK_PHASE_NONE = 0,
	GDK_FRAME_CLOCK_PHASE_FLUSH_EVENTS = 1,
	GDK_FRAME_CLOCK_PHASE_BEFORE_PAINT = 2,
	GDK_FRAME_CLOCK_PHASE_UPDATE = 4,
	GDK_FRAME_CLOCK_PHASE_LAYOUT = 8,
	GDK_FRAME_CLOCK_PHASE_PAINT = 16,
	GDK_FRAME_CLOCK_PHASE_RESUME_EVENTS = 32,
	GDK_FRAME_CLOCK_PHASE_AFTER_PAINT = 64
}
