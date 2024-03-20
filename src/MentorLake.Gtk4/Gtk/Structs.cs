using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;

public struct GtkMessageDialogClass { }
public struct GtkListItemClass { }
public struct GtkEditableLabel { }
public struct GtkSeparator { }

public struct GtkCustomLayoutClass
{
	public GtkLayoutManagerClass parent_class;
}

public struct GtkGestureDragClass { }
public struct GtkDragIcon { }

public struct GtkDialogClass
{
	public GtkWindowClass parent_class;
	public IntPtr response;
	public IntPtr close;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkDropControllerMotion { }

public struct GtkNativeDialog
{
	public GObject.GObject parent_instance;
}

public struct GtkShortcutsSectionClass { }

public struct GtkScaleButton
{
	public GtkWidget parent_instance;
}

public struct GtkHeaderBar { }

public struct GtkListStore
{
	public GObject.GObject parent;
	public GtkListStorePrivateHandle priv;
}

public struct GtkAnyFilterClass { }
public struct GtkFontButton { }

public struct GtkBuilderCScopeClass
{
	public GObjectClass parent_class;
}

public struct GtkConstraintTarget { }

public struct GtkBoxClass
{
	public GtkWidgetClass parent_class;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkCustomFilterClass
{
	public GtkFilterClass parent_class;
}

public struct GtkDragIconClass
{
	public GtkWidgetClass parent_class;
}

public struct GtkTreeSortableIface
{
	public GTypeInterface g_iface;
	public IntPtr sort_column_changed;
	public IntPtr get_sort_column_id;
	public IntPtr set_sort_column_id;
	public IntPtr set_sort_func;
	public IntPtr set_default_sort_func;
	public IntPtr has_default_sort_func;
}

public struct GtkBuilderClass { }
public struct GtkCssSection { }

public struct GtkButtonClass
{
	public GtkWidgetClass parent_class;
	public IntPtr clicked;
	public IntPtr activate;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkAssistantPage { }
public struct GtkListItemFactory { }

public struct GtkBuilderScopeInterface
{
	public GTypeInterface g_iface;
	public IntPtr get_type_from_name;
	public IntPtr get_type_from_function;
	public IntPtr create_closure;
}

public struct GtkWindowControls { }
public struct GtkEventControllerMotionClass { }
public struct GtkListBaseClass { }
public struct GtkListView { }

public struct GtkWindowGroup
{
	public GObject.GObject parent_instance;
	public GtkWindowGroupPrivateHandle priv;
}

public struct GtkTreeSelection { }

public struct GtkTextTagClass
{
	public GObjectClass parent_class;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkShortcutLabel { }

public struct GtkCellRendererTextClass
{
	public GtkCellRendererClass parent_class;
	public IntPtr edited;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkGridLayoutClass
{
	public GtkLayoutManagerClass parent_class;
}

public struct GtkShortcutController { }
public struct GtkPadController { }
public struct GtkGestureRotate { }
public struct GtkTreeRowReference { }

public struct GtkFrameClass
{
	public GtkWidgetClass parent_class;
	public IntPtr compute_child_allocation;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkFontChooserDialog { }
public struct GtkExpander { }
public struct GtkEventControllerFocus { }

public struct GtkPopoverClass
{
	public GtkWidgetClass parent_class;
	public IntPtr closed;
	public IntPtr activate_default;
	public IntPtr reserved;

	public struct _reserved_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkStringListClass
{
	public GObjectClass parent_class;
}

public struct GtkOverlayLayoutChild { }
public struct GtkTreeModelFilterPrivate { }
public struct GtkListBase { }

public struct GtkRecentManagerClass
{
	public GObjectClass parent_class;
	public IntPtr changed;
	public IntPtr _gtk_recent1;
	public IntPtr _gtk_recent2;
	public IntPtr _gtk_recent3;
	public IntPtr _gtk_recent4;
}

public struct GtkLayoutChild
{
	public GObject.GObject parent_instance;
}

public struct GtkShortcutActionClass { }

public struct GtkSortListModelClass
{
	public GObjectClass parent_class;
}

public struct GtkConstraintGuideClass
{
	public GObjectClass parent_class;
}

public struct GtkGestureSingleClass { }
public struct GtkLinkButton { }

public struct GtkTreeModelIface
{
	public GTypeInterface g_iface;
	public IntPtr row_changed;
	public IntPtr row_inserted;
	public IntPtr row_has_child_toggled;
	public IntPtr row_deleted;
	public IntPtr rows_reordered;
	public IntPtr get_flags;
	public IntPtr get_n_columns;
	public IntPtr get_column_type;
	public IntPtr get_iter;
	public IntPtr get_path;
	public IntPtr get_value;
	public IntPtr iter_next;
	public IntPtr iter_previous;
	public IntPtr iter_children;
	public IntPtr iter_has_child;
	public IntPtr iter_n_children;
	public IntPtr iter_nth_child;
	public IntPtr iter_parent;
	public IntPtr ref_node;
	public IntPtr unref_node;
}

public struct GtkEventControllerClass { }
public struct GtkPasswordEntryBuffer { }
public struct GtkPaperSize { }

public struct GtkStringSorterClass
{
	public GtkSorterClass parent_class;
}

public struct GtkDragSource { }
public struct GtkCellRendererAccel { }

public struct GtkStringFilterClass
{
	public GtkFilterClass parent_class;
}

public struct GtkStackSwitcher { }

public struct GtkTreeIter
{
	public int stamp;
	public IntPtr user_data;
	public IntPtr user_data2;
	public IntPtr user_data3;
}

public struct GtkTreeDragSourceIface
{
	public GTypeInterface g_iface;
	public IntPtr row_draggable;
	public IntPtr drag_data_get;
	public IntPtr drag_data_delete;
}

public struct GtkNoSelection { }

public struct GtkTreeModelSortClass
{
	public GObjectClass parent_class;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkBitsetIter
{
	public IntPtr private_data;

	public struct _private_data_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
		public IntPtr e8;
		public IntPtr e9;
	}
}

public struct GtkSliceListModel { }
public struct GtkGestureDrag { }
public struct GtkShortcutManager { }

public struct GtkWidgetPaintableClass
{
	public GObjectClass parent_class;
}

public struct GtkCalendar { }
public struct GtkExpressionWatch { }

public struct GtkCustomSorterClass
{
	public GtkSorterClass parent_class;
}

public struct GtkPopover
{
	public GtkWidget parent;
}

public struct GtkBuilderListItemFactoryClass { }
public struct GtkProgressBar { }
public struct GtkAppChooser { }

public struct GtkScrollableInterface
{
	public GTypeInterface base_iface;
	public IntPtr get_border;
}

public struct GtkIMContextSimpleClass
{
	public GtkIMContextClass parent_class;
}

public struct GtkListBoxRow
{
	public GtkWidget parent_instance;
}

public struct GtkRecentData
{
	public string display_name;
	public string description;
	public string mime_type;
	public string app_name;
	public string app_exec;
	public string[] groups;
	public int is_private;
}

public struct GtkPasswordEntry { }

public struct GtkScale
{
	public GtkRange parent_instance;
}

public struct GtkShortcutManagerInterface
{
	public GTypeInterface g_iface;
	public IntPtr add_controller;
	public IntPtr remove_controller;
}

public struct GtkGLArea
{
	public GtkWidget parent_instance;
}

public struct GtkGridViewClass { }
public struct GtkGridLayout { }
public struct GtkGesturePanClass { }
public struct GtkColumnViewColumn { }
public struct GtkMultiFilterClass { }
public struct GtkTextViewPrivate { }
public struct GtkIMContextSimplePrivate { }

public struct GtkWindowGroupClass
{
	public GObjectClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}

public struct GtkTooltip { }
public struct GtkCellAreaContextPrivate { }
public struct GtkStyleProvider { }
public struct GtkPopoverMenuBar { }
public struct GtkActivateAction { }
public struct GtkSwitch { }
public struct GtkSignalAction { }
public struct GtkConstraintTargetInterface { }
public struct GtkGestureClickClass { }
public struct GtkSearchBar { }
public struct GtkSignalActionClass { }
public struct GtkCustomLayout { }
public struct GtkNothingAction { }
public struct GtkPrintOperationPreview { }
public struct GtkFlattenListModel { }
public struct GtkNotebook { }

public struct GtkEntry
{
	public GtkWidget parent_instance;
}

public struct GtkDropControllerMotionClass { }
public struct GtkTreeListRow { }

public struct GtkNumericSorterClass
{
	public GtkSorterClass parent_class;
}

public struct GtkStack { }
public struct GtkTreeListRowSorter { }
public struct GtkColorChooserWidget { }

public struct GtkFontChooserIface
{
	public GTypeInterface base_iface;
	public IntPtr get_font_family;
	public IntPtr get_font_face;
	public IntPtr get_font_size;
	public IntPtr set_filter_func;
	public IntPtr font_activated;
	public IntPtr set_font_map;
	public IntPtr get_font_map;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
		public IntPtr e8;
		public IntPtr e9;
	}
}

public struct GtkCellArea
{
	public GObject.GObject parent_instance;
}

public struct GtkApplicationWindow
{
	public GtkWindow parent_instance;
}

public struct GtkListViewClass { }

public struct GtkTextBuffer
{
	public GObject.GObject parent_instance;
	public GtkTextBufferPrivateHandle priv;
}

public struct GtkConstraint { }

public struct GtkPageRange
{
	public int start;
	public int end;
}

public struct GtkCellRendererSpin { }
public struct GtkConstraintLayoutChild { }
public struct GtkGestureSingle { }

public struct GtkSelectionFilterModelClass
{
	public GObjectClass parent_class;
}

public struct GtkSearchEntry { }

public struct GtkLayoutChildClass
{
	public GObjectClass parent_class;
}

public struct GtkGesturePan { }
public struct GtkFixedLayoutChild { }

public struct GtkMessageDialog
{
	public GtkDialog parent_instance;
}

public struct GtkEventControllerKeyClass { }

public struct GtkEditableInterface
{
	public GTypeInterface base_iface;
	public IntPtr insert_text;
	public IntPtr delete_text;
	public IntPtr changed;
	public IntPtr get_text;
	public IntPtr do_insert_text;
	public IntPtr do_delete_text;
	public IntPtr get_selection_bounds;
	public IntPtr set_selection_bounds;
	public IntPtr get_delegate;
}

public struct GtkPasswordEntryBufferClass
{
	public GtkEntryBufferClass parent_class;
}

public struct GtkAspectFrame { }

public struct GtkEntryBufferClass
{
	public GObjectClass parent_class;
	public IntPtr inserted_text;
	public IntPtr deleted_text;
	public IntPtr get_text;
	public IntPtr get_length;
	public IntPtr insert_text;
	public IntPtr delete_text;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
	public IntPtr _gtk_reserved5;
	public IntPtr _gtk_reserved6;
	public IntPtr _gtk_reserved7;
	public IntPtr _gtk_reserved8;
}

public struct GtkStringSorter { }
public struct GtkRoot { }
public struct GtkShortcutLabelClass { }

public struct GtkMultiSelectionClass
{
	public GObjectClass parent_class;
}

public struct GtkFileFilter { }
public struct GtkActivateActionClass { }

public struct GtkWidgetClass
{
	public GObjectClass parent_class;
	public IntPtr show;
	public IntPtr hide;
	public IntPtr map;
	public IntPtr unmap;
	public IntPtr realize;
	public IntPtr unrealize;
	public IntPtr root;
	public IntPtr unroot;
	public IntPtr size_allocate;
	public IntPtr state_flags_changed;
	public IntPtr direction_changed;
	public IntPtr get_request_mode;
	public IntPtr measure;
	public IntPtr mnemonic_activate;
	public IntPtr grab_focus;
	public IntPtr focus;
	public IntPtr set_focus_child;
	public IntPtr move_focus;
	public IntPtr keynav_failed;
	public IntPtr query_tooltip;
	public IntPtr compute_expand;
	public IntPtr css_changed;
	public IntPtr system_setting_changed;
	public IntPtr snapshot;
	public IntPtr contains;
	public GtkWidgetClassPrivateHandle priv;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkShortcutsGroupClass { }
public struct GtkFlowBox { }

public struct GtkTreeListRowClass
{
	public GObjectClass parent_class;
}

public struct GtkFixedLayoutClass
{
	public GtkLayoutManagerClass parent_class;
}

public struct GtkIconView { }
public struct GtkATContextClass { }

public struct GtkFlattenListModelClass
{
	public GObjectClass parent_class;
}

public struct GtkSliceListModelClass
{
	public GObjectClass parent_class;
}

public struct GtkColorButton { }
public struct GtkCenterBox { }
public struct GtkGridView { }
public struct GtkIconPaintable { }

public struct GtkTextViewClass
{
	public GtkWidgetClass parent_class;
	public IntPtr move_cursor;
	public IntPtr set_anchor;
	public IntPtr insert_at_cursor;
	public IntPtr delete_from_cursor;
	public IntPtr backspace;
	public IntPtr cut_clipboard;
	public IntPtr copy_clipboard;
	public IntPtr paste_clipboard;
	public IntPtr toggle_overwrite;
	public IntPtr create_buffer;
	public IntPtr snapshot_layer;
	public IntPtr extend_selection;
	public IntPtr insert_emoji;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkGrid
{
	public GtkWidget parent_instance;
}

public struct GtkPrintOperationClass
{
	public GObjectClass parent_class;
	public IntPtr done;
	public IntPtr begin_print;
	public IntPtr paginate;
	public IntPtr request_page_setup;
	public IntPtr draw_page;
	public IntPtr end_print;
	public IntPtr status_changed;
	public IntPtr create_custom_widget;
	public IntPtr custom_widget_apply;
	public IntPtr preview;
	public IntPtr update_custom_widget;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkOverlay { }
public struct GtkGestureZoom { }

public struct GtkFileChooserNativeClass
{
	public GtkNativeDialogClass parent_class;
}

public struct GtkBookmarkList { }
public struct GtkShortcutControllerClass { }

public struct GtkConstraintLayoutClass
{
	public GtkLayoutManagerClass parent_class;
}

public struct GtkMultiSorterClass
{
	public GtkSorterClass parent_class;
}

public struct GtkSpinner { }
public struct GtkSettings { }
public struct GtkObjectExpression { }
public struct GtkBitset { }
public struct GtkStringList { }
public struct GtkTreeModel { }
public struct GtkListBox { }
public struct GtkGestureLongPress { }
public struct GtkNative { }
public struct GtkEntryCompletion { }

public struct GtkEntryBuffer
{
	public GObject.GObject parent_instance;
}

public struct GtkEditableLabelClass
{
	public GtkWidgetClass parent_class;
}

public struct GtkToggleButtonClass
{
	public GtkButtonClass parent_class;
	public IntPtr toggled;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkToggleButton
{
	public GtkButton button;
}

public struct GtkAnyFilter { }
public struct GtkDirectoryList { }
public struct GtkGestureZoomClass { }
public struct GtkShortcutTrigger { }
public struct GtkNeverTrigger { }
public struct GtkAccessible { }

public struct GtkEntryClass
{
	public GtkWidgetClass parent_class;
	public IntPtr activate;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkEventControllerMotion { }

public struct GtkRecentManager
{
	public GObject.GObject parent_instance;
	public GtkRecentManagerPrivateHandle priv;
}

public struct GtkMapListModelClass
{
	public GObjectClass parent_class;
}

public struct GtkFixedLayoutChildClass
{
	public GtkLayoutChildClass parent_class;
}

public struct GtkFileChooserDialog { }
public struct GtkCellView { }
public struct GtkAlternativeTriggerClass { }

public struct GtkBoolFilterClass
{
	public GtkFilterClass parent_class;
}

public struct GtkParamSpecExpression
{
	public GParamSpec parent_instance;
}

public struct GtkFixedLayout { }
public struct GtkEventController { }

public struct GtkTreeListModelClass
{
	public GObjectClass parent_class;
}

public struct GtkShortcutAction { }

public struct GtkPrintOperationPreviewIface
{
	public GTypeInterface g_iface;
	public IntPtr ready;
	public IntPtr got_page_size;
	public IntPtr render_page;
	public IntPtr is_selected;
	public IntPtr end_preview;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
	public IntPtr _gtk_reserved5;
	public IntPtr _gtk_reserved6;
	public IntPtr _gtk_reserved7;
	public IntPtr _gtk_reserved8;
}

public struct GtkCellRendererCombo { }
public struct GtkDropTargetAsync { }
public struct GtkATContext { }

public struct GtkDrawingAreaClass
{
	public GtkWidgetClass parent_class;
	public IntPtr resize;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkTreeStoreClass
{
	public GObjectClass parent_class;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkIMContextSimple
{
	public GtkIMContext @object;
	public GtkIMContextSimplePrivateHandle priv;
}

public struct GtkRecentManagerPrivate { }
public struct GtkLabel { }
public struct GtkNativeInterface { }

public struct GtkRange
{
	public GtkWidget parent_instance;
}

public struct GtkFileChooserWidget { }

public struct GtkPrintOperation
{
	public GObject.GObject parent_instance;
	public GtkPrintOperationPrivateHandle priv;
}

public struct GtkApplicationWindowClass
{
	public GtkWindowClass parent_class;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkActionBar { }

public struct GtkOrientableIface
{
	public GTypeInterface base_iface;
}

public struct GtkWidgetClassPrivate { }
public struct GtkPrintSettings { }

public struct GtkFlowBoxChild
{
	public GtkWidget parent_instance;
}

public struct GtkVideoClass
{
	public GtkWidgetClass parent_class;
}

public struct GtkApplicationClass
{
	public GApplicationClass parent_class;
	public IntPtr window_added;
	public IntPtr window_removed;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkStackPage { }
public struct GtkEventControllerScrollClass { }

public struct GtkConstraintLayoutChildClass
{
	public GtkLayoutChildClass parent_class;
}

public struct GtkPropertyExpression { }
public struct GtkAssistant { }
public struct GtkAppChooserDialog { }
public struct GtkShortcutsSection { }
public struct GtkShortcutsShortcutClass { }
public struct GtkPicture { }

public struct GtkSelectionModelInterface
{
	public GTypeInterface g_iface;
	public IntPtr is_selected;
	public IntPtr get_selection_in_range;
	public IntPtr select_item;
	public IntPtr unselect_item;
	public IntPtr select_range;
	public IntPtr unselect_range;
	public IntPtr select_all;
	public IntPtr unselect_all;
	public IntPtr set_selection;
}

public struct GtkGridLayoutChild { }
public struct GtkAppChooserButton { }
public struct GtkCssStyleChange { }
public struct GtkKeyvalTrigger { }
public struct GtkMnemonicAction { }

public struct GtkOverlayLayoutChildClass
{
	public GtkLayoutChildClass parent_class;
}

public struct GtkButtonPrivate { }
public struct GtkDropTarget { }
public struct GtkTreePath { }
public struct GtkRootInterface { }
public struct GtkMnemonicActionClass { }
public struct GtkPadControllerClass { }
public struct GtkConstraintLayout { }
public struct GtkInfoBar { }
public struct GtkViewport { }
public struct GtkRecentInfo { }

public struct GtkOverlayLayoutClass
{
	public GtkLayoutManagerClass parent_class;
}

public struct GtkCellRendererPrivate { }

public struct GtkTextChildAnchor
{
	public GObject.GObject parent_instance;
	public IntPtr segment;
}

public struct GtkFilterListModel { }
public struct GtkShortcutsShortcut { }
public struct GtkCenterLayout { }
public struct GtkTextBufferPrivate { }
public struct GtkGestureSwipeClass { }
public struct GtkDragSourceClass { }
public struct GtkEventControllerFocusClass { }

public struct GtkDropDownClass
{
	public GtkWidgetClass parent_class;
}

public struct GtkApplication
{
	public GApplication parent_instance;
}

public struct GtkFilter
{
	public GObject.GObject parent_instance;
}

public struct GtkMediaStream
{
	public GObject.GObject parent_instance;
}

public struct GtkGestureLongPressClass { }

public struct GtkTreeViewClass
{
	public GtkWidgetClass parent_class;
	public IntPtr row_activated;
	public IntPtr test_expand_row;
	public IntPtr test_collapse_row;
	public IntPtr row_expanded;
	public IntPtr row_collapsed;
	public IntPtr columns_changed;
	public IntPtr cursor_changed;
	public IntPtr move_cursor;
	public IntPtr select_all;
	public IntPtr unselect_all;
	public IntPtr select_cursor_row;
	public IntPtr toggle_cursor_row;
	public IntPtr expand_collapse_cursor_row;
	public IntPtr select_cursor_parent;
	public IntPtr start_interactive_search;
	public IntPtr _reserved;

	public struct __reserved_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
		public IntPtr e8;
		public IntPtr e9;
		public IntPtr e10;
		public IntPtr e11;
		public IntPtr e12;
		public IntPtr e13;
		public IntPtr e14;
		public IntPtr e15;
	}
}

public struct GtkWindowHandleClass
{
	public GtkWidgetClass parent_class;
}

public struct GtkMultiSelection { }
public struct GtkBoolFilter { }
public struct GtkMenuButton { }
public struct GtkFileChooserNative { }
public struct GtkNeverTriggerClass { }
public struct GtkListStorePrivate { }
public struct GtkShortcutsWindow { }
public struct GtkTreeListModel { }
public struct GtkSingleSelection { }

public struct GtkBuilderCScope
{
	public GObject.GObject parent_instance;
}

public struct GtkBorder
{
	public short left;
	public short right;
	public short top;
	public short bottom;
}

public struct GtkScaleClass
{
	public GtkRangeClass parent_class;
	public IntPtr get_layout_offsets;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkScrolledWindow { }
public struct GtkEditable { }

public struct GtkConstraintClass
{
	public GObjectClass parent_class;
}

public struct GtkPageSetup { }

public struct GtkActionableInterface
{
	public GTypeInterface g_iface;
	public IntPtr get_action_name;
	public IntPtr set_action_name;
	public IntPtr get_action_target_value;
	public IntPtr set_action_target_value;
}

public struct GtkAdjustment
{
	public GObject.GObject parent_instance;
}

public struct GtkTextTagTable { }

public struct GtkCellRenderer
{
	public GObject.GObject parent_instance;
	public GtkCellRendererPrivateHandle priv;
}

public struct GtkScaleButtonClass
{
	public GtkWidgetClass parent_class;
	public IntPtr value_changed;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkTreeModelFilterClass
{
	public GObjectClass parent_class;
	public IntPtr visible;
	public IntPtr modify;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkWindowControlsClass
{
	public GtkWidgetClass parent_class;
}

public struct GtkButton
{
	public GtkWidget parent_instance;
}

public struct GtkSignalListItemFactory { }
public struct GtkCssProviderPrivate { }

public struct GtkCellAreaContext
{
	public GObject.GObject parent_instance;
}

public struct GtkConstraintGuide { }
public struct GtkCssProviderClass { }
public struct GtkSnapshotClass { }

public struct GtkSizeGroup
{
	public GObject.GObject parent_instance;
}

public struct GtkEveryFilterClass { }
public struct GtkSelectionFilterModel { }

public struct GtkPictureClass
{
	public GtkWidgetClass parent_class;
}

public struct GtkStringObject { }
public struct GtkActionable { }
public struct GtkScrollbar { }
public struct GtkBinLayout { }
public struct GtkEmojiChooser { }

public struct GtkBookmarkListClass
{
	public GObjectClass parent_class;
}

public struct GtkBinLayoutClass
{
	public GtkLayoutManagerClass parent_class;
}

public struct GtkTreeStore
{
	public GObject.GObject parent;
	public GtkTreeStorePrivateHandle priv;
}

public struct GtkCallbackAction { }

public struct GtkMediaControlsClass
{
	public GtkWidgetClass parent_class;
}

public struct GtkCustomSorter { }

public struct GtkTreeView
{
	public GtkWidget parent_instance;
}

public struct GtkMultiSorter { }
public struct GtkAccessibleInterface { }
public struct GtkAlternativeTrigger { }

public struct GtkStyleContextClass
{
	public GObjectClass parent_class;
	public IntPtr changed;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}

public struct GtkAppChooserWidget { }

public struct GtkCellAreaContextClass
{
	public GObjectClass parent_class;
	public IntPtr allocate;
	public IntPtr reset;
	public IntPtr get_preferred_height_for_width;
	public IntPtr get_preferred_width_for_height;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkExpression { }

public struct GtkSorterClass
{
	public GObjectClass parent_class;
	public IntPtr compare;
	public IntPtr get_order;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
	public IntPtr _gtk_reserved5;
	public IntPtr _gtk_reserved6;
	public IntPtr _gtk_reserved7;
	public IntPtr _gtk_reserved8;
}

public struct GtkCenterLayoutClass
{
	public GtkLayoutManagerClass parent_class;
}

public struct GtkDropTargetClass { }

public struct GtkBox
{
	public GtkWidget parent_instance;
}

public struct GtkDropTargetAsyncClass { }
public struct GtkBuildableParseContext { }

public struct GtkSorter
{
	public GObject.GObject parent_instance;
}

public struct GtkFilterClass
{
	public GObjectClass parent_class;
	public IntPtr match;
	public IntPtr get_strictness;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
	public IntPtr _gtk_reserved5;
	public IntPtr _gtk_reserved6;
	public IntPtr _gtk_reserved7;
	public IntPtr _gtk_reserved8;
}

public struct GtkBoxLayout { }

public struct GtkTextIter
{
	public IntPtr dummy1;
	public IntPtr dummy2;
	public int dummy3;
	public int dummy4;
	public int dummy5;
	public int dummy6;
	public int dummy7;
	public int dummy8;
	public IntPtr dummy9;
	public IntPtr dummy10;
	public int dummy11;
	public int dummy12;
	public int dummy13;
	public IntPtr dummy14;
}

public struct GtkComboBoxClass
{
	public GtkWidgetClass parent_class;
	public IntPtr changed;
	public IntPtr format_entry_text;
	public IntPtr activate;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
	}
}

public struct GtkListBoxRowClass
{
	public GtkWidgetClass parent_class;
	public IntPtr activate;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkMediaFileClass
{
	public GtkMediaStreamClass parent_class;
	public IntPtr open;
	public IntPtr close;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}

public struct GtkMnemonicTrigger { }

public struct GtkTextMark
{
	public GObject.GObject parent_instance;
	public IntPtr segment;
}

public struct GtkShortcutClass
{
	public GObjectClass parent_class;
}

public struct GtkGestureRotateClass { }
public struct GtkPrintContext { }

public struct GtkNativeDialogClass
{
	public GObjectClass parent_class;
	public IntPtr response;
	public IntPtr show;
	public IntPtr hide;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}

public struct GtkEventControllerLegacy { }
public struct GtkGestureStylus { }
public struct GtkOrientable { }
public struct GtkCellLayout { }

public struct GtkLayoutManager
{
	public GObject.GObject parent_instance;
}

public struct GtkTreeListRowSorterClass
{
	public GtkSorterClass parent_class;
}

public struct GtkSpinButton { }

public struct GtkCellRendererText
{
	public GtkCellRenderer parent;
}

public struct GtkSignalListItemFactoryClass { }

public struct GtkSymbolicPaintableInterface
{
	public GTypeInterface g_iface;
	public IntPtr snapshot_symbolic;
}

public struct GtkGestureClass { }

public struct GtkAdjustmentClass
{
	public GObjectClass parent_class;
	public IntPtr changed;
	public IntPtr value_changed;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}

public struct GtkCellRendererPixbuf { }

public struct GtkStringObjectClass
{
	public GObjectClass parent_class;
}

public struct GtkComboBox
{
	public GtkWidget parent_instance;
}

public struct GtkLayoutManagerClass
{
	public GObjectClass parent_class;
	public IntPtr get_request_mode;
	public IntPtr measure;
	public IntPtr allocate;
	public GType layout_child_type;
	public IntPtr create_layout_child;
	public IntPtr root;
	public IntPtr unroot;
	public IntPtr _padding;

	public struct __padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
		public IntPtr e8;
		public IntPtr e9;
		public IntPtr e10;
		public IntPtr e11;
		public IntPtr e12;
		public IntPtr e13;
		public IntPtr e14;
		public IntPtr e15;
	}
}

public struct GtkEmojiChooserClass { }
public struct GtkStringFilter { }

public struct GtkTreeExpanderClass
{
	public GtkWidgetClass parent_class;
}

public struct GtkKeyvalTriggerClass { }
public struct GtkScrollable { }

public struct GtkGridClass
{
	public GtkWidgetClass parent_class;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkColorChooserInterface
{
	public GTypeInterface base_interface;
	public IntPtr get_rgba;
	public IntPtr set_rgba;
	public IntPtr add_palette;
	public IntPtr color_activated;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
		public IntPtr e8;
		public IntPtr e9;
		public IntPtr e10;
		public IntPtr e11;
	}
}

public struct GtkNamedActionClass { }
public struct GtkStatusbar { }
public struct GtkListItemFactoryClass { }

public struct GtkRequestedSize
{
	public IntPtr data;
	public int minimum_size;
	public int natural_size;
}

public struct GtkCheckButtonClass
{
	public GtkWidgetClass parent_class;
	public IntPtr toggled;
	public IntPtr activate;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
	}
}

public struct GtkCellEditableIface
{
	public GTypeInterface g_iface;
	public IntPtr editing_done;
	public IntPtr remove_widget;
	public IntPtr start_editing;
}

public struct GtkMountOperationPrivate { }
public struct GtkFontChooser { }

public struct GtkCellRendererClass
{
	public GObjectClass parent_class;
	public IntPtr get_request_mode;
	public IntPtr get_preferred_width;
	public IntPtr get_preferred_height_for_width;
	public IntPtr get_preferred_height;
	public IntPtr get_preferred_width_for_height;
	public IntPtr get_aligned_area;
	public IntPtr snapshot;
	public IntPtr activate;
	public IntPtr start_editing;
	public IntPtr editing_canceled;
	public IntPtr editing_started;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkVolumeButton
{
	public GtkScaleButton parent;
}

public struct GtkIconTheme { }

public struct GtkBoxLayoutClass
{
	public GtkLayoutManagerClass parent_class;
}

public struct GtkTreeModelFilter
{
	public GObject.GObject parent;
	public GtkTreeModelFilterPrivateHandle priv;
}

public struct GtkMountOperationClass
{
	public GMountOperationClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}

public struct GtkCustomFilter { }

public struct GtkTreeModelSort
{
	public GObject.GObject parent;
	public GtkTreeModelSortPrivateHandle priv;
}

public struct GtkCssLocation
{
	public nuint bytes;
	public nuint chars;
	public nuint lines;
	public nuint line_bytes;
	public nuint line_chars;
}

public struct GtkColumnViewClass { }
public struct GtkNamedAction { }
public struct GtkWidgetPaintable { }

public struct GtkWindowClass
{
	public GtkWidgetClass parent_class;
	public IntPtr activate_focus;
	public IntPtr activate_default;
	public IntPtr keys_changed;
	public IntPtr enable_debugging;
	public IntPtr close_request;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkPaned { }

public struct GtkCellAreaClass
{
	public GObjectClass parent_class;
	public IntPtr add;
	public IntPtr remove;
	public IntPtr @foreach;
	public IntPtr foreach_alloc;
	public IntPtr @event;
	public IntPtr snapshot;
	public IntPtr apply_attributes;
	public IntPtr create_context;
	public IntPtr copy_context;
	public IntPtr get_request_mode;
	public IntPtr get_preferred_width;
	public IntPtr get_preferred_height_for_width;
	public IntPtr get_preferred_height;
	public IntPtr get_preferred_width_for_height;
	public IntPtr set_cell_property;
	public IntPtr get_cell_property;
	public IntPtr focus;
	public IntPtr is_activatable;
	public IntPtr activate;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkCellLayoutIface
{
	public GTypeInterface g_iface;
	public IntPtr pack_start;
	public IntPtr pack_end;
	public IntPtr clear;
	public IntPtr add_attribute;
	public IntPtr set_cell_data_func;
	public IntPtr clear_attributes;
	public IntPtr reorder;
	public IntPtr get_cells;
	public IntPtr get_area;
}

public struct GtkSelectionModel { }
public struct GtkComboBoxText { }
public struct GtkCellRendererClassPrivate { }
public struct GtkNumericSorter { }
public struct GtkColumnViewColumnClass { }

public struct GtkMediaStreamClass
{
	public GObjectClass parent_class;
	public IntPtr play;
	public IntPtr pause;
	public IntPtr seek;
	public IntPtr update_audio;
	public IntPtr realize;
	public IntPtr unrealize;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
	public IntPtr _gtk_reserved5;
	public IntPtr _gtk_reserved6;
	public IntPtr _gtk_reserved7;
	public IntPtr _gtk_reserved8;
}

public struct GtkDropDown { }
public struct GtkPasswordEntryClass { }

public struct GtkGridLayoutChildClass
{
	public GtkLayoutChildClass parent_class;
}

public struct GtkTreeModelSortPrivate { }

public struct GtkNoSelectionClass
{
	public GObjectClass parent_class;
}

public struct GtkCellAreaBox { }
public struct GtkShortcut { }
public struct GtkGestureSwipe { }

public struct GtkFixed
{
	public GtkWidget parent_instance;
}

public struct GtkImage { }
public struct GtkMediaControls { }
public struct GtkMapListModel { }

public struct GtkMediaFile
{
	public GtkMediaStream parent_instance;
}

public struct GtkTreeDragSource { }

public struct GtkDirectoryListClass
{
	public GObjectClass parent_class;
}

public struct GtkSymbolicPaintable { }
public struct GtkBuilderScope { }
public struct GtkColorChooser { }
public struct GtkNothingActionClass { }
public struct GtkShortcutTriggerClass { }

public struct GtkSingleSelectionClass
{
	public GObjectClass parent_class;
}

public struct GtkTextChildAnchorClass
{
	public GObjectClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}

public struct GtkTreeExpander { }
public struct GtkRevealer { }
public struct GtkWidgetPrivate { }

public struct GtkText
{
	public GtkWidget parent_instance;
}

public struct GtkBuilderListItemFactory { }
public struct GtkCClosureExpression { }
public struct GtkGestureClick { }

public struct GtkCheckButton
{
	public GtkWidget parent_instance;
}

public struct GtkIMContextClass
{
	public GObjectClass parent_class;
	public IntPtr preedit_start;
	public IntPtr preedit_end;
	public IntPtr preedit_changed;
	public IntPtr commit;
	public IntPtr retrieve_surrounding;
	public IntPtr delete_surrounding;
	public IntPtr set_client_widget;
	public IntPtr get_preedit_string;
	public IntPtr filter_keypress;
	public IntPtr focus_in;
	public IntPtr focus_out;
	public IntPtr reset;
	public IntPtr set_cursor_location;
	public IntPtr set_use_preedit;
	public IntPtr set_surrounding;
	public IntPtr get_surrounding;
	public IntPtr set_surrounding_with_selection;
	public IntPtr get_surrounding_with_selection;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
	public IntPtr _gtk_reserved5;
}

public struct GtkIMMulticontextClass
{
	public GtkIMContextClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}

public struct GtkStackSidebar { }

public struct GtkIMContext
{
	public GObject.GObject parent_instance;
}

public struct GtkGestureStylusClass { }
public struct GtkListItem { }
public struct GtkCenterBoxClass { }
public struct GtkColorChooserDialog { }
public struct GtkPrintOperationPrivate { }
public struct GtkVideo { }
public struct GtkShortcutsGroup { }

public struct GtkRequisition
{
	public int width;
	public int height;
}

public struct GtkTextMarkClass
{
	public GObjectClass parent_class;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkRangeClass
{
	public GtkWidgetClass parent_class;
	public IntPtr value_changed;
	public IntPtr adjust_bounds;
	public IntPtr move_slider;
	public IntPtr get_range_border;
	public IntPtr change_value;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkBuildable { }
public struct GtkBuilder { }
public struct GtkLevelBar { }
public struct GtkIMMulticontextPrivate { }
public struct GtkTextTagPrivate { }
public struct GtkAboutDialog { }
public struct GtkTreeStorePrivate { }
public struct GtkPopoverMenu { }

public struct GtkWindow
{
	public GtkWidget parent_instance;
}

public struct GtkEventControllerScroll { }

public struct GtkFlowBoxChildClass
{
	public GtkWidgetClass parent_class;
	public IntPtr activate;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkEventControllerKey { }
public struct GtkCallbackActionClass { }

public struct GtkListStoreClass
{
	public GObjectClass parent_class;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkMultiFilter { }
public struct GtkClosureExpression { }
public struct GtkColumnView { }
public struct GtkCellEditable { }
public struct GtkTreeViewColumn { }

public struct GtkGLAreaClass
{
	public GtkWidgetClass parent_class;
	public IntPtr render;
	public IntPtr resize;
	public IntPtr create_context;
	public IntPtr _padding;

	public struct __padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkWidget
{
	public GObject.GObject parent_instance;
	public GtkWidgetPrivateHandle priv;
}

public struct GtkIMMulticontext
{
	public GtkIMContext @object;
	public GtkIMMulticontextPrivateHandle priv;
}

public struct GtkFilterListModelClass
{
	public GObjectClass parent_class;
}

public struct GtkCellRendererProgress { }

public struct GtkTreeDragDestIface
{
	public GTypeInterface g_iface;
	public IntPtr drag_data_received;
	public IntPtr row_drop_possible;
}

public struct GtkMountOperation
{
	public GMountOperation parent_instance;
	public GtkMountOperationPrivateHandle priv;
}

public struct GtkBuildableParser
{
	public IntPtr start_element;
	public IntPtr end_element;
	public IntPtr text;
	public IntPtr error;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
	}
}

public struct GtkFontChooserWidget { }
public struct GtkTreeSortable { }

public struct GtkTextTag
{
	public GObject.GObject parent_instance;
	public GtkTextTagPrivateHandle priv;
}

public struct GtkFileChooser { }
public struct GtkLockButton { }

public struct GtkStyleContext
{
	public GObject.GObject parent_object;
}

public struct GtkEveryFilter { }
public struct GtkMnemonicTriggerClass { }

public struct GtkTextView
{
	public GtkWidget parent_instance;
	public GtkTextViewPrivateHandle priv;
}

public struct GtkConstantExpression { }

public struct GtkPadActionEntry
{
	public GtkPadActionType type;
	public int index;
	public int mode;
	public string label;
	public string action_name;
}

public struct GtkNotebookPage { }
public struct GtkCellRendererToggle { }
public struct GtkWindowGroupPrivate { }
public struct GtkSortListModel { }

public struct GtkBuildableIface
{
	public GTypeInterface g_iface;
	public IntPtr set_id;
	public IntPtr get_id;
	public IntPtr add_child;
	public IntPtr set_buildable_property;
	public IntPtr construct_child;
	public IntPtr custom_tag_start;
	public IntPtr custom_tag_end;
	public IntPtr custom_finished;
	public IntPtr parser_finished;
	public IntPtr get_internal_child;
}

public struct GtkDialog
{
	public GtkWindow parent_instance;
}

public struct GtkCellRendererSpinner { }

public struct GtkCssProvider
{
	public GObject.GObject parent_instance;
}

public struct GtkDrawingArea
{
	public GtkWidget widget;
}

public struct GtkGesture { }
public struct GtkTreeDragDest { }

public struct GtkFrame
{
	public GtkWidget parent_instance;
}

public struct GtkFixedClass
{
	public GtkWidgetClass parent_class;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GtkOverlayLayout { }

public struct GtkTextBufferClass
{
	public GObjectClass parent_class;
	public IntPtr insert_text;
	public IntPtr insert_paintable;
	public IntPtr insert_child_anchor;
	public IntPtr delete_range;
	public IntPtr changed;
	public IntPtr modified_changed;
	public IntPtr mark_set;
	public IntPtr mark_deleted;
	public IntPtr apply_tag;
	public IntPtr remove_tag;
	public IntPtr begin_user_action;
	public IntPtr end_user_action;
	public IntPtr paste_done;
	public IntPtr undo;
	public IntPtr redo;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}

public struct GtkEventControllerLegacyClass { }

public struct GtkAllocation
{
	public int x;
	public int y;
	public int width;
	public int height;
}

public struct GtkSnapshot { }
