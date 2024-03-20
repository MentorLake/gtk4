using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;
public static class GtkEntryAdaptors
{
	public static GtkEntryBufferHandle GetBuffer(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_buffer(entry);
	}

	public static GtkEntryHandle SetBuffer(this GtkEntryHandle entry, GtkEntryBufferHandle buffer)
	{
		GtkEntryExterns.gtk_entry_set_buffer(entry, buffer);
		return entry;
	}

	public static GtkEntryHandle SetVisibility(this GtkEntryHandle entry, int visible)
	{
		GtkEntryExterns.gtk_entry_set_visibility(entry, visible);
		return entry;
	}

	public static int GetVisibility(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_visibility(entry);
	}

	public static GtkEntryHandle SetInvisibleChar(this GtkEntryHandle entry, uint ch)
	{
		GtkEntryExterns.gtk_entry_set_invisible_char(entry, ch);
		return entry;
	}

	public static uint GetInvisibleChar(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_invisible_char(entry);
	}

	public static GtkEntryHandle UnsetInvisibleChar(this GtkEntryHandle entry)
	{
		GtkEntryExterns.gtk_entry_unset_invisible_char(entry);
		return entry;
	}

	public static GtkEntryHandle SetHasFrame(this GtkEntryHandle entry, int setting)
	{
		GtkEntryExterns.gtk_entry_set_has_frame(entry, setting);
		return entry;
	}

	public static int GetHasFrame(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_has_frame(entry);
	}

	public static GtkEntryHandle SetOverwriteMode(this GtkEntryHandle entry, int overwrite)
	{
		GtkEntryExterns.gtk_entry_set_overwrite_mode(entry, overwrite);
		return entry;
	}

	public static int GetOverwriteMode(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_overwrite_mode(entry);
	}

	public static GtkEntryHandle SetMaxLength(this GtkEntryHandle entry, int max)
	{
		GtkEntryExterns.gtk_entry_set_max_length(entry, max);
		return entry;
	}

	public static int GetMaxLength(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_max_length(entry);
	}

	public static ushort GetTextLength(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_text_length(entry);
	}

	public static GtkEntryHandle SetActivatesDefault(this GtkEntryHandle entry, int setting)
	{
		GtkEntryExterns.gtk_entry_set_activates_default(entry, setting);
		return entry;
	}

	public static int GetActivatesDefault(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_activates_default(entry);
	}

	public static GtkEntryHandle SetAlignment(this GtkEntryHandle entry, float xalign)
	{
		GtkEntryExterns.gtk_entry_set_alignment(entry, xalign);
		return entry;
	}

	public static float GetAlignment(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_alignment(entry);
	}

	public static GtkEntryHandle SetCompletion(this GtkEntryHandle entry, GtkEntryCompletionHandle completion)
	{
		GtkEntryExterns.gtk_entry_set_completion(entry, completion);
		return entry;
	}

	public static GtkEntryCompletionHandle GetCompletion(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_completion(entry);
	}

	public static GtkEntryHandle SetProgressFraction(this GtkEntryHandle entry, double fraction)
	{
		GtkEntryExterns.gtk_entry_set_progress_fraction(entry, fraction);
		return entry;
	}

	public static double GetProgressFraction(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_progress_fraction(entry);
	}

	public static GtkEntryHandle SetProgressPulseStep(this GtkEntryHandle entry, double fraction)
	{
		GtkEntryExterns.gtk_entry_set_progress_pulse_step(entry, fraction);
		return entry;
	}

	public static double GetProgressPulseStep(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_progress_pulse_step(entry);
	}

	public static GtkEntryHandle ProgressPulse(this GtkEntryHandle entry)
	{
		GtkEntryExterns.gtk_entry_progress_pulse(entry);
		return entry;
	}

	public static string GetPlaceholderText(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_placeholder_text(entry);
	}

	public static GtkEntryHandle SetPlaceholderText(this GtkEntryHandle entry, string text)
	{
		GtkEntryExterns.gtk_entry_set_placeholder_text(entry, text);
		return entry;
	}

	public static GtkEntryHandle SetIconFromPaintable(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, GdkPaintableHandle paintable)
	{
		GtkEntryExterns.gtk_entry_set_icon_from_paintable(entry, icon_pos, paintable);
		return entry;
	}

	public static GtkEntryHandle SetIconFromIconName(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, string icon_name)
	{
		GtkEntryExterns.gtk_entry_set_icon_from_icon_name(entry, icon_pos, icon_name);
		return entry;
	}

	public static GtkEntryHandle SetIconFromGicon(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, GIconHandle icon)
	{
		GtkEntryExterns.gtk_entry_set_icon_from_gicon(entry, icon_pos, icon);
		return entry;
	}

	public static GtkImageType GetIconStorageType(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_storage_type(entry, icon_pos);
	}

	public static GdkPaintableHandle GetIconPaintable(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_paintable(entry, icon_pos);
	}

	public static string GetIconName(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_name(entry, icon_pos);
	}

	public static GIconHandle GetIconGicon(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_gicon(entry, icon_pos);
	}

	public static GtkEntryHandle SetIconActivatable(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, int activatable)
	{
		GtkEntryExterns.gtk_entry_set_icon_activatable(entry, icon_pos, activatable);
		return entry;
	}

	public static int GetIconActivatable(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_activatable(entry, icon_pos);
	}

	public static GtkEntryHandle SetIconSensitive(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, int sensitive)
	{
		GtkEntryExterns.gtk_entry_set_icon_sensitive(entry, icon_pos, sensitive);
		return entry;
	}

	public static int GetIconSensitive(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_sensitive(entry, icon_pos);
	}

	public static int GetIconAtPos(this GtkEntryHandle entry, int x, int y)
	{
		return GtkEntryExterns.gtk_entry_get_icon_at_pos(entry, x, y);
	}

	public static GtkEntryHandle SetIconTooltipText(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, string tooltip)
	{
		GtkEntryExterns.gtk_entry_set_icon_tooltip_text(entry, icon_pos, tooltip);
		return entry;
	}

	public static string GetIconTooltipText(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_tooltip_text(entry, icon_pos);
	}

	public static GtkEntryHandle SetIconTooltipMarkup(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, string tooltip)
	{
		GtkEntryExterns.gtk_entry_set_icon_tooltip_markup(entry, icon_pos, tooltip);
		return entry;
	}

	public static string GetIconTooltipMarkup(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_tooltip_markup(entry, icon_pos);
	}

	public static GtkEntryHandle SetIconDragSource(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, GdkContentProviderHandle provider, GdkDragAction actions)
	{
		GtkEntryExterns.gtk_entry_set_icon_drag_source(entry, icon_pos, provider, actions);
		return entry;
	}

	public static int GetCurrentIconDragSource(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_current_icon_drag_source(entry);
	}

	public static GtkEntryHandle GetIconArea(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, GdkRectangleHandle icon_area)
	{
		GtkEntryExterns.gtk_entry_get_icon_area(entry, icon_pos, icon_area);
		return entry;
	}

	public static GtkEntryHandle ResetImContext(this GtkEntryHandle entry)
	{
		GtkEntryExterns.gtk_entry_reset_im_context(entry);
		return entry;
	}

	public static GtkEntryHandle SetInputPurpose(this GtkEntryHandle entry, GtkInputPurpose purpose)
	{
		GtkEntryExterns.gtk_entry_set_input_purpose(entry, purpose);
		return entry;
	}

	public static GtkInputPurpose GetInputPurpose(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_input_purpose(entry);
	}

	public static GtkEntryHandle SetInputHints(this GtkEntryHandle entry, GtkInputHints hints)
	{
		GtkEntryExterns.gtk_entry_set_input_hints(entry, hints);
		return entry;
	}

	public static GtkInputHints GetInputHints(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_input_hints(entry);
	}

	public static GtkEntryHandle SetAttributes(this GtkEntryHandle entry, PangoAttrListHandle attrs)
	{
		GtkEntryExterns.gtk_entry_set_attributes(entry, attrs);
		return entry;
	}

	public static PangoAttrListHandle GetAttributes(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_attributes(entry);
	}

	public static GtkEntryHandle SetTabs(this GtkEntryHandle entry, PangoTabArrayHandle tabs)
	{
		GtkEntryExterns.gtk_entry_set_tabs(entry, tabs);
		return entry;
	}

	public static PangoTabArrayHandle GetTabs(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_tabs(entry);
	}

	public static int GrabFocusWithoutSelecting(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_grab_focus_without_selecting(entry);
	}

	public static GtkEntryHandle SetExtraMenu(this GtkEntryHandle entry, GMenuModelHandle model)
	{
		GtkEntryExterns.gtk_entry_set_extra_menu(entry, model);
		return entry;
	}

	public static GMenuModelHandle GetExtraMenu(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_extra_menu(entry);
	}
}
