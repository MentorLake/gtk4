using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GRandExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_rand_free")]
    internal static extern void g_rand_free(this GRandHandle rand_);
    [DllImport(Libraries.GLib, EntryPoint = "g_rand_copy")]
    internal static extern GRandHandle g_rand_copy(this GRandHandle rand_);
    [DllImport(Libraries.GLib, EntryPoint = "g_rand_set_seed")]
    internal static extern void g_rand_set_seed(this GRandHandle rand_, uint seed);
    [DllImport(Libraries.GLib, EntryPoint = "g_rand_set_seed_array")]
    internal static extern void g_rand_set_seed_array(this GRandHandle rand_, uint[] seed, uint seed_length);
    [DllImport(Libraries.GLib, EntryPoint = "g_rand_int")]
    internal static extern uint g_rand_int(this GRandHandle rand_);
    [DllImport(Libraries.GLib, EntryPoint = "g_rand_int_range")]
    internal static extern int g_rand_int_range(this GRandHandle rand_, int begin, int end);
    [DllImport(Libraries.GLib, EntryPoint = "g_rand_double")]
    internal static extern double g_rand_double(this GRandHandle rand_);
    [DllImport(Libraries.GLib, EntryPoint = "g_rand_double_range")]
    internal static extern double g_rand_double_range(this GRandHandle rand_, double begin, double end);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GRandHandle g_rand_new_with_seed(uint seed);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GRandHandle g_rand_new_with_seed_array(uint[] seed, uint seed_length);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GRandHandle g_rand_new();
}
