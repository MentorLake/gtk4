using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GObject;
public static class GFlagsClassAdaptors
{
    public static GFlagsValueHandle GFlagsGetFirstValue(this GFlagsClassHandle flags_class, uint value)
    {
        return GFlagsClassExterns.g_flags_get_first_value(flags_class, value);
    }

    public static GFlagsValueHandle GFlagsGetValueByName(this GFlagsClassHandle flags_class, string name)
    {
        return GFlagsClassExterns.g_flags_get_value_by_name(flags_class, name);
    }

    public static GFlagsValueHandle GFlagsGetValueByNick(this GFlagsClassHandle flags_class, string nick)
    {
        return GFlagsClassExterns.g_flags_get_value_by_nick(flags_class, nick);
    }
}
