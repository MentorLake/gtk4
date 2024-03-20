using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GObject;
public static class GSignalInvocationHintAdaptors
{
    public static int GSignalAccumulatorTrueHandled(this GSignalInvocationHintHandle ihint, GValueHandle return_accu, GValueHandle handler_return, IntPtr dummy)
    {
        return GSignalInvocationHintExterns.g_signal_accumulator_true_handled(ihint, return_accu, handler_return, dummy);
    }

    public static int GSignalAccumulatorFirstWins(this GSignalInvocationHintHandle ihint, GValueHandle return_accu, GValueHandle handler_return, IntPtr dummy)
    {
        return GSignalInvocationHintExterns.g_signal_accumulator_first_wins(ihint, return_accu, handler_return, dummy);
    }
}
