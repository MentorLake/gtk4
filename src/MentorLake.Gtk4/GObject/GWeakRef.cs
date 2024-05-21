namespace MentorLake.Gtk4.GObject;

public class GWeakRefHandle : BaseSafeHandle
{
}


public static class GWeakRefHandleExtensions
{
	public static GWeakRefHandle Clear(this GWeakRefHandle weak_ref)
	{
		GWeakRefExterns.g_weak_ref_clear(weak_ref);
		return weak_ref;
	}

	public static GObjectHandle Get(this GWeakRefHandle weak_ref)
	{
		return GWeakRefExterns.g_weak_ref_get(weak_ref);
	}

	public static GWeakRefHandle Init(this GWeakRefHandle weak_ref, GObjectHandle @object)
	{
		GWeakRefExterns.g_weak_ref_init(weak_ref, @object);
		return weak_ref;
	}

	public static GWeakRefHandle Set(this GWeakRefHandle weak_ref, GObjectHandle @object)
	{
		GWeakRefExterns.g_weak_ref_set(weak_ref, @object);
		return weak_ref;
	}

}
internal class GWeakRefExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern void g_weak_ref_clear(GWeakRefHandle weak_ref);

	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_weak_ref_get(GWeakRefHandle weak_ref);

	[DllImport(Libraries.GObject)]
	internal static extern void g_weak_ref_init(GWeakRefHandle weak_ref, GObjectHandle @object);

	[DllImport(Libraries.GObject)]
	internal static extern void g_weak_ref_set(GWeakRefHandle weak_ref, GObjectHandle @object);

}

public struct GWeakRef
{
}
