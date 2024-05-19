using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.GLib;

public enum GDateMonth
{
	G_DATE_BAD_MONTH,
	G_DATE_JANUARY,
	G_DATE_FEBRUARY,
	G_DATE_MARCH,
	G_DATE_APRIL,
	G_DATE_MAY,
	G_DATE_JUNE,
	G_DATE_JULY,
	G_DATE_AUGUST,
	G_DATE_SEPTEMBER,
	G_DATE_OCTOBER,
	G_DATE_NOVEMBER,
	G_DATE_DECEMBER
}
