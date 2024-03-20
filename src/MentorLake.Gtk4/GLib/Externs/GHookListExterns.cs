using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GHookListExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_hook_list_init")]
	internal static extern void g_hook_list_init(this GHookListHandle hook_list, uint hook_size);

	[DllImport(Libraries.GLib, EntryPoint = "g_hook_list_clear")]
	internal static extern void g_hook_list_clear(this GHookListHandle hook_list);

	[DllImport(Libraries.GLib, EntryPoint = "g_hook_alloc")]
	internal static extern GHookHandle g_hook_alloc(this GHookListHandle hook_list);

	[DllImport(Libraries.GLib, EntryPoint = "g_hook_free")]
	internal static extern void g_hook_free(this GHookListHandle hook_list, GHookHandle hook);

	[DllImport(Libraries.GLib, EntryPoint = "g_hook_ref")]
	internal static extern GHookHandle g_hook_ref(this GHookListHandle hook_list, GHookHandle hook);

	[DllImport(Libraries.GLib, EntryPoint = "g_hook_unref")]
	internal static extern void g_hook_unref(this GHookListHandle hook_list, GHookHandle hook);

	[DllImport(Libraries.GLib, EntryPoint = "g_hook_destroy")]
	internal static extern int g_hook_destroy(this GHookListHandle hook_list, nuint hook_id);

	[DllImport(Libraries.GLib, EntryPoint = "g_hook_destroy_link")]
	internal static extern void g_hook_destroy_link(this GHookListHandle hook_list, GHookHandle hook);

	[DllImport(Libraries.GLib, EntryPoint = "g_hook_prepend")]
	internal static extern void g_hook_prepend(this GHookListHandle hook_list, GHookHandle hook);

	[DllImport(Libraries.GLib, EntryPoint = "g_hook_insert_before")]
	internal static extern void g_hook_insert_before(this GHookListHandle hook_list, GHookHandle sibling, GHookHandle hook);

	[DllImport(Libraries.GLib, EntryPoint = "g_hook_insert_sorted")]
	internal static extern void g_hook_insert_sorted(this GHookListHandle hook_list, GHookHandle hook, GHookCompareFunc func);

	[DllImport(Libraries.GLib, EntryPoint = "g_hook_get")]
	internal static extern GHookHandle g_hook_get(this GHookListHandle hook_list, nuint hook_id);

	[DllImport(Libraries.GLib, EntryPoint = "g_hook_find")]
	internal static extern GHookHandle g_hook_find(this GHookListHandle hook_list, int need_valids, GHookFindFunc func, IntPtr data);

	[DllImport(Libraries.GLib, EntryPoint = "g_hook_find_data")]
	internal static extern GHookHandle g_hook_find_data(this GHookListHandle hook_list, int need_valids, IntPtr data);

	[DllImport(Libraries.GLib, EntryPoint = "g_hook_find_func")]
	internal static extern GHookHandle g_hook_find_func(this GHookListHandle hook_list, int need_valids, IntPtr func);

	[DllImport(Libraries.GLib, EntryPoint = "g_hook_find_func_data")]
	internal static extern GHookHandle g_hook_find_func_data(this GHookListHandle hook_list, int need_valids, IntPtr func, IntPtr data);

	[DllImport(Libraries.GLib, EntryPoint = "g_hook_first_valid")]
	internal static extern GHookHandle g_hook_first_valid(this GHookListHandle hook_list, int may_be_in_call);

	[DllImport(Libraries.GLib, EntryPoint = "g_hook_next_valid")]
	internal static extern GHookHandle g_hook_next_valid(this GHookListHandle hook_list, GHookHandle hook, int may_be_in_call);

	[DllImport(Libraries.GLib, EntryPoint = "g_hook_list_invoke")]
	internal static extern void g_hook_list_invoke(this GHookListHandle hook_list, int may_recurse);

	[DllImport(Libraries.GLib, EntryPoint = "g_hook_list_invoke_check")]
	internal static extern void g_hook_list_invoke_check(this GHookListHandle hook_list, int may_recurse);

	[DllImport(Libraries.GLib, EntryPoint = "g_hook_list_marshal")]
	internal static extern void g_hook_list_marshal(this GHookListHandle hook_list, int may_recurse, GHookMarshaller marshaller, IntPtr marshal_data);

	[DllImport(Libraries.GLib, EntryPoint = "g_hook_list_marshal_check")]
	internal static extern void g_hook_list_marshal_check(this GHookListHandle hook_list, int may_recurse, GHookCheckMarshaller marshaller, IntPtr marshal_data);
}
