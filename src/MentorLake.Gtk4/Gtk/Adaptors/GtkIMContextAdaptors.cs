using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;
public static class GtkIMContextAdaptors
{
	public static GtkIMContextHandle GtkImContextSetClientWidget(this GtkIMContextHandle context, GtkWidgetHandle widget)
	{
		GtkIMContextExterns.gtk_im_context_set_client_widget(context, widget);
		return context;
	}

	public static GtkIMContextHandle GtkImContextGetPreeditString(this GtkIMContextHandle context, string[] str, out PangoAttrListHandle attrs, out int cursor_pos)
	{
		GtkIMContextExterns.gtk_im_context_get_preedit_string(context, str, out attrs, out cursor_pos);
		return context;
	}

	public static int GtkImContextFilterKeypress(this GtkIMContextHandle context, GdkEventHandle @event)
	{
		return GtkIMContextExterns.gtk_im_context_filter_keypress(context, @event);
	}

	public static int GtkImContextFilterKey(this GtkIMContextHandle context, int press, GdkSurfaceHandle surface, GdkDeviceHandle device, uint time, uint keycode, GdkModifierType state, int group)
	{
		return GtkIMContextExterns.gtk_im_context_filter_key(context, press, surface, device, time, keycode, state, group);
	}

	public static GtkIMContextHandle GtkImContextFocusIn(this GtkIMContextHandle context)
	{
		GtkIMContextExterns.gtk_im_context_focus_in(context);
		return context;
	}

	public static GtkIMContextHandle GtkImContextFocusOut(this GtkIMContextHandle context)
	{
		GtkIMContextExterns.gtk_im_context_focus_out(context);
		return context;
	}

	public static GtkIMContextHandle GtkImContextReset(this GtkIMContextHandle context)
	{
		GtkIMContextExterns.gtk_im_context_reset(context);
		return context;
	}

	public static GtkIMContextHandle GtkImContextSetCursorLocation(this GtkIMContextHandle context, GdkRectangleHandle area)
	{
		GtkIMContextExterns.gtk_im_context_set_cursor_location(context, area);
		return context;
	}

	public static GtkIMContextHandle GtkImContextSetUsePreedit(this GtkIMContextHandle context, int use_preedit)
	{
		GtkIMContextExterns.gtk_im_context_set_use_preedit(context, use_preedit);
		return context;
	}

	public static GtkIMContextHandle GtkImContextSetSurrounding(this GtkIMContextHandle context, string text, int len, int cursor_index)
	{
		GtkIMContextExterns.gtk_im_context_set_surrounding(context, text, len, cursor_index);
		return context;
	}

	public static int GtkImContextGetSurrounding(this GtkIMContextHandle context, string[] text, out int cursor_index)
	{
		return GtkIMContextExterns.gtk_im_context_get_surrounding(context, text, out cursor_index);
	}

	public static GtkIMContextHandle GtkImContextSetSurroundingWithSelection(this GtkIMContextHandle context, string text, int len, int cursor_index, int anchor_index)
	{
		GtkIMContextExterns.gtk_im_context_set_surrounding_with_selection(context, text, len, cursor_index, anchor_index);
		return context;
	}

	public static int GtkImContextGetSurroundingWithSelection(this GtkIMContextHandle context, string[] text, out int cursor_index, out int anchor_index)
	{
		return GtkIMContextExterns.gtk_im_context_get_surrounding_with_selection(context, text, out cursor_index, out anchor_index);
	}

	public static int GtkImContextDeleteSurrounding(this GtkIMContextHandle context, int offset, int n_chars)
	{
		return GtkIMContextExterns.gtk_im_context_delete_surrounding(context, offset, n_chars);
	}

	public static GtkIMContextHandle GtkImMulticontextNew()
	{
		return GtkIMContextExterns.gtk_im_multicontext_new();
	}
}
