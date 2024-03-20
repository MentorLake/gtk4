using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Gsk;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;
public static class GtkWidgetAdaptors
{
    public static GtkWidgetHandle Unparent(this GtkWidgetHandle widget)
    {
        GtkWidgetExterns.gtk_widget_unparent(widget);
        return widget;
    }

    public static GtkWidgetHandle Show(this GtkWidgetHandle widget)
    {
        GtkWidgetExterns.gtk_widget_show(widget);
        return widget;
    }

    public static GtkWidgetHandle Hide(this GtkWidgetHandle widget)
    {
        GtkWidgetExterns.gtk_widget_hide(widget);
        return widget;
    }

    public static GtkWidgetHandle Map(this GtkWidgetHandle widget)
    {
        GtkWidgetExterns.gtk_widget_map(widget);
        return widget;
    }

    public static GtkWidgetHandle Unmap(this GtkWidgetHandle widget)
    {
        GtkWidgetExterns.gtk_widget_unmap(widget);
        return widget;
    }

    public static GtkWidgetHandle Realize(this GtkWidgetHandle widget)
    {
        GtkWidgetExterns.gtk_widget_realize(widget);
        return widget;
    }

    public static GtkWidgetHandle Unrealize(this GtkWidgetHandle widget)
    {
        GtkWidgetExterns.gtk_widget_unrealize(widget);
        return widget;
    }

    public static GtkWidgetHandle QueueDraw(this GtkWidgetHandle widget)
    {
        GtkWidgetExterns.gtk_widget_queue_draw(widget);
        return widget;
    }

    public static GtkWidgetHandle QueueResize(this GtkWidgetHandle widget)
    {
        GtkWidgetExterns.gtk_widget_queue_resize(widget);
        return widget;
    }

    public static GtkWidgetHandle QueueAllocate(this GtkWidgetHandle widget)
    {
        GtkWidgetExterns.gtk_widget_queue_allocate(widget);
        return widget;
    }

    public static GdkFrameClockHandle GetFrameClock(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_frame_clock(widget);
    }

    public static GtkWidgetHandle SizeAllocate(this GtkWidgetHandle widget, GtkAllocationHandle allocation, int baseline)
    {
        GtkWidgetExterns.gtk_widget_size_allocate(widget, allocation, baseline);
        return widget;
    }

    public static GtkWidgetHandle Allocate(this GtkWidgetHandle widget, int width, int height, int baseline, GskTransformHandle transform)
    {
        GtkWidgetExterns.gtk_widget_allocate(widget, width, height, baseline, transform);
        return widget;
    }

    public static GtkSizeRequestMode GetRequestMode(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_request_mode(widget);
    }

    public static GtkWidgetHandle Measure(this GtkWidgetHandle widget, GtkOrientation orientation, int for_size, out int minimum, out int natural, out int minimum_baseline, out int natural_baseline)
    {
        GtkWidgetExterns.gtk_widget_measure(widget, orientation, for_size, out minimum, out natural, out minimum_baseline, out natural_baseline);
        return widget;
    }

    public static GtkWidgetHandle GetPreferredSize(this GtkWidgetHandle widget, GtkRequisitionHandle minimum_size, GtkRequisitionHandle natural_size)
    {
        GtkWidgetExterns.gtk_widget_get_preferred_size(widget, minimum_size, natural_size);
        return widget;
    }

    public static GtkWidgetHandle SetLayoutManager(this GtkWidgetHandle widget, GtkLayoutManagerHandle layout_manager)
    {
        GtkWidgetExterns.gtk_widget_set_layout_manager(widget, layout_manager);
        return widget;
    }

    public static GtkLayoutManagerHandle GetLayoutManager(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_layout_manager(widget);
    }

    public static int MnemonicActivate(this GtkWidgetHandle widget, int group_cycling)
    {
        return GtkWidgetExterns.gtk_widget_mnemonic_activate(widget, group_cycling);
    }

    public static int Activate(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_activate(widget);
    }

    public static GtkWidgetHandle SetCanFocus(this GtkWidgetHandle widget, int can_focus)
    {
        GtkWidgetExterns.gtk_widget_set_can_focus(widget, can_focus);
        return widget;
    }

    public static int GetCanFocus(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_can_focus(widget);
    }

    public static GtkWidgetHandle SetFocusable(this GtkWidgetHandle widget, int focusable)
    {
        GtkWidgetExterns.gtk_widget_set_focusable(widget, focusable);
        return widget;
    }

    public static int GetFocusable(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_focusable(widget);
    }

    public static int HasFocus(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_has_focus(widget);
    }

    public static int IsFocus(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_is_focus(widget);
    }

    public static int HasVisibleFocus(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_has_visible_focus(widget);
    }

    public static int GrabFocus(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_grab_focus(widget);
    }

    public static GtkWidgetHandle SetFocusOnClick(this GtkWidgetHandle widget, int focus_on_click)
    {
        GtkWidgetExterns.gtk_widget_set_focus_on_click(widget, focus_on_click);
        return widget;
    }

    public static int GetFocusOnClick(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_focus_on_click(widget);
    }

    public static GtkWidgetHandle SetCanTarget(this GtkWidgetHandle widget, int can_target)
    {
        GtkWidgetExterns.gtk_widget_set_can_target(widget, can_target);
        return widget;
    }

    public static int GetCanTarget(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_can_target(widget);
    }

    public static int HasDefault(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_has_default(widget);
    }

    public static GtkWidgetHandle SetReceivesDefault(this GtkWidgetHandle widget, int receives_default)
    {
        GtkWidgetExterns.gtk_widget_set_receives_default(widget, receives_default);
        return widget;
    }

    public static int GetReceivesDefault(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_receives_default(widget);
    }

    public static GtkWidgetHandle SetName(this GtkWidgetHandle widget, string name)
    {
        GtkWidgetExterns.gtk_widget_set_name(widget, name);
        return widget;
    }

    public static string GetName(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_name(widget);
    }

    public static GtkWidgetHandle SetStateFlags(this GtkWidgetHandle widget, GtkStateFlags flags, int clear)
    {
        GtkWidgetExterns.gtk_widget_set_state_flags(widget, flags, clear);
        return widget;
    }

    public static GtkWidgetHandle UnsetStateFlags(this GtkWidgetHandle widget, GtkStateFlags flags)
    {
        GtkWidgetExterns.gtk_widget_unset_state_flags(widget, flags);
        return widget;
    }

    public static GtkStateFlags GetStateFlags(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_state_flags(widget);
    }

    public static GtkWidgetHandle SetSensitive(this GtkWidgetHandle widget, int sensitive)
    {
        GtkWidgetExterns.gtk_widget_set_sensitive(widget, sensitive);
        return widget;
    }

    public static int GetSensitive(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_sensitive(widget);
    }

    public static int IsSensitive(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_is_sensitive(widget);
    }

    public static GtkWidgetHandle SetVisible(this GtkWidgetHandle widget, int visible)
    {
        GtkWidgetExterns.gtk_widget_set_visible(widget, visible);
        return widget;
    }

    public static int GetVisible(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_visible(widget);
    }

    public static int IsVisible(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_is_visible(widget);
    }

    public static int IsDrawable(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_is_drawable(widget);
    }

    public static int GetRealized(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_realized(widget);
    }

    public static int GetMapped(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_mapped(widget);
    }

    public static GtkWidgetHandle SetParent(this GtkWidgetHandle widget, GtkWidgetHandle parent)
    {
        GtkWidgetExterns.gtk_widget_set_parent(widget, parent);
        return widget;
    }

    public static GtkWidgetHandle GetParent(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_parent(widget);
    }

    public static GtkRootHandle GetRoot(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_root(widget);
    }

    public static GtkNativeHandle GetNative(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_native(widget);
    }

    public static GtkWidgetHandle SetChildVisible(this GtkWidgetHandle widget, int child_visible)
    {
        GtkWidgetExterns.gtk_widget_set_child_visible(widget, child_visible);
        return widget;
    }

    public static int GetChildVisible(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_child_visible(widget);
    }

    public static int GetAllocatedWidth(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_allocated_width(widget);
    }

    public static int GetAllocatedHeight(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_allocated_height(widget);
    }

    public static int GetAllocatedBaseline(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_allocated_baseline(widget);
    }

    public static GtkWidgetHandle GetAllocation(this GtkWidgetHandle widget, GtkAllocationHandle allocation)
    {
        GtkWidgetExterns.gtk_widget_get_allocation(widget, allocation);
        return widget;
    }

    public static int ComputeTransform(this GtkWidgetHandle widget, GtkWidgetHandle target, graphene_matrix_tHandle out_transform)
    {
        return GtkWidgetExterns.gtk_widget_compute_transform(widget, target, out_transform);
    }

    public static int ComputeBounds(this GtkWidgetHandle widget, GtkWidgetHandle target, graphene_rect_tHandle out_bounds)
    {
        return GtkWidgetExterns.gtk_widget_compute_bounds(widget, target, out_bounds);
    }

    public static int ComputePoint(this GtkWidgetHandle widget, GtkWidgetHandle target, graphene_point_tHandle point, graphene_point_tHandle out_point)
    {
        return GtkWidgetExterns.gtk_widget_compute_point(widget, target, point, out_point);
    }

    public static int GetWidth(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_width(widget);
    }

    public static int GetHeight(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_height(widget);
    }

    public static int GetSize(this GtkWidgetHandle widget, GtkOrientation orientation)
    {
        return GtkWidgetExterns.gtk_widget_get_size(widget, orientation);
    }

    public static int ChildFocus(this GtkWidgetHandle widget, GtkDirectionType direction)
    {
        return GtkWidgetExterns.gtk_widget_child_focus(widget, direction);
    }

    public static int KeynavFailed(this GtkWidgetHandle widget, GtkDirectionType direction)
    {
        return GtkWidgetExterns.gtk_widget_keynav_failed(widget, direction);
    }

    public static GtkWidgetHandle ErrorBell(this GtkWidgetHandle widget)
    {
        GtkWidgetExterns.gtk_widget_error_bell(widget);
        return widget;
    }

    public static GtkWidgetHandle SetSizeRequest(this GtkWidgetHandle widget, int width, int height)
    {
        GtkWidgetExterns.gtk_widget_set_size_request(widget, width, height);
        return widget;
    }

    public static GtkWidgetHandle GetSizeRequest(this GtkWidgetHandle widget, out int width, out int height)
    {
        GtkWidgetExterns.gtk_widget_get_size_request(widget, out width, out height);
        return widget;
    }

    public static GtkWidgetHandle SetOpacity(this GtkWidgetHandle widget, double opacity)
    {
        GtkWidgetExterns.gtk_widget_set_opacity(widget, opacity);
        return widget;
    }

    public static double GetOpacity(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_opacity(widget);
    }

    public static GtkWidgetHandle SetOverflow(this GtkWidgetHandle widget, GtkOverflow overflow)
    {
        GtkWidgetExterns.gtk_widget_set_overflow(widget, overflow);
        return widget;
    }

    public static GtkOverflow GetOverflow(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_overflow(widget);
    }

    public static GtkWidgetHandle GetAncestor(this GtkWidgetHandle widget, GType widget_type)
    {
        return GtkWidgetExterns.gtk_widget_get_ancestor(widget, widget_type);
    }

    public static int GetScaleFactor(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_scale_factor(widget);
    }

    public static GdkDisplayHandle GetDisplay(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_display(widget);
    }

    public static GtkSettingsHandle GetSettings(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_settings(widget);
    }

    public static GdkClipboardHandle GetClipboard(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_clipboard(widget);
    }

    public static GdkClipboardHandle GetPrimaryClipboard(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_primary_clipboard(widget);
    }

    public static int GetHexpand(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_hexpand(widget);
    }

    public static GtkWidgetHandle SetHexpand(this GtkWidgetHandle widget, int expand)
    {
        GtkWidgetExterns.gtk_widget_set_hexpand(widget, expand);
        return widget;
    }

    public static int GetHexpandSet(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_hexpand_set(widget);
    }

    public static GtkWidgetHandle SetHexpandSet(this GtkWidgetHandle widget, int set)
    {
        GtkWidgetExterns.gtk_widget_set_hexpand_set(widget, set);
        return widget;
    }

    public static int GetVexpand(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_vexpand(widget);
    }

    public static GtkWidgetHandle SetVexpand(this GtkWidgetHandle widget, int expand)
    {
        GtkWidgetExterns.gtk_widget_set_vexpand(widget, expand);
        return widget;
    }

    public static int GetVexpandSet(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_vexpand_set(widget);
    }

    public static GtkWidgetHandle SetVexpandSet(this GtkWidgetHandle widget, int set)
    {
        GtkWidgetExterns.gtk_widget_set_vexpand_set(widget, set);
        return widget;
    }

    public static int ComputeExpand(this GtkWidgetHandle widget, GtkOrientation orientation)
    {
        return GtkWidgetExterns.gtk_widget_compute_expand(widget, orientation);
    }

    public static GtkAlign GetHalign(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_halign(widget);
    }

    public static GtkWidgetHandle SetHalign(this GtkWidgetHandle widget, GtkAlign align)
    {
        GtkWidgetExterns.gtk_widget_set_halign(widget, align);
        return widget;
    }

    public static GtkAlign GetValign(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_valign(widget);
    }

    public static GtkWidgetHandle SetValign(this GtkWidgetHandle widget, GtkAlign align)
    {
        GtkWidgetExterns.gtk_widget_set_valign(widget, align);
        return widget;
    }

    public static int GetMarginStart(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_margin_start(widget);
    }

    public static GtkWidgetHandle SetMarginStart(this GtkWidgetHandle widget, int margin)
    {
        GtkWidgetExterns.gtk_widget_set_margin_start(widget, margin);
        return widget;
    }

    public static int GetMarginEnd(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_margin_end(widget);
    }

    public static GtkWidgetHandle SetMarginEnd(this GtkWidgetHandle widget, int margin)
    {
        GtkWidgetExterns.gtk_widget_set_margin_end(widget, margin);
        return widget;
    }

    public static int GetMarginTop(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_margin_top(widget);
    }

    public static GtkWidgetHandle SetMarginTop(this GtkWidgetHandle widget, int margin)
    {
        GtkWidgetExterns.gtk_widget_set_margin_top(widget, margin);
        return widget;
    }

    public static int GetMarginBottom(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_margin_bottom(widget);
    }

    public static GtkWidgetHandle SetMarginBottom(this GtkWidgetHandle widget, int margin)
    {
        GtkWidgetExterns.gtk_widget_set_margin_bottom(widget, margin);
        return widget;
    }

    public static int IsAncestor(this GtkWidgetHandle widget, GtkWidgetHandle ancestor)
    {
        return GtkWidgetExterns.gtk_widget_is_ancestor(widget, ancestor);
    }

    public static int TranslateCoordinates(this GtkWidgetHandle src_widget, GtkWidgetHandle dest_widget, double src_x, double src_y, out double dest_x, out double dest_y)
    {
        return GtkWidgetExterns.gtk_widget_translate_coordinates(src_widget, dest_widget, src_x, src_y, out dest_x, out dest_y);
    }

    public static int Contains(this GtkWidgetHandle widget, double x, double y)
    {
        return GtkWidgetExterns.gtk_widget_contains(widget, x, y);
    }

    public static GtkWidgetHandle Pick(this GtkWidgetHandle widget, double x, double y, GtkPickFlags flags)
    {
        return GtkWidgetExterns.gtk_widget_pick(widget, x, y, flags);
    }

    public static GtkWidgetHandle AddController(this GtkWidgetHandle widget, GtkEventControllerHandle controller)
    {
        GtkWidgetExterns.gtk_widget_add_controller(widget, controller);
        return widget;
    }

    public static GtkWidgetHandle RemoveController(this GtkWidgetHandle widget, GtkEventControllerHandle controller)
    {
        GtkWidgetExterns.gtk_widget_remove_controller(widget, controller);
        return widget;
    }

    public static PangoContextHandle CreatePangoContext(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_create_pango_context(widget);
    }

    public static PangoContextHandle GetPangoContext(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_pango_context(widget);
    }

    public static GtkWidgetHandle SetFontOptions(this GtkWidgetHandle widget, cairo_font_optionsHandle options)
    {
        GtkWidgetExterns.gtk_widget_set_font_options(widget, options);
        return widget;
    }

    public static cairo_font_optionsHandle GetFontOptions(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_font_options(widget);
    }

    public static PangoLayoutHandle CreatePangoLayout(this GtkWidgetHandle widget, string text)
    {
        return GtkWidgetExterns.gtk_widget_create_pango_layout(widget, text);
    }

    public static GtkWidgetHandle SetDirection(this GtkWidgetHandle widget, GtkTextDirection dir)
    {
        GtkWidgetExterns.gtk_widget_set_direction(widget, dir);
        return widget;
    }

    public static GtkTextDirection GetDirection(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_direction(widget);
    }

    public static GtkWidgetHandle SetCursor(this GtkWidgetHandle widget, GdkCursorHandle cursor)
    {
        GtkWidgetExterns.gtk_widget_set_cursor(widget, cursor);
        return widget;
    }

    public static GtkWidgetHandle SetCursorFromName(this GtkWidgetHandle widget, string name)
    {
        GtkWidgetExterns.gtk_widget_set_cursor_from_name(widget, name);
        return widget;
    }

    public static GdkCursorHandle GetCursor(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_cursor(widget);
    }

    public static GListHandle ListMnemonicLabels(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_list_mnemonic_labels(widget);
    }

    public static GtkWidgetHandle AddMnemonicLabel(this GtkWidgetHandle widget, GtkWidgetHandle label)
    {
        GtkWidgetExterns.gtk_widget_add_mnemonic_label(widget, label);
        return widget;
    }

    public static GtkWidgetHandle RemoveMnemonicLabel(this GtkWidgetHandle widget, GtkWidgetHandle label)
    {
        GtkWidgetExterns.gtk_widget_remove_mnemonic_label(widget, label);
        return widget;
    }

    public static GtkWidgetHandle TriggerTooltipQuery(this GtkWidgetHandle widget)
    {
        GtkWidgetExterns.gtk_widget_trigger_tooltip_query(widget);
        return widget;
    }

    public static GtkWidgetHandle SetTooltipText(this GtkWidgetHandle widget, string text)
    {
        GtkWidgetExterns.gtk_widget_set_tooltip_text(widget, text);
        return widget;
    }

    public static string GetTooltipText(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_tooltip_text(widget);
    }

    public static GtkWidgetHandle SetTooltipMarkup(this GtkWidgetHandle widget, string markup)
    {
        GtkWidgetExterns.gtk_widget_set_tooltip_markup(widget, markup);
        return widget;
    }

    public static string GetTooltipMarkup(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_tooltip_markup(widget);
    }

    public static GtkWidgetHandle SetHasTooltip(this GtkWidgetHandle widget, int has_tooltip)
    {
        GtkWidgetExterns.gtk_widget_set_has_tooltip(widget, has_tooltip);
        return widget;
    }

    public static int GetHasTooltip(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_has_tooltip(widget);
    }

    public static int InDestruction(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_in_destruction(widget);
    }

    public static GtkStyleContextHandle GetStyleContext(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_style_context(widget);
    }

    public static uint AddTickCallback(this GtkWidgetHandle widget, GtkTickCallback callback, IntPtr user_data, GDestroyNotify notify)
    {
        return GtkWidgetExterns.gtk_widget_add_tick_callback(widget, callback, user_data, notify);
    }

    public static GtkWidgetHandle RemoveTickCallback(this GtkWidgetHandle widget, uint id)
    {
        GtkWidgetExterns.gtk_widget_remove_tick_callback(widget, id);
        return widget;
    }

    public static GtkWidgetHandle InitTemplate(this GtkWidgetHandle widget)
    {
        GtkWidgetExterns.gtk_widget_init_template(widget);
        return widget;
    }

    public static GObjectHandle GetTemplateChild(this GtkWidgetHandle widget, GType widget_type, string name)
    {
        return GtkWidgetExterns.gtk_widget_get_template_child(widget, widget_type, name);
    }

    public static GtkWidgetHandle InsertActionGroup(this GtkWidgetHandle widget, string name, GActionGroupHandle group)
    {
        GtkWidgetExterns.gtk_widget_insert_action_group(widget, name, group);
        return widget;
    }

    public static int ActivateAction(this GtkWidgetHandle widget, string name, string format_string, IntPtr @__argList)
    {
        return GtkWidgetExterns.gtk_widget_activate_action(widget, name, format_string, @__argList);
    }

    public static int ActivateActionVariant(this GtkWidgetHandle widget, string name, GVariantHandle args)
    {
        return GtkWidgetExterns.gtk_widget_activate_action_variant(widget, name, args);
    }

    public static GtkWidgetHandle ActivateDefault(this GtkWidgetHandle widget)
    {
        GtkWidgetExterns.gtk_widget_activate_default(widget);
        return widget;
    }

    public static GtkWidgetHandle SetFontMap(this GtkWidgetHandle widget, PangoFontMapHandle font_map)
    {
        GtkWidgetExterns.gtk_widget_set_font_map(widget, font_map);
        return widget;
    }

    public static PangoFontMapHandle GetFontMap(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_font_map(widget);
    }

    public static GtkWidgetHandle GetFirstChild(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_first_child(widget);
    }

    public static GtkWidgetHandle GetLastChild(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_last_child(widget);
    }

    public static GtkWidgetHandle GetNextSibling(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_next_sibling(widget);
    }

    public static GtkWidgetHandle GetPrevSibling(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_prev_sibling(widget);
    }

    public static GListModelHandle ObserveChildren(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_observe_children(widget);
    }

    public static GListModelHandle ObserveControllers(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_observe_controllers(widget);
    }

    public static GtkWidgetHandle InsertAfter(this GtkWidgetHandle widget, GtkWidgetHandle parent, GtkWidgetHandle previous_sibling)
    {
        GtkWidgetExterns.gtk_widget_insert_after(widget, parent, previous_sibling);
        return widget;
    }

    public static GtkWidgetHandle InsertBefore(this GtkWidgetHandle widget, GtkWidgetHandle parent, GtkWidgetHandle next_sibling)
    {
        GtkWidgetExterns.gtk_widget_insert_before(widget, parent, next_sibling);
        return widget;
    }

    public static GtkWidgetHandle SetFocusChild(this GtkWidgetHandle widget, GtkWidgetHandle child)
    {
        GtkWidgetExterns.gtk_widget_set_focus_child(widget, child);
        return widget;
    }

    public static GtkWidgetHandle GetFocusChild(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_focus_child(widget);
    }

    public static GtkWidgetHandle SnapshotChild(this GtkWidgetHandle widget, GtkWidgetHandle child, GtkSnapshotHandle snapshot)
    {
        GtkWidgetExterns.gtk_widget_snapshot_child(widget, child, snapshot);
        return widget;
    }

    public static int ShouldLayout(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_should_layout(widget);
    }

    public static string GetCssName(this GtkWidgetHandle self)
    {
        return GtkWidgetExterns.gtk_widget_get_css_name(self);
    }

    public static GtkWidgetHandle AddCssClass(this GtkWidgetHandle widget, string css_class)
    {
        GtkWidgetExterns.gtk_widget_add_css_class(widget, css_class);
        return widget;
    }

    public static GtkWidgetHandle RemoveCssClass(this GtkWidgetHandle widget, string css_class)
    {
        GtkWidgetExterns.gtk_widget_remove_css_class(widget, css_class);
        return widget;
    }

    public static int HasCssClass(this GtkWidgetHandle widget, string css_class)
    {
        return GtkWidgetExterns.gtk_widget_has_css_class(widget, css_class);
    }

    public static string[] GetCssClasses(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_get_css_classes(widget);
    }

    public static GtkWidgetHandle SetCssClasses(this GtkWidgetHandle widget, string[] classes)
    {
        GtkWidgetExterns.gtk_widget_set_css_classes(widget, classes);
        return widget;
    }

    public static GtkWidgetHandle ActionSetEnabled(this GtkWidgetHandle widget, string action_name, int enabled)
    {
        GtkWidgetExterns.gtk_widget_action_set_enabled(widget, action_name, enabled);
        return widget;
    }

    public static int GtkDragCheckThreshold(this GtkWidgetHandle widget, int start_x, int start_y, int current_x, int current_y)
    {
        return GtkWidgetExterns.gtk_drag_check_threshold(widget, start_x, start_y, current_x, current_y);
    }

    public static GtkWidgetHandle GtkTestWidgetWaitForDraw(this GtkWidgetHandle widget)
    {
        GtkWidgetExterns.gtk_test_widget_wait_for_draw(widget);
        return widget;
    }

    public static GdkPaintableHandle PaintableNew(this GtkWidgetHandle widget)
    {
        return GtkWidgetExterns.gtk_widget_paintable_new(widget);
    }
}
