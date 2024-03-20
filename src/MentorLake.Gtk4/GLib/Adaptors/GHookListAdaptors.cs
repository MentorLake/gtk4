using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GHookListAdaptors
{
    public static GHookListHandle Init(this GHookListHandle hook_list, uint hook_size)
    {
        GHookListExterns.g_hook_list_init(hook_list, hook_size);
        return hook_list;
    }

    public static GHookListHandle Clear(this GHookListHandle hook_list)
    {
        GHookListExterns.g_hook_list_clear(hook_list);
        return hook_list;
    }

    public static GHookHandle GHookAlloc(this GHookListHandle hook_list)
    {
        return GHookListExterns.g_hook_alloc(hook_list);
    }

    public static GHookListHandle GHookFree(this GHookListHandle hook_list, GHookHandle hook)
    {
        GHookListExterns.g_hook_free(hook_list, hook);
        return hook_list;
    }

    public static GHookHandle GHookRef(this GHookListHandle hook_list, GHookHandle hook)
    {
        return GHookListExterns.g_hook_ref(hook_list, hook);
    }

    public static GHookListHandle GHookUnref(this GHookListHandle hook_list, GHookHandle hook)
    {
        GHookListExterns.g_hook_unref(hook_list, hook);
        return hook_list;
    }

    public static int GHookDestroy(this GHookListHandle hook_list, nuint hook_id)
    {
        return GHookListExterns.g_hook_destroy(hook_list, hook_id);
    }

    public static GHookListHandle GHookDestroyLink(this GHookListHandle hook_list, GHookHandle hook)
    {
        GHookListExterns.g_hook_destroy_link(hook_list, hook);
        return hook_list;
    }

    public static GHookListHandle GHookPrepend(this GHookListHandle hook_list, GHookHandle hook)
    {
        GHookListExterns.g_hook_prepend(hook_list, hook);
        return hook_list;
    }

    public static GHookListHandle GHookInsertBefore(this GHookListHandle hook_list, GHookHandle sibling, GHookHandle hook)
    {
        GHookListExterns.g_hook_insert_before(hook_list, sibling, hook);
        return hook_list;
    }

    public static GHookListHandle GHookInsertSorted(this GHookListHandle hook_list, GHookHandle hook, GHookCompareFunc func)
    {
        GHookListExterns.g_hook_insert_sorted(hook_list, hook, func);
        return hook_list;
    }

    public static GHookHandle GHookGet(this GHookListHandle hook_list, nuint hook_id)
    {
        return GHookListExterns.g_hook_get(hook_list, hook_id);
    }

    public static GHookHandle GHookFind(this GHookListHandle hook_list, int need_valids, GHookFindFunc func, IntPtr data)
    {
        return GHookListExterns.g_hook_find(hook_list, need_valids, func, data);
    }

    public static GHookHandle GHookFindData(this GHookListHandle hook_list, int need_valids, IntPtr data)
    {
        return GHookListExterns.g_hook_find_data(hook_list, need_valids, data);
    }

    public static GHookHandle GHookFindFunc(this GHookListHandle hook_list, int need_valids, IntPtr func)
    {
        return GHookListExterns.g_hook_find_func(hook_list, need_valids, func);
    }

    public static GHookHandle GHookFindFuncData(this GHookListHandle hook_list, int need_valids, IntPtr func, IntPtr data)
    {
        return GHookListExterns.g_hook_find_func_data(hook_list, need_valids, func, data);
    }

    public static GHookHandle GHookFirstValid(this GHookListHandle hook_list, int may_be_in_call)
    {
        return GHookListExterns.g_hook_first_valid(hook_list, may_be_in_call);
    }

    public static GHookHandle GHookNextValid(this GHookListHandle hook_list, GHookHandle hook, int may_be_in_call)
    {
        return GHookListExterns.g_hook_next_valid(hook_list, hook, may_be_in_call);
    }

    public static GHookListHandle Invoke(this GHookListHandle hook_list, int may_recurse)
    {
        GHookListExterns.g_hook_list_invoke(hook_list, may_recurse);
        return hook_list;
    }

    public static GHookListHandle InvokeCheck(this GHookListHandle hook_list, int may_recurse)
    {
        GHookListExterns.g_hook_list_invoke_check(hook_list, may_recurse);
        return hook_list;
    }

    public static GHookListHandle Marshal(this GHookListHandle hook_list, int may_recurse, GHookMarshaller marshaller, IntPtr marshal_data)
    {
        GHookListExterns.g_hook_list_marshal(hook_list, may_recurse, marshaller, marshal_data);
        return hook_list;
    }

    public static GHookListHandle MarshalCheck(this GHookListHandle hook_list, int may_recurse, GHookCheckMarshaller marshaller, IntPtr marshal_data)
    {
        GHookListExterns.g_hook_list_marshal_check(hook_list, may_recurse, marshaller, marshal_data);
        return hook_list;
    }
}
