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

namespace MentorLake.Gtk4.GLib;

public enum GTestLogType
{
	G_TEST_LOG_NONE,
	G_TEST_LOG_ERROR,
	G_TEST_LOG_START_BINARY,
	G_TEST_LOG_LIST_CASE,
	G_TEST_LOG_SKIP_CASE,
	G_TEST_LOG_START_CASE,
	G_TEST_LOG_STOP_CASE,
	G_TEST_LOG_MIN_RESULT,
	G_TEST_LOG_MAX_RESULT,
	G_TEST_LOG_MESSAGE,
	G_TEST_LOG_START_SUITE,
	G_TEST_LOG_STOP_SUITE
}
