using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkWidgetHandle : GInitiallyUnownedHandle
{
	public static GtkTextDirection GetDefaultDirection()
	{
		return GtkWidgetExterns.gtk_widget_get_default_direction();
	}

	public static void SetDefaultDirection(GtkTextDirection dir)
	{
		GtkWidgetExterns.gtk_widget_set_default_direction(dir);
	}

}

public class GtkWidgetSignal
{
	public string Value { get; set; }
	public GtkWidgetSignal(string value) => Value = value;
}

public static class GtkWidgetSignals
{
	public static GtkWidgetSignal Destroy = new("destroy");
	public static GtkWidgetSignal DirectionChanged = new("direction-changed");
	public static GtkWidgetSignal Hide = new("hide");
	public static GtkWidgetSignal KeynavFailed = new("keynav-failed");
	public static GtkWidgetSignal Map = new("map");
	public static GtkWidgetSignal MnemonicActivate = new("mnemonic-activate");
	public static GtkWidgetSignal MoveFocus = new("move-focus");
	public static GtkWidgetSignal QueryTooltip = new("query-tooltip");
	public static GtkWidgetSignal Realize = new("realize");
	public static GtkWidgetSignal Show = new("show");
	public static GtkWidgetSignal StateFlagsChanged = new("state-flags-changed");
	public static GtkWidgetSignal Unmap = new("unmap");
	public static GtkWidgetSignal Unrealize = new("unrealize");
}

public static class GtkWidgetHandleExtensions
{
	public static GtkWidgetHandle ActionSetEnabled(this GtkWidgetHandle widget, string action_name, bool enabled)
	{
		GtkWidgetExterns.gtk_widget_action_set_enabled(widget, action_name, enabled);
		return widget;
	}

	public static bool Activate(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_activate(widget);
	}

	public static bool ActivateAction(this GtkWidgetHandle widget, string name, string format_string, IntPtr @__arglist)
	{
		return GtkWidgetExterns.gtk_widget_activate_action(widget, name, format_string, @__arglist);
	}

	public static bool ActivateActionVariant(this GtkWidgetHandle widget, string name, GVariantHandle args)
	{
		return GtkWidgetExterns.gtk_widget_activate_action_variant(widget, name, args);
	}

	public static GtkWidgetHandle ActivateDefault(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_activate_default(widget);
		return widget;
	}

	public static GtkWidgetHandle AddController(this GtkWidgetHandle widget, GtkEventControllerHandle controller)
	{
		GtkWidgetExterns.gtk_widget_add_controller(widget, controller);
		return widget;
	}

	public static GtkWidgetHandle AddCssClass(this GtkWidgetHandle widget, string css_class)
	{
		GtkWidgetExterns.gtk_widget_add_css_class(widget, css_class);
		return widget;
	}

	public static GtkWidgetHandle AddMnemonicLabel(this GtkWidgetHandle widget, GtkWidgetHandle label)
	{
		GtkWidgetExterns.gtk_widget_add_mnemonic_label(widget, label);
		return widget;
	}

	public static uint AddTickCallback(this GtkWidgetHandle widget, GtkTickCallback callback, IntPtr user_data, GDestroyNotify notify)
	{
		return GtkWidgetExterns.gtk_widget_add_tick_callback(widget, callback, user_data, notify);
	}

	public static GtkWidgetHandle Allocate(this GtkWidgetHandle widget, int width, int height, int baseline, GskTransformHandle transform)
	{
		GtkWidgetExterns.gtk_widget_allocate(widget, width, height, baseline, transform);
		return widget;
	}

	public static bool ChildFocus(this GtkWidgetHandle widget, GtkDirectionType direction)
	{
		return GtkWidgetExterns.gtk_widget_child_focus(widget, direction);
	}

	public static bool ComputeBounds(this GtkWidgetHandle widget, GtkWidgetHandle target, out graphene_rect_t out_bounds)
	{
		return GtkWidgetExterns.gtk_widget_compute_bounds(widget, target, out out_bounds);
	}

	public static bool ComputeExpand(this GtkWidgetHandle widget, GtkOrientation orientation)
	{
		return GtkWidgetExterns.gtk_widget_compute_expand(widget, orientation);
	}

	public static bool ComputePoint(this GtkWidgetHandle widget, GtkWidgetHandle target, graphene_point_tHandle point, out graphene_point_t out_point)
	{
		return GtkWidgetExterns.gtk_widget_compute_point(widget, target, point, out out_point);
	}

	public static bool ComputeTransform(this GtkWidgetHandle widget, GtkWidgetHandle target, out graphene_matrix_t out_transform)
	{
		return GtkWidgetExterns.gtk_widget_compute_transform(widget, target, out out_transform);
	}

	public static bool Contains(this GtkWidgetHandle widget, double x, double y)
	{
		return GtkWidgetExterns.gtk_widget_contains(widget, x, y);
	}

	public static PangoContextHandle CreatePangoContext(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_create_pango_context(widget);
	}

	public static PangoLayoutHandle CreatePangoLayout(this GtkWidgetHandle widget, string text)
	{
		return GtkWidgetExterns.gtk_widget_create_pango_layout(widget, text);
	}

	public static GtkWidgetHandle DisposeTemplate(this GtkWidgetHandle widget, GType widget_type)
	{
		GtkWidgetExterns.gtk_widget_dispose_template(widget, widget_type);
		return widget;
	}

	public static bool GtkDragCheckThreshold(this GtkWidgetHandle widget, int start_x, int start_y, int current_x, int current_y)
	{
		return GtkWidgetExterns.gtk_drag_check_threshold(widget, start_x, start_y, current_x, current_y);
	}

	public static GtkWidgetHandle ErrorBell(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_error_bell(widget);
		return widget;
	}

	public static int GetAllocatedBaseline(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_allocated_baseline(widget);
	}

	public static int GetAllocatedHeight(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_allocated_height(widget);
	}

	public static int GetAllocatedWidth(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_allocated_width(widget);
	}

	public static GtkWidgetHandle GetAllocation(this GtkWidgetHandle widget, out GtkAllocation allocation)
	{
		GtkWidgetExterns.gtk_widget_get_allocation(widget, out allocation);
		return widget;
	}

	public static GtkWidgetHandle GetAncestor(this GtkWidgetHandle widget, GType widget_type)
	{
		return GtkWidgetExterns.gtk_widget_get_ancestor(widget, widget_type);
	}

	public static int GetBaseline(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_baseline(widget);
	}

	public static bool GetCanFocus(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_can_focus(widget);
	}

	public static bool GetCanTarget(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_can_target(widget);
	}

	public static bool GetChildVisible(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_child_visible(widget);
	}

	public static GdkClipboardHandle GetClipboard(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_clipboard(widget);
	}

	public static GtkWidgetHandle GetColor(this GtkWidgetHandle widget, out GdkRGBA color)
	{
		GtkWidgetExterns.gtk_widget_get_color(widget, out color);
		return widget;
	}

	public static string[] GetCssClasses(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_css_classes(widget);
	}

	public static string GetCssName(this GtkWidgetHandle self)
	{
		return GtkWidgetExterns.gtk_widget_get_css_name(self);
	}

	public static GdkCursorHandle GetCursor(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_cursor(widget);
	}

	public static GtkTextDirection GetDirection(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_direction(widget);
	}

	public static GdkDisplayHandle GetDisplay(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_display(widget);
	}

	public static GtkWidgetHandle GetFirstChild(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_first_child(widget);
	}

	public static GtkWidgetHandle GetFocusChild(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_focus_child(widget);
	}

	public static bool GetFocusOnClick(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_focus_on_click(widget);
	}

	public static bool GetFocusable(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_focusable(widget);
	}

	public static PangoFontMapHandle GetFontMap(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_font_map(widget);
	}

	public static cairo_font_options_tHandle GetFontOptions(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_font_options(widget);
	}

	public static GdkFrameClockHandle GetFrameClock(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_frame_clock(widget);
	}

	public static GtkAlign GetHalign(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_halign(widget);
	}

	public static bool GetHasTooltip(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_has_tooltip(widget);
	}

	public static int GetHeight(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_height(widget);
	}

	public static bool GetHexpand(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_hexpand(widget);
	}

	public static bool GetHexpandSet(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_hexpand_set(widget);
	}

	public static GtkWidgetHandle GetLastChild(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_last_child(widget);
	}

	public static GtkLayoutManagerHandle GetLayoutManager(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_layout_manager(widget);
	}

	public static bool GetMapped(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_mapped(widget);
	}

	public static int GetMarginBottom(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_margin_bottom(widget);
	}

	public static int GetMarginEnd(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_margin_end(widget);
	}

	public static int GetMarginStart(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_margin_start(widget);
	}

	public static int GetMarginTop(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_margin_top(widget);
	}

	public static string GetName(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_name(widget);
	}

	public static GtkNativeHandle GetNative(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_native(widget);
	}

	public static GtkWidgetHandle GetNextSibling(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_next_sibling(widget);
	}

	public static double GetOpacity(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_opacity(widget);
	}

	public static GtkOverflow GetOverflow(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_overflow(widget);
	}

	public static PangoContextHandle GetPangoContext(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_pango_context(widget);
	}

	public static GtkWidgetHandle GetParent(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_parent(widget);
	}

	public static GtkWidgetHandle GetPreferredSize(this GtkWidgetHandle widget, out GtkRequisition minimum_size, out GtkRequisition natural_size)
	{
		GtkWidgetExterns.gtk_widget_get_preferred_size(widget, out minimum_size, out natural_size);
		return widget;
	}

	public static GtkWidgetHandle GetPrevSibling(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_prev_sibling(widget);
	}

	public static GdkClipboardHandle GetPrimaryClipboard(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_primary_clipboard(widget);
	}

	public static bool GetRealized(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_realized(widget);
	}

	public static bool GetReceivesDefault(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_receives_default(widget);
	}

	public static GtkSizeRequestMode GetRequestMode(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_request_mode(widget);
	}

	public static GtkRootHandle GetRoot(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_root(widget);
	}

	public static int GetScaleFactor(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_scale_factor(widget);
	}

	public static bool GetSensitive(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_sensitive(widget);
	}

	public static GtkSettingsHandle GetSettings(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_settings(widget);
	}

	public static int GetSize(this GtkWidgetHandle widget, GtkOrientation orientation)
	{
		return GtkWidgetExterns.gtk_widget_get_size(widget, orientation);
	}

	public static GtkWidgetHandle GetSizeRequest(this GtkWidgetHandle widget, out int width, out int height)
	{
		GtkWidgetExterns.gtk_widget_get_size_request(widget, out width, out height);
		return widget;
	}

	public static GtkStateFlags GetStateFlags(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_state_flags(widget);
	}

	public static GtkStyleContextHandle GetStyleContext(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_style_context(widget);
	}

	public static GObjectHandle GetTemplateChild(this GtkWidgetHandle widget, GType widget_type, string name)
	{
		return GtkWidgetExterns.gtk_widget_get_template_child(widget, widget_type, name);
	}

	public static string GetTooltipMarkup(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_tooltip_markup(widget);
	}

	public static string GetTooltipText(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_tooltip_text(widget);
	}

	public static GtkAlign GetValign(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_valign(widget);
	}

	public static bool GetVexpand(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_vexpand(widget);
	}

	public static bool GetVexpandSet(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_vexpand_set(widget);
	}

	public static bool GetVisible(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_visible(widget);
	}

	public static int GetWidth(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_width(widget);
	}

	public static bool GrabFocus(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_grab_focus(widget);
	}

	public static bool HasCssClass(this GtkWidgetHandle widget, string css_class)
	{
		return GtkWidgetExterns.gtk_widget_has_css_class(widget, css_class);
	}

	public static bool HasDefault(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_has_default(widget);
	}

	public static bool HasFocus(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_has_focus(widget);
	}

	public static bool HasVisibleFocus(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_has_visible_focus(widget);
	}

	public static GtkWidgetHandle Hide(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_hide(widget);
		return widget;
	}

	public static bool InDestruction(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_in_destruction(widget);
	}

	public static GtkWidgetHandle InitTemplate(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_init_template(widget);
		return widget;
	}

	public static GtkWidgetHandle InsertActionGroup(this GtkWidgetHandle widget, string name, GActionGroupHandle group)
	{
		GtkWidgetExterns.gtk_widget_insert_action_group(widget, name, group);
		return widget;
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

	public static bool IsAncestor(this GtkWidgetHandle widget, GtkWidgetHandle ancestor)
	{
		return GtkWidgetExterns.gtk_widget_is_ancestor(widget, ancestor);
	}

	public static bool IsDrawable(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_is_drawable(widget);
	}

	public static bool IsFocus(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_is_focus(widget);
	}

	public static bool IsSensitive(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_is_sensitive(widget);
	}

	public static bool IsVisible(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_is_visible(widget);
	}

	public static bool KeynavFailed(this GtkWidgetHandle widget, GtkDirectionType direction)
	{
		return GtkWidgetExterns.gtk_widget_keynav_failed(widget, direction);
	}

	public static GListHandle ListMnemonicLabels(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_list_mnemonic_labels(widget);
	}

	public static GtkWidgetHandle Map(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_map(widget);
		return widget;
	}

	public static GtkWidgetHandle Measure(this GtkWidgetHandle widget, GtkOrientation orientation, int for_size, out int minimum, out int natural, out int minimum_baseline, out int natural_baseline)
	{
		GtkWidgetExterns.gtk_widget_measure(widget, orientation, for_size, out minimum, out natural, out minimum_baseline, out natural_baseline);
		return widget;
	}

	public static bool MnemonicActivate(this GtkWidgetHandle widget, bool group_cycling)
	{
		return GtkWidgetExterns.gtk_widget_mnemonic_activate(widget, group_cycling);
	}

	public static GListModelHandle ObserveChildren(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_observe_children(widget);
	}

	public static GListModelHandle ObserveControllers(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_observe_controllers(widget);
	}

	public static GtkWidgetHandle Pick(this GtkWidgetHandle widget, double x, double y, GtkPickFlags flags)
	{
		return GtkWidgetExterns.gtk_widget_pick(widget, x, y, flags);
	}

	public static GtkWidgetHandle QueueAllocate(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_queue_allocate(widget);
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

	public static GtkWidgetHandle Realize(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_realize(widget);
		return widget;
	}

	public static GtkWidgetHandle RemoveController(this GtkWidgetHandle widget, GtkEventControllerHandle controller)
	{
		GtkWidgetExterns.gtk_widget_remove_controller(widget, controller);
		return widget;
	}

	public static GtkWidgetHandle RemoveCssClass(this GtkWidgetHandle widget, string css_class)
	{
		GtkWidgetExterns.gtk_widget_remove_css_class(widget, css_class);
		return widget;
	}

	public static GtkWidgetHandle RemoveMnemonicLabel(this GtkWidgetHandle widget, GtkWidgetHandle label)
	{
		GtkWidgetExterns.gtk_widget_remove_mnemonic_label(widget, label);
		return widget;
	}

	public static GtkWidgetHandle RemoveTickCallback(this GtkWidgetHandle widget, uint id)
	{
		GtkWidgetExterns.gtk_widget_remove_tick_callback(widget, id);
		return widget;
	}

	public static GtkWidgetHandle SetCanFocus(this GtkWidgetHandle widget, bool can_focus)
	{
		GtkWidgetExterns.gtk_widget_set_can_focus(widget, can_focus);
		return widget;
	}

	public static GtkWidgetHandle SetCanTarget(this GtkWidgetHandle widget, bool can_target)
	{
		GtkWidgetExterns.gtk_widget_set_can_target(widget, can_target);
		return widget;
	}

	public static GtkWidgetHandle SetChildVisible(this GtkWidgetHandle widget, bool child_visible)
	{
		GtkWidgetExterns.gtk_widget_set_child_visible(widget, child_visible);
		return widget;
	}

	public static GtkWidgetHandle SetCssClasses(this GtkWidgetHandle widget, string[] classes)
	{
		GtkWidgetExterns.gtk_widget_set_css_classes(widget, classes);
		return widget;
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

	public static GtkWidgetHandle SetDirection(this GtkWidgetHandle widget, GtkTextDirection dir)
	{
		GtkWidgetExterns.gtk_widget_set_direction(widget, dir);
		return widget;
	}

	public static GtkWidgetHandle SetFocusChild(this GtkWidgetHandle widget, GtkWidgetHandle child)
	{
		GtkWidgetExterns.gtk_widget_set_focus_child(widget, child);
		return widget;
	}

	public static GtkWidgetHandle SetFocusOnClick(this GtkWidgetHandle widget, bool focus_on_click)
	{
		GtkWidgetExterns.gtk_widget_set_focus_on_click(widget, focus_on_click);
		return widget;
	}

	public static GtkWidgetHandle SetFocusable(this GtkWidgetHandle widget, bool focusable)
	{
		GtkWidgetExterns.gtk_widget_set_focusable(widget, focusable);
		return widget;
	}

	public static GtkWidgetHandle SetFontMap(this GtkWidgetHandle widget, PangoFontMapHandle font_map)
	{
		GtkWidgetExterns.gtk_widget_set_font_map(widget, font_map);
		return widget;
	}

	public static GtkWidgetHandle SetFontOptions(this GtkWidgetHandle widget, cairo_font_options_tHandle options)
	{
		GtkWidgetExterns.gtk_widget_set_font_options(widget, options);
		return widget;
	}

	public static GtkWidgetHandle SetHalign(this GtkWidgetHandle widget, GtkAlign align)
	{
		GtkWidgetExterns.gtk_widget_set_halign(widget, align);
		return widget;
	}

	public static GtkWidgetHandle SetHasTooltip(this GtkWidgetHandle widget, bool has_tooltip)
	{
		GtkWidgetExterns.gtk_widget_set_has_tooltip(widget, has_tooltip);
		return widget;
	}

	public static GtkWidgetHandle SetHexpand(this GtkWidgetHandle widget, bool expand)
	{
		GtkWidgetExterns.gtk_widget_set_hexpand(widget, expand);
		return widget;
	}

	public static GtkWidgetHandle SetHexpandSet(this GtkWidgetHandle widget, bool set)
	{
		GtkWidgetExterns.gtk_widget_set_hexpand_set(widget, set);
		return widget;
	}

	public static GtkWidgetHandle SetLayoutManager(this GtkWidgetHandle widget, GtkLayoutManagerHandle layout_manager)
	{
		GtkWidgetExterns.gtk_widget_set_layout_manager(widget, layout_manager);
		return widget;
	}

	public static GtkWidgetHandle SetMarginBottom(this GtkWidgetHandle widget, int margin)
	{
		GtkWidgetExterns.gtk_widget_set_margin_bottom(widget, margin);
		return widget;
	}

	public static GtkWidgetHandle SetMarginEnd(this GtkWidgetHandle widget, int margin)
	{
		GtkWidgetExterns.gtk_widget_set_margin_end(widget, margin);
		return widget;
	}

	public static GtkWidgetHandle SetMarginStart(this GtkWidgetHandle widget, int margin)
	{
		GtkWidgetExterns.gtk_widget_set_margin_start(widget, margin);
		return widget;
	}

	public static GtkWidgetHandle SetMarginTop(this GtkWidgetHandle widget, int margin)
	{
		GtkWidgetExterns.gtk_widget_set_margin_top(widget, margin);
		return widget;
	}

	public static GtkWidgetHandle SetName(this GtkWidgetHandle widget, string name)
	{
		GtkWidgetExterns.gtk_widget_set_name(widget, name);
		return widget;
	}

	public static GtkWidgetHandle SetOpacity(this GtkWidgetHandle widget, double opacity)
	{
		GtkWidgetExterns.gtk_widget_set_opacity(widget, opacity);
		return widget;
	}

	public static GtkWidgetHandle SetOverflow(this GtkWidgetHandle widget, GtkOverflow overflow)
	{
		GtkWidgetExterns.gtk_widget_set_overflow(widget, overflow);
		return widget;
	}

	public static GtkWidgetHandle SetParent(this GtkWidgetHandle widget, GtkWidgetHandle parent)
	{
		GtkWidgetExterns.gtk_widget_set_parent(widget, parent);
		return widget;
	}

	public static GtkWidgetHandle SetReceivesDefault(this GtkWidgetHandle widget, bool receives_default)
	{
		GtkWidgetExterns.gtk_widget_set_receives_default(widget, receives_default);
		return widget;
	}

	public static GtkWidgetHandle SetSensitive(this GtkWidgetHandle widget, bool sensitive)
	{
		GtkWidgetExterns.gtk_widget_set_sensitive(widget, sensitive);
		return widget;
	}

	public static GtkWidgetHandle SetSizeRequest(this GtkWidgetHandle widget, int width, int height)
	{
		GtkWidgetExterns.gtk_widget_set_size_request(widget, width, height);
		return widget;
	}

	public static GtkWidgetHandle SetStateFlags(this GtkWidgetHandle widget, GtkStateFlags flags, bool clear)
	{
		GtkWidgetExterns.gtk_widget_set_state_flags(widget, flags, clear);
		return widget;
	}

	public static GtkWidgetHandle SetTooltipMarkup(this GtkWidgetHandle widget, string markup)
	{
		GtkWidgetExterns.gtk_widget_set_tooltip_markup(widget, markup);
		return widget;
	}

	public static GtkWidgetHandle SetTooltipText(this GtkWidgetHandle widget, string text)
	{
		GtkWidgetExterns.gtk_widget_set_tooltip_text(widget, text);
		return widget;
	}

	public static GtkWidgetHandle SetValign(this GtkWidgetHandle widget, GtkAlign align)
	{
		GtkWidgetExterns.gtk_widget_set_valign(widget, align);
		return widget;
	}

	public static GtkWidgetHandle SetVexpand(this GtkWidgetHandle widget, bool expand)
	{
		GtkWidgetExterns.gtk_widget_set_vexpand(widget, expand);
		return widget;
	}

	public static GtkWidgetHandle SetVexpandSet(this GtkWidgetHandle widget, bool set)
	{
		GtkWidgetExterns.gtk_widget_set_vexpand_set(widget, set);
		return widget;
	}

	public static GtkWidgetHandle SetVisible(this GtkWidgetHandle widget, bool visible)
	{
		GtkWidgetExterns.gtk_widget_set_visible(widget, visible);
		return widget;
	}

	public static bool ShouldLayout(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_should_layout(widget);
	}

	public static GtkWidgetHandle Show(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_show(widget);
		return widget;
	}

	public static GtkWidgetHandle SizeAllocate(this GtkWidgetHandle widget, GtkAllocation[] allocation, int baseline)
	{
		GtkWidgetExterns.gtk_widget_size_allocate(widget, allocation, baseline);
		return widget;
	}

	public static GtkWidgetHandle SnapshotChild(this GtkWidgetHandle widget, GtkWidgetHandle child, GtkSnapshotHandle snapshot)
	{
		GtkWidgetExterns.gtk_widget_snapshot_child(widget, child, snapshot);
		return widget;
	}

	public static bool TranslateCoordinates(this GtkWidgetHandle src_widget, GtkWidgetHandle dest_widget, double src_x, double src_y, out double dest_x, out double dest_y)
	{
		return GtkWidgetExterns.gtk_widget_translate_coordinates(src_widget, dest_widget, src_x, src_y, out dest_x, out dest_y);
	}

	public static GtkWidgetHandle TriggerTooltipQuery(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_trigger_tooltip_query(widget);
		return widget;
	}

	public static GtkWidgetHandle Unmap(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_unmap(widget);
		return widget;
	}

	public static GtkWidgetHandle Unparent(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_unparent(widget);
		return widget;
	}

	public static GtkWidgetHandle Unrealize(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_unrealize(widget);
		return widget;
	}

	public static GtkWidgetHandle UnsetStateFlags(this GtkWidgetHandle widget, GtkStateFlags flags)
	{
		GtkWidgetExterns.gtk_widget_unset_state_flags(widget, flags);
		return widget;
	}

	public static GtkWidgetHandle GtkTestWidgetWaitForDraw(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_test_widget_wait_for_draw(widget);
		return widget;
	}

	public static GtkWidgetHandle Connect(this GtkWidgetHandle instance, GtkWidgetSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkWidgetExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_action_set_enabled(GtkWidgetHandle widget, string action_name, bool enabled);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_activate(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_activate_action(GtkWidgetHandle widget, string name, string format_string, IntPtr @__arglist);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_activate_action_variant(GtkWidgetHandle widget, string name, GVariantHandle args);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_activate_default(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_add_controller(GtkWidgetHandle widget, GtkEventControllerHandle controller);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_add_css_class(GtkWidgetHandle widget, string css_class);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_add_mnemonic_label(GtkWidgetHandle widget, GtkWidgetHandle label);
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_widget_add_tick_callback(GtkWidgetHandle widget, GtkTickCallback callback, IntPtr user_data, GDestroyNotify notify);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_allocate(GtkWidgetHandle widget, int width, int height, int baseline, GskTransformHandle transform);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_child_focus(GtkWidgetHandle widget, GtkDirectionType direction);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_compute_bounds(GtkWidgetHandle widget, GtkWidgetHandle target, out graphene_rect_t out_bounds);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_compute_expand(GtkWidgetHandle widget, GtkOrientation orientation);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_compute_point(GtkWidgetHandle widget, GtkWidgetHandle target, graphene_point_tHandle point, out graphene_point_t out_point);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_compute_transform(GtkWidgetHandle widget, GtkWidgetHandle target, out graphene_matrix_t out_transform);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_contains(GtkWidgetHandle widget, double x, double y);
	[DllImport(Libraries.Gtk4)]
	internal static extern PangoContextHandle gtk_widget_create_pango_context(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern PangoLayoutHandle gtk_widget_create_pango_layout(GtkWidgetHandle widget, string text);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_dispose_template(GtkWidgetHandle widget, GType widget_type);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_drag_check_threshold(GtkWidgetHandle widget, int start_x, int start_y, int current_x, int current_y);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_error_bell(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_widget_get_allocated_baseline(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_widget_get_allocated_height(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_widget_get_allocated_width(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_get_allocation(GtkWidgetHandle widget, out GtkAllocation allocation);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_widget_get_ancestor(GtkWidgetHandle widget, GType widget_type);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_widget_get_baseline(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_get_can_focus(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_get_can_target(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_get_child_visible(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkClipboardHandle gtk_widget_get_clipboard(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_get_color(GtkWidgetHandle widget, out GdkRGBA color);
	[DllImport(Libraries.Gtk4)]
	internal static extern string[] gtk_widget_get_css_classes(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_widget_get_css_name(GtkWidgetHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkCursorHandle gtk_widget_get_cursor(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextDirection gtk_widget_get_direction(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDisplayHandle gtk_widget_get_display(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_widget_get_first_child(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_widget_get_focus_child(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_get_focus_on_click(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_get_focusable(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern PangoFontMapHandle gtk_widget_get_font_map(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern cairo_font_options_tHandle gtk_widget_get_font_options(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkFrameClockHandle gtk_widget_get_frame_clock(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAlign gtk_widget_get_halign(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_get_has_tooltip(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_widget_get_height(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_get_hexpand(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_get_hexpand_set(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_widget_get_last_child(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkLayoutManagerHandle gtk_widget_get_layout_manager(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_get_mapped(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_widget_get_margin_bottom(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_widget_get_margin_end(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_widget_get_margin_start(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_widget_get_margin_top(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_widget_get_name(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkNativeHandle gtk_widget_get_native(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_widget_get_next_sibling(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_widget_get_opacity(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkOverflow gtk_widget_get_overflow(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern PangoContextHandle gtk_widget_get_pango_context(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_widget_get_parent(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_get_preferred_size(GtkWidgetHandle widget, out GtkRequisition minimum_size, out GtkRequisition natural_size);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_widget_get_prev_sibling(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkClipboardHandle gtk_widget_get_primary_clipboard(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_get_realized(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_get_receives_default(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSizeRequestMode gtk_widget_get_request_mode(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkRootHandle gtk_widget_get_root(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_widget_get_scale_factor(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_get_sensitive(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSettingsHandle gtk_widget_get_settings(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_widget_get_size(GtkWidgetHandle widget, GtkOrientation orientation);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_get_size_request(GtkWidgetHandle widget, out int width, out int height);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkStateFlags gtk_widget_get_state_flags(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkStyleContextHandle gtk_widget_get_style_context(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GObjectHandle gtk_widget_get_template_child(GtkWidgetHandle widget, GType widget_type, string name);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_widget_get_tooltip_markup(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_widget_get_tooltip_text(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAlign gtk_widget_get_valign(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_get_vexpand(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_get_vexpand_set(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_get_visible(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_widget_get_width(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_grab_focus(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_has_css_class(GtkWidgetHandle widget, string css_class);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_has_default(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_has_focus(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_has_visible_focus(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_hide(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_in_destruction(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_init_template(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_insert_action_group(GtkWidgetHandle widget, string name, GActionGroupHandle group);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_insert_after(GtkWidgetHandle widget, GtkWidgetHandle parent, GtkWidgetHandle previous_sibling);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_insert_before(GtkWidgetHandle widget, GtkWidgetHandle parent, GtkWidgetHandle next_sibling);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_is_ancestor(GtkWidgetHandle widget, GtkWidgetHandle ancestor);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_is_drawable(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_is_focus(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_is_sensitive(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_is_visible(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_keynav_failed(GtkWidgetHandle widget, GtkDirectionType direction);
	[DllImport(Libraries.Gtk4)]
	internal static extern GListHandle gtk_widget_list_mnemonic_labels(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_map(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_measure(GtkWidgetHandle widget, GtkOrientation orientation, int for_size, out int minimum, out int natural, out int minimum_baseline, out int natural_baseline);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_mnemonic_activate(GtkWidgetHandle widget, bool group_cycling);
	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_widget_observe_children(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_widget_observe_controllers(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_widget_pick(GtkWidgetHandle widget, double x, double y, GtkPickFlags flags);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_queue_allocate(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_queue_draw(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_queue_resize(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_realize(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_remove_controller(GtkWidgetHandle widget, GtkEventControllerHandle controller);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_remove_css_class(GtkWidgetHandle widget, string css_class);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_remove_mnemonic_label(GtkWidgetHandle widget, GtkWidgetHandle label);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_remove_tick_callback(GtkWidgetHandle widget, uint id);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_can_focus(GtkWidgetHandle widget, bool can_focus);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_can_target(GtkWidgetHandle widget, bool can_target);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_child_visible(GtkWidgetHandle widget, bool child_visible);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_css_classes(GtkWidgetHandle widget, string[] classes);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_cursor(GtkWidgetHandle widget, GdkCursorHandle cursor);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_cursor_from_name(GtkWidgetHandle widget, string name);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_direction(GtkWidgetHandle widget, GtkTextDirection dir);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_focus_child(GtkWidgetHandle widget, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_focus_on_click(GtkWidgetHandle widget, bool focus_on_click);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_focusable(GtkWidgetHandle widget, bool focusable);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_font_map(GtkWidgetHandle widget, PangoFontMapHandle font_map);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_font_options(GtkWidgetHandle widget, cairo_font_options_tHandle options);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_halign(GtkWidgetHandle widget, GtkAlign align);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_has_tooltip(GtkWidgetHandle widget, bool has_tooltip);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_hexpand(GtkWidgetHandle widget, bool expand);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_hexpand_set(GtkWidgetHandle widget, bool set);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_layout_manager(GtkWidgetHandle widget, GtkLayoutManagerHandle layout_manager);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_margin_bottom(GtkWidgetHandle widget, int margin);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_margin_end(GtkWidgetHandle widget, int margin);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_margin_start(GtkWidgetHandle widget, int margin);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_margin_top(GtkWidgetHandle widget, int margin);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_name(GtkWidgetHandle widget, string name);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_opacity(GtkWidgetHandle widget, double opacity);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_overflow(GtkWidgetHandle widget, GtkOverflow overflow);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_parent(GtkWidgetHandle widget, GtkWidgetHandle parent);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_receives_default(GtkWidgetHandle widget, bool receives_default);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_sensitive(GtkWidgetHandle widget, bool sensitive);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_size_request(GtkWidgetHandle widget, int width, int height);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_state_flags(GtkWidgetHandle widget, GtkStateFlags flags, bool clear);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_tooltip_markup(GtkWidgetHandle widget, string markup);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_tooltip_text(GtkWidgetHandle widget, string text);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_valign(GtkWidgetHandle widget, GtkAlign align);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_vexpand(GtkWidgetHandle widget, bool expand);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_vexpand_set(GtkWidgetHandle widget, bool set);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_visible(GtkWidgetHandle widget, bool visible);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_should_layout(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_show(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_size_allocate(GtkWidgetHandle widget, GtkAllocation[] allocation, int baseline);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_snapshot_child(GtkWidgetHandle widget, GtkWidgetHandle child, GtkSnapshotHandle snapshot);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_widget_translate_coordinates(GtkWidgetHandle src_widget, GtkWidgetHandle dest_widget, double src_x, double src_y, out double dest_x, out double dest_y);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_trigger_tooltip_query(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_unmap(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_unparent(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_unrealize(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_unset_state_flags(GtkWidgetHandle widget, GtkStateFlags flags);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_test_widget_wait_for_draw(GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextDirection gtk_widget_get_default_direction();
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_widget_set_default_direction(GtkTextDirection dir);
}
