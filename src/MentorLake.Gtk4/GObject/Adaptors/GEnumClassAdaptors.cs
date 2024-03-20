using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GObject;
public static class GEnumClassAdaptors
{
    public static GEnumValueHandle GEnumGetValue(this GEnumClassHandle enum_class, int value)
    {
        return GEnumClassExterns.g_enum_get_value(enum_class, value);
    }

    public static GEnumValueHandle GEnumGetValueByName(this GEnumClassHandle enum_class, string name)
    {
        return GEnumClassExterns.g_enum_get_value_by_name(enum_class, name);
    }

    public static GEnumValueHandle GEnumGetValueByNick(this GEnumClassHandle enum_class, string nick)
    {
        return GEnumClassExterns.g_enum_get_value_by_nick(enum_class, nick);
    }
}
