using System.Runtime.InteropServices;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;
public static class GtkProgressBarAdaptors
{
	public static GtkProgressBarHandle Pulse(this GtkProgressBarHandle pbar)
	{
		GtkProgressBarExterns.gtk_progress_bar_pulse(pbar);
		return pbar;
	}

	public static GtkProgressBarHandle SetText(this GtkProgressBarHandle pbar, string text)
	{
		GtkProgressBarExterns.gtk_progress_bar_set_text(pbar, text);
		return pbar;
	}

	public static GtkProgressBarHandle SetFraction(this GtkProgressBarHandle pbar, double fraction)
	{
		GtkProgressBarExterns.gtk_progress_bar_set_fraction(pbar, fraction);
		return pbar;
	}

	public static GtkProgressBarHandle SetPulseStep(this GtkProgressBarHandle pbar, double fraction)
	{
		GtkProgressBarExterns.gtk_progress_bar_set_pulse_step(pbar, fraction);
		return pbar;
	}

	public static GtkProgressBarHandle SetInverted(this GtkProgressBarHandle pbar, int inverted)
	{
		GtkProgressBarExterns.gtk_progress_bar_set_inverted(pbar, inverted);
		return pbar;
	}

	public static string GetText(this GtkProgressBarHandle pbar)
	{
		return GtkProgressBarExterns.gtk_progress_bar_get_text(pbar);
	}

	public static double GetFraction(this GtkProgressBarHandle pbar)
	{
		return GtkProgressBarExterns.gtk_progress_bar_get_fraction(pbar);
	}

	public static double GetPulseStep(this GtkProgressBarHandle pbar)
	{
		return GtkProgressBarExterns.gtk_progress_bar_get_pulse_step(pbar);
	}

	public static int GetInverted(this GtkProgressBarHandle pbar)
	{
		return GtkProgressBarExterns.gtk_progress_bar_get_inverted(pbar);
	}

	public static GtkProgressBarHandle SetEllipsize(this GtkProgressBarHandle pbar, PangoEllipsizeMode mode)
	{
		GtkProgressBarExterns.gtk_progress_bar_set_ellipsize(pbar, mode);
		return pbar;
	}

	public static PangoEllipsizeMode GetEllipsize(this GtkProgressBarHandle pbar)
	{
		return GtkProgressBarExterns.gtk_progress_bar_get_ellipsize(pbar);
	}

	public static GtkProgressBarHandle SetShowText(this GtkProgressBarHandle pbar, int show_text)
	{
		GtkProgressBarExterns.gtk_progress_bar_set_show_text(pbar, show_text);
		return pbar;
	}

	public static int GetShowText(this GtkProgressBarHandle pbar)
	{
		return GtkProgressBarExterns.gtk_progress_bar_get_show_text(pbar);
	}
}
