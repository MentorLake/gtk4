using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Pixbuf;

namespace MentorLake.Gtk4.Gtk;
public class GtkATContextClassHandle : GObjectHandle
{
}

public class GtkATContextHandle : GObjectHandle
{
}

public class GtkAccessibleHandle : GObjectHandle
{
}

public class GtkAccessibleInterfaceHandle : GObjectHandle
{
}

public class GtkActionableHandle : GObjectHandle
{
}

public class GtkActionableInterfaceHandle : GObjectHandle
{
}

public class GtkActivateActionClassHandle : GObjectHandle
{
}

public class GtkActivateActionHandle : GObjectHandle
{
}

public class GtkAdjustmentClassHandle : GObjectHandle
{
}

public class GtkAdjustmentHandle : GObjectHandle
{
	public static GtkAdjustmentHandle New(double value, double lower, double upper, double step_increment, double page_increment, double page_size)
	{
		return GtkAdjustmentExterns.gtk_adjustment_new(value, lower, upper, step_increment, page_increment, page_size);
	}
}

public class GtkAllocationHandle : GObjectHandle
{
}

public class GtkAlternativeTriggerClassHandle : GObjectHandle
{
}

public class GtkAlternativeTriggerHandle : GObjectHandle
{
}

public class GtkAnyFilterClassHandle : GObjectHandle
{
}

public class GtkAnyFilterHandle : GObjectHandle
{
	public static GtkAnyFilterHandle New()
	{
		return GtkAnyFilterExterns.gtk_any_filter_new();
	}
}

public class GtkAppChooserDialogHandle : GObjectHandle
{
}

public class GtkAppChooserHandle : GObjectHandle
{
}

public class GtkApplicationClassHandle : GObjectHandle
{
}

public class GtkApplicationWindowClassHandle : GObjectHandle
{
}

public class GtkAssistantPageHandle : GObjectHandle
{
}

public class GtkBinLayoutClassHandle : GObjectHandle
{
}

public class GtkBinLayoutHandle : GObjectHandle
{
}

public class GtkBitsetHandle : GObjectHandle
{
	public static GtkBitsetHandle NewEmpty()
	{
		return GtkBitsetExterns.gtk_bitset_new_empty();
	}

	public static GtkBitsetHandle NewRange(uint start, uint n_items)
	{
		return GtkBitsetExterns.gtk_bitset_new_range(start, n_items);
	}
}

public class GtkBitsetIterHandle : GObjectHandle
{
}

public class GtkBookmarkListClassHandle : GObjectHandle
{
}

public class GtkBookmarkListHandle : GObjectHandle
{
	public static GtkBookmarkListHandle New(string filename, string attributes)
	{
		return GtkBookmarkListExterns.gtk_bookmark_list_new(filename, attributes);
	}
}

public class GtkBoolFilterClassHandle : GObjectHandle
{
}

public class GtkBoolFilterHandle : GObjectHandle
{
}

public class GtkBorderHandle : GObjectHandle
{
	public static GtkBorderHandle New()
	{
		return GtkBorderExterns.gtk_border_new();
	}
}

public class GtkBoxClassHandle : GObjectHandle
{
}

public class GtkBoxLayoutClassHandle : GObjectHandle
{
}

public class GtkBoxLayoutHandle : GObjectHandle
{
}

public class GtkBuildableHandle : GObjectHandle
{
}

public class GtkBuildableIfaceHandle : GObjectHandle
{
}

public class GtkBuildableParseContextHandle : GObjectHandle
{
}

public class GtkBuildableParserHandle : GObjectHandle
{
}

public class GtkBuilderCScopeClassHandle : GObjectHandle
{
}

public class GtkBuilderCScopeHandle : GObjectHandle
{
}

public class GtkBuilderClassHandle : GObjectHandle
{
}

public class GtkBuilderHandle : GObjectHandle
{
	public static GtkBuilderHandle New()
	{
		return GtkBuilderExterns.gtk_builder_new();
	}

	public static GtkBuilderHandle NewFromFile(string filename)
	{
		return GtkBuilderExterns.gtk_builder_new_from_file(filename);
	}

	public static GtkBuilderHandle NewFromResource(string resource_path)
	{
		return GtkBuilderExterns.gtk_builder_new_from_resource(resource_path);
	}

	public static GtkBuilderHandle NewFromString(string @string, nint length)
	{
		return GtkBuilderExterns.gtk_builder_new_from_string(@string, length);
	}
}

public class GtkBuilderListItemFactoryClassHandle : GObjectHandle
{
}

public class GtkBuilderListItemFactoryHandle : GObjectHandle
{
}

public class GtkBuilderScopeHandle : GObjectHandle
{
	public static GtkBuilderScopeHandle GtkBuilderCscopeNew()
	{
		return GtkBuilderScopeExterns.gtk_builder_cscope_new();
	}
}

public class GtkBuilderScopeInterfaceHandle : GObjectHandle
{
}

public class GtkButtonClassHandle : GObjectHandle
{
}

public class GtkButtonPrivateHandle : GObjectHandle
{
}

public class GtkCClosureExpressionHandle : GObjectHandle
{
}

public class GtkCallbackActionClassHandle : GObjectHandle
{
}

public class GtkCallbackActionHandle : GObjectHandle
{
}

public class GtkCellAreaBoxHandle : GObjectHandle
{
}

public class GtkCellAreaClassHandle : GObjectHandle
{
}

public class GtkCellAreaContextClassHandle : GObjectHandle
{
}

public class GtkCellAreaContextHandle : GObjectHandle
{
}

public class GtkCellAreaContextPrivateHandle : GObjectHandle
{
}

public class GtkCellAreaHandle : GObjectHandle
{
	public static GtkCellAreaHandle BoxNew()
	{
		return GtkCellAreaExterns.gtk_cell_area_box_new();
	}
}

public class GtkCellEditableHandle : GObjectHandle
{
}

public class GtkCellEditableIfaceHandle : GObjectHandle
{
}

public class GtkCellLayoutHandle : GObjectHandle
{
}

public class GtkCellLayoutIfaceHandle : GObjectHandle
{
}

public class GtkCellRendererAccelHandle : GObjectHandle
{
}

public class GtkCellRendererClassHandle : GObjectHandle
{
}

public class GtkCellRendererClassPrivateHandle : GObjectHandle
{
}

public class GtkCellRendererComboHandle : GObjectHandle
{
}

public class GtkCellRendererHandle : GObjectHandle
{
	public static GtkCellRendererHandle TextNew()
	{
		return GtkCellRendererExterns.gtk_cell_renderer_text_new();
	}

	public static GtkCellRendererHandle AccelNew()
	{
		return GtkCellRendererExterns.gtk_cell_renderer_accel_new();
	}

	public static GtkCellRendererHandle ComboNew()
	{
		return GtkCellRendererExterns.gtk_cell_renderer_combo_new();
	}

	public static GtkCellRendererHandle PixbufNew()
	{
		return GtkCellRendererExterns.gtk_cell_renderer_pixbuf_new();
	}

	public static GtkCellRendererHandle ProgressNew()
	{
		return GtkCellRendererExterns.gtk_cell_renderer_progress_new();
	}

	public static GtkCellRendererHandle SpinNew()
	{
		return GtkCellRendererExterns.gtk_cell_renderer_spin_new();
	}

	public static GtkCellRendererHandle SpinnerNew()
	{
		return GtkCellRendererExterns.gtk_cell_renderer_spinner_new();
	}

	public static GtkCellRendererHandle ToggleNew()
	{
		return GtkCellRendererExterns.gtk_cell_renderer_toggle_new();
	}
}

public class GtkCellRendererPixbufHandle : GObjectHandle
{
}

public class GtkCellRendererPrivateHandle : GObjectHandle
{
}

public class GtkCellRendererProgressHandle : GObjectHandle
{
}

public class GtkCellRendererSpinHandle : GObjectHandle
{
}

public class GtkCellRendererSpinnerHandle : GObjectHandle
{
}

public class GtkCellRendererTextClassHandle : GObjectHandle
{
}

public class GtkCellRendererTextHandle : GObjectHandle
{
}

public class GtkCellRendererToggleHandle : GObjectHandle
{
}

public class GtkCenterBoxClassHandle : GObjectHandle
{
}

public class GtkCenterLayoutClassHandle : GObjectHandle
{
}

public class GtkCenterLayoutHandle : GObjectHandle
{
}

public class GtkCheckButtonClassHandle : GObjectHandle
{
}

public class GtkClosureExpressionHandle : GObjectHandle
{
}

public class GtkColorChooserDialogHandle : GObjectHandle
{
	public static GtkColorChooserDialogHandle New(string title, GtkWindowHandle parent)
	{
		return GtkColorChooserDialogExterns.gtk_color_chooser_dialog_new(title, parent);
	}
}

public class GtkColorChooserHandle : GObjectHandle
{
}

public class GtkColorChooserInterfaceHandle : GObjectHandle
{
}

public class GtkColumnViewClassHandle : GObjectHandle
{
}

public class GtkColumnViewColumnClassHandle : GObjectHandle
{
}

public class GtkColumnViewColumnHandle : GObjectHandle
{
	public static GtkColumnViewColumnHandle New(string title, GtkListItemFactoryHandle factory)
	{
		return GtkColumnViewColumnExterns.gtk_column_view_column_new(title, factory);
	}
}

public class GtkComboBoxClassHandle : GObjectHandle
{
}

public class GtkComboBoxTextHandle : GObjectHandle
{
	public static GtkComboBoxTextHandle New()
	{
		return GtkComboBoxTextExterns.gtk_combo_box_text_new();
	}

	public static GtkComboBoxTextHandle NewWithEntry()
	{
		return GtkComboBoxTextExterns.gtk_combo_box_text_new_with_entry();
	}
}

public class GtkConstantExpressionHandle : GObjectHandle
{
}

public class GtkConstraintClassHandle : GObjectHandle
{
}

public class GtkConstraintGuideClassHandle : GObjectHandle
{
}

public class GtkConstraintGuideHandle : GObjectHandle
{
	public static GtkConstraintGuideHandle New()
	{
		return GtkConstraintGuideExterns.gtk_constraint_guide_new();
	}
}

public class GtkConstraintHandle : GObjectHandle
{
	public static GtkConstraintHandle New(IntPtr target, GtkConstraintAttribute target_attribute, GtkConstraintRelation relation, IntPtr source, GtkConstraintAttribute source_attribute, double multiplier, double constant, int strength)
	{
		return GtkConstraintExterns.gtk_constraint_new(target, target_attribute, relation, source, source_attribute, multiplier, constant, strength);
	}

	public static GtkConstraintHandle NewConstant(IntPtr target, GtkConstraintAttribute target_attribute, GtkConstraintRelation relation, double constant, int strength)
	{
		return GtkConstraintExterns.gtk_constraint_new_constant(target, target_attribute, relation, constant, strength);
	}
}

public class GtkConstraintLayoutChildClassHandle : GObjectHandle
{
}

public class GtkConstraintLayoutChildHandle : GObjectHandle
{
}

public class GtkConstraintLayoutClassHandle : GObjectHandle
{
}

public class GtkConstraintLayoutHandle : GObjectHandle
{
}

public class GtkConstraintTargetHandle : GObjectHandle
{
}

public class GtkConstraintTargetInterfaceHandle : GObjectHandle
{
}

public class GtkCssLocationHandle : GObjectHandle
{
}

public class GtkCssProviderClassHandle : GObjectHandle
{
}

public class GtkCssProviderHandle : GObjectHandle
{
	public static GtkCssProviderHandle New()
	{
		return GtkCssProviderExterns.gtk_css_provider_new();
	}
}

public class GtkCssProviderPrivateHandle : GObjectHandle
{
}

public class GtkCssSectionHandle : GObjectHandle
{
	public static GtkCssSectionHandle New(GFileHandle file, GtkCssLocationHandle start, GtkCssLocationHandle end)
	{
		return GtkCssSectionExterns.gtk_css_section_new(file, start, end);
	}
}

public class GtkCssStyleChangeHandle : GObjectHandle
{
}

public class GtkCustomFilterClassHandle : GObjectHandle
{
}

public class GtkCustomFilterHandle : GObjectHandle
{
	public static GtkCustomFilterHandle New(GtkCustomFilterFunc match_func, IntPtr user_data, GDestroyNotify user_destroy)
	{
		return GtkCustomFilterExterns.gtk_custom_filter_new(match_func, user_data, user_destroy);
	}
}

public class GtkCustomLayoutClassHandle : GObjectHandle
{
}

public class GtkCustomLayoutHandle : GObjectHandle
{
}

public class GtkCustomSorterClassHandle : GObjectHandle
{
}

public class GtkCustomSorterHandle : GObjectHandle
{
	public static GtkCustomSorterHandle New(GCompareDataFunc sort_func, IntPtr user_data, GDestroyNotify user_destroy)
	{
		return GtkCustomSorterExterns.gtk_custom_sorter_new(sort_func, user_data, user_destroy);
	}
}

public class GtkDialogClassHandle : GObjectHandle
{
}

public class GtkDirectoryListClassHandle : GObjectHandle
{
}

public class GtkDirectoryListHandle : GObjectHandle
{
	public static GtkDirectoryListHandle New(string attributes, GFileHandle file)
	{
		return GtkDirectoryListExterns.gtk_directory_list_new(attributes, file);
	}
}

public class GtkDragIconClassHandle : GObjectHandle
{
}

public class GtkDragSourceClassHandle : GObjectHandle
{
}

public class GtkDragSourceHandle : GObjectHandle
{
	public static GtkDragSourceHandle New()
	{
		return GtkDragSourceExterns.gtk_drag_source_new();
	}
}

public class GtkDrawingAreaClassHandle : GObjectHandle
{
}

public class GtkDropControllerMotionClassHandle : GObjectHandle
{
}

public class GtkDropControllerMotionHandle : GObjectHandle
{
}

public class GtkDropDownClassHandle : GObjectHandle
{
}

public class GtkDropTargetAsyncClassHandle : GObjectHandle
{
}

public class GtkDropTargetAsyncHandle : GObjectHandle
{
	public static GtkDropTargetAsyncHandle New(GdkContentFormatsHandle formats, GdkDragAction actions)
	{
		return GtkDropTargetAsyncExterns.gtk_drop_target_async_new(formats, actions);
	}
}

public class GtkDropTargetClassHandle : GObjectHandle
{
}

public class GtkDropTargetHandle : GObjectHandle
{
	public static GtkDropTargetHandle New(GType type, GdkDragAction actions)
	{
		return GtkDropTargetExterns.gtk_drop_target_new(type, actions);
	}
}

public class GtkEditableHandle : GObjectHandle
{
}

public class GtkEditableInterfaceHandle : GObjectHandle
{
}

public class GtkEditableLabelClassHandle : GObjectHandle
{
}

public class GtkEmojiChooserClassHandle : GObjectHandle
{
}

public class GtkEmojiChooserHandle : GObjectHandle
{
	public static GtkEmojiChooserHandle New()
	{
		return GtkEmojiChooserExterns.gtk_emoji_chooser_new();
	}
}

public class GtkEntryBufferClassHandle : GObjectHandle
{
}

public class GtkEntryBufferHandle : GObjectHandle
{
	public static GtkEntryBufferHandle New(string initial_chars, int n_initial_chars)
	{
		return GtkEntryBufferExterns.gtk_entry_buffer_new(initial_chars, n_initial_chars);
	}

	public static GtkEntryBufferHandle GtkPasswordEntryBufferNew()
	{
		return GtkEntryBufferExterns.gtk_password_entry_buffer_new();
	}
}

public class GtkEntryClassHandle : GObjectHandle
{
}

public class GtkEntryCompletionHandle : GObjectHandle
{
	public static GtkEntryCompletionHandle New()
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_new();
	}
}

public class GtkEventControllerClassHandle : GObjectHandle
{
}

public class GtkEventControllerFocusClassHandle : GObjectHandle
{
}

public class GtkEventControllerFocusHandle : GObjectHandle
{
}

public class GtkEventControllerHandle : GObjectHandle
{
	public static GtkEventControllerHandle GtkDropControllerMotionNew()
	{
		return GtkEventControllerExterns.gtk_drop_controller_motion_new();
	}

	public static GtkEventControllerHandle FocusNew()
	{
		return GtkEventControllerExterns.gtk_event_controller_focus_new();
	}

	public static GtkEventControllerHandle KeyNew()
	{
		return GtkEventControllerExterns.gtk_event_controller_key_new();
	}

	public static GtkEventControllerHandle LegacyNew()
	{
		return GtkEventControllerExterns.gtk_event_controller_legacy_new();
	}

	public static GtkEventControllerHandle MotionNew()
	{
		return GtkEventControllerExterns.gtk_event_controller_motion_new();
	}

	public static GtkEventControllerHandle ScrollNew(GtkEventControllerScrollFlags flags)
	{
		return GtkEventControllerExterns.gtk_event_controller_scroll_new(flags);
	}

	public static GtkEventControllerHandle GtkShortcutControllerNew()
	{
		return GtkEventControllerExterns.gtk_shortcut_controller_new();
	}

	public static GtkEventControllerHandle GtkShortcutControllerNewForModel(GListModelHandle model)
	{
		return GtkEventControllerExterns.gtk_shortcut_controller_new_for_model(model);
	}
}

public class GtkEventControllerKeyClassHandle : GObjectHandle
{
}

public class GtkEventControllerKeyHandle : GObjectHandle
{
}

public class GtkEventControllerLegacyClassHandle : GObjectHandle
{
}

public class GtkEventControllerLegacyHandle : GObjectHandle
{
}

public class GtkEventControllerMotionClassHandle : GObjectHandle
{
}

public class GtkEventControllerMotionHandle : GObjectHandle
{
}

public class GtkEventControllerScrollClassHandle : GObjectHandle
{
}

public class GtkEventControllerScrollHandle : GObjectHandle
{
}

public class GtkEveryFilterClassHandle : GObjectHandle
{
}

public class GtkEveryFilterHandle : GObjectHandle
{
	public static GtkEveryFilterHandle New()
	{
		return GtkEveryFilterExterns.gtk_every_filter_new();
	}
}

public class GtkExpressionHandle : GObjectHandle
{
	public static GtkExpressionHandle GtkPropertyExpressionNew(GType this_type, GtkExpressionHandle expression, string property_name)
	{
		return GtkExpressionExterns.gtk_property_expression_new(this_type, expression, property_name);
	}

	public static GtkExpressionHandle GtkConstantExpressionNew(GType value_type, IntPtr @__arglist)
	{
		return GtkExpressionExterns.gtk_constant_expression_new(value_type, @__arglist);
	}

	public static GtkExpressionHandle GtkConstantExpressionNewForValue(GValueHandle value)
	{
		return GtkExpressionExterns.gtk_constant_expression_new_for_value(value);
	}

	public static GtkExpressionHandle GtkObjectExpressionNew(GObjectHandle @object)
	{
		return GtkExpressionExterns.gtk_object_expression_new(@object);
	}

	public static GtkExpressionHandle GtkClosureExpressionNew(GType value_type, GClosureHandle closure, uint n_params, out GtkExpression[] @params)
	{
		return GtkExpressionExterns.gtk_closure_expression_new(value_type, closure, n_params, out @params);
	}

	public static GtkExpressionHandle GtkCclosureExpressionNew(GType value_type, GClosureMarshal marshal, uint n_params, GtkExpression[] @params, GCallback callback_func, IntPtr user_data, GClosureNotify user_destroy)
	{
		return GtkExpressionExterns.gtk_cclosure_expression_new(value_type, marshal, n_params, @params, callback_func, user_data, user_destroy);
	}
}

public class GtkExpressionWatchHandle : GObjectHandle
{
}

public class GtkFileChooserDialogHandle : GObjectHandle
{
	public static GtkFileChooserDialogHandle New(string title, GtkWindowHandle parent, GtkFileChooserAction action, string first_button_text, IntPtr @__arglist)
	{
		return GtkFileChooserDialogExterns.gtk_file_chooser_dialog_new(title, parent, action, first_button_text, @__arglist);
	}
}

public class GtkFileChooserHandle : GObjectHandle
{
}

public class GtkFileChooserNativeClassHandle : GObjectHandle
{
}

public class GtkFileChooserNativeHandle : GObjectHandle
{
	public static GtkFileChooserNativeHandle New(string title, GtkWindowHandle parent, GtkFileChooserAction action, string accept_label, string cancel_label)
	{
		return GtkFileChooserNativeExterns.gtk_file_chooser_native_new(title, parent, action, accept_label, cancel_label);
	}
}

public class GtkFileFilterHandle : GObjectHandle
{
	public static GtkFileFilterHandle New()
	{
		return GtkFileFilterExterns.gtk_file_filter_new();
	}

	public static GtkFileFilterHandle NewFromGvariant(GVariantHandle variant)
	{
		return GtkFileFilterExterns.gtk_file_filter_new_from_gvariant(variant);
	}
}

public class GtkFilterClassHandle : GObjectHandle
{
}

public class GtkFilterHandle : GObjectHandle
{
}

public class GtkFilterListModelClassHandle : GObjectHandle
{
}

public class GtkFilterListModelHandle : GObjectHandle
{
	public static GtkFilterListModelHandle New(GListModelHandle model, GtkFilterHandle filter)
	{
		return GtkFilterListModelExterns.gtk_filter_list_model_new(model, filter);
	}
}

public class GtkFixedClassHandle : GObjectHandle
{
}

public class GtkFixedLayoutChildClassHandle : GObjectHandle
{
}

public class GtkFixedLayoutChildHandle : GObjectHandle
{
}

public class GtkFixedLayoutClassHandle : GObjectHandle
{
}

public class GtkFixedLayoutHandle : GObjectHandle
{
}

public class GtkFlattenListModelClassHandle : GObjectHandle
{
}

public class GtkFlattenListModelHandle : GObjectHandle
{
	public static GtkFlattenListModelHandle New(GListModelHandle model)
	{
		return GtkFlattenListModelExterns.gtk_flatten_list_model_new(model);
	}
}

public class GtkFlowBoxChildClassHandle : GObjectHandle
{
}

public class GtkFontChooserDialogHandle : GObjectHandle
{
	public static GtkFontChooserDialogHandle New(string title, GtkWindowHandle parent)
	{
		return GtkFontChooserDialogExterns.gtk_font_chooser_dialog_new(title, parent);
	}
}

public class GtkFontChooserHandle : GObjectHandle
{
}

public class GtkFontChooserIfaceHandle : GObjectHandle
{
}

public class GtkFrameClassHandle : GObjectHandle
{
}

public class GtkGLAreaClassHandle : GObjectHandle
{
}

public class GtkGestureClassHandle : GObjectHandle
{
}

public class GtkGestureClickClassHandle : GObjectHandle
{
}

public class GtkGestureClickHandle : GObjectHandle
{
}

public class GtkGestureDragClassHandle : GObjectHandle
{
}

public class GtkGestureDragHandle : GObjectHandle
{
}

public class GtkGestureHandle : GObjectHandle
{
	public static GtkGestureHandle ClickNew()
	{
		return GtkGestureExterns.gtk_gesture_click_new();
	}

	public static GtkGestureHandle DragNew()
	{
		return GtkGestureExterns.gtk_gesture_drag_new();
	}

	public static GtkGestureHandle LongPressNew()
	{
		return GtkGestureExterns.gtk_gesture_long_press_new();
	}

	public static GtkGestureHandle PanNew(GtkOrientation orientation)
	{
		return GtkGestureExterns.gtk_gesture_pan_new(orientation);
	}

	public static GtkGestureHandle RotateNew()
	{
		return GtkGestureExterns.gtk_gesture_rotate_new();
	}

	public static GtkGestureHandle StylusNew()
	{
		return GtkGestureExterns.gtk_gesture_stylus_new();
	}

	public static GtkGestureHandle SwipeNew()
	{
		return GtkGestureExterns.gtk_gesture_swipe_new();
	}

	public static GtkGestureHandle ZoomNew()
	{
		return GtkGestureExterns.gtk_gesture_zoom_new();
	}
}

public class GtkGestureLongPressClassHandle : GObjectHandle
{
}

public class GtkGestureLongPressHandle : GObjectHandle
{
}

public class GtkGesturePanClassHandle : GObjectHandle
{
}

public class GtkGesturePanHandle : GObjectHandle
{
}

public class GtkGestureRotateClassHandle : GObjectHandle
{
}

public class GtkGestureRotateHandle : GObjectHandle
{
}

public class GtkGestureSingleClassHandle : GObjectHandle
{
}

public class GtkGestureSingleHandle : GObjectHandle
{
}

public class GtkGestureStylusClassHandle : GObjectHandle
{
}

public class GtkGestureStylusHandle : GObjectHandle
{
}

public class GtkGestureSwipeClassHandle : GObjectHandle
{
}

public class GtkGestureSwipeHandle : GObjectHandle
{
}

public class GtkGestureZoomClassHandle : GObjectHandle
{
}

public class GtkGestureZoomHandle : GObjectHandle
{
}

public class GtkGridClassHandle : GObjectHandle
{
}

public class GtkGridLayoutChildClassHandle : GObjectHandle
{
}

public class GtkGridLayoutChildHandle : GObjectHandle
{
}

public class GtkGridLayoutClassHandle : GObjectHandle
{
}

public class GtkGridLayoutHandle : GObjectHandle
{
}

public class GtkGridViewClassHandle : GObjectHandle
{
}

public class GtkGridViewHandle : GObjectHandle
{
}

public class GtkIMContextClassHandle : GObjectHandle
{
}

public class GtkIMContextHandle : GObjectHandle
{
	public static GtkIMContextHandle GtkImContextSimpleNew()
	{
		return GtkIMContextExterns.gtk_im_context_simple_new();
	}

	public static GtkIMContextHandle GtkImMulticontextNew()
	{
		return GtkIMContextExterns.gtk_im_multicontext_new();
	}
}

public class GtkIMContextSimpleClassHandle : GObjectHandle
{
}

public class GtkIMContextSimpleHandle : GObjectHandle
{
}

public class GtkIMContextSimplePrivateHandle : GObjectHandle
{
}

public class GtkIMMulticontextClassHandle : GObjectHandle
{
}

public class GtkIMMulticontextHandle : GObjectHandle
{
}

public class GtkIMMulticontextPrivateHandle : GObjectHandle
{
}

public class GtkIconPaintableHandle : GObjectHandle
{
	public static GtkIconPaintableHandle NewForFile(GFileHandle file, int size, int scale)
	{
		return GtkIconPaintableExterns.gtk_icon_paintable_new_for_file(file, size, scale);
	}
}

public class GtkIconThemeHandle : GObjectHandle
{
	public static GtkIconThemeHandle New()
	{
		return GtkIconThemeExterns.gtk_icon_theme_new();
	}
}

public class GtkKeyvalTriggerClassHandle : GObjectHandle
{
}

public class GtkKeyvalTriggerHandle : GObjectHandle
{
}

public class GtkLayoutChildClassHandle : GObjectHandle
{
}

public class GtkLayoutChildHandle : GObjectHandle
{
}

public class GtkLayoutManagerClassHandle : GObjectHandle
{
}

public class GtkLayoutManagerHandle : GObjectHandle
{
	public static GtkLayoutManagerHandle GtkBinLayoutNew()
	{
		return GtkLayoutManagerExterns.gtk_bin_layout_new();
	}

	public static GtkLayoutManagerHandle GtkBoxLayoutNew(GtkOrientation orientation)
	{
		return GtkLayoutManagerExterns.gtk_box_layout_new(orientation);
	}

	public static GtkLayoutManagerHandle GtkCenterLayoutNew()
	{
		return GtkLayoutManagerExterns.gtk_center_layout_new();
	}

	public static GtkLayoutManagerHandle GtkConstraintLayoutNew()
	{
		return GtkLayoutManagerExterns.gtk_constraint_layout_new();
	}

	public static GtkLayoutManagerHandle GtkCustomLayoutNew(GtkCustomRequestModeFunc request_mode, GtkCustomMeasureFunc measure, GtkCustomAllocateFunc allocate)
	{
		return GtkLayoutManagerExterns.gtk_custom_layout_new(request_mode, measure, allocate);
	}

	public static GtkLayoutManagerHandle GtkFixedLayoutNew()
	{
		return GtkLayoutManagerExterns.gtk_fixed_layout_new();
	}

	public static GtkLayoutManagerHandle GtkGridLayoutNew()
	{
		return GtkLayoutManagerExterns.gtk_grid_layout_new();
	}

	public static GtkLayoutManagerHandle GtkOverlayLayoutNew()
	{
		return GtkLayoutManagerExterns.gtk_overlay_layout_new();
	}
}

public class GtkLinkButtonHandle : GObjectHandle
{
	public static GtkLinkButtonHandle New(string uri)
	{
		return GtkLinkButtonExterns.gtk_link_button_new(uri);
	}

	public static GtkLinkButtonHandle NewWithLabel(string uri, string label)
	{
		return GtkLinkButtonExterns.gtk_link_button_new_with_label(uri, label);
	}
}

public class GtkListBaseClassHandle : GObjectHandle
{
}

public class GtkListBoxRowClassHandle : GObjectHandle
{
}

public class GtkListItemClassHandle : GObjectHandle
{
}

public class GtkListItemFactoryClassHandle : GObjectHandle
{
}

public class GtkListItemFactoryHandle : GObjectHandle
{
	public static GtkListItemFactoryHandle GtkSignalListItemFactoryNew()
	{
		return GtkListItemFactoryExterns.gtk_signal_list_item_factory_new();
	}
}

public class GtkListItemHandle : GObjectHandle
{
}

public class GtkListStoreClassHandle : GObjectHandle
{
}

public class GtkListStoreHandle : GObjectHandle
{
	public static GtkListStoreHandle New(int n_columns, IntPtr @__arglist)
	{
		return GtkListStoreExterns.gtk_list_store_new(n_columns, @__arglist);
	}

	public static GtkListStoreHandle Newv(int n_columns, GTypeHandle types)
	{
		return GtkListStoreExterns.gtk_list_store_newv(n_columns, types);
	}
}

public class GtkListStorePrivateHandle : GObjectHandle
{
}

public class GtkListViewClassHandle : GObjectHandle
{
}

public class GtkListViewHandle : GObjectHandle
{
}

public class GtkLockButtonHandle : GObjectHandle
{
	public static GtkLockButtonHandle New(GPermissionHandle permission)
	{
		return GtkLockButtonExterns.gtk_lock_button_new(permission);
	}
}

public class GtkMapListModelClassHandle : GObjectHandle
{
}

public class GtkMapListModelHandle : GObjectHandle
{
	public static GtkMapListModelHandle New(GListModelHandle model, GtkMapListModelMapFunc map_func, IntPtr user_data, GDestroyNotify user_destroy)
	{
		return GtkMapListModelExterns.gtk_map_list_model_new(model, map_func, user_data, user_destroy);
	}
}

public class GtkMediaControlsClassHandle : GObjectHandle
{
}

public class GtkMediaFileClassHandle : GObjectHandle
{
}

public class GtkMediaFileHandle : GObjectHandle
{
}

public class GtkMediaStreamClassHandle : GObjectHandle
{
}

public class GtkMediaStreamHandle : GObjectHandle
{
	public static GtkMediaStreamHandle GtkMediaFileNew()
	{
		return GtkMediaStreamExterns.gtk_media_file_new();
	}

	public static GtkMediaStreamHandle GtkMediaFileNewForFilename(string filename)
	{
		return GtkMediaStreamExterns.gtk_media_file_new_for_filename(filename);
	}

	public static GtkMediaStreamHandle GtkMediaFileNewForResource(string resource_path)
	{
		return GtkMediaStreamExterns.gtk_media_file_new_for_resource(resource_path);
	}

	public static GtkMediaStreamHandle GtkMediaFileNewForFile(GFileHandle file)
	{
		return GtkMediaStreamExterns.gtk_media_file_new_for_file(file);
	}

	public static GtkMediaStreamHandle GtkMediaFileNewForInputStream(GInputStreamHandle stream)
	{
		return GtkMediaStreamExterns.gtk_media_file_new_for_input_stream(stream);
	}
}

public class GtkMessageDialogClassHandle : GObjectHandle
{
}

public class GtkMessageDialogHandle : GObjectHandle
{
}

public class GtkMnemonicActionClassHandle : GObjectHandle
{
}

public class GtkMnemonicActionHandle : GObjectHandle
{
}

public class GtkMnemonicTriggerClassHandle : GObjectHandle
{
}

public class GtkMnemonicTriggerHandle : GObjectHandle
{
}

public class GtkMountOperationClassHandle : GObjectHandle
{
}

public class GtkMountOperationHandle : GObjectHandle
{
}

public class GtkMountOperationPrivateHandle : GObjectHandle
{
}

public class GtkMultiFilterClassHandle : GObjectHandle
{
}

public class GtkMultiFilterHandle : GObjectHandle
{
}

public class GtkMultiSelectionClassHandle : GObjectHandle
{
}

public class GtkMultiSelectionHandle : GObjectHandle
{
	public static GtkMultiSelectionHandle New(GListModelHandle model)
	{
		return GtkMultiSelectionExterns.gtk_multi_selection_new(model);
	}
}

public class GtkMultiSorterClassHandle : GObjectHandle
{
}

public class GtkMultiSorterHandle : GObjectHandle
{
	public static GtkMultiSorterHandle New()
	{
		return GtkMultiSorterExterns.gtk_multi_sorter_new();
	}
}

public class GtkNamedActionClassHandle : GObjectHandle
{
}

public class GtkNamedActionHandle : GObjectHandle
{
}

public class GtkNativeDialogClassHandle : GObjectHandle
{
}

public class GtkNativeDialogHandle : GObjectHandle
{
}

public class GtkNativeHandle : GObjectHandle
{
}

public class GtkNativeInterfaceHandle : GObjectHandle
{
}

public class GtkNeverTriggerClassHandle : GObjectHandle
{
}

public class GtkNeverTriggerHandle : GObjectHandle
{
}

public class GtkNoSelectionClassHandle : GObjectHandle
{
}

public class GtkNoSelectionHandle : GObjectHandle
{
	public static GtkNoSelectionHandle New(GListModelHandle model)
	{
		return GtkNoSelectionExterns.gtk_no_selection_new(model);
	}
}

public class GtkNotebookPageHandle : GObjectHandle
{
}

public class GtkNothingActionClassHandle : GObjectHandle
{
}

public class GtkNothingActionHandle : GObjectHandle
{
}

public class GtkNumericSorterClassHandle : GObjectHandle
{
}

public class GtkNumericSorterHandle : GObjectHandle
{
}

public class GtkObjectExpressionHandle : GObjectHandle
{
}

public class GtkOrientableHandle : GObjectHandle
{
}

public class GtkOrientableIfaceHandle : GObjectHandle
{
}

public class GtkOverlayLayoutChildClassHandle : GObjectHandle
{
}

public class GtkOverlayLayoutChildHandle : GObjectHandle
{
}

public class GtkOverlayLayoutClassHandle : GObjectHandle
{
}

public class GtkOverlayLayoutHandle : GObjectHandle
{
}

public class GtkPadActionEntryHandle : GObjectHandle
{
}

public class GtkPadControllerClassHandle : GObjectHandle
{
}

public class GtkPadControllerHandle : GObjectHandle
{
	public static GtkPadControllerHandle New(GActionGroupHandle group, GdkDeviceHandle pad)
	{
		return GtkPadControllerExterns.gtk_pad_controller_new(group, pad);
	}
}

public class GtkPageRangeHandle : GObjectHandle
{
}

public class GtkPageSetupHandle : GObjectHandle
{
	public static GtkPageSetupHandle New()
	{
		return GtkPageSetupExterns.gtk_page_setup_new();
	}

	public static GtkPageSetupHandle NewFromFile(string file_name, out GErrorHandle error)
	{
		return GtkPageSetupExterns.gtk_page_setup_new_from_file(file_name, out error);
	}

	public static GtkPageSetupHandle NewFromKeyFile(GKeyFileHandle key_file, string group_name, out GErrorHandle error)
	{
		return GtkPageSetupExterns.gtk_page_setup_new_from_key_file(key_file, group_name, out error);
	}

	public static GtkPageSetupHandle NewFromGvariant(GVariantHandle variant)
	{
		return GtkPageSetupExterns.gtk_page_setup_new_from_gvariant(variant);
	}
}

public class GtkPaperSizeHandle : GObjectHandle
{
	public static GtkPaperSizeHandle New(string name)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new(name);
	}

	public static GtkPaperSizeHandle NewFromPpd(string ppd_name, string ppd_display_name, double width, double height)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_from_ppd(ppd_name, ppd_display_name, width, height);
	}

	public static GtkPaperSizeHandle NewFromIpp(string ipp_name, double width, double height)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_from_ipp(ipp_name, width, height);
	}

	public static GtkPaperSizeHandle NewCustom(string name, string display_name, double width, double height, GtkUnit unit)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_custom(name, display_name, width, height, unit);
	}

	public static GtkPaperSizeHandle NewFromKeyFile(GKeyFileHandle key_file, string group_name, out GErrorHandle error)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_from_key_file(key_file, group_name, out error);
	}

	public static GtkPaperSizeHandle NewFromGvariant(GVariantHandle variant)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_from_gvariant(variant);
	}
}

public class GtkParamSpecExpressionHandle : GObjectHandle
{
}

public class GtkPasswordEntryBufferClassHandle : GObjectHandle
{
}

public class GtkPasswordEntryBufferHandle : GObjectHandle
{
}

public class GtkPasswordEntryClassHandle : GObjectHandle
{
}

public class GtkPictureClassHandle : GObjectHandle
{
}

public class GtkPopoverClassHandle : GObjectHandle
{
}

public class GtkPopoverMenuHandle : GObjectHandle
{
	public static GtkPopoverMenuHandle NewFromModel(GMenuModelHandle model)
	{
		return GtkPopoverMenuExterns.gtk_popover_menu_new_from_model(model);
	}

	public static GtkPopoverMenuHandle NewFromModelFull(GMenuModelHandle model, GtkPopoverMenuFlags flags)
	{
		return GtkPopoverMenuExterns.gtk_popover_menu_new_from_model_full(model, flags);
	}
}

public class GtkPrintContextHandle : GObjectHandle
{
}

public class GtkPrintOperationClassHandle : GObjectHandle
{
}

public class GtkPrintOperationHandle : GObjectHandle
{
	public static GtkPrintOperationHandle New()
	{
		return GtkPrintOperationExterns.gtk_print_operation_new();
	}
}

public class GtkPrintOperationPreviewHandle : GObjectHandle
{
}

public class GtkPrintOperationPreviewIfaceHandle : GObjectHandle
{
}

public class GtkPrintOperationPrivateHandle : GObjectHandle
{
}

public class GtkPrintSettingsHandle : GObjectHandle
{
	public static GtkPrintSettingsHandle New()
	{
		return GtkPrintSettingsExterns.gtk_print_settings_new();
	}

	public static GtkPrintSettingsHandle NewFromFile(string file_name, out GErrorHandle error)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_new_from_file(file_name, out error);
	}

	public static GtkPrintSettingsHandle NewFromKeyFile(GKeyFileHandle key_file, string group_name, out GErrorHandle error)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_new_from_key_file(key_file, group_name, out error);
	}

	public static GtkPrintSettingsHandle NewFromGvariant(GVariantHandle variant)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_new_from_gvariant(variant);
	}
}

public class GtkPropertyExpressionHandle : GObjectHandle
{
}

public class GtkRangeClassHandle : GObjectHandle
{
}

public class GtkRecentDataHandle : GObjectHandle
{
}

public class GtkRecentInfoHandle : GObjectHandle
{
}

public class GtkRecentManagerClassHandle : GObjectHandle
{
}

public class GtkRecentManagerHandle : GObjectHandle
{
	public static GtkRecentManagerHandle New()
	{
		return GtkRecentManagerExterns.gtk_recent_manager_new();
	}
}

public class GtkRecentManagerPrivateHandle : GObjectHandle
{
}

public class GtkRequestedSizeHandle : GObjectHandle
{
}

public class GtkRequisitionHandle : GObjectHandle
{
	public static GtkRequisitionHandle New()
	{
		return GtkRequisitionExterns.gtk_requisition_new();
	}
}

public class GtkRootHandle : GObjectHandle
{
}

public class GtkRootInterfaceHandle : GObjectHandle
{
}

public class GtkScaleButtonClassHandle : GObjectHandle
{
}

public class GtkScaleClassHandle : GObjectHandle
{
}

public class GtkScaleHandle : GObjectHandle
{
	public static GtkScaleHandle New(GtkOrientation orientation, GtkAdjustmentHandle adjustment)
	{
		return GtkScaleExterns.gtk_scale_new(orientation, adjustment);
	}

	public static GtkScaleHandle NewWithRange(GtkOrientation orientation, double min, double max, double step)
	{
		return GtkScaleExterns.gtk_scale_new_with_range(orientation, min, max, step);
	}
}

public class GtkScrollableHandle : GObjectHandle
{
}

public class GtkScrollableInterfaceHandle : GObjectHandle
{
}

public class GtkSelectionFilterModelClassHandle : GObjectHandle
{
}

public class GtkSelectionFilterModelHandle : GObjectHandle
{
}

public class GtkSelectionModelHandle : GObjectHandle
{
}

public class GtkSelectionModelInterfaceHandle : GObjectHandle
{
}

public class GtkSettingsHandle : GObjectHandle
{
}

public class GtkShortcutActionClassHandle : GObjectHandle
{
}

public class GtkShortcutActionHandle : GObjectHandle
{
	public static GtkShortcutActionHandle GtkCallbackActionNew(GtkShortcutFunc callback, IntPtr data, GDestroyNotify destroy)
	{
		return GtkShortcutActionExterns.gtk_callback_action_new(callback, data, destroy);
	}

	public static GtkShortcutActionHandle GtkSignalActionNew(string signal_name)
	{
		return GtkShortcutActionExterns.gtk_signal_action_new(signal_name);
	}

	public static GtkShortcutActionHandle GtkNamedActionNew(string name)
	{
		return GtkShortcutActionExterns.gtk_named_action_new(name);
	}
}

public class GtkShortcutClassHandle : GObjectHandle
{
}

public class GtkShortcutControllerClassHandle : GObjectHandle
{
}

public class GtkShortcutControllerHandle : GObjectHandle
{
}

public class GtkShortcutHandle : GObjectHandle
{
	public static GtkShortcutHandle New(GtkShortcutTriggerHandle trigger, GtkShortcutActionHandle action)
	{
		return GtkShortcutExterns.gtk_shortcut_new(trigger, action);
	}

	public static GtkShortcutHandle NewWithArguments(GtkShortcutTriggerHandle trigger, GtkShortcutActionHandle action, string format_string, IntPtr @__arglist)
	{
		return GtkShortcutExterns.gtk_shortcut_new_with_arguments(trigger, action, format_string, @__arglist);
	}
}

public class GtkShortcutLabelClassHandle : GObjectHandle
{
}

public class GtkShortcutManagerHandle : GObjectHandle
{
}

public class GtkShortcutManagerInterfaceHandle : GObjectHandle
{
}

public class GtkShortcutTriggerClassHandle : GObjectHandle
{
}

public class GtkShortcutTriggerHandle : GObjectHandle
{
	public static GtkShortcutTriggerHandle GtkKeyvalTriggerNew(uint keyval, GdkModifierType modifiers)
	{
		return GtkShortcutTriggerExterns.gtk_keyval_trigger_new(keyval, modifiers);
	}

	public static GtkShortcutTriggerHandle GtkMnemonicTriggerNew(uint keyval)
	{
		return GtkShortcutTriggerExterns.gtk_mnemonic_trigger_new(keyval);
	}
}

public class GtkShortcutsGroupClassHandle : GObjectHandle
{
}

public class GtkShortcutsGroupHandle : GObjectHandle
{
}

public class GtkShortcutsSectionClassHandle : GObjectHandle
{
}

public class GtkShortcutsSectionHandle : GObjectHandle
{
}

public class GtkShortcutsShortcutClassHandle : GObjectHandle
{
}

public class GtkSignalActionClassHandle : GObjectHandle
{
}

public class GtkSignalActionHandle : GObjectHandle
{
}

public class GtkSignalListItemFactoryClassHandle : GObjectHandle
{
}

public class GtkSignalListItemFactoryHandle : GObjectHandle
{
}

public class GtkSingleSelectionClassHandle : GObjectHandle
{
}

public class GtkSingleSelectionHandle : GObjectHandle
{
	public static GtkSingleSelectionHandle New(GListModelHandle model)
	{
		return GtkSingleSelectionExterns.gtk_single_selection_new(model);
	}
}

public class GtkSizeGroupHandle : GObjectHandle
{
	public static GtkSizeGroupHandle New(GtkSizeGroupMode mode)
	{
		return GtkSizeGroupExterns.gtk_size_group_new(mode);
	}
}

public class GtkSliceListModelClassHandle : GObjectHandle
{
}

public class GtkSliceListModelHandle : GObjectHandle
{
	public static GtkSliceListModelHandle New(GListModelHandle model, uint offset, uint size)
	{
		return GtkSliceListModelExterns.gtk_slice_list_model_new(model, offset, size);
	}
}

public class GtkSnapshotClassHandle : GObjectHandle
{
}

public class GtkSnapshotHandle : GObjectHandle
{
	public static GtkSnapshotHandle New()
	{
		return GtkSnapshotExterns.gtk_snapshot_new();
	}
}

public class GtkSortListModelClassHandle : GObjectHandle
{
}

public class GtkSortListModelHandle : GObjectHandle
{
	public static GtkSortListModelHandle New(GListModelHandle model, GtkSorterHandle sorter)
	{
		return GtkSortListModelExterns.gtk_sort_list_model_new(model, sorter);
	}
}

public class GtkSorterClassHandle : GObjectHandle
{
}

public class GtkSorterHandle : GObjectHandle
{
}

public class GtkStackPageHandle : GObjectHandle
{
}

public class GtkStringFilterClassHandle : GObjectHandle
{
}

public class GtkStringFilterHandle : GObjectHandle
{
}

public class GtkStringListClassHandle : GObjectHandle
{
}

public class GtkStringListHandle : GObjectHandle
{
	public static GtkStringListHandle New(string strings)
	{
		return GtkStringListExterns.gtk_string_list_new(strings);
	}
}

public class GtkStringObjectClassHandle : GObjectHandle
{
}

public class GtkStringObjectHandle : GObjectHandle
{
	public static GtkStringObjectHandle New(string @string)
	{
		return GtkStringObjectExterns.gtk_string_object_new(@string);
	}
}

public class GtkStringSorterClassHandle : GObjectHandle
{
}

public class GtkStringSorterHandle : GObjectHandle
{
}

public class GtkStyleContextClassHandle : GObjectHandle
{
}

public class GtkStyleContextHandle : GObjectHandle
{
}

public class GtkStyleProviderHandle : GObjectHandle
{
}

public class GtkSymbolicPaintableHandle : GObjectHandle
{
}

public class GtkSymbolicPaintableInterfaceHandle : GObjectHandle
{
}

public class GtkTextBufferClassHandle : GObjectHandle
{
}

public class GtkTextBufferHandle : GObjectHandle
{
}

public class GtkTextBufferPrivateHandle : GObjectHandle
{
}

public class GtkTextChildAnchorClassHandle : GObjectHandle
{
}

public class GtkTextChildAnchorHandle : GObjectHandle
{
	public static GtkTextChildAnchorHandle New()
	{
		return GtkTextChildAnchorExterns.gtk_text_child_anchor_new();
	}

	public static GtkTextChildAnchorHandle NewWithReplacement(string character)
	{
		return GtkTextChildAnchorExterns.gtk_text_child_anchor_new_with_replacement(character);
	}
}

public class GtkTextIterHandle : GObjectHandle
{
}

public class GtkTextMarkClassHandle : GObjectHandle
{
}

public class GtkTextMarkHandle : GObjectHandle
{
	public static GtkTextMarkHandle New(string name, int left_gravity)
	{
		return GtkTextMarkExterns.gtk_text_mark_new(name, left_gravity);
	}
}

public class GtkTextTagClassHandle : GObjectHandle
{
}

public class GtkTextTagHandle : GObjectHandle
{
	public static GtkTextTagHandle New(string name)
	{
		return GtkTextTagExterns.gtk_text_tag_new(name);
	}
}

public class GtkTextTagPrivateHandle : GObjectHandle
{
}

public class GtkTextTagTableHandle : GObjectHandle
{
	public static GtkTextTagTableHandle New()
	{
		return GtkTextTagTableExterns.gtk_text_tag_table_new();
	}
}

public class GtkTextViewClassHandle : GObjectHandle
{
}

public class GtkTextViewPrivateHandle : GObjectHandle
{
}

public class GtkToggleButtonClassHandle : GObjectHandle
{
}

public class GtkToggleButtonHandle : GObjectHandle
{
	public static GtkToggleButtonHandle New()
	{
		return GtkToggleButtonExterns.gtk_toggle_button_new();
	}

	public static GtkToggleButtonHandle NewWithLabel(string label)
	{
		return GtkToggleButtonExterns.gtk_toggle_button_new_with_label(label);
	}

	public static GtkToggleButtonHandle NewWithMnemonic(string label)
	{
		return GtkToggleButtonExterns.gtk_toggle_button_new_with_mnemonic(label);
	}
}

public class GtkTooltipHandle : GObjectHandle
{
}

public class GtkTreeDragDestHandle : GObjectHandle
{
}

public class GtkTreeDragDestIfaceHandle : GObjectHandle
{
}

public class GtkTreeDragSourceHandle : GObjectHandle
{
}

public class GtkTreeDragSourceIfaceHandle : GObjectHandle
{
}

public class GtkTreeExpanderClassHandle : GObjectHandle
{
}

public class GtkTreeIterHandle : GObjectHandle
{
}

public class GtkTreeListModelClassHandle : GObjectHandle
{
}

public class GtkTreeListModelHandle : GObjectHandle
{
	public static GtkTreeListModelHandle New(GListModelHandle root, int passthrough, int autoexpand, GtkTreeListModelCreateModelFunc create_func, IntPtr user_data, GDestroyNotify user_destroy)
	{
		return GtkTreeListModelExterns.gtk_tree_list_model_new(root, passthrough, autoexpand, create_func, user_data, user_destroy);
	}
}

public class GtkTreeListRowClassHandle : GObjectHandle
{
}

public class GtkTreeListRowHandle : GObjectHandle
{
}

public class GtkTreeListRowSorterClassHandle : GObjectHandle
{
}

public class GtkTreeListRowSorterHandle : GObjectHandle
{
}

public class GtkTreeModelFilterClassHandle : GObjectHandle
{
}

public class GtkTreeModelFilterHandle : GObjectHandle
{
}

public class GtkTreeModelFilterPrivateHandle : GObjectHandle
{
}

public class GtkTreeModelHandle : GObjectHandle
{
}

public class GtkTreeModelIfaceHandle : GObjectHandle
{
}

public class GtkTreeModelSortClassHandle : GObjectHandle
{
}

public class GtkTreeModelSortHandle : GObjectHandle
{
}

public class GtkTreeModelSortPrivateHandle : GObjectHandle
{
}

public class GtkTreePathHandle : GObjectHandle
{
	public static GtkTreePathHandle New()
	{
		return GtkTreePathExterns.gtk_tree_path_new();
	}

	public static GtkTreePathHandle NewFromString(string path)
	{
		return GtkTreePathExterns.gtk_tree_path_new_from_string(path);
	}

	public static GtkTreePathHandle NewFromIndices(int first_index, IntPtr @__arglist)
	{
		return GtkTreePathExterns.gtk_tree_path_new_from_indices(first_index, @__arglist);
	}

	public static GtkTreePathHandle NewFromIndicesv(int[] indices, nuint length)
	{
		return GtkTreePathExterns.gtk_tree_path_new_from_indicesv(indices, length);
	}

	public static GtkTreePathHandle NewFirst()
	{
		return GtkTreePathExterns.gtk_tree_path_new_first();
	}
}

public class GtkTreeRowReferenceHandle : GObjectHandle
{
	public static GtkTreeRowReferenceHandle New(GtkTreeModelHandle model, GtkTreePathHandle path)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_new(model, path);
	}

	public static GtkTreeRowReferenceHandle NewProxy(GObjectHandle proxy, GtkTreeModelHandle model, GtkTreePathHandle path)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_new_proxy(proxy, model, path);
	}
}

public class GtkTreeSelectionHandle : GObjectHandle
{
}

public class GtkTreeSortableHandle : GObjectHandle
{
}

public class GtkTreeSortableIfaceHandle : GObjectHandle
{
}

public class GtkTreeStoreClassHandle : GObjectHandle
{
}

public class GtkTreeStoreHandle : GObjectHandle
{
	public static GtkTreeStoreHandle New(int n_columns, IntPtr @__arglist)
	{
		return GtkTreeStoreExterns.gtk_tree_store_new(n_columns, @__arglist);
	}

	public static GtkTreeStoreHandle Newv(int n_columns, GTypeHandle types)
	{
		return GtkTreeStoreExterns.gtk_tree_store_newv(n_columns, types);
	}
}

public class GtkTreeStorePrivateHandle : GObjectHandle
{
}

public class GtkTreeViewClassHandle : GObjectHandle
{
}

public class GtkTreeViewColumnHandle : GObjectHandle
{
	public static GtkTreeViewColumnHandle New()
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_new();
	}

	public static GtkTreeViewColumnHandle NewWithAttributes(string title, GtkCellRendererHandle cell, IntPtr @__arglist)
	{
		return GtkTreeViewColumnExterns.gtk_tree_view_column_new_with_attributes(title, cell, @__arglist);
	}
}

public class GtkVideoClassHandle : GObjectHandle
{
}

public class GtkVolumeButtonHandle : GObjectHandle
{
	public static GtkVolumeButtonHandle New()
	{
		return GtkVolumeButtonExterns.gtk_volume_button_new();
	}
}

public class GtkWidgetClassHandle : GObjectHandle
{
}

public class GtkWidgetClassPrivateHandle : GObjectHandle
{
}

public class GtkWidgetHandle : GObjectHandle
{
}

public class GtkWidgetPaintableClassHandle : GObjectHandle
{
}

public class GtkWidgetPaintableHandle : GObjectHandle
{
}

public class GtkWidgetPrivateHandle : GObjectHandle
{
}

public class GtkWindowClassHandle : GObjectHandle
{
}

public class GtkWindowControlsClassHandle : GObjectHandle
{
}

public class GtkWindowGroupClassHandle : GObjectHandle
{
}

public class GtkWindowGroupHandle : GObjectHandle
{
	public static GtkWindowGroupHandle New()
	{
		return GtkWindowGroupExterns.gtk_window_group_new();
	}
}

public class GtkWindowGroupPrivateHandle : GObjectHandle
{
}

public class GtkWindowHandleClassHandle : GObjectHandle
{
}

public class GtkActionBarHandle : GtkWidgetHandle
{
	public static GtkActionBarHandle New()
	{
		return GtkActionBarExterns.gtk_action_bar_new();
	}
}

public class GtkAppChooserButtonHandle : GtkWidgetHandle
{
	public static GtkAppChooserButtonHandle New(string content_type)
	{
		return GtkAppChooserButtonExterns.gtk_app_chooser_button_new(content_type);
	}
}

public class GtkAppChooserWidgetHandle : GtkWidgetHandle
{
	public static GtkAppChooserWidgetHandle New(string content_type)
	{
		return GtkAppChooserWidgetExterns.gtk_app_chooser_widget_new(content_type);
	}
}

public class GtkAspectFrameHandle : GtkWidgetHandle
{
	public static GtkAspectFrameHandle New(float xalign, float yalign, float ratio, int obey_child)
	{
		return GtkAspectFrameExterns.gtk_aspect_frame_new(xalign, yalign, ratio, obey_child);
	}
}

public class GtkBoxHandle : GtkWidgetHandle
{
	public static GtkBoxHandle New(GtkOrientation orientation, int spacing)
	{
		return GtkBoxExterns.gtk_box_new(orientation, spacing);
	}
}

public class GtkButtonHandle : GtkWidgetHandle
{
	public static GtkButtonHandle New()
	{
		return GtkButtonExterns.gtk_button_new();
	}

	public static GtkButtonHandle NewWithLabel(string label)
	{
		return GtkButtonExterns.gtk_button_new_with_label(label);
	}

	public static GtkButtonHandle NewFromIconName(string icon_name)
	{
		return GtkButtonExterns.gtk_button_new_from_icon_name(icon_name);
	}

	public static GtkButtonHandle NewWithMnemonic(string label)
	{
		return GtkButtonExterns.gtk_button_new_with_mnemonic(label);
	}
}

public class GtkCalendarHandle : GtkWidgetHandle
{
	public static GtkCalendarHandle New()
	{
		return GtkCalendarExterns.gtk_calendar_new();
	}
}

public class GtkCellViewHandle : GtkWidgetHandle
{
	public static GtkCellViewHandle New()
	{
		return GtkCellViewExterns.gtk_cell_view_new();
	}

	public static GtkCellViewHandle NewWithText(string text)
	{
		return GtkCellViewExterns.gtk_cell_view_new_with_text(text);
	}

	public static GtkCellViewHandle NewWithMarkup(string markup)
	{
		return GtkCellViewExterns.gtk_cell_view_new_with_markup(markup);
	}

	public static GtkCellViewHandle NewWithTexture(GdkTextureHandle texture)
	{
		return GtkCellViewExterns.gtk_cell_view_new_with_texture(texture);
	}
}

public class GtkCenterBoxHandle : GtkWidgetHandle
{
	public static GtkCenterBoxHandle New()
	{
		return GtkCenterBoxExterns.gtk_center_box_new();
	}
}

public class GtkCheckButtonHandle : GtkWidgetHandle
{
	public static GtkCheckButtonHandle New()
	{
		return GtkCheckButtonExterns.gtk_check_button_new();
	}

	public static GtkCheckButtonHandle NewWithLabel(string label)
	{
		return GtkCheckButtonExterns.gtk_check_button_new_with_label(label);
	}

	public static GtkCheckButtonHandle NewWithMnemonic(string label)
	{
		return GtkCheckButtonExterns.gtk_check_button_new_with_mnemonic(label);
	}
}

public class GtkColorButtonHandle : GtkWidgetHandle
{
	public static GtkColorButtonHandle New()
	{
		return GtkColorButtonExterns.gtk_color_button_new();
	}

	public static GtkColorButtonHandle NewWithRgba(GdkRGBAHandle rgba)
	{
		return GtkColorButtonExterns.gtk_color_button_new_with_rgba(rgba);
	}
}

public class GtkColorChooserWidgetHandle : GtkWidgetHandle
{
	public static GtkColorChooserWidgetHandle New()
	{
		return GtkColorChooserWidgetExterns.gtk_color_chooser_widget_new();
	}
}

public class GtkColorDialogButtonHandle : GtkWidgetHandle
{
}

public class GtkColumnViewHandle : GtkWidgetHandle
{
}

public class GtkComboBoxHandle : GtkWidgetHandle
{
	public static GtkComboBoxHandle New()
	{
		return GtkComboBoxExterns.gtk_combo_box_new();
	}

	public static GtkComboBoxHandle NewWithEntry()
	{
		return GtkComboBoxExterns.gtk_combo_box_new_with_entry();
	}
}

public class GtkDragIconHandle : GtkWidgetHandle
{
}

public class GtkDrawingAreaHandle : GtkWidgetHandle
{
	public static GtkDrawingAreaHandle New()
	{
		return GtkDrawingAreaExterns.gtk_drawing_area_new();
	}
}

public class GtkDropDownHandle : GtkWidgetHandle
{
	public static GtkDropDownHandle New(GListModelHandle model, GtkExpressionHandle expression)
	{
		return GtkDropDownExterns.gtk_drop_down_new(model, expression);
	}

	public static GtkDropDownHandle NewFromStrings(string strings)
	{
		return GtkDropDownExterns.gtk_drop_down_new_from_strings(strings);
	}
}

public class GtkEditableLabelHandle : GtkWidgetHandle
{
	public static GtkEditableLabelHandle New(string str)
	{
		return GtkEditableLabelExterns.gtk_editable_label_new(str);
	}
}

public class GtkEntryHandle : GtkWidgetHandle
{
	public static GtkEntryHandle New()
	{
		return GtkEntryExterns.gtk_entry_new();
	}
}

public class GtkExpanderHandle : GtkWidgetHandle
{
	public static GtkExpanderHandle New(string label)
	{
		return GtkExpanderExterns.gtk_expander_new(label);
	}

	public static GtkExpanderHandle NewWithMnemonic(string label)
	{
		return GtkExpanderExterns.gtk_expander_new_with_mnemonic(label);
	}
}

public class GtkFileChooserWidgetHandle : GtkWidgetHandle
{
	public static GtkFileChooserWidgetHandle New(GtkFileChooserAction action)
	{
		return GtkFileChooserWidgetExterns.gtk_file_chooser_widget_new(action);
	}
}

public class GtkFixedHandle : GtkWidgetHandle
{
	public static GtkFixedHandle New()
	{
		return GtkFixedExterns.gtk_fixed_new();
	}
}

public class GtkFlowBoxHandle : GtkWidgetHandle
{
	public static GtkFlowBoxHandle New()
	{
		return GtkFlowBoxExterns.gtk_flow_box_new();
	}
}

public class GtkFlowBoxChildHandle : GtkWidgetHandle
{
	public static GtkFlowBoxChildHandle New()
	{
		return GtkFlowBoxChildExterns.gtk_flow_box_child_new();
	}
}

public class GtkFontButtonHandle : GtkWidgetHandle
{
	public static GtkFontButtonHandle New()
	{
		return GtkFontButtonExterns.gtk_font_button_new();
	}

	public static GtkFontButtonHandle NewWithFont(string fontname)
	{
		return GtkFontButtonExterns.gtk_font_button_new_with_font(fontname);
	}
}

public class GtkFontChooserWidgetHandle : GtkWidgetHandle
{
	public static GtkFontChooserWidgetHandle New()
	{
		return GtkFontChooserWidgetExterns.gtk_font_chooser_widget_new();
	}
}

public class GtkFontDialogButtonHandle : GtkWidgetHandle
{
}

public class GtkFrameHandle : GtkWidgetHandle
{
	public static GtkFrameHandle New(string label)
	{
		return GtkFrameExterns.gtk_frame_new(label);
	}
}

public class GtkGLAreaHandle : GtkWidgetHandle
{
	public static GtkGLAreaHandle GtkGlAreaNew()
	{
		return GtkGLAreaExterns.gtk_gl_area_new();
	}
}

public class GtkGraphicsOffloadHandle : GtkWidgetHandle
{
}

public class GtkGridHandle : GtkWidgetHandle
{
	public static GtkGridHandle New()
	{
		return GtkGridExterns.gtk_grid_new();
	}
}

public class GtkHeaderBarHandle : GtkWidgetHandle
{
	public static GtkHeaderBarHandle New()
	{
		return GtkHeaderBarExterns.gtk_header_bar_new();
	}
}

public class GtkIconViewHandle : GtkWidgetHandle
{
	public static GtkIconViewHandle New()
	{
		return GtkIconViewExterns.gtk_icon_view_new();
	}
}

public class GtkImageHandle : GtkWidgetHandle
{
	public static GtkImageHandle New()
	{
		return GtkImageExterns.gtk_image_new();
	}

	public static GtkImageHandle NewFromFile(string filename)
	{
		return GtkImageExterns.gtk_image_new_from_file(filename);
	}

	public static GtkImageHandle NewFromResource(string resource_path)
	{
		return GtkImageExterns.gtk_image_new_from_resource(resource_path);
	}

	public static GtkImageHandle NewFromPixbuf(GdkPixbufHandle pixbuf)
	{
		return GtkImageExterns.gtk_image_new_from_pixbuf(pixbuf);
	}

	public static GtkImageHandle NewFromPaintable(GdkPaintableHandle paintable)
	{
		return GtkImageExterns.gtk_image_new_from_paintable(paintable);
	}

	public static GtkImageHandle NewFromIconName(string icon_name)
	{
		return GtkImageExterns.gtk_image_new_from_icon_name(icon_name);
	}

	public static GtkImageHandle NewFromGicon(GIconHandle icon)
	{
		return GtkImageExterns.gtk_image_new_from_gicon(icon);
	}
}

public class GtkInfoBarHandle : GtkWidgetHandle
{
	public static GtkInfoBarHandle New()
	{
		return GtkInfoBarExterns.gtk_info_bar_new();
	}

	public static GtkInfoBarHandle NewWithButtons(string first_button_text, IntPtr @__arglist)
	{
		return GtkInfoBarExterns.gtk_info_bar_new_with_buttons(first_button_text, @__arglist);
	}
}

public class GtkInscriptionHandle : GtkWidgetHandle
{
}

public class GtkLabelHandle : GtkWidgetHandle
{
	public static GtkLabelHandle New(string str)
	{
		return GtkLabelExterns.gtk_label_new(str);
	}

	public static GtkLabelHandle NewWithMnemonic(string str)
	{
		return GtkLabelExterns.gtk_label_new_with_mnemonic(str);
	}
}

public class GtkLevelBarHandle : GtkWidgetHandle
{
	public static GtkLevelBarHandle New()
	{
		return GtkLevelBarExterns.gtk_level_bar_new();
	}

	public static GtkLevelBarHandle NewForInterval(double min_value, double max_value)
	{
		return GtkLevelBarExterns.gtk_level_bar_new_for_interval(min_value, max_value);
	}
}

public class GtkListBaseHandle : GtkWidgetHandle
{
}

public class GtkListBoxHandle : GtkWidgetHandle
{
	public static GtkListBoxHandle New()
	{
		return GtkListBoxExterns.gtk_list_box_new();
	}
}

public class GtkListBoxRowHandle : GtkWidgetHandle
{
	public static GtkListBoxRowHandle New()
	{
		return GtkListBoxRowExterns.gtk_list_box_row_new();
	}
}

public class GtkMediaControlsHandle : GtkWidgetHandle
{
}

public class GtkMenuButtonHandle : GtkWidgetHandle
{
	public static GtkMenuButtonHandle New()
	{
		return GtkMenuButtonExterns.gtk_menu_button_new();
	}
}

public class GtkNotebookHandle : GtkWidgetHandle
{
	public static GtkNotebookHandle New()
	{
		return GtkNotebookExterns.gtk_notebook_new();
	}
}

public class GtkOverlayHandle : GtkWidgetHandle
{
	public static GtkOverlayHandle New()
	{
		return GtkOverlayExterns.gtk_overlay_new();
	}
}

public class GtkPanedHandle : GtkWidgetHandle
{
	public static GtkPanedHandle New(GtkOrientation orientation)
	{
		return GtkPanedExterns.gtk_paned_new(orientation);
	}
}

public class GtkPasswordEntryHandle : GtkWidgetHandle
{
	public static GtkPasswordEntryHandle New()
	{
		return GtkPasswordEntryExterns.gtk_password_entry_new();
	}
}

public class GtkPictureHandle : GtkWidgetHandle
{
	public static GtkPictureHandle New()
	{
		return GtkPictureExterns.gtk_picture_new();
	}

	public static GtkPictureHandle NewForPaintable(GdkPaintableHandle paintable)
	{
		return GtkPictureExterns.gtk_picture_new_for_paintable(paintable);
	}

	public static GtkPictureHandle NewForPixbuf(GdkPixbufHandle pixbuf)
	{
		return GtkPictureExterns.gtk_picture_new_for_pixbuf(pixbuf);
	}

	public static GtkPictureHandle NewForFile(GFileHandle file)
	{
		return GtkPictureExterns.gtk_picture_new_for_file(file);
	}

	public static GtkPictureHandle NewForFilename(string filename)
	{
		return GtkPictureExterns.gtk_picture_new_for_filename(filename);
	}

	public static GtkPictureHandle NewForResource(string resource_path)
	{
		return GtkPictureExterns.gtk_picture_new_for_resource(resource_path);
	}
}

public class GtkPopoverHandle : GtkWidgetHandle
{
	public static GtkPopoverHandle New()
	{
		return GtkPopoverExterns.gtk_popover_new();
	}
}

public class GtkPopoverMenuBarHandle : GtkWidgetHandle
{
	public static GtkPopoverMenuBarHandle NewFromModel(GMenuModelHandle model)
	{
		return GtkPopoverMenuBarExterns.gtk_popover_menu_bar_new_from_model(model);
	}
}

public class GtkProgressBarHandle : GtkWidgetHandle
{
	public static GtkProgressBarHandle New()
	{
		return GtkProgressBarExterns.gtk_progress_bar_new();
	}
}

public class GtkRangeHandle : GtkWidgetHandle
{
}

public class GtkRevealerHandle : GtkWidgetHandle
{
	public static GtkRevealerHandle New()
	{
		return GtkRevealerExterns.gtk_revealer_new();
	}
}

public class GtkScaleButtonHandle : GtkWidgetHandle
{
	public static GtkScaleButtonHandle New(double min, double max, double step, string[] icons)
	{
		return GtkScaleButtonExterns.gtk_scale_button_new(min, max, step, icons);
	}
}

public class GtkScrollbarHandle : GtkWidgetHandle
{
	public static GtkScrollbarHandle New(GtkOrientation orientation, GtkAdjustmentHandle adjustment)
	{
		return GtkScrollbarExterns.gtk_scrollbar_new(orientation, adjustment);
	}
}

public class GtkScrolledWindowHandle : GtkWidgetHandle
{
	public static GtkScrolledWindowHandle New()
	{
		return GtkScrolledWindowExterns.gtk_scrolled_window_new();
	}
}

public class GtkSearchBarHandle : GtkWidgetHandle
{
	public static GtkSearchBarHandle New()
	{
		return GtkSearchBarExterns.gtk_search_bar_new();
	}
}

public class GtkSearchEntryHandle : GtkWidgetHandle
{
	public static GtkSearchEntryHandle New()
	{
		return GtkSearchEntryExterns.gtk_search_entry_new();
	}
}

public class GtkSeparatorHandle : GtkWidgetHandle
{
	public static GtkSeparatorHandle New(GtkOrientation orientation)
	{
		return GtkSeparatorExterns.gtk_separator_new(orientation);
	}
}

public class GtkShortcutLabelHandle : GtkWidgetHandle
{
	public static GtkShortcutLabelHandle New(string accelerator)
	{
		return GtkShortcutLabelExterns.gtk_shortcut_label_new(accelerator);
	}
}

public class GtkShortcutsShortcutHandle : GtkWidgetHandle
{
}

public class GtkSpinButtonHandle : GtkWidgetHandle
{
	public static GtkSpinButtonHandle NewWithRange(double min, double max, double step)
	{
		return GtkSpinButtonExterns.gtk_spin_button_new_with_range(min, max, step);
	}
}

public class GtkSpinnerHandle : GtkWidgetHandle
{
	public static GtkSpinnerHandle New()
	{
		return GtkSpinnerExterns.gtk_spinner_new();
	}
}

public class GtkStackHandle : GtkWidgetHandle
{
	public static GtkStackHandle New()
	{
		return GtkStackExterns.gtk_stack_new();
	}
}

public class GtkStackSidebarHandle : GtkWidgetHandle
{
	public static GtkStackSidebarHandle New()
	{
		return GtkStackSidebarExterns.gtk_stack_sidebar_new();
	}
}

public class GtkStackSwitcherHandle : GtkWidgetHandle
{
	public static GtkStackSwitcherHandle New()
	{
		return GtkStackSwitcherExterns.gtk_stack_switcher_new();
	}
}

public class GtkStatusbarHandle : GtkWidgetHandle
{
	public static GtkStatusbarHandle New()
	{
		return GtkStatusbarExterns.gtk_statusbar_new();
	}
}

public class GtkSwitchHandle : GtkWidgetHandle
{
	public static GtkSwitchHandle New()
	{
		return GtkSwitchExterns.gtk_switch_new();
	}
}

public class GtkTextHandle : GtkWidgetHandle
{
	public static GtkTextHandle New()
	{
		return GtkTextExterns.gtk_text_new();
	}
}

public class GtkTextViewHandle : GtkWidgetHandle
{
	public static GtkTextViewHandle New()
	{
		return GtkTextViewExterns.gtk_text_view_new();
	}
}

public class GtkTreeExpanderHandle : GtkWidgetHandle
{
	public static GtkTreeExpanderHandle New()
	{
		return GtkTreeExpanderExterns.gtk_tree_expander_new();
	}
}

public class GtkTreeViewHandle : GtkWidgetHandle
{
	public static GtkTreeViewHandle New()
	{
		return GtkTreeViewExterns.gtk_tree_view_new();
	}
}

public class GtkVideoHandle : GtkWidgetHandle
{
	public static GtkVideoHandle New()
	{
		return GtkVideoExterns.gtk_video_new();
	}

	public static GtkVideoHandle NewForFile(GFileHandle file)
	{
		return GtkVideoExterns.gtk_video_new_for_file(file);
	}

	public static GtkVideoHandle NewForFilename(string filename)
	{
		return GtkVideoExterns.gtk_video_new_for_filename(filename);
	}

	public static GtkVideoHandle NewForResource(string resource_path)
	{
		return GtkVideoExterns.gtk_video_new_for_resource(resource_path);
	}
}

public class GtkViewportHandle : GtkWidgetHandle
{
}

public class GtkWindowHandle : GtkWidgetHandle
{
	public static GtkWindowHandle New()
	{
		return GtkWindowExterns.gtk_window_new();
	}
}

public class GtkWindowControlsHandle : GtkWidgetHandle
{
	public static GtkWindowControlsHandle New(GtkPackType side)
	{
		return GtkWindowControlsExterns.gtk_window_controls_new(side);
	}
}

public class GtkWindowHandleHandle : GtkWidgetHandle
{
	public static GtkWindowHandleHandle New()
	{
		return GtkWindowHandleExterns.gtk_window_handle_new();
	}
}

public class GtkAboutDialogHandle : GtkWindowHandle
{
	public static GtkAboutDialogHandle New()
	{
		return GtkAboutDialogExterns.gtk_about_dialog_new();
	}
}

public class GtkApplicationWindowHandle : GtkWindowHandle
{
}

public class GtkAssistantHandle : GtkWindowHandle
{
	public static GtkAssistantHandle New()
	{
		return GtkAssistantExterns.gtk_assistant_new();
	}
}

public class GtkDialogHandle : GtkWindowHandle
{
	public static GtkDialogHandle New()
	{
		return GtkDialogExterns.gtk_dialog_new();
	}

	public static GtkDialogHandle NewWithButtons(string title, GtkWindowHandle parent, GtkDialogFlags flags, string first_button_text, IntPtr @__arglist)
	{
		return GtkDialogExterns.gtk_dialog_new_with_buttons(title, parent, flags, first_button_text, @__arglist);
	}
}

public class GtkShortcutsWindowHandle : GtkWindowHandle
{
}

public class GtkApplicationHandle : GApplicationHandle
{
	public static GtkApplicationHandle New(string application_id, GApplicationFlags flags)
	{
		return GtkApplicationExterns.gtk_application_new(application_id, flags);
	}
}
