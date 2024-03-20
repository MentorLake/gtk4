using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GObject;

public static class GWeakRefExterns
{
	[DllImport(Libraries.GObject, EntryPoint = "g_weak_ref_init")]
	internal static extern void g_weak_ref_init(this GWeakRefHandle weak_ref, IntPtr @object);

	[DllImport(Libraries.GObject, EntryPoint = "g_weak_ref_clear")]
	internal static extern void g_weak_ref_clear(this GWeakRefHandle weak_ref);

	[DllImport(Libraries.GObject, EntryPoint = "g_weak_ref_get")]
	internal static extern IntPtr g_weak_ref_get(this GWeakRefHandle weak_ref);

	[DllImport(Libraries.GObject, EntryPoint = "g_weak_ref_set")]
	internal static extern void g_weak_ref_set(this GWeakRefHandle weak_ref, IntPtr @object);
}
