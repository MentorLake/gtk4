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

public class GtkCellViewHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkCellLayoutHandle, GtkConstraintTargetHandle, GtkOrientableHandle
{
	public static GtkCellViewHandle New()
	{
		return GtkCellViewExterns.gtk_cell_view_new();
	}

	public static GtkCellViewHandle NewWithContext(GtkCellAreaHandle area, GtkCellAreaContextHandle context)
	{
		return GtkCellViewExterns.gtk_cell_view_new_with_context(area, context);
	}

	public static GtkCellViewHandle NewWithMarkup(string markup)
	{
		return GtkCellViewExterns.gtk_cell_view_new_with_markup(markup);
	}

	public static GtkCellViewHandle NewWithText(string text)
	{
		return GtkCellViewExterns.gtk_cell_view_new_with_text(text);
	}

	public static GtkCellViewHandle NewWithTexture(GdkTextureHandle texture)
	{
		return GtkCellViewExterns.gtk_cell_view_new_with_texture(texture);
	}

}

public static class GtkCellViewHandleExtensions
{
	public static GtkTreePathHandle GetDisplayedRow(this GtkCellViewHandle cell_view)
	{
		return GtkCellViewExterns.gtk_cell_view_get_displayed_row(cell_view);
	}

	public static bool GetDrawSensitive(this GtkCellViewHandle cell_view)
	{
		return GtkCellViewExterns.gtk_cell_view_get_draw_sensitive(cell_view);
	}

	public static bool GetFitModel(this GtkCellViewHandle cell_view)
	{
		return GtkCellViewExterns.gtk_cell_view_get_fit_model(cell_view);
	}

	public static GtkTreeModelHandle GetModel(this GtkCellViewHandle cell_view)
	{
		return GtkCellViewExterns.gtk_cell_view_get_model(cell_view);
	}

	public static GtkCellViewHandle SetDisplayedRow(this GtkCellViewHandle cell_view, GtkTreePathHandle path)
	{
		GtkCellViewExterns.gtk_cell_view_set_displayed_row(cell_view, path);
		return cell_view;
	}

	public static GtkCellViewHandle SetDrawSensitive(this GtkCellViewHandle cell_view, bool draw_sensitive)
	{
		GtkCellViewExterns.gtk_cell_view_set_draw_sensitive(cell_view, draw_sensitive);
		return cell_view;
	}

	public static GtkCellViewHandle SetFitModel(this GtkCellViewHandle cell_view, bool fit_model)
	{
		GtkCellViewExterns.gtk_cell_view_set_fit_model(cell_view, fit_model);
		return cell_view;
	}

	public static GtkCellViewHandle SetModel(this GtkCellViewHandle cell_view, GtkTreeModelHandle model)
	{
		GtkCellViewExterns.gtk_cell_view_set_model(cell_view, model);
		return cell_view;
	}

}

internal class GtkCellViewExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellViewHandle gtk_cell_view_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellViewHandle gtk_cell_view_new_with_context(GtkCellAreaHandle area, GtkCellAreaContextHandle context);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellViewHandle gtk_cell_view_new_with_markup(string markup);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellViewHandle gtk_cell_view_new_with_text(string text);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellViewHandle gtk_cell_view_new_with_texture(GdkTextureHandle texture);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreePathHandle gtk_cell_view_get_displayed_row(GtkCellViewHandle cell_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_cell_view_get_draw_sensitive(GtkCellViewHandle cell_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_cell_view_get_fit_model(GtkCellViewHandle cell_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeModelHandle gtk_cell_view_get_model(GtkCellViewHandle cell_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_view_set_displayed_row(GtkCellViewHandle cell_view, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_view_set_draw_sensitive(GtkCellViewHandle cell_view, bool draw_sensitive);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_view_set_fit_model(GtkCellViewHandle cell_view, bool fit_model);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_cell_view_set_model(GtkCellViewHandle cell_view, GtkTreeModelHandle model);

}
