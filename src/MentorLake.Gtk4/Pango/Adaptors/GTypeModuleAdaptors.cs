using System.Runtime.InteropServices;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Pango;
public static class GTypeModuleAdaptors
{
    public static GTypeModuleHandle ScriptEngineInit(this GTypeModuleHandle module)
    {
        GTypeModuleExterns.script_engine_init(module);
        return module;
    }
}
