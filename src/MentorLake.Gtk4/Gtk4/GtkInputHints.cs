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

namespace MentorLake.Gtk4.Gtk4;

[Flags]
public enum GtkInputHints
{
	GTK_INPUT_HINT_NONE = 0,
	GTK_INPUT_HINT_SPELLCHECK = 1,
	GTK_INPUT_HINT_NO_SPELLCHECK = 2,
	GTK_INPUT_HINT_WORD_COMPLETION = 4,
	GTK_INPUT_HINT_LOWERCASE = 8,
	GTK_INPUT_HINT_UPPERCASE_CHARS = 16,
	GTK_INPUT_HINT_UPPERCASE_WORDS = 32,
	GTK_INPUT_HINT_UPPERCASE_SENTENCES = 64,
	GTK_INPUT_HINT_INHIBIT_OSK = 128,
	GTK_INPUT_HINT_VERTICAL_WRITING = 256,
	GTK_INPUT_HINT_EMOJI = 512,
	GTK_INPUT_HINT_NO_EMOJI = 1024,
	GTK_INPUT_HINT_PRIVATE = 2048
}
