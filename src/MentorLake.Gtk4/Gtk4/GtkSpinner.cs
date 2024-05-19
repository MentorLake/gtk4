namespace MentorLake.Gtk4.Gtk4;

public class GtkSpinnerHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkSpinnerHandle New()
	{
		return GtkSpinnerExterns.gtk_spinner_new();
	}

}

public static class GtkSpinnerHandleExtensions
{
	public static bool GetSpinning(this GtkSpinnerHandle spinner)
	{
		return GtkSpinnerExterns.gtk_spinner_get_spinning(spinner);
	}

	public static GtkSpinnerHandle SetSpinning(this GtkSpinnerHandle spinner, bool spinning)
	{
		GtkSpinnerExterns.gtk_spinner_set_spinning(spinner, spinning);
		return spinner;
	}

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

}

internal class GtkSpinnerExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSpinnerHandle gtk_spinner_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_spinner_get_spinning(GtkSpinnerHandle spinner);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_spinner_set_spinning(GtkSpinnerHandle spinner, bool spinning);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_spinner_start(GtkSpinnerHandle spinner);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_spinner_stop(GtkSpinnerHandle spinner);

}
