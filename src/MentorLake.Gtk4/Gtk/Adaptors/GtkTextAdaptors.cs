using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTextAdaptors
{
	public static GtkEntryBufferHandle GetBuffer(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_buffer(self);
	}

	public static GtkTextHandle SetBuffer(this GtkTextHandle self, GtkEntryBufferHandle buffer)
	{
		GtkTextExterns.gtk_text_set_buffer(self, buffer);
		return self;
	}

	public static GtkTextHandle SetVisibility(this GtkTextHandle self, int visible)
	{
		GtkTextExterns.gtk_text_set_visibility(self, visible);
		return self;
	}

	public static int GetVisibility(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_visibility(self);
	}

	public static GtkTextHandle SetInvisibleChar(this GtkTextHandle self, uint ch)
	{
		GtkTextExterns.gtk_text_set_invisible_char(self, ch);
		return self;
	}

	public static uint GetInvisibleChar(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_invisible_char(self);
	}

	public static GtkTextHandle UnsetInvisibleChar(this GtkTextHandle self)
	{
		GtkTextExterns.gtk_text_unset_invisible_char(self);
		return self;
	}

	public static GtkTextHandle SetOverwriteMode(this GtkTextHandle self, int overwrite)
	{
		GtkTextExterns.gtk_text_set_overwrite_mode(self, overwrite);
		return self;
	}

	public static int GetOverwriteMode(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_overwrite_mode(self);
	}

	public static GtkTextHandle SetMaxLength(this GtkTextHandle self, int length)
	{
		GtkTextExterns.gtk_text_set_max_length(self, length);
		return self;
	}

	public static int GetMaxLength(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_max_length(self);
	}

	public static ushort GetTextLength(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_text_length(self);
	}

	public static GtkTextHandle SetActivatesDefault(this GtkTextHandle self, int activates)
	{
		GtkTextExterns.gtk_text_set_activates_default(self, activates);
		return self;
	}

	public static int GetActivatesDefault(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_activates_default(self);
	}

	public static string GetPlaceholderText(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_placeholder_text(self);
	}

	public static GtkTextHandle SetPlaceholderText(this GtkTextHandle self, string text)
	{
		GtkTextExterns.gtk_text_set_placeholder_text(self, text);
		return self;
	}

	public static GtkTextHandle SetInputPurpose(this GtkTextHandle self, GtkInputPurpose purpose)
	{
		GtkTextExterns.gtk_text_set_input_purpose(self, purpose);
		return self;
	}

	public static GtkInputPurpose GetInputPurpose(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_input_purpose(self);
	}

	public static GtkTextHandle SetInputHints(this GtkTextHandle self, GtkInputHints hints)
	{
		GtkTextExterns.gtk_text_set_input_hints(self, hints);
		return self;
	}

	public static GtkInputHints GetInputHints(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_input_hints(self);
	}

	public static GtkTextHandle SetAttributes(this GtkTextHandle self, PangoAttrListHandle attrs)
	{
		GtkTextExterns.gtk_text_set_attributes(self, attrs);
		return self;
	}

	public static PangoAttrListHandle GetAttributes(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_attributes(self);
	}

	public static GtkTextHandle SetTabs(this GtkTextHandle self, PangoTabArrayHandle tabs)
	{
		GtkTextExterns.gtk_text_set_tabs(self, tabs);
		return self;
	}

	public static PangoTabArrayHandle GetTabs(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_tabs(self);
	}

	public static int GrabFocusWithoutSelecting(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_grab_focus_without_selecting(self);
	}

	public static GtkTextHandle SetExtraMenu(this GtkTextHandle self, GMenuModelHandle model)
	{
		GtkTextExterns.gtk_text_set_extra_menu(self, model);
		return self;
	}

	public static GMenuModelHandle GetExtraMenu(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_extra_menu(self);
	}

	public static GtkTextHandle SetEnableEmojiCompletion(this GtkTextHandle self, int enable_emoji_completion)
	{
		GtkTextExterns.gtk_text_set_enable_emoji_completion(self, enable_emoji_completion);
		return self;
	}

	public static int GetEnableEmojiCompletion(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_enable_emoji_completion(self);
	}

	public static GtkTextHandle SetPropagateTextWidth(this GtkTextHandle self, int propagate_text_width)
	{
		GtkTextExterns.gtk_text_set_propagate_text_width(self, propagate_text_width);
		return self;
	}

	public static int GetPropagateTextWidth(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_propagate_text_width(self);
	}

	public static GtkTextHandle SetTruncateMultiline(this GtkTextHandle self, int truncate_multiline)
	{
		GtkTextExterns.gtk_text_set_truncate_multiline(self, truncate_multiline);
		return self;
	}

	public static int GetTruncateMultiline(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_truncate_multiline(self);
	}

	public static GtkTextHandle ComputeCursorExtents(this GtkTextHandle self, nuint position, graphene_rect_tHandle strong, graphene_rect_tHandle weak)
	{
		GtkTextExterns.gtk_text_compute_cursor_extents(self, position, strong, weak);
		return self;
	}
}
