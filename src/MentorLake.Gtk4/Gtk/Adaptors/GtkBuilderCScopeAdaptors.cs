using System.Runtime.InteropServices;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GtkBuilderCScopeAdaptors
{
    public static GtkBuilderCScopeHandle GtkBuilderCscopeAddCallbackSymbol(this GtkBuilderCScopeHandle self, string callback_name, GCallback callback_symbol)
    {
        GtkBuilderCScopeExterns.gtk_builder_cscope_add_callback_symbol(self, callback_name, callback_symbol);
        return self;
    }

    public static GtkBuilderCScopeHandle GtkBuilderCscopeAddCallbackSymbols(this GtkBuilderCScopeHandle self, string first_callback_name, GCallback first_callback_symbol, IntPtr @__argList)
    {
        GtkBuilderCScopeExterns.gtk_builder_cscope_add_callback_symbols(self, first_callback_name, first_callback_symbol, @__argList);
        return self;
    }

    public static GCallback GtkBuilderCscopeLookupCallbackSymbol(this GtkBuilderCScopeHandle self, string callback_name)
    {
        return GtkBuilderCScopeExterns.gtk_builder_cscope_lookup_callback_symbol(self, callback_name);
    }
}
