using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkExpanderAdaptors
{
	public static GtkExpanderHandle SetExpanded(this GtkExpanderHandle expander, int expanded)
	{
		GtkExpanderExterns.gtk_expander_set_expanded(expander, expanded);
		return expander;
	}

	public static int GetExpanded(this GtkExpanderHandle expander)
	{
		return GtkExpanderExterns.gtk_expander_get_expanded(expander);
	}

	public static GtkExpanderHandle SetLabel(this GtkExpanderHandle expander, string label)
	{
		GtkExpanderExterns.gtk_expander_set_label(expander, label);
		return expander;
	}

	public static string GetLabel(this GtkExpanderHandle expander)
	{
		return GtkExpanderExterns.gtk_expander_get_label(expander);
	}

	public static GtkExpanderHandle SetUseUnderline(this GtkExpanderHandle expander, int use_underline)
	{
		GtkExpanderExterns.gtk_expander_set_use_underline(expander, use_underline);
		return expander;
	}

	public static int GetUseUnderline(this GtkExpanderHandle expander)
	{
		return GtkExpanderExterns.gtk_expander_get_use_underline(expander);
	}

	public static GtkExpanderHandle SetUseMarkup(this GtkExpanderHandle expander, int use_markup)
	{
		GtkExpanderExterns.gtk_expander_set_use_markup(expander, use_markup);
		return expander;
	}

	public static int GetUseMarkup(this GtkExpanderHandle expander)
	{
		return GtkExpanderExterns.gtk_expander_get_use_markup(expander);
	}

	public static GtkExpanderHandle SetLabelWidget(this GtkExpanderHandle expander, GtkWidgetHandle label_widget)
	{
		GtkExpanderExterns.gtk_expander_set_label_widget(expander, label_widget);
		return expander;
	}

	public static GtkWidgetHandle GetLabelWidget(this GtkExpanderHandle expander)
	{
		return GtkExpanderExterns.gtk_expander_get_label_widget(expander);
	}

	public static GtkExpanderHandle SetResizeToplevel(this GtkExpanderHandle expander, int resize_toplevel)
	{
		GtkExpanderExterns.gtk_expander_set_resize_toplevel(expander, resize_toplevel);
		return expander;
	}

	public static int GetResizeToplevel(this GtkExpanderHandle expander)
	{
		return GtkExpanderExterns.gtk_expander_get_resize_toplevel(expander);
	}

	public static GtkExpanderHandle SetChild(this GtkExpanderHandle expander, GtkWidgetHandle child)
	{
		GtkExpanderExterns.gtk_expander_set_child(expander, child);
		return expander;
	}

	public static GtkWidgetHandle GetChild(this GtkExpanderHandle expander)
	{
		return GtkExpanderExterns.gtk_expander_get_child(expander);
	}

	public static GtkExpanderHandle NewWithMnemonic(string label)
	{
		return GtkExpanderExterns.gtk_expander_new_with_mnemonic(label);
	}
}
