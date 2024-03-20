using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GTimeValAdaptors
{
    public static GTimeValHandle GGetCurrentTime(this GTimeValHandle result)
    {
        GTimeValExterns.g_get_current_time(result);
        return result;
    }

    public static GTimeValHandle Add(this GTimeValHandle time_, nint microseconds)
    {
        GTimeValExterns.g_time_val_add(time_, microseconds);
        return time_;
    }

    public static string ToIso8601(this GTimeValHandle time_)
    {
        return GTimeValExterns.g_time_val_to_iso8601(time_);
    }
}
