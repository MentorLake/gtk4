using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GObject;

public static class GSignalInvocationHintExterns
{
	[DllImport(Libraries.GObject, EntryPoint = "g_signal_accumulator_true_handled")]
	internal static extern int g_signal_accumulator_true_handled(this GSignalInvocationHintHandle ihint, GValueHandle return_accu, GValueHandle handler_return, IntPtr dummy);

	[DllImport(Libraries.GObject, EntryPoint = "g_signal_accumulator_first_wins")]
	internal static extern int g_signal_accumulator_first_wins(this GSignalInvocationHintHandle ihint, GValueHandle return_accu, GValueHandle handler_return, IntPtr dummy);
}
