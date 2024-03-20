using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSpinnerAdaptors
{
	public static GtkSpinnerHandle Start(this GtkSpinnerHandle spinner)
	{
		GtkSpinnerExterns.gtk_spinner_start(spinner);
		return spinner;
	}

	public static GtkSpinnerHandle Stop(this GtkSpinnerHandle spinner)
	{
		GtkSpinnerExterns.gtk_spinner_stop(spinner);
		return spinner;
	}

	public static GtkSpinnerHandle SetSpinning(this GtkSpinnerHandle spinner, int spinning)
	{
		GtkSpinnerExterns.gtk_spinner_set_spinning(spinner, spinning);
		return spinner;
	}

	public static int GetSpinning(this GtkSpinnerHandle spinner)
	{
		return GtkSpinnerExterns.gtk_spinner_get_spinning(spinner);
	}
}
