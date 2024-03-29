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

namespace MentorLake.Gtk4.Gtk4;

public class GtkIMMulticontextHandle : GtkIMContextHandle
{
	public static GtkIMMulticontextHandle GtkImMulticontextNew()
	{
		return GtkIMMulticontextExterns.gtk_im_multicontext_new();
	}

}

public static class GtkIMMulticontextHandleExtensions
{
	public static string GtkImMulticontextGetContextId(this GtkIMMulticontextHandle context)
	{
		return GtkIMMulticontextExterns.gtk_im_multicontext_get_context_id(context);
	}

	public static GtkIMMulticontextHandle GtkImMulticontextSetContextId(this GtkIMMulticontextHandle context, string context_id)
	{
		GtkIMMulticontextExterns.gtk_im_multicontext_set_context_id(context, context_id);
		return context;
	}

}

internal class GtkIMMulticontextExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkIMMulticontextHandle gtk_im_multicontext_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_im_multicontext_get_context_id(GtkIMMulticontextHandle context);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_im_multicontext_set_context_id(GtkIMMulticontextHandle context, string context_id);
}
