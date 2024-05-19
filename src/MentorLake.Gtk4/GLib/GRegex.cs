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

public class GRegexHandle : BaseSafeHandle
{
	public static GRegexHandle New(string pattern, GRegexCompileFlags compile_options, GRegexMatchFlags match_options, out GErrorHandle error)
	{
		return GRegexExterns.g_regex_new(pattern, compile_options, match_options, out error);
	}

}

internal class GRegexExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GRegexHandle g_regex_new(string pattern, GRegexCompileFlags compile_options, GRegexMatchFlags match_options, out GErrorHandle error);

}

public struct GRegex
{
}
