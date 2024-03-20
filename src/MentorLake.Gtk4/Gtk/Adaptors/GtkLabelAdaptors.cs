using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;
public static class GtkLabelAdaptors
{
	public static GtkLabelHandle SetText(this GtkLabelHandle self, string str)
	{
		GtkLabelExterns.gtk_label_set_text(self, str);
		return self;
	}

	public static string GetText(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_text(self);
	}

	public static GtkLabelHandle SetAttributes(this GtkLabelHandle self, PangoAttrListHandle attrs)
	{
		GtkLabelExterns.gtk_label_set_attributes(self, attrs);
		return self;
	}

	public static PangoAttrListHandle GetAttributes(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_attributes(self);
	}

	public static GtkLabelHandle SetLabel(this GtkLabelHandle self, string str)
	{
		GtkLabelExterns.gtk_label_set_label(self, str);
		return self;
	}

	public static string GetLabel(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_label(self);
	}

	public static GtkLabelHandle SetMarkup(this GtkLabelHandle self, string str)
	{
		GtkLabelExterns.gtk_label_set_markup(self, str);
		return self;
	}

	public static GtkLabelHandle SetUseMarkup(this GtkLabelHandle self, int setting)
	{
		GtkLabelExterns.gtk_label_set_use_markup(self, setting);
		return self;
	}

	public static int GetUseMarkup(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_use_markup(self);
	}

	public static GtkLabelHandle SetUseUnderline(this GtkLabelHandle self, int setting)
	{
		GtkLabelExterns.gtk_label_set_use_underline(self, setting);
		return self;
	}

	public static int GetUseUnderline(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_use_underline(self);
	}

	public static GtkLabelHandle SetMarkupWithMnemonic(this GtkLabelHandle self, string str)
	{
		GtkLabelExterns.gtk_label_set_markup_with_mnemonic(self, str);
		return self;
	}

	public static uint GetMnemonicKeyval(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_mnemonic_keyval(self);
	}

	public static GtkLabelHandle SetMnemonicWidget(this GtkLabelHandle self, GtkWidgetHandle widget)
	{
		GtkLabelExterns.gtk_label_set_mnemonic_widget(self, widget);
		return self;
	}

	public static GtkWidgetHandle GetMnemonicWidget(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_mnemonic_widget(self);
	}

	public static GtkLabelHandle SetTextWithMnemonic(this GtkLabelHandle self, string str)
	{
		GtkLabelExterns.gtk_label_set_text_with_mnemonic(self, str);
		return self;
	}

	public static GtkLabelHandle SetJustify(this GtkLabelHandle self, GtkJustification jtype)
	{
		GtkLabelExterns.gtk_label_set_justify(self, jtype);
		return self;
	}

	public static GtkJustification GetJustify(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_justify(self);
	}

	public static GtkLabelHandle SetEllipsize(this GtkLabelHandle self, PangoEllipsizeMode mode)
	{
		GtkLabelExterns.gtk_label_set_ellipsize(self, mode);
		return self;
	}

	public static PangoEllipsizeMode GetEllipsize(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_ellipsize(self);
	}

	public static GtkLabelHandle SetWidthChars(this GtkLabelHandle self, int n_chars)
	{
		GtkLabelExterns.gtk_label_set_width_chars(self, n_chars);
		return self;
	}

	public static int GetWidthChars(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_width_chars(self);
	}

	public static GtkLabelHandle SetMaxWidthChars(this GtkLabelHandle self, int n_chars)
	{
		GtkLabelExterns.gtk_label_set_max_width_chars(self, n_chars);
		return self;
	}

	public static int GetMaxWidthChars(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_max_width_chars(self);
	}

	public static GtkLabelHandle SetLines(this GtkLabelHandle self, int lines)
	{
		GtkLabelExterns.gtk_label_set_lines(self, lines);
		return self;
	}

	public static int GetLines(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_lines(self);
	}

	public static GtkLabelHandle SetWrap(this GtkLabelHandle self, int wrap)
	{
		GtkLabelExterns.gtk_label_set_wrap(self, wrap);
		return self;
	}

	public static int GetWrap(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_wrap(self);
	}

	public static GtkLabelHandle SetWrapMode(this GtkLabelHandle self, PangoWrapMode wrap_mode)
	{
		GtkLabelExterns.gtk_label_set_wrap_mode(self, wrap_mode);
		return self;
	}

	public static PangoWrapMode GetWrapMode(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_wrap_mode(self);
	}

	public static GtkLabelHandle SetNaturalWrapMode(this GtkLabelHandle self, GtkNaturalWrapMode wrap_mode)
	{
		GtkLabelExterns.gtk_label_set_natural_wrap_mode(self, wrap_mode);
		return self;
	}

	public static GtkNaturalWrapMode GetNaturalWrapMode(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_natural_wrap_mode(self);
	}

	public static GtkLabelHandle SetSelectable(this GtkLabelHandle self, int setting)
	{
		GtkLabelExterns.gtk_label_set_selectable(self, setting);
		return self;
	}

	public static int GetSelectable(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_selectable(self);
	}

	public static GtkLabelHandle SelectRegion(this GtkLabelHandle self, int start_offset, int end_offset)
	{
		GtkLabelExterns.gtk_label_select_region(self, start_offset, end_offset);
		return self;
	}

	public static int GetSelectionBounds(this GtkLabelHandle self, out int start, out int end)
	{
		return GtkLabelExterns.gtk_label_get_selection_bounds(self, out start, out end);
	}

	public static PangoLayoutHandle GetLayout(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_layout(self);
	}

	public static GtkLabelHandle GetLayoutOffsets(this GtkLabelHandle self, out int x, out int y)
	{
		GtkLabelExterns.gtk_label_get_layout_offsets(self, out x, out y);
		return self;
	}

	public static GtkLabelHandle SetSingleLineMode(this GtkLabelHandle self, int single_line_mode)
	{
		GtkLabelExterns.gtk_label_set_single_line_mode(self, single_line_mode);
		return self;
	}

	public static int GetSingleLineMode(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_single_line_mode(self);
	}

	public static string GetCurrentUri(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_current_uri(self);
	}

	public static GtkLabelHandle SetXalign(this GtkLabelHandle self, float xalign)
	{
		GtkLabelExterns.gtk_label_set_xalign(self, xalign);
		return self;
	}

	public static float GetXalign(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_xalign(self);
	}

	public static GtkLabelHandle SetYalign(this GtkLabelHandle self, float yalign)
	{
		GtkLabelExterns.gtk_label_set_yalign(self, yalign);
		return self;
	}

	public static float GetYalign(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_yalign(self);
	}

	public static GtkLabelHandle SetExtraMenu(this GtkLabelHandle self, GMenuModelHandle model)
	{
		GtkLabelExterns.gtk_label_set_extra_menu(self, model);
		return self;
	}

	public static GMenuModelHandle GetExtraMenu(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_extra_menu(self);
	}

	public static GtkLabelHandle NewWithMnemonic(string str)
	{
		return GtkLabelExterns.gtk_label_new_with_mnemonic(str);
	}
}
