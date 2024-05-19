namespace MentorLake.Gtk4.Gtk4;

public class GtkProgressBarHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkAccessibleRangeHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkOrientableHandle
{
	public static GtkProgressBarHandle New()
	{
		return GtkProgressBarExterns.gtk_progress_bar_new();
	}

}

public static class GtkProgressBarHandleExtensions
{
	public static PangoEllipsizeMode GetEllipsize(this GtkProgressBarHandle pbar)
	{
		return GtkProgressBarExterns.gtk_progress_bar_get_ellipsize(pbar);
	}

	public static double GetFraction(this GtkProgressBarHandle pbar)
	{
		return GtkProgressBarExterns.gtk_progress_bar_get_fraction(pbar);
	}

	public static bool GetInverted(this GtkProgressBarHandle pbar)
	{
		return GtkProgressBarExterns.gtk_progress_bar_get_inverted(pbar);
	}

	public static double GetPulseStep(this GtkProgressBarHandle pbar)
	{
		return GtkProgressBarExterns.gtk_progress_bar_get_pulse_step(pbar);
	}

	public static bool GetShowText(this GtkProgressBarHandle pbar)
	{
		return GtkProgressBarExterns.gtk_progress_bar_get_show_text(pbar);
	}

	public static string GetText(this GtkProgressBarHandle pbar)
	{
		return GtkProgressBarExterns.gtk_progress_bar_get_text(pbar);
	}

	public static GtkProgressBarHandle Pulse(this GtkProgressBarHandle pbar)
	{
		GtkProgressBarExterns.gtk_progress_bar_pulse(pbar);
		return pbar;
	}

	public static GtkProgressBarHandle SetEllipsize(this GtkProgressBarHandle pbar, PangoEllipsizeMode mode)
	{
		GtkProgressBarExterns.gtk_progress_bar_set_ellipsize(pbar, mode);
		return pbar;
	}

	public static GtkProgressBarHandle SetFraction(this GtkProgressBarHandle pbar, double fraction)
	{
		GtkProgressBarExterns.gtk_progress_bar_set_fraction(pbar, fraction);
		return pbar;
	}

	public static GtkProgressBarHandle SetInverted(this GtkProgressBarHandle pbar, bool inverted)
	{
		GtkProgressBarExterns.gtk_progress_bar_set_inverted(pbar, inverted);
		return pbar;
	}

	public static GtkProgressBarHandle SetPulseStep(this GtkProgressBarHandle pbar, double fraction)
	{
		GtkProgressBarExterns.gtk_progress_bar_set_pulse_step(pbar, fraction);
		return pbar;
	}

	public static GtkProgressBarHandle SetShowText(this GtkProgressBarHandle pbar, bool show_text)
	{
		GtkProgressBarExterns.gtk_progress_bar_set_show_text(pbar, show_text);
		return pbar;
	}

	public static GtkProgressBarHandle SetText(this GtkProgressBarHandle pbar, string text)
	{
		GtkProgressBarExterns.gtk_progress_bar_set_text(pbar, text);
		return pbar;
	}

}

internal class GtkProgressBarExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkProgressBarHandle gtk_progress_bar_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern PangoEllipsizeMode gtk_progress_bar_get_ellipsize(GtkProgressBarHandle pbar);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_progress_bar_get_fraction(GtkProgressBarHandle pbar);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_progress_bar_get_inverted(GtkProgressBarHandle pbar);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_progress_bar_get_pulse_step(GtkProgressBarHandle pbar);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_progress_bar_get_show_text(GtkProgressBarHandle pbar);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_progress_bar_get_text(GtkProgressBarHandle pbar);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_progress_bar_pulse(GtkProgressBarHandle pbar);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_progress_bar_set_ellipsize(GtkProgressBarHandle pbar, PangoEllipsizeMode mode);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_progress_bar_set_fraction(GtkProgressBarHandle pbar, double fraction);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_progress_bar_set_inverted(GtkProgressBarHandle pbar, bool inverted);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_progress_bar_set_pulse_step(GtkProgressBarHandle pbar, double fraction);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_progress_bar_set_show_text(GtkProgressBarHandle pbar, bool show_text);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_progress_bar_set_text(GtkProgressBarHandle pbar, string text);

}
