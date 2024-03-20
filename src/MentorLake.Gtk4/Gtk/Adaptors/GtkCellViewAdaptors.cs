using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCellViewAdaptors
{
	public static GtkCellViewHandle SetModel(this GtkCellViewHandle cell_view, GtkTreeModelHandle model)
	{
		GtkCellViewExterns.gtk_cell_view_set_model(cell_view, model);
		return cell_view;
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

	public static GtkTreePathHandle GetDisplayedRow(this GtkCellViewHandle cell_view)
	{
		return GtkCellViewExterns.gtk_cell_view_get_displayed_row(cell_view);
	}

	public static int GetDrawSensitive(this GtkCellViewHandle cell_view)
	{
		return GtkCellViewExterns.gtk_cell_view_get_draw_sensitive(cell_view);
	}

	public static GtkCellViewHandle SetDrawSensitive(this GtkCellViewHandle cell_view, int draw_sensitive)
	{
		GtkCellViewExterns.gtk_cell_view_set_draw_sensitive(cell_view, draw_sensitive);
		return cell_view;
	}

	public static int GetFitModel(this GtkCellViewHandle cell_view)
	{
		return GtkCellViewExterns.gtk_cell_view_get_fit_model(cell_view);
	}

	public static GtkCellViewHandle SetFitModel(this GtkCellViewHandle cell_view, int fit_model)
	{
		GtkCellViewExterns.gtk_cell_view_set_fit_model(cell_view, fit_model);
		return cell_view;
	}

	public static GtkCellViewHandle NewWithText(string text)
	{
		return GtkCellViewExterns.gtk_cell_view_new_with_text(text);
	}

	public static GtkCellViewHandle NewWithMarkup(string markup)
	{
		return GtkCellViewExterns.gtk_cell_view_new_with_markup(markup);
	}

	public static GtkCellViewHandle NewWithTexture(GdkTextureHandle texture)
	{
		return GtkCellViewExterns.gtk_cell_view_new_with_texture(texture);
	}
}
