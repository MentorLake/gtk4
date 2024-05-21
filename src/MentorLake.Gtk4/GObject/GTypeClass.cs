namespace MentorLake.Gtk4.GObject;

public class GTypeClassHandle : BaseSafeHandle
{
}


public static class GTypeClassHandleExtensions
{
	public static GTypeClassHandle AddPrivate(this GTypeClassHandle g_class, UIntPtr private_size)
	{
		GTypeClassExterns.g_type_class_add_private(g_class, private_size);
		return g_class;
	}

	public static int GetInstancePrivateOffset(this GTypeClassHandle g_class)
	{
		return GTypeClassExterns.g_type_class_get_instance_private_offset(g_class);
	}

	public static IntPtr GetPrivate(this GTypeClassHandle klass, GType private_type)
	{
		return GTypeClassExterns.g_type_class_get_private(klass, private_type);
	}

	public static GTypeClassHandle PeekParent(this GTypeClassHandle g_class)
	{
		return GTypeClassExterns.g_type_class_peek_parent(g_class);
	}

	public static GTypeClassHandle Unref(this GTypeClassHandle g_class)
	{
		GTypeClassExterns.g_type_class_unref(g_class);
		return g_class;
	}

	public static GTypeClassHandle UnrefUncached(this GTypeClassHandle g_class)
	{
		GTypeClassExterns.g_type_class_unref_uncached(g_class);
		return g_class;
	}

}
internal class GTypeClassExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern void g_type_class_add_private(GTypeClassHandle g_class, UIntPtr private_size);

	[DllImport(Libraries.GObject)]
	internal static extern int g_type_class_get_instance_private_offset(GTypeClassHandle g_class);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_type_class_get_private(GTypeClassHandle klass, GType private_type);

	[DllImport(Libraries.GObject)]
	internal static extern GTypeClassHandle g_type_class_peek_parent(GTypeClassHandle g_class);

	[DllImport(Libraries.GObject)]
	internal static extern void g_type_class_unref(GTypeClassHandle g_class);

	[DllImport(Libraries.GObject)]
	internal static extern void g_type_class_unref_uncached(GTypeClassHandle g_class);

}

public struct GTypeClass
{
}
