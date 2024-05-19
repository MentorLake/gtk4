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

namespace MentorLake.Gtk4.Gsk4;

public enum GskGLUniformType
{
	GSK_GL_UNIFORM_TYPE_NONE,
	GSK_GL_UNIFORM_TYPE_FLOAT,
	GSK_GL_UNIFORM_TYPE_INT,
	GSK_GL_UNIFORM_TYPE_UINT,
	GSK_GL_UNIFORM_TYPE_BOOL,
	GSK_GL_UNIFORM_TYPE_VEC2,
	GSK_GL_UNIFORM_TYPE_VEC3,
	GSK_GL_UNIFORM_TYPE_VEC4
}
