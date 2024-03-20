using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gdk;

public static class Methods
{
	public const int GDK_MAJOR_VERSION = 4;

	public const int GDK_MINOR_VERSION = 6;

	public const int GDK_MICRO_VERSION = 9;

	public const int GDK_VERSION_4_0 = (4 << 16) | (0 << 8);

	public const int GDK_VERSION_4_2 = (4 << 16) | (2 << 8);

	public const int GDK_VERSION_4_4 = (4 << 16) | (4 << 8);

	public const int GDK_VERSION_4_6 = (4 << 16) | (6 << 8);

	public const int GDK_VERSION_CUR_STABLE = (4 << 16) | (6 << 8);

	public const int GDK_VERSION_PREV_STABLE = (4 << 16) | ((6 - 2) << 8);

	public const int GDK_VERSION_MIN_REQUIRED = (4 << 16) | (6 << 8);

	public const int GDK_VERSION_MAX_ALLOWED = (4 << 16) | (6 << 8);

	public const nint GDK_CURRENT_TIME = 0;

	public const int GDK_MODIFIER_MASK = (int)GdkModifierType.GDK_SHIFT_MASK | (int)GdkModifierType.GDK_LOCK_MASK | (int)GdkModifierType.GDK_CONTROL_MASK | (int)GdkModifierType.GDK_ALT_MASK | (int)GdkModifierType.GDK_SUPER_MASK | (int)GdkModifierType.GDK_HYPER_MASK | (int)GdkModifierType.GDK_META_MASK | (int)GdkModifierType.GDK_BUTTON1_MASK | (int)GdkModifierType.GDK_BUTTON2_MASK | (int)GdkModifierType.GDK_BUTTON3_MASK | (int)GdkModifierType.GDK_BUTTON4_MASK | (int)GdkModifierType.GDK_BUTTON5_MASK;

	public const int GDK_ACTION_ALL = (int)GdkDragAction.GDK_ACTION_COPY | (int)GdkDragAction.GDK_ACTION_MOVE | (int)GdkDragAction.GDK_ACTION_LINK;

	public const int GDK_PRIORITY_EVENTS = 0;

	public const int GDK_PRIORITY_REDRAW = 100 + 20;

	public const int GDK_EVENT_PROPAGATE = 0;

	public const bool GDK_EVENT_STOP = 0 == 0;

	public const int GDK_BUTTON_PRIMARY = 1;

	public const int GDK_BUTTON_MIDDLE = 2;

	public const int GDK_BUTTON_SECONDARY = 3;

	public const int GDK_KEY_VoidSymbol = 0xffffff;

	public const int GDK_KEY_BackSpace = 0xff08;

	public const int GDK_KEY_Tab = 0xff09;

	public const int GDK_KEY_Linefeed = 0xff0a;

	public const int GDK_KEY_Clear = 0xff0b;

	public const int GDK_KEY_Return = 0xff0d;

	public const int GDK_KEY_Pause = 0xff13;

	public const int GDK_KEY_Scroll_Lock = 0xff14;

	public const int GDK_KEY_Sys_Req = 0xff15;

	public const int GDK_KEY_Escape = 0xff1b;

	public const int GDK_KEY_Delete = 0xffff;

	public const int GDK_KEY_Multi_key = 0xff20;

	public const int GDK_KEY_Codeinput = 0xff37;

	public const int GDK_KEY_SingleCandidate = 0xff3c;

	public const int GDK_KEY_MultipleCandidate = 0xff3d;

	public const int GDK_KEY_PreviousCandidate = 0xff3e;

	public const int GDK_KEY_Kanji = 0xff21;

	public const int GDK_KEY_Muhenkan = 0xff22;

	public const int GDK_KEY_Henkan_Mode = 0xff23;

	public const int GDK_KEY_Henkan = 0xff23;

	public const int GDK_KEY_Romaji = 0xff24;

	public const int GDK_KEY_Hiragana = 0xff25;

	public const int GDK_KEY_Katakana = 0xff26;

	public const int GDK_KEY_Hiragana_Katakana = 0xff27;

	public const int GDK_KEY_Zenkaku = 0xff28;

	public const int GDK_KEY_Hankaku = 0xff29;

	public const int GDK_KEY_Zenkaku_Hankaku = 0xff2a;

	public const int GDK_KEY_Touroku = 0xff2b;

	public const int GDK_KEY_Massyo = 0xff2c;

	public const int GDK_KEY_Kana_Lock = 0xff2d;

	public const int GDK_KEY_Kana_Shift = 0xff2e;

	public const int GDK_KEY_Eisu_Shift = 0xff2f;

	public const int GDK_KEY_Eisu_toggle = 0xff30;

	public const int GDK_KEY_Kanji_Bangou = 0xff37;

	public const int GDK_KEY_Zen_Koho = 0xff3d;

	public const int GDK_KEY_Mae_Koho = 0xff3e;

	public const int GDK_KEY_Home = 0xff50;

	public const int GDK_KEY_Left = 0xff51;

	public const int GDK_KEY_Up = 0xff52;

	public const int GDK_KEY_Right = 0xff53;

	public const int GDK_KEY_Down = 0xff54;

	public const int GDK_KEY_Prior = 0xff55;

	public const int GDK_KEY_Page_Up = 0xff55;

	public const int GDK_KEY_Next = 0xff56;

	public const int GDK_KEY_Page_Down = 0xff56;

	public const int GDK_KEY_End = 0xff57;

	public const int GDK_KEY_Begin = 0xff58;

	public const int GDK_KEY_Select = 0xff60;

	public const int GDK_KEY_Print = 0xff61;

	public const int GDK_KEY_Execute = 0xff62;

	public const int GDK_KEY_Insert = 0xff63;

	public const int GDK_KEY_Undo = 0xff65;

	public const int GDK_KEY_Redo = 0xff66;

	public const int GDK_KEY_Menu = 0xff67;

	public const int GDK_KEY_Find = 0xff68;

	public const int GDK_KEY_Cancel = 0xff69;

	public const int GDK_KEY_Help = 0xff6a;

	public const int GDK_KEY_Break = 0xff6b;

	public const int GDK_KEY_Mode_switch = 0xff7e;

	public const int GDK_KEY_script_switch = 0xff7e;

	public const int GDK_KEY_Num_Lock = 0xff7f;

	public const int GDK_KEY_KP_Space = 0xff80;

	public const int GDK_KEY_KP_Tab = 0xff89;

	public const int GDK_KEY_KP_Enter = 0xff8d;

	public const int GDK_KEY_KP_F1 = 0xff91;

	public const int GDK_KEY_KP_F2 = 0xff92;

	public const int GDK_KEY_KP_F3 = 0xff93;

	public const int GDK_KEY_KP_F4 = 0xff94;

	public const int GDK_KEY_KP_Home = 0xff95;

	public const int GDK_KEY_KP_Left = 0xff96;

	public const int GDK_KEY_KP_Up = 0xff97;

	public const int GDK_KEY_KP_Right = 0xff98;

	public const int GDK_KEY_KP_Down = 0xff99;

	public const int GDK_KEY_KP_Prior = 0xff9a;

	public const int GDK_KEY_KP_Page_Up = 0xff9a;

	public const int GDK_KEY_KP_Next = 0xff9b;

	public const int GDK_KEY_KP_Page_Down = 0xff9b;

	public const int GDK_KEY_KP_End = 0xff9c;

	public const int GDK_KEY_KP_Begin = 0xff9d;

	public const int GDK_KEY_KP_Insert = 0xff9e;

	public const int GDK_KEY_KP_Delete = 0xff9f;

	public const int GDK_KEY_KP_Equal = 0xffbd;

	public const int GDK_KEY_KP_Multiply = 0xffaa;

	public const int GDK_KEY_KP_Add = 0xffab;

	public const int GDK_KEY_KP_Separator = 0xffac;

	public const int GDK_KEY_KP_Subtract = 0xffad;

	public const int GDK_KEY_KP_Decimal = 0xffae;

	public const int GDK_KEY_KP_Divide = 0xffaf;

	public const int GDK_KEY_KP_0 = 0xffb0;

	public const int GDK_KEY_KP_1 = 0xffb1;

	public const int GDK_KEY_KP_2 = 0xffb2;

	public const int GDK_KEY_KP_3 = 0xffb3;

	public const int GDK_KEY_KP_4 = 0xffb4;

	public const int GDK_KEY_KP_5 = 0xffb5;

	public const int GDK_KEY_KP_6 = 0xffb6;

	public const int GDK_KEY_KP_7 = 0xffb7;

	public const int GDK_KEY_KP_8 = 0xffb8;

	public const int GDK_KEY_KP_9 = 0xffb9;

	public const int GDK_KEY_F1 = 0xffbe;

	public const int GDK_KEY_F2 = 0xffbf;

	public const int GDK_KEY_F3 = 0xffc0;

	public const int GDK_KEY_F4 = 0xffc1;

	public const int GDK_KEY_F5 = 0xffc2;

	public const int GDK_KEY_F6 = 0xffc3;

	public const int GDK_KEY_F7 = 0xffc4;

	public const int GDK_KEY_F8 = 0xffc5;

	public const int GDK_KEY_F9 = 0xffc6;

	public const int GDK_KEY_F10 = 0xffc7;

	public const int GDK_KEY_F11 = 0xffc8;

	public const int GDK_KEY_L1 = 0xffc8;

	public const int GDK_KEY_F12 = 0xffc9;

	public const int GDK_KEY_L2 = 0xffc9;

	public const int GDK_KEY_F13 = 0xffca;

	public const int GDK_KEY_L3 = 0xffca;

	public const int GDK_KEY_F14 = 0xffcb;

	public const int GDK_KEY_L4 = 0xffcb;

	public const int GDK_KEY_F15 = 0xffcc;

	public const int GDK_KEY_L5 = 0xffcc;

	public const int GDK_KEY_F16 = 0xffcd;

	public const int GDK_KEY_L6 = 0xffcd;

	public const int GDK_KEY_F17 = 0xffce;

	public const int GDK_KEY_L7 = 0xffce;

	public const int GDK_KEY_F18 = 0xffcf;

	public const int GDK_KEY_L8 = 0xffcf;

	public const int GDK_KEY_F19 = 0xffd0;

	public const int GDK_KEY_L9 = 0xffd0;

	public const int GDK_KEY_F20 = 0xffd1;

	public const int GDK_KEY_L10 = 0xffd1;

	public const int GDK_KEY_F21 = 0xffd2;

	public const int GDK_KEY_R1 = 0xffd2;

	public const int GDK_KEY_F22 = 0xffd3;

	public const int GDK_KEY_R2 = 0xffd3;

	public const int GDK_KEY_F23 = 0xffd4;

	public const int GDK_KEY_R3 = 0xffd4;

	public const int GDK_KEY_F24 = 0xffd5;

	public const int GDK_KEY_R4 = 0xffd5;

	public const int GDK_KEY_F25 = 0xffd6;

	public const int GDK_KEY_R5 = 0xffd6;

	public const int GDK_KEY_F26 = 0xffd7;

	public const int GDK_KEY_R6 = 0xffd7;

	public const int GDK_KEY_F27 = 0xffd8;

	public const int GDK_KEY_R7 = 0xffd8;

	public const int GDK_KEY_F28 = 0xffd9;

	public const int GDK_KEY_R8 = 0xffd9;

	public const int GDK_KEY_F29 = 0xffda;

	public const int GDK_KEY_R9 = 0xffda;

	public const int GDK_KEY_F30 = 0xffdb;

	public const int GDK_KEY_R10 = 0xffdb;

	public const int GDK_KEY_F31 = 0xffdc;

	public const int GDK_KEY_R11 = 0xffdc;

	public const int GDK_KEY_F32 = 0xffdd;

	public const int GDK_KEY_R12 = 0xffdd;

	public const int GDK_KEY_F33 = 0xffde;

	public const int GDK_KEY_R13 = 0xffde;

	public const int GDK_KEY_F34 = 0xffdf;

	public const int GDK_KEY_R14 = 0xffdf;

	public const int GDK_KEY_F35 = 0xffe0;

	public const int GDK_KEY_R15 = 0xffe0;

	public const int GDK_KEY_Shift_L = 0xffe1;

	public const int GDK_KEY_Shift_R = 0xffe2;

	public const int GDK_KEY_Control_L = 0xffe3;

	public const int GDK_KEY_Control_R = 0xffe4;

	public const int GDK_KEY_Caps_Lock = 0xffe5;

	public const int GDK_KEY_Shift_Lock = 0xffe6;

	public const int GDK_KEY_Meta_L = 0xffe7;

	public const int GDK_KEY_Meta_R = 0xffe8;

	public const int GDK_KEY_Alt_L = 0xffe9;

	public const int GDK_KEY_Alt_R = 0xffea;

	public const int GDK_KEY_Super_L = 0xffeb;

	public const int GDK_KEY_Super_R = 0xffec;

	public const int GDK_KEY_Hyper_L = 0xffed;

	public const int GDK_KEY_Hyper_R = 0xffee;

	public const int GDK_KEY_ISO_Lock = 0xfe01;

	public const int GDK_KEY_ISO_Level2_Latch = 0xfe02;

	public const int GDK_KEY_ISO_Level3_Shift = 0xfe03;

	public const int GDK_KEY_ISO_Level3_Latch = 0xfe04;

	public const int GDK_KEY_ISO_Level3_Lock = 0xfe05;

	public const int GDK_KEY_ISO_Level5_Shift = 0xfe11;

	public const int GDK_KEY_ISO_Level5_Latch = 0xfe12;

	public const int GDK_KEY_ISO_Level5_Lock = 0xfe13;

	public const int GDK_KEY_ISO_Group_Shift = 0xff7e;

	public const int GDK_KEY_ISO_Group_Latch = 0xfe06;

	public const int GDK_KEY_ISO_Group_Lock = 0xfe07;

	public const int GDK_KEY_ISO_Next_Group = 0xfe08;

	public const int GDK_KEY_ISO_Next_Group_Lock = 0xfe09;

	public const int GDK_KEY_ISO_Prev_Group = 0xfe0a;

	public const int GDK_KEY_ISO_Prev_Group_Lock = 0xfe0b;

	public const int GDK_KEY_ISO_First_Group = 0xfe0c;

	public const int GDK_KEY_ISO_First_Group_Lock = 0xfe0d;

	public const int GDK_KEY_ISO_Last_Group = 0xfe0e;

	public const int GDK_KEY_ISO_Last_Group_Lock = 0xfe0f;

	public const int GDK_KEY_ISO_Left_Tab = 0xfe20;

	public const int GDK_KEY_ISO_Move_Line_Up = 0xfe21;

	public const int GDK_KEY_ISO_Move_Line_Down = 0xfe22;

	public const int GDK_KEY_ISO_Partial_Line_Up = 0xfe23;

	public const int GDK_KEY_ISO_Partial_Line_Down = 0xfe24;

	public const int GDK_KEY_ISO_Partial_Space_Left = 0xfe25;

	public const int GDK_KEY_ISO_Partial_Space_Right = 0xfe26;

	public const int GDK_KEY_ISO_Set_Margin_Left = 0xfe27;

	public const int GDK_KEY_ISO_Set_Margin_Right = 0xfe28;

	public const int GDK_KEY_ISO_Release_Margin_Left = 0xfe29;

	public const int GDK_KEY_ISO_Release_Margin_Right = 0xfe2a;

	public const int GDK_KEY_ISO_Release_Both_Margins = 0xfe2b;

	public const int GDK_KEY_ISO_Fast_Cursor_Left = 0xfe2c;

	public const int GDK_KEY_ISO_Fast_Cursor_Right = 0xfe2d;

	public const int GDK_KEY_ISO_Fast_Cursor_Up = 0xfe2e;

	public const int GDK_KEY_ISO_Fast_Cursor_Down = 0xfe2f;

	public const int GDK_KEY_ISO_Continuous_Underline = 0xfe30;

	public const int GDK_KEY_ISO_Discontinuous_Underline = 0xfe31;

	public const int GDK_KEY_ISO_Emphasize = 0xfe32;

	public const int GDK_KEY_ISO_Center_Object = 0xfe33;

	public const int GDK_KEY_ISO_Enter = 0xfe34;

	public const int GDK_KEY_dead_grave = 0xfe50;

	public const int GDK_KEY_dead_acute = 0xfe51;

	public const int GDK_KEY_dead_circumflex = 0xfe52;

	public const int GDK_KEY_dead_tilde = 0xfe53;

	public const int GDK_KEY_dead_perispomeni = 0xfe53;

	public const int GDK_KEY_dead_macron = 0xfe54;

	public const int GDK_KEY_dead_breve = 0xfe55;

	public const int GDK_KEY_dead_abovedot = 0xfe56;

	public const int GDK_KEY_dead_diaeresis = 0xfe57;

	public const int GDK_KEY_dead_abovering = 0xfe58;

	public const int GDK_KEY_dead_doubleacute = 0xfe59;

	public const int GDK_KEY_dead_caron = 0xfe5a;

	public const int GDK_KEY_dead_cedilla = 0xfe5b;

	public const int GDK_KEY_dead_ogonek = 0xfe5c;

	public const int GDK_KEY_dead_iota = 0xfe5d;

	public const int GDK_KEY_dead_voiced_sound = 0xfe5e;

	public const int GDK_KEY_dead_semivoiced_sound = 0xfe5f;

	public const int GDK_KEY_dead_belowdot = 0xfe60;

	public const int GDK_KEY_dead_hook = 0xfe61;

	public const int GDK_KEY_dead_horn = 0xfe62;

	public const int GDK_KEY_dead_stroke = 0xfe63;

	public const int GDK_KEY_dead_abovecomma = 0xfe64;

	public const int GDK_KEY_dead_psili = 0xfe64;

	public const int GDK_KEY_dead_abovereversedcomma = 0xfe65;

	public const int GDK_KEY_dead_dasia = 0xfe65;

	public const int GDK_KEY_dead_doublegrave = 0xfe66;

	public const int GDK_KEY_dead_belowring = 0xfe67;

	public const int GDK_KEY_dead_belowmacron = 0xfe68;

	public const int GDK_KEY_dead_belowcircumflex = 0xfe69;

	public const int GDK_KEY_dead_belowtilde = 0xfe6a;

	public const int GDK_KEY_dead_belowbreve = 0xfe6b;

	public const int GDK_KEY_dead_belowdiaeresis = 0xfe6c;

	public const int GDK_KEY_dead_invertedbreve = 0xfe6d;

	public const int GDK_KEY_dead_belowcomma = 0xfe6e;

	public const int GDK_KEY_dead_currency = 0xfe6f;

	public const int GDK_KEY_dead_lowline = 0xfe90;

	public const int GDK_KEY_dead_aboveverticalline = 0xfe91;

	public const int GDK_KEY_dead_belowverticalline = 0xfe92;

	public const int GDK_KEY_dead_longsolidusoverlay = 0xfe93;

	public const int GDK_KEY_dead_a = 0xfe80;

	public const int GDK_KEY_dead_A = 0xfe81;

	public const int GDK_KEY_dead_e = 0xfe82;

	public const int GDK_KEY_dead_E = 0xfe83;

	public const int GDK_KEY_dead_i = 0xfe84;

	public const int GDK_KEY_dead_I = 0xfe85;

	public const int GDK_KEY_dead_o = 0xfe86;

	public const int GDK_KEY_dead_O = 0xfe87;

	public const int GDK_KEY_dead_u = 0xfe88;

	public const int GDK_KEY_dead_U = 0xfe89;

	public const int GDK_KEY_dead_small_schwa = 0xfe8a;

	public const int GDK_KEY_dead_capital_schwa = 0xfe8b;

	public const int GDK_KEY_dead_greek = 0xfe8c;

	public const int GDK_KEY_First_Virtual_Screen = 0xfed0;

	public const int GDK_KEY_Prev_Virtual_Screen = 0xfed1;

	public const int GDK_KEY_Next_Virtual_Screen = 0xfed2;

	public const int GDK_KEY_Last_Virtual_Screen = 0xfed4;

	public const int GDK_KEY_Terminate_Server = 0xfed5;

	public const int GDK_KEY_AccessX_Enable = 0xfe70;

	public const int GDK_KEY_AccessX_Feedback_Enable = 0xfe71;

	public const int GDK_KEY_RepeatKeys_Enable = 0xfe72;

	public const int GDK_KEY_SlowKeys_Enable = 0xfe73;

	public const int GDK_KEY_BounceKeys_Enable = 0xfe74;

	public const int GDK_KEY_StickyKeys_Enable = 0xfe75;

	public const int GDK_KEY_MouseKeys_Enable = 0xfe76;

	public const int GDK_KEY_MouseKeys_Accel_Enable = 0xfe77;

	public const int GDK_KEY_Overlay1_Enable = 0xfe78;

	public const int GDK_KEY_Overlay2_Enable = 0xfe79;

	public const int GDK_KEY_AudibleBell_Enable = 0xfe7a;

	public const int GDK_KEY_Pointer_Left = 0xfee0;

	public const int GDK_KEY_Pointer_Right = 0xfee1;

	public const int GDK_KEY_Pointer_Up = 0xfee2;

	public const int GDK_KEY_Pointer_Down = 0xfee3;

	public const int GDK_KEY_Pointer_UpLeft = 0xfee4;

	public const int GDK_KEY_Pointer_UpRight = 0xfee5;

	public const int GDK_KEY_Pointer_DownLeft = 0xfee6;

	public const int GDK_KEY_Pointer_DownRight = 0xfee7;

	public const int GDK_KEY_Pointer_Button_Dflt = 0xfee8;

	public const int GDK_KEY_Pointer_Button1 = 0xfee9;

	public const int GDK_KEY_Pointer_Button2 = 0xfeea;

	public const int GDK_KEY_Pointer_Button3 = 0xfeeb;

	public const int GDK_KEY_Pointer_Button4 = 0xfeec;

	public const int GDK_KEY_Pointer_Button5 = 0xfeed;

	public const int GDK_KEY_Pointer_DblClick_Dflt = 0xfeee;

	public const int GDK_KEY_Pointer_DblClick1 = 0xfeef;

	public const int GDK_KEY_Pointer_DblClick2 = 0xfef0;

	public const int GDK_KEY_Pointer_DblClick3 = 0xfef1;

	public const int GDK_KEY_Pointer_DblClick4 = 0xfef2;

	public const int GDK_KEY_Pointer_DblClick5 = 0xfef3;

	public const int GDK_KEY_Pointer_Drag_Dflt = 0xfef4;

	public const int GDK_KEY_Pointer_Drag1 = 0xfef5;

	public const int GDK_KEY_Pointer_Drag2 = 0xfef6;

	public const int GDK_KEY_Pointer_Drag3 = 0xfef7;

	public const int GDK_KEY_Pointer_Drag4 = 0xfef8;

	public const int GDK_KEY_Pointer_Drag5 = 0xfefd;

	public const int GDK_KEY_Pointer_EnableKeys = 0xfef9;

	public const int GDK_KEY_Pointer_Accelerate = 0xfefa;

	public const int GDK_KEY_Pointer_DfltBtnNext = 0xfefb;

	public const int GDK_KEY_Pointer_DfltBtnPrev = 0xfefc;

	public const int GDK_KEY_ch = 0xfea0;

	public const int GDK_KEY_Ch = 0xfea1;

	public const int GDK_KEY_CH = 0xfea2;

	public const int GDK_KEY_c_h = 0xfea3;

	public const int GDK_KEY_C_h = 0xfea4;

	public const int GDK_KEY_C_H = 0xfea5;

	public const int GDK_KEY_3270_Duplicate = 0xfd01;

	public const int GDK_KEY_3270_FieldMark = 0xfd02;

	public const int GDK_KEY_3270_Right2 = 0xfd03;

	public const int GDK_KEY_3270_Left2 = 0xfd04;

	public const int GDK_KEY_3270_BackTab = 0xfd05;

	public const int GDK_KEY_3270_EraseEOF = 0xfd06;

	public const int GDK_KEY_3270_EraseInput = 0xfd07;

	public const int GDK_KEY_3270_Reset = 0xfd08;

	public const int GDK_KEY_3270_Quit = 0xfd09;

	public const int GDK_KEY_3270_PA1 = 0xfd0a;

	public const int GDK_KEY_3270_PA2 = 0xfd0b;

	public const int GDK_KEY_3270_PA3 = 0xfd0c;

	public const int GDK_KEY_3270_Test = 0xfd0d;

	public const int GDK_KEY_3270_Attn = 0xfd0e;

	public const int GDK_KEY_3270_CursorBlink = 0xfd0f;

	public const int GDK_KEY_3270_AltCursor = 0xfd10;

	public const int GDK_KEY_3270_KeyClick = 0xfd11;

	public const int GDK_KEY_3270_Jump = 0xfd12;

	public const int GDK_KEY_3270_Ident = 0xfd13;

	public const int GDK_KEY_3270_Rule = 0xfd14;

	public const int GDK_KEY_3270_Copy = 0xfd15;

	public const int GDK_KEY_3270_Play = 0xfd16;

	public const int GDK_KEY_3270_Setup = 0xfd17;

	public const int GDK_KEY_3270_Record = 0xfd18;

	public const int GDK_KEY_3270_ChangeScreen = 0xfd19;

	public const int GDK_KEY_3270_DeleteWord = 0xfd1a;

	public const int GDK_KEY_3270_ExSelect = 0xfd1b;

	public const int GDK_KEY_3270_CursorSelect = 0xfd1c;

	public const int GDK_KEY_3270_PrintScreen = 0xfd1d;

	public const int GDK_KEY_3270_Enter = 0xfd1e;

	public const int GDK_KEY_space = 0x020;

	public const int GDK_KEY_exclam = 0x021;

	public const int GDK_KEY_quotedbl = 0x022;

	public const int GDK_KEY_numbersign = 0x023;

	public const int GDK_KEY_dollar = 0x024;

	public const int GDK_KEY_percent = 0x025;

	public const int GDK_KEY_ampersand = 0x026;

	public const int GDK_KEY_apostrophe = 0x027;

	public const int GDK_KEY_quoteright = 0x027;

	public const int GDK_KEY_parenleft = 0x028;

	public const int GDK_KEY_parenright = 0x029;

	public const int GDK_KEY_asterisk = 0x02a;

	public const int GDK_KEY_plus = 0x02b;

	public const int GDK_KEY_comma = 0x02c;

	public const int GDK_KEY_minus = 0x02d;

	public const int GDK_KEY_period = 0x02e;

	public const int GDK_KEY_slash = 0x02f;

	public const int GDK_KEY_0 = 0x030;

	public const int GDK_KEY_1 = 0x031;

	public const int GDK_KEY_2 = 0x032;

	public const int GDK_KEY_3 = 0x033;

	public const int GDK_KEY_4 = 0x034;

	public const int GDK_KEY_5 = 0x035;

	public const int GDK_KEY_6 = 0x036;

	public const int GDK_KEY_7 = 0x037;

	public const int GDK_KEY_8 = 0x038;

	public const int GDK_KEY_9 = 0x039;

	public const int GDK_KEY_colon = 0x03a;

	public const int GDK_KEY_semicolon = 0x03b;

	public const int GDK_KEY_less = 0x03c;

	public const int GDK_KEY_equal = 0x03d;

	public const int GDK_KEY_greater = 0x03e;

	public const int GDK_KEY_question = 0x03f;

	public const int GDK_KEY_at = 0x040;

	public const int GDK_KEY_A = 0x041;

	public const int GDK_KEY_B = 0x042;

	public const int GDK_KEY_C = 0x043;

	public const int GDK_KEY_D = 0x044;

	public const int GDK_KEY_E = 0x045;

	public const int GDK_KEY_F = 0x046;

	public const int GDK_KEY_G = 0x047;

	public const int GDK_KEY_H = 0x048;

	public const int GDK_KEY_I = 0x049;

	public const int GDK_KEY_J = 0x04a;

	public const int GDK_KEY_K = 0x04b;

	public const int GDK_KEY_L = 0x04c;

	public const int GDK_KEY_M = 0x04d;

	public const int GDK_KEY_N = 0x04e;

	public const int GDK_KEY_O = 0x04f;

	public const int GDK_KEY_P = 0x050;

	public const int GDK_KEY_Q = 0x051;

	public const int GDK_KEY_R = 0x052;

	public const int GDK_KEY_S = 0x053;

	public const int GDK_KEY_T = 0x054;

	public const int GDK_KEY_U = 0x055;

	public const int GDK_KEY_V = 0x056;

	public const int GDK_KEY_W = 0x057;

	public const int GDK_KEY_X = 0x058;

	public const int GDK_KEY_Y = 0x059;

	public const int GDK_KEY_Z = 0x05a;

	public const int GDK_KEY_bracketleft = 0x05b;

	public const int GDK_KEY_backslash = 0x05c;

	public const int GDK_KEY_bracketright = 0x05d;

	public const int GDK_KEY_asciicircum = 0x05e;

	public const int GDK_KEY_underscore = 0x05f;

	public const int GDK_KEY_grave = 0x060;

	public const int GDK_KEY_quoteleft = 0x060;

	public const int GDK_KEY_a = 0x061;

	public const int GDK_KEY_b = 0x062;

	public const int GDK_KEY_c = 0x063;

	public const int GDK_KEY_d = 0x064;

	public const int GDK_KEY_e = 0x065;

	public const int GDK_KEY_f = 0x066;

	public const int GDK_KEY_g = 0x067;

	public const int GDK_KEY_h = 0x068;

	public const int GDK_KEY_i = 0x069;

	public const int GDK_KEY_j = 0x06a;

	public const int GDK_KEY_k = 0x06b;

	public const int GDK_KEY_l = 0x06c;

	public const int GDK_KEY_m = 0x06d;

	public const int GDK_KEY_n = 0x06e;

	public const int GDK_KEY_o = 0x06f;

	public const int GDK_KEY_p = 0x070;

	public const int GDK_KEY_q = 0x071;

	public const int GDK_KEY_r = 0x072;

	public const int GDK_KEY_s = 0x073;

	public const int GDK_KEY_t = 0x074;

	public const int GDK_KEY_u = 0x075;

	public const int GDK_KEY_v = 0x076;

	public const int GDK_KEY_w = 0x077;

	public const int GDK_KEY_x = 0x078;

	public const int GDK_KEY_y = 0x079;

	public const int GDK_KEY_z = 0x07a;

	public const int GDK_KEY_braceleft = 0x07b;

	public const int GDK_KEY_bar = 0x07c;

	public const int GDK_KEY_braceright = 0x07d;

	public const int GDK_KEY_asciitilde = 0x07e;

	public const int GDK_KEY_nobreakspace = 0x0a0;

	public const int GDK_KEY_exclamdown = 0x0a1;

	public const int GDK_KEY_cent = 0x0a2;

	public const int GDK_KEY_sterling = 0x0a3;

	public const int GDK_KEY_currency = 0x0a4;

	public const int GDK_KEY_yen = 0x0a5;

	public const int GDK_KEY_brokenbar = 0x0a6;

	public const int GDK_KEY_section = 0x0a7;

	public const int GDK_KEY_diaeresis = 0x0a8;

	public const int GDK_KEY_copyright = 0x0a9;

	public const int GDK_KEY_ordfeminine = 0x0aa;

	public const int GDK_KEY_guillemotleft = 0x0ab;

	public const int GDK_KEY_notsign = 0x0ac;

	public const int GDK_KEY_hyphen = 0x0ad;

	public const int GDK_KEY_registered = 0x0ae;

	public const int GDK_KEY_macron = 0x0af;

	public const int GDK_KEY_degree = 0x0b0;

	public const int GDK_KEY_plusminus = 0x0b1;

	public const int GDK_KEY_twosuperior = 0x0b2;

	public const int GDK_KEY_threesuperior = 0x0b3;

	public const int GDK_KEY_acute = 0x0b4;

	public const int GDK_KEY_mu = 0x0b5;

	public const int GDK_KEY_paragraph = 0x0b6;

	public const int GDK_KEY_periodcentered = 0x0b7;

	public const int GDK_KEY_cedilla = 0x0b8;

	public const int GDK_KEY_onesuperior = 0x0b9;

	public const int GDK_KEY_masculine = 0x0ba;

	public const int GDK_KEY_guillemotright = 0x0bb;

	public const int GDK_KEY_onequarter = 0x0bc;

	public const int GDK_KEY_onehalf = 0x0bd;

	public const int GDK_KEY_threequarters = 0x0be;

	public const int GDK_KEY_questiondown = 0x0bf;

	public const int GDK_KEY_Agrave = 0x0c0;

	public const int GDK_KEY_Aacute = 0x0c1;

	public const int GDK_KEY_Acircumflex = 0x0c2;

	public const int GDK_KEY_Atilde = 0x0c3;

	public const int GDK_KEY_Adiaeresis = 0x0c4;

	public const int GDK_KEY_Aring = 0x0c5;

	public const int GDK_KEY_AE = 0x0c6;

	public const int GDK_KEY_Ccedilla = 0x0c7;

	public const int GDK_KEY_Egrave = 0x0c8;

	public const int GDK_KEY_Eacute = 0x0c9;

	public const int GDK_KEY_Ecircumflex = 0x0ca;

	public const int GDK_KEY_Ediaeresis = 0x0cb;

	public const int GDK_KEY_Igrave = 0x0cc;

	public const int GDK_KEY_Iacute = 0x0cd;

	public const int GDK_KEY_Icircumflex = 0x0ce;

	public const int GDK_KEY_Idiaeresis = 0x0cf;

	public const int GDK_KEY_ETH = 0x0d0;

	public const int GDK_KEY_Eth = 0x0d0;

	public const int GDK_KEY_Ntilde = 0x0d1;

	public const int GDK_KEY_Ograve = 0x0d2;

	public const int GDK_KEY_Oacute = 0x0d3;

	public const int GDK_KEY_Ocircumflex = 0x0d4;

	public const int GDK_KEY_Otilde = 0x0d5;

	public const int GDK_KEY_Odiaeresis = 0x0d6;

	public const int GDK_KEY_multiply = 0x0d7;

	public const int GDK_KEY_Oslash = 0x0d8;

	public const int GDK_KEY_Ooblique = 0x0d8;

	public const int GDK_KEY_Ugrave = 0x0d9;

	public const int GDK_KEY_Uacute = 0x0da;

	public const int GDK_KEY_Ucircumflex = 0x0db;

	public const int GDK_KEY_Udiaeresis = 0x0dc;

	public const int GDK_KEY_Yacute = 0x0dd;

	public const int GDK_KEY_THORN = 0x0de;

	public const int GDK_KEY_Thorn = 0x0de;

	public const int GDK_KEY_ssharp = 0x0df;

	public const int GDK_KEY_agrave = 0x0e0;

	public const int GDK_KEY_aacute = 0x0e1;

	public const int GDK_KEY_acircumflex = 0x0e2;

	public const int GDK_KEY_atilde = 0x0e3;

	public const int GDK_KEY_adiaeresis = 0x0e4;

	public const int GDK_KEY_aring = 0x0e5;

	public const int GDK_KEY_ae = 0x0e6;

	public const int GDK_KEY_ccedilla = 0x0e7;

	public const int GDK_KEY_egrave = 0x0e8;

	public const int GDK_KEY_eacute = 0x0e9;

	public const int GDK_KEY_ecircumflex = 0x0ea;

	public const int GDK_KEY_ediaeresis = 0x0eb;

	public const int GDK_KEY_igrave = 0x0ec;

	public const int GDK_KEY_iacute = 0x0ed;

	public const int GDK_KEY_icircumflex = 0x0ee;

	public const int GDK_KEY_idiaeresis = 0x0ef;

	public const int GDK_KEY_eth = 0x0f0;

	public const int GDK_KEY_ntilde = 0x0f1;

	public const int GDK_KEY_ograve = 0x0f2;

	public const int GDK_KEY_oacute = 0x0f3;

	public const int GDK_KEY_ocircumflex = 0x0f4;

	public const int GDK_KEY_otilde = 0x0f5;

	public const int GDK_KEY_odiaeresis = 0x0f6;

	public const int GDK_KEY_division = 0x0f7;

	public const int GDK_KEY_oslash = 0x0f8;

	public const int GDK_KEY_ooblique = 0x0f8;

	public const int GDK_KEY_ugrave = 0x0f9;

	public const int GDK_KEY_uacute = 0x0fa;

	public const int GDK_KEY_ucircumflex = 0x0fb;

	public const int GDK_KEY_udiaeresis = 0x0fc;

	public const int GDK_KEY_yacute = 0x0fd;

	public const int GDK_KEY_thorn = 0x0fe;

	public const int GDK_KEY_ydiaeresis = 0x0ff;

	public const int GDK_KEY_Aogonek = 0x1a1;

	public const int GDK_KEY_breve = 0x1a2;

	public const int GDK_KEY_Lstroke = 0x1a3;

	public const int GDK_KEY_Lcaron = 0x1a5;

	public const int GDK_KEY_Sacute = 0x1a6;

	public const int GDK_KEY_Scaron = 0x1a9;

	public const int GDK_KEY_Scedilla = 0x1aa;

	public const int GDK_KEY_Tcaron = 0x1ab;

	public const int GDK_KEY_Zacute = 0x1ac;

	public const int GDK_KEY_Zcaron = 0x1ae;

	public const int GDK_KEY_Zabovedot = 0x1af;

	public const int GDK_KEY_aogonek = 0x1b1;

	public const int GDK_KEY_ogonek = 0x1b2;

	public const int GDK_KEY_lstroke = 0x1b3;

	public const int GDK_KEY_lcaron = 0x1b5;

	public const int GDK_KEY_sacute = 0x1b6;

	public const int GDK_KEY_caron = 0x1b7;

	public const int GDK_KEY_scaron = 0x1b9;

	public const int GDK_KEY_scedilla = 0x1ba;

	public const int GDK_KEY_tcaron = 0x1bb;

	public const int GDK_KEY_zacute = 0x1bc;

	public const int GDK_KEY_doubleacute = 0x1bd;

	public const int GDK_KEY_zcaron = 0x1be;

	public const int GDK_KEY_zabovedot = 0x1bf;

	public const int GDK_KEY_Racute = 0x1c0;

	public const int GDK_KEY_Abreve = 0x1c3;

	public const int GDK_KEY_Lacute = 0x1c5;

	public const int GDK_KEY_Cacute = 0x1c6;

	public const int GDK_KEY_Ccaron = 0x1c8;

	public const int GDK_KEY_Eogonek = 0x1ca;

	public const int GDK_KEY_Ecaron = 0x1cc;

	public const int GDK_KEY_Dcaron = 0x1cf;

	public const int GDK_KEY_Dstroke = 0x1d0;

	public const int GDK_KEY_Nacute = 0x1d1;

	public const int GDK_KEY_Ncaron = 0x1d2;

	public const int GDK_KEY_Odoubleacute = 0x1d5;

	public const int GDK_KEY_Rcaron = 0x1d8;

	public const int GDK_KEY_Uring = 0x1d9;

	public const int GDK_KEY_Udoubleacute = 0x1db;

	public const int GDK_KEY_Tcedilla = 0x1de;

	public const int GDK_KEY_racute = 0x1e0;

	public const int GDK_KEY_abreve = 0x1e3;

	public const int GDK_KEY_lacute = 0x1e5;

	public const int GDK_KEY_cacute = 0x1e6;

	public const int GDK_KEY_ccaron = 0x1e8;

	public const int GDK_KEY_eogonek = 0x1ea;

	public const int GDK_KEY_ecaron = 0x1ec;

	public const int GDK_KEY_dcaron = 0x1ef;

	public const int GDK_KEY_dstroke = 0x1f0;

	public const int GDK_KEY_nacute = 0x1f1;

	public const int GDK_KEY_ncaron = 0x1f2;

	public const int GDK_KEY_odoubleacute = 0x1f5;

	public const int GDK_KEY_rcaron = 0x1f8;

	public const int GDK_KEY_uring = 0x1f9;

	public const int GDK_KEY_udoubleacute = 0x1fb;

	public const int GDK_KEY_tcedilla = 0x1fe;

	public const int GDK_KEY_abovedot = 0x1ff;

	public const int GDK_KEY_Hstroke = 0x2a1;

	public const int GDK_KEY_Hcircumflex = 0x2a6;

	public const int GDK_KEY_Iabovedot = 0x2a9;

	public const int GDK_KEY_Gbreve = 0x2ab;

	public const int GDK_KEY_Jcircumflex = 0x2ac;

	public const int GDK_KEY_hstroke = 0x2b1;

	public const int GDK_KEY_hcircumflex = 0x2b6;

	public const int GDK_KEY_idotless = 0x2b9;

	public const int GDK_KEY_gbreve = 0x2bb;

	public const int GDK_KEY_jcircumflex = 0x2bc;

	public const int GDK_KEY_Cabovedot = 0x2c5;

	public const int GDK_KEY_Ccircumflex = 0x2c6;

	public const int GDK_KEY_Gabovedot = 0x2d5;

	public const int GDK_KEY_Gcircumflex = 0x2d8;

	public const int GDK_KEY_Ubreve = 0x2dd;

	public const int GDK_KEY_Scircumflex = 0x2de;

	public const int GDK_KEY_cabovedot = 0x2e5;

	public const int GDK_KEY_ccircumflex = 0x2e6;

	public const int GDK_KEY_gabovedot = 0x2f5;

	public const int GDK_KEY_gcircumflex = 0x2f8;

	public const int GDK_KEY_ubreve = 0x2fd;

	public const int GDK_KEY_scircumflex = 0x2fe;

	public const int GDK_KEY_kra = 0x3a2;

	public const int GDK_KEY_kappa = 0x3a2;

	public const int GDK_KEY_Rcedilla = 0x3a3;

	public const int GDK_KEY_Itilde = 0x3a5;

	public const int GDK_KEY_Lcedilla = 0x3a6;

	public const int GDK_KEY_Emacron = 0x3aa;

	public const int GDK_KEY_Gcedilla = 0x3ab;

	public const int GDK_KEY_Tslash = 0x3ac;

	public const int GDK_KEY_rcedilla = 0x3b3;

	public const int GDK_KEY_itilde = 0x3b5;

	public const int GDK_KEY_lcedilla = 0x3b6;

	public const int GDK_KEY_emacron = 0x3ba;

	public const int GDK_KEY_gcedilla = 0x3bb;

	public const int GDK_KEY_tslash = 0x3bc;

	public const int GDK_KEY_ENG = 0x3bd;

	public const int GDK_KEY_eng = 0x3bf;

	public const int GDK_KEY_Amacron = 0x3c0;

	public const int GDK_KEY_Iogonek = 0x3c7;

	public const int GDK_KEY_Eabovedot = 0x3cc;

	public const int GDK_KEY_Imacron = 0x3cf;

	public const int GDK_KEY_Ncedilla = 0x3d1;

	public const int GDK_KEY_Omacron = 0x3d2;

	public const int GDK_KEY_Kcedilla = 0x3d3;

	public const int GDK_KEY_Uogonek = 0x3d9;

	public const int GDK_KEY_Utilde = 0x3dd;

	public const int GDK_KEY_Umacron = 0x3de;

	public const int GDK_KEY_amacron = 0x3e0;

	public const int GDK_KEY_iogonek = 0x3e7;

	public const int GDK_KEY_eabovedot = 0x3ec;

	public const int GDK_KEY_imacron = 0x3ef;

	public const int GDK_KEY_ncedilla = 0x3f1;

	public const int GDK_KEY_omacron = 0x3f2;

	public const int GDK_KEY_kcedilla = 0x3f3;

	public const int GDK_KEY_uogonek = 0x3f9;

	public const int GDK_KEY_utilde = 0x3fd;

	public const int GDK_KEY_umacron = 0x3fe;

	public const int GDK_KEY_Wcircumflex = 0x1000174;

	public const int GDK_KEY_wcircumflex = 0x1000175;

	public const int GDK_KEY_Ycircumflex = 0x1000176;

	public const int GDK_KEY_ycircumflex = 0x1000177;

	public const int GDK_KEY_Babovedot = 0x1001e02;

	public const int GDK_KEY_babovedot = 0x1001e03;

	public const int GDK_KEY_Dabovedot = 0x1001e0a;

	public const int GDK_KEY_dabovedot = 0x1001e0b;

	public const int GDK_KEY_Fabovedot = 0x1001e1e;

	public const int GDK_KEY_fabovedot = 0x1001e1f;

	public const int GDK_KEY_Mabovedot = 0x1001e40;

	public const int GDK_KEY_mabovedot = 0x1001e41;

	public const int GDK_KEY_Pabovedot = 0x1001e56;

	public const int GDK_KEY_pabovedot = 0x1001e57;

	public const int GDK_KEY_Sabovedot = 0x1001e60;

	public const int GDK_KEY_sabovedot = 0x1001e61;

	public const int GDK_KEY_Tabovedot = 0x1001e6a;

	public const int GDK_KEY_tabovedot = 0x1001e6b;

	public const int GDK_KEY_Wgrave = 0x1001e80;

	public const int GDK_KEY_wgrave = 0x1001e81;

	public const int GDK_KEY_Wacute = 0x1001e82;

	public const int GDK_KEY_wacute = 0x1001e83;

	public const int GDK_KEY_Wdiaeresis = 0x1001e84;

	public const int GDK_KEY_wdiaeresis = 0x1001e85;

	public const int GDK_KEY_Ygrave = 0x1001ef2;

	public const int GDK_KEY_ygrave = 0x1001ef3;

	public const int GDK_KEY_OE = 0x13bc;

	public const int GDK_KEY_oe = 0x13bd;

	public const int GDK_KEY_Ydiaeresis = 0x13be;

	public const int GDK_KEY_overline = 0x47e;

	public const int GDK_KEY_kana_fullstop = 0x4a1;

	public const int GDK_KEY_kana_openingbracket = 0x4a2;

	public const int GDK_KEY_kana_closingbracket = 0x4a3;

	public const int GDK_KEY_kana_comma = 0x4a4;

	public const int GDK_KEY_kana_conjunctive = 0x4a5;

	public const int GDK_KEY_kana_middledot = 0x4a5;

	public const int GDK_KEY_kana_WO = 0x4a6;

	public const int GDK_KEY_kana_a = 0x4a7;

	public const int GDK_KEY_kana_i = 0x4a8;

	public const int GDK_KEY_kana_u = 0x4a9;

	public const int GDK_KEY_kana_e = 0x4aa;

	public const int GDK_KEY_kana_o = 0x4ab;

	public const int GDK_KEY_kana_ya = 0x4ac;

	public const int GDK_KEY_kana_yu = 0x4ad;

	public const int GDK_KEY_kana_yo = 0x4ae;

	public const int GDK_KEY_kana_tsu = 0x4af;

	public const int GDK_KEY_kana_tu = 0x4af;

	public const int GDK_KEY_prolongedsound = 0x4b0;

	public const int GDK_KEY_kana_A = 0x4b1;

	public const int GDK_KEY_kana_I = 0x4b2;

	public const int GDK_KEY_kana_U = 0x4b3;

	public const int GDK_KEY_kana_E = 0x4b4;

	public const int GDK_KEY_kana_O = 0x4b5;

	public const int GDK_KEY_kana_KA = 0x4b6;

	public const int GDK_KEY_kana_KI = 0x4b7;

	public const int GDK_KEY_kana_KU = 0x4b8;

	public const int GDK_KEY_kana_KE = 0x4b9;

	public const int GDK_KEY_kana_KO = 0x4ba;

	public const int GDK_KEY_kana_SA = 0x4bb;

	public const int GDK_KEY_kana_SHI = 0x4bc;

	public const int GDK_KEY_kana_SU = 0x4bd;

	public const int GDK_KEY_kana_SE = 0x4be;

	public const int GDK_KEY_kana_SO = 0x4bf;

	public const int GDK_KEY_kana_TA = 0x4c0;

	public const int GDK_KEY_kana_CHI = 0x4c1;

	public const int GDK_KEY_kana_TI = 0x4c1;

	public const int GDK_KEY_kana_TSU = 0x4c2;

	public const int GDK_KEY_kana_TU = 0x4c2;

	public const int GDK_KEY_kana_TE = 0x4c3;

	public const int GDK_KEY_kana_TO = 0x4c4;

	public const int GDK_KEY_kana_NA = 0x4c5;

	public const int GDK_KEY_kana_NI = 0x4c6;

	public const int GDK_KEY_kana_NU = 0x4c7;

	public const int GDK_KEY_kana_NE = 0x4c8;

	public const int GDK_KEY_kana_NO = 0x4c9;

	public const int GDK_KEY_kana_HA = 0x4ca;

	public const int GDK_KEY_kana_HI = 0x4cb;

	public const int GDK_KEY_kana_FU = 0x4cc;

	public const int GDK_KEY_kana_HU = 0x4cc;

	public const int GDK_KEY_kana_HE = 0x4cd;

	public const int GDK_KEY_kana_HO = 0x4ce;

	public const int GDK_KEY_kana_MA = 0x4cf;

	public const int GDK_KEY_kana_MI = 0x4d0;

	public const int GDK_KEY_kana_MU = 0x4d1;

	public const int GDK_KEY_kana_ME = 0x4d2;

	public const int GDK_KEY_kana_MO = 0x4d3;

	public const int GDK_KEY_kana_YA = 0x4d4;

	public const int GDK_KEY_kana_YU = 0x4d5;

	public const int GDK_KEY_kana_YO = 0x4d6;

	public const int GDK_KEY_kana_RA = 0x4d7;

	public const int GDK_KEY_kana_RI = 0x4d8;

	public const int GDK_KEY_kana_RU = 0x4d9;

	public const int GDK_KEY_kana_RE = 0x4da;

	public const int GDK_KEY_kana_RO = 0x4db;

	public const int GDK_KEY_kana_WA = 0x4dc;

	public const int GDK_KEY_kana_N = 0x4dd;

	public const int GDK_KEY_voicedsound = 0x4de;

	public const int GDK_KEY_semivoicedsound = 0x4df;

	public const int GDK_KEY_kana_switch = 0xff7e;

	public const int GDK_KEY_Farsi_0 = 0x10006f0;

	public const int GDK_KEY_Farsi_1 = 0x10006f1;

	public const int GDK_KEY_Farsi_2 = 0x10006f2;

	public const int GDK_KEY_Farsi_3 = 0x10006f3;

	public const int GDK_KEY_Farsi_4 = 0x10006f4;

	public const int GDK_KEY_Farsi_5 = 0x10006f5;

	public const int GDK_KEY_Farsi_6 = 0x10006f6;

	public const int GDK_KEY_Farsi_7 = 0x10006f7;

	public const int GDK_KEY_Farsi_8 = 0x10006f8;

	public const int GDK_KEY_Farsi_9 = 0x10006f9;

	public const int GDK_KEY_Arabic_percent = 0x100066a;

	public const int GDK_KEY_Arabic_superscript_alef = 0x1000670;

	public const int GDK_KEY_Arabic_tteh = 0x1000679;

	public const int GDK_KEY_Arabic_peh = 0x100067e;

	public const int GDK_KEY_Arabic_tcheh = 0x1000686;

	public const int GDK_KEY_Arabic_ddal = 0x1000688;

	public const int GDK_KEY_Arabic_rreh = 0x1000691;

	public const int GDK_KEY_Arabic_comma = 0x5ac;

	public const int GDK_KEY_Arabic_fullstop = 0x10006d4;

	public const int GDK_KEY_Arabic_0 = 0x1000660;

	public const int GDK_KEY_Arabic_1 = 0x1000661;

	public const int GDK_KEY_Arabic_2 = 0x1000662;

	public const int GDK_KEY_Arabic_3 = 0x1000663;

	public const int GDK_KEY_Arabic_4 = 0x1000664;

	public const int GDK_KEY_Arabic_5 = 0x1000665;

	public const int GDK_KEY_Arabic_6 = 0x1000666;

	public const int GDK_KEY_Arabic_7 = 0x1000667;

	public const int GDK_KEY_Arabic_8 = 0x1000668;

	public const int GDK_KEY_Arabic_9 = 0x1000669;

	public const int GDK_KEY_Arabic_semicolon = 0x5bb;

	public const int GDK_KEY_Arabic_question_mark = 0x5bf;

	public const int GDK_KEY_Arabic_hamza = 0x5c1;

	public const int GDK_KEY_Arabic_maddaonalef = 0x5c2;

	public const int GDK_KEY_Arabic_hamzaonalef = 0x5c3;

	public const int GDK_KEY_Arabic_hamzaonwaw = 0x5c4;

	public const int GDK_KEY_Arabic_hamzaunderalef = 0x5c5;

	public const int GDK_KEY_Arabic_hamzaonyeh = 0x5c6;

	public const int GDK_KEY_Arabic_alef = 0x5c7;

	public const int GDK_KEY_Arabic_beh = 0x5c8;

	public const int GDK_KEY_Arabic_tehmarbuta = 0x5c9;

	public const int GDK_KEY_Arabic_teh = 0x5ca;

	public const int GDK_KEY_Arabic_theh = 0x5cb;

	public const int GDK_KEY_Arabic_jeem = 0x5cc;

	public const int GDK_KEY_Arabic_hah = 0x5cd;

	public const int GDK_KEY_Arabic_khah = 0x5ce;

	public const int GDK_KEY_Arabic_dal = 0x5cf;

	public const int GDK_KEY_Arabic_thal = 0x5d0;

	public const int GDK_KEY_Arabic_ra = 0x5d1;

	public const int GDK_KEY_Arabic_zain = 0x5d2;

	public const int GDK_KEY_Arabic_seen = 0x5d3;

	public const int GDK_KEY_Arabic_sheen = 0x5d4;

	public const int GDK_KEY_Arabic_sad = 0x5d5;

	public const int GDK_KEY_Arabic_dad = 0x5d6;

	public const int GDK_KEY_Arabic_tah = 0x5d7;

	public const int GDK_KEY_Arabic_zah = 0x5d8;

	public const int GDK_KEY_Arabic_ain = 0x5d9;

	public const int GDK_KEY_Arabic_ghain = 0x5da;

	public const int GDK_KEY_Arabic_tatweel = 0x5e0;

	public const int GDK_KEY_Arabic_feh = 0x5e1;

	public const int GDK_KEY_Arabic_qaf = 0x5e2;

	public const int GDK_KEY_Arabic_kaf = 0x5e3;

	public const int GDK_KEY_Arabic_lam = 0x5e4;

	public const int GDK_KEY_Arabic_meem = 0x5e5;

	public const int GDK_KEY_Arabic_noon = 0x5e6;

	public const int GDK_KEY_Arabic_ha = 0x5e7;

	public const int GDK_KEY_Arabic_heh = 0x5e7;

	public const int GDK_KEY_Arabic_waw = 0x5e8;

	public const int GDK_KEY_Arabic_alefmaksura = 0x5e9;

	public const int GDK_KEY_Arabic_yeh = 0x5ea;

	public const int GDK_KEY_Arabic_fathatan = 0x5eb;

	public const int GDK_KEY_Arabic_dammatan = 0x5ec;

	public const int GDK_KEY_Arabic_kasratan = 0x5ed;

	public const int GDK_KEY_Arabic_fatha = 0x5ee;

	public const int GDK_KEY_Arabic_damma = 0x5ef;

	public const int GDK_KEY_Arabic_kasra = 0x5f0;

	public const int GDK_KEY_Arabic_shadda = 0x5f1;

	public const int GDK_KEY_Arabic_sukun = 0x5f2;

	public const int GDK_KEY_Arabic_madda_above = 0x1000653;

	public const int GDK_KEY_Arabic_hamza_above = 0x1000654;

	public const int GDK_KEY_Arabic_hamza_below = 0x1000655;

	public const int GDK_KEY_Arabic_jeh = 0x1000698;

	public const int GDK_KEY_Arabic_veh = 0x10006a4;

	public const int GDK_KEY_Arabic_keheh = 0x10006a9;

	public const int GDK_KEY_Arabic_gaf = 0x10006af;

	public const int GDK_KEY_Arabic_noon_ghunna = 0x10006ba;

	public const int GDK_KEY_Arabic_heh_doachashmee = 0x10006be;

	public const int GDK_KEY_Farsi_yeh = 0x10006cc;

	public const int GDK_KEY_Arabic_farsi_yeh = 0x10006cc;

	public const int GDK_KEY_Arabic_yeh_baree = 0x10006d2;

	public const int GDK_KEY_Arabic_heh_goal = 0x10006c1;

	public const int GDK_KEY_Arabic_switch = 0xff7e;

	public const int GDK_KEY_Cyrillic_GHE_bar = 0x1000492;

	public const int GDK_KEY_Cyrillic_ghe_bar = 0x1000493;

	public const int GDK_KEY_Cyrillic_ZHE_descender = 0x1000496;

	public const int GDK_KEY_Cyrillic_zhe_descender = 0x1000497;

	public const int GDK_KEY_Cyrillic_KA_descender = 0x100049a;

	public const int GDK_KEY_Cyrillic_ka_descender = 0x100049b;

	public const int GDK_KEY_Cyrillic_KA_vertstroke = 0x100049c;

	public const int GDK_KEY_Cyrillic_ka_vertstroke = 0x100049d;

	public const int GDK_KEY_Cyrillic_EN_descender = 0x10004a2;

	public const int GDK_KEY_Cyrillic_en_descender = 0x10004a3;

	public const int GDK_KEY_Cyrillic_U_straight = 0x10004ae;

	public const int GDK_KEY_Cyrillic_u_straight = 0x10004af;

	public const int GDK_KEY_Cyrillic_U_straight_bar = 0x10004b0;

	public const int GDK_KEY_Cyrillic_u_straight_bar = 0x10004b1;

	public const int GDK_KEY_Cyrillic_HA_descender = 0x10004b2;

	public const int GDK_KEY_Cyrillic_ha_descender = 0x10004b3;

	public const int GDK_KEY_Cyrillic_CHE_descender = 0x10004b6;

	public const int GDK_KEY_Cyrillic_che_descender = 0x10004b7;

	public const int GDK_KEY_Cyrillic_CHE_vertstroke = 0x10004b8;

	public const int GDK_KEY_Cyrillic_che_vertstroke = 0x10004b9;

	public const int GDK_KEY_Cyrillic_SHHA = 0x10004ba;

	public const int GDK_KEY_Cyrillic_shha = 0x10004bb;

	public const int GDK_KEY_Cyrillic_SCHWA = 0x10004d8;

	public const int GDK_KEY_Cyrillic_schwa = 0x10004d9;

	public const int GDK_KEY_Cyrillic_I_macron = 0x10004e2;

	public const int GDK_KEY_Cyrillic_i_macron = 0x10004e3;

	public const int GDK_KEY_Cyrillic_O_bar = 0x10004e8;

	public const int GDK_KEY_Cyrillic_o_bar = 0x10004e9;

	public const int GDK_KEY_Cyrillic_U_macron = 0x10004ee;

	public const int GDK_KEY_Cyrillic_u_macron = 0x10004ef;

	public const int GDK_KEY_Serbian_dje = 0x6a1;

	public const int GDK_KEY_Macedonia_gje = 0x6a2;

	public const int GDK_KEY_Cyrillic_io = 0x6a3;

	public const int GDK_KEY_Ukrainian_ie = 0x6a4;

	public const int GDK_KEY_Ukranian_je = 0x6a4;

	public const int GDK_KEY_Macedonia_dse = 0x6a5;

	public const int GDK_KEY_Ukrainian_i = 0x6a6;

	public const int GDK_KEY_Ukranian_i = 0x6a6;

	public const int GDK_KEY_Ukrainian_yi = 0x6a7;

	public const int GDK_KEY_Ukranian_yi = 0x6a7;

	public const int GDK_KEY_Cyrillic_je = 0x6a8;

	public const int GDK_KEY_Serbian_je = 0x6a8;

	public const int GDK_KEY_Cyrillic_lje = 0x6a9;

	public const int GDK_KEY_Serbian_lje = 0x6a9;

	public const int GDK_KEY_Cyrillic_nje = 0x6aa;

	public const int GDK_KEY_Serbian_nje = 0x6aa;

	public const int GDK_KEY_Serbian_tshe = 0x6ab;

	public const int GDK_KEY_Macedonia_kje = 0x6ac;

	public const int GDK_KEY_Ukrainian_ghe_with_upturn = 0x6ad;

	public const int GDK_KEY_Byelorussian_shortu = 0x6ae;

	public const int GDK_KEY_Cyrillic_dzhe = 0x6af;

	public const int GDK_KEY_Serbian_dze = 0x6af;

	public const int GDK_KEY_numerosign = 0x6b0;

	public const int GDK_KEY_Serbian_DJE = 0x6b1;

	public const int GDK_KEY_Macedonia_GJE = 0x6b2;

	public const int GDK_KEY_Cyrillic_IO = 0x6b3;

	public const int GDK_KEY_Ukrainian_IE = 0x6b4;

	public const int GDK_KEY_Ukranian_JE = 0x6b4;

	public const int GDK_KEY_Macedonia_DSE = 0x6b5;

	public const int GDK_KEY_Ukrainian_I = 0x6b6;

	public const int GDK_KEY_Ukranian_I = 0x6b6;

	public const int GDK_KEY_Ukrainian_YI = 0x6b7;

	public const int GDK_KEY_Ukranian_YI = 0x6b7;

	public const int GDK_KEY_Cyrillic_JE = 0x6b8;

	public const int GDK_KEY_Serbian_JE = 0x6b8;

	public const int GDK_KEY_Cyrillic_LJE = 0x6b9;

	public const int GDK_KEY_Serbian_LJE = 0x6b9;

	public const int GDK_KEY_Cyrillic_NJE = 0x6ba;

	public const int GDK_KEY_Serbian_NJE = 0x6ba;

	public const int GDK_KEY_Serbian_TSHE = 0x6bb;

	public const int GDK_KEY_Macedonia_KJE = 0x6bc;

	public const int GDK_KEY_Ukrainian_GHE_WITH_UPTURN = 0x6bd;

	public const int GDK_KEY_Byelorussian_SHORTU = 0x6be;

	public const int GDK_KEY_Cyrillic_DZHE = 0x6bf;

	public const int GDK_KEY_Serbian_DZE = 0x6bf;

	public const int GDK_KEY_Cyrillic_yu = 0x6c0;

	public const int GDK_KEY_Cyrillic_a = 0x6c1;

	public const int GDK_KEY_Cyrillic_be = 0x6c2;

	public const int GDK_KEY_Cyrillic_tse = 0x6c3;

	public const int GDK_KEY_Cyrillic_de = 0x6c4;

	public const int GDK_KEY_Cyrillic_ie = 0x6c5;

	public const int GDK_KEY_Cyrillic_ef = 0x6c6;

	public const int GDK_KEY_Cyrillic_ghe = 0x6c7;

	public const int GDK_KEY_Cyrillic_ha = 0x6c8;

	public const int GDK_KEY_Cyrillic_i = 0x6c9;

	public const int GDK_KEY_Cyrillic_shorti = 0x6ca;

	public const int GDK_KEY_Cyrillic_ka = 0x6cb;

	public const int GDK_KEY_Cyrillic_el = 0x6cc;

	public const int GDK_KEY_Cyrillic_em = 0x6cd;

	public const int GDK_KEY_Cyrillic_en = 0x6ce;

	public const int GDK_KEY_Cyrillic_o = 0x6cf;

	public const int GDK_KEY_Cyrillic_pe = 0x6d0;

	public const int GDK_KEY_Cyrillic_ya = 0x6d1;

	public const int GDK_KEY_Cyrillic_er = 0x6d2;

	public const int GDK_KEY_Cyrillic_es = 0x6d3;

	public const int GDK_KEY_Cyrillic_te = 0x6d4;

	public const int GDK_KEY_Cyrillic_u = 0x6d5;

	public const int GDK_KEY_Cyrillic_zhe = 0x6d6;

	public const int GDK_KEY_Cyrillic_ve = 0x6d7;

	public const int GDK_KEY_Cyrillic_softsign = 0x6d8;

	public const int GDK_KEY_Cyrillic_yeru = 0x6d9;

	public const int GDK_KEY_Cyrillic_ze = 0x6da;

	public const int GDK_KEY_Cyrillic_sha = 0x6db;

	public const int GDK_KEY_Cyrillic_e = 0x6dc;

	public const int GDK_KEY_Cyrillic_shcha = 0x6dd;

	public const int GDK_KEY_Cyrillic_che = 0x6de;

	public const int GDK_KEY_Cyrillic_hardsign = 0x6df;

	public const int GDK_KEY_Cyrillic_YU = 0x6e0;

	public const int GDK_KEY_Cyrillic_A = 0x6e1;

	public const int GDK_KEY_Cyrillic_BE = 0x6e2;

	public const int GDK_KEY_Cyrillic_TSE = 0x6e3;

	public const int GDK_KEY_Cyrillic_DE = 0x6e4;

	public const int GDK_KEY_Cyrillic_IE = 0x6e5;

	public const int GDK_KEY_Cyrillic_EF = 0x6e6;

	public const int GDK_KEY_Cyrillic_GHE = 0x6e7;

	public const int GDK_KEY_Cyrillic_HA = 0x6e8;

	public const int GDK_KEY_Cyrillic_I = 0x6e9;

	public const int GDK_KEY_Cyrillic_SHORTI = 0x6ea;

	public const int GDK_KEY_Cyrillic_KA = 0x6eb;

	public const int GDK_KEY_Cyrillic_EL = 0x6ec;

	public const int GDK_KEY_Cyrillic_EM = 0x6ed;

	public const int GDK_KEY_Cyrillic_EN = 0x6ee;

	public const int GDK_KEY_Cyrillic_O = 0x6ef;

	public const int GDK_KEY_Cyrillic_PE = 0x6f0;

	public const int GDK_KEY_Cyrillic_YA = 0x6f1;

	public const int GDK_KEY_Cyrillic_ER = 0x6f2;

	public const int GDK_KEY_Cyrillic_ES = 0x6f3;

	public const int GDK_KEY_Cyrillic_TE = 0x6f4;

	public const int GDK_KEY_Cyrillic_U = 0x6f5;

	public const int GDK_KEY_Cyrillic_ZHE = 0x6f6;

	public const int GDK_KEY_Cyrillic_VE = 0x6f7;

	public const int GDK_KEY_Cyrillic_SOFTSIGN = 0x6f8;

	public const int GDK_KEY_Cyrillic_YERU = 0x6f9;

	public const int GDK_KEY_Cyrillic_ZE = 0x6fa;

	public const int GDK_KEY_Cyrillic_SHA = 0x6fb;

	public const int GDK_KEY_Cyrillic_E = 0x6fc;

	public const int GDK_KEY_Cyrillic_SHCHA = 0x6fd;

	public const int GDK_KEY_Cyrillic_CHE = 0x6fe;

	public const int GDK_KEY_Cyrillic_HARDSIGN = 0x6ff;

	public const int GDK_KEY_Greek_ALPHAaccent = 0x7a1;

	public const int GDK_KEY_Greek_EPSILONaccent = 0x7a2;

	public const int GDK_KEY_Greek_ETAaccent = 0x7a3;

	public const int GDK_KEY_Greek_IOTAaccent = 0x7a4;

	public const int GDK_KEY_Greek_IOTAdieresis = 0x7a5;

	public const int GDK_KEY_Greek_IOTAdiaeresis = 0x7a5;

	public const int GDK_KEY_Greek_OMICRONaccent = 0x7a7;

	public const int GDK_KEY_Greek_UPSILONaccent = 0x7a8;

	public const int GDK_KEY_Greek_UPSILONdieresis = 0x7a9;

	public const int GDK_KEY_Greek_OMEGAaccent = 0x7ab;

	public const int GDK_KEY_Greek_accentdieresis = 0x7ae;

	public const int GDK_KEY_Greek_horizbar = 0x7af;

	public const int GDK_KEY_Greek_alphaaccent = 0x7b1;

	public const int GDK_KEY_Greek_epsilonaccent = 0x7b2;

	public const int GDK_KEY_Greek_etaaccent = 0x7b3;

	public const int GDK_KEY_Greek_iotaaccent = 0x7b4;

	public const int GDK_KEY_Greek_iotadieresis = 0x7b5;

	public const int GDK_KEY_Greek_iotaaccentdieresis = 0x7b6;

	public const int GDK_KEY_Greek_omicronaccent = 0x7b7;

	public const int GDK_KEY_Greek_upsilonaccent = 0x7b8;

	public const int GDK_KEY_Greek_upsilondieresis = 0x7b9;

	public const int GDK_KEY_Greek_upsilonaccentdieresis = 0x7ba;

	public const int GDK_KEY_Greek_omegaaccent = 0x7bb;

	public const int GDK_KEY_Greek_ALPHA = 0x7c1;

	public const int GDK_KEY_Greek_BETA = 0x7c2;

	public const int GDK_KEY_Greek_GAMMA = 0x7c3;

	public const int GDK_KEY_Greek_DELTA = 0x7c4;

	public const int GDK_KEY_Greek_EPSILON = 0x7c5;

	public const int GDK_KEY_Greek_ZETA = 0x7c6;

	public const int GDK_KEY_Greek_ETA = 0x7c7;

	public const int GDK_KEY_Greek_THETA = 0x7c8;

	public const int GDK_KEY_Greek_IOTA = 0x7c9;

	public const int GDK_KEY_Greek_KAPPA = 0x7ca;

	public const int GDK_KEY_Greek_LAMDA = 0x7cb;

	public const int GDK_KEY_Greek_LAMBDA = 0x7cb;

	public const int GDK_KEY_Greek_MU = 0x7cc;

	public const int GDK_KEY_Greek_NU = 0x7cd;

	public const int GDK_KEY_Greek_XI = 0x7ce;

	public const int GDK_KEY_Greek_OMICRON = 0x7cf;

	public const int GDK_KEY_Greek_PI = 0x7d0;

	public const int GDK_KEY_Greek_RHO = 0x7d1;

	public const int GDK_KEY_Greek_SIGMA = 0x7d2;

	public const int GDK_KEY_Greek_TAU = 0x7d4;

	public const int GDK_KEY_Greek_UPSILON = 0x7d5;

	public const int GDK_KEY_Greek_PHI = 0x7d6;

	public const int GDK_KEY_Greek_CHI = 0x7d7;

	public const int GDK_KEY_Greek_PSI = 0x7d8;

	public const int GDK_KEY_Greek_OMEGA = 0x7d9;

	public const int GDK_KEY_Greek_alpha = 0x7e1;

	public const int GDK_KEY_Greek_beta = 0x7e2;

	public const int GDK_KEY_Greek_gamma = 0x7e3;

	public const int GDK_KEY_Greek_delta = 0x7e4;

	public const int GDK_KEY_Greek_epsilon = 0x7e5;

	public const int GDK_KEY_Greek_zeta = 0x7e6;

	public const int GDK_KEY_Greek_eta = 0x7e7;

	public const int GDK_KEY_Greek_theta = 0x7e8;

	public const int GDK_KEY_Greek_iota = 0x7e9;

	public const int GDK_KEY_Greek_kappa = 0x7ea;

	public const int GDK_KEY_Greek_lamda = 0x7eb;

	public const int GDK_KEY_Greek_lambda = 0x7eb;

	public const int GDK_KEY_Greek_mu = 0x7ec;

	public const int GDK_KEY_Greek_nu = 0x7ed;

	public const int GDK_KEY_Greek_xi = 0x7ee;

	public const int GDK_KEY_Greek_omicron = 0x7ef;

	public const int GDK_KEY_Greek_pi = 0x7f0;

	public const int GDK_KEY_Greek_rho = 0x7f1;

	public const int GDK_KEY_Greek_sigma = 0x7f2;

	public const int GDK_KEY_Greek_finalsmallsigma = 0x7f3;

	public const int GDK_KEY_Greek_tau = 0x7f4;

	public const int GDK_KEY_Greek_upsilon = 0x7f5;

	public const int GDK_KEY_Greek_phi = 0x7f6;

	public const int GDK_KEY_Greek_chi = 0x7f7;

	public const int GDK_KEY_Greek_psi = 0x7f8;

	public const int GDK_KEY_Greek_omega = 0x7f9;

	public const int GDK_KEY_Greek_switch = 0xff7e;

	public const int GDK_KEY_leftradical = 0x8a1;

	public const int GDK_KEY_topleftradical = 0x8a2;

	public const int GDK_KEY_horizconnector = 0x8a3;

	public const int GDK_KEY_topintegral = 0x8a4;

	public const int GDK_KEY_botintegral = 0x8a5;

	public const int GDK_KEY_vertconnector = 0x8a6;

	public const int GDK_KEY_topleftsqbracket = 0x8a7;

	public const int GDK_KEY_botleftsqbracket = 0x8a8;

	public const int GDK_KEY_toprightsqbracket = 0x8a9;

	public const int GDK_KEY_botrightsqbracket = 0x8aa;

	public const int GDK_KEY_topleftparens = 0x8ab;

	public const int GDK_KEY_botleftparens = 0x8ac;

	public const int GDK_KEY_toprightparens = 0x8ad;

	public const int GDK_KEY_botrightparens = 0x8ae;

	public const int GDK_KEY_leftmiddlecurlybrace = 0x8af;

	public const int GDK_KEY_rightmiddlecurlybrace = 0x8b0;

	public const int GDK_KEY_topleftsummation = 0x8b1;

	public const int GDK_KEY_botleftsummation = 0x8b2;

	public const int GDK_KEY_topvertsummationconnector = 0x8b3;

	public const int GDK_KEY_botvertsummationconnector = 0x8b4;

	public const int GDK_KEY_toprightsummation = 0x8b5;

	public const int GDK_KEY_botrightsummation = 0x8b6;

	public const int GDK_KEY_rightmiddlesummation = 0x8b7;

	public const int GDK_KEY_lessthanequal = 0x8bc;

	public const int GDK_KEY_notequal = 0x8bd;

	public const int GDK_KEY_greaterthanequal = 0x8be;

	public const int GDK_KEY_integral = 0x8bf;

	public const int GDK_KEY_therefore = 0x8c0;

	public const int GDK_KEY_variation = 0x8c1;

	public const int GDK_KEY_infinity = 0x8c2;

	public const int GDK_KEY_nabla = 0x8c5;

	public const int GDK_KEY_approximate = 0x8c8;

	public const int GDK_KEY_similarequal = 0x8c9;

	public const int GDK_KEY_ifonlyif = 0x8cd;

	public const int GDK_KEY_implies = 0x8ce;

	public const int GDK_KEY_identical = 0x8cf;

	public const int GDK_KEY_radical = 0x8d6;

	public const int GDK_KEY_includedin = 0x8da;

	public const int GDK_KEY_includes = 0x8db;

	public const int GDK_KEY_intersection = 0x8dc;

	public const int GDK_KEY_union = 0x8dd;

	public const int GDK_KEY_logicaland = 0x8de;

	public const int GDK_KEY_logicalor = 0x8df;

	public const int GDK_KEY_partialderivative = 0x8ef;

	public const int GDK_KEY_function = 0x8f6;

	public const int GDK_KEY_leftarrow = 0x8fb;

	public const int GDK_KEY_uparrow = 0x8fc;

	public const int GDK_KEY_rightarrow = 0x8fd;

	public const int GDK_KEY_downarrow = 0x8fe;

	public const int GDK_KEY_blank = 0x9df;

	public const int GDK_KEY_soliddiamond = 0x9e0;

	public const int GDK_KEY_checkerboard = 0x9e1;

	public const int GDK_KEY_ht = 0x9e2;

	public const int GDK_KEY_ff = 0x9e3;

	public const int GDK_KEY_cr = 0x9e4;

	public const int GDK_KEY_lf = 0x9e5;

	public const int GDK_KEY_nl = 0x9e8;

	public const int GDK_KEY_vt = 0x9e9;

	public const int GDK_KEY_lowrightcorner = 0x9ea;

	public const int GDK_KEY_uprightcorner = 0x9eb;

	public const int GDK_KEY_upleftcorner = 0x9ec;

	public const int GDK_KEY_lowleftcorner = 0x9ed;

	public const int GDK_KEY_crossinglines = 0x9ee;

	public const int GDK_KEY_horizlinescan1 = 0x9ef;

	public const int GDK_KEY_horizlinescan3 = 0x9f0;

	public const int GDK_KEY_horizlinescan5 = 0x9f1;

	public const int GDK_KEY_horizlinescan7 = 0x9f2;

	public const int GDK_KEY_horizlinescan9 = 0x9f3;

	public const int GDK_KEY_leftt = 0x9f4;

	public const int GDK_KEY_rightt = 0x9f5;

	public const int GDK_KEY_bott = 0x9f6;

	public const int GDK_KEY_topt = 0x9f7;

	public const int GDK_KEY_vertbar = 0x9f8;

	public const int GDK_KEY_emspace = 0xaa1;

	public const int GDK_KEY_enspace = 0xaa2;

	public const int GDK_KEY_em3space = 0xaa3;

	public const int GDK_KEY_em4space = 0xaa4;

	public const int GDK_KEY_digitspace = 0xaa5;

	public const int GDK_KEY_punctspace = 0xaa6;

	public const int GDK_KEY_thinspace = 0xaa7;

	public const int GDK_KEY_hairspace = 0xaa8;

	public const int GDK_KEY_emdash = 0xaa9;

	public const int GDK_KEY_endash = 0xaaa;

	public const int GDK_KEY_signifblank = 0xaac;

	public const int GDK_KEY_ellipsis = 0xaae;

	public const int GDK_KEY_doubbaselinedot = 0xaaf;

	public const int GDK_KEY_onethird = 0xab0;

	public const int GDK_KEY_twothirds = 0xab1;

	public const int GDK_KEY_onefifth = 0xab2;

	public const int GDK_KEY_twofifths = 0xab3;

	public const int GDK_KEY_threefifths = 0xab4;

	public const int GDK_KEY_fourfifths = 0xab5;

	public const int GDK_KEY_onesixth = 0xab6;

	public const int GDK_KEY_fivesixths = 0xab7;

	public const int GDK_KEY_careof = 0xab8;

	public const int GDK_KEY_figdash = 0xabb;

	public const int GDK_KEY_leftanglebracket = 0xabc;

	public const int GDK_KEY_decimalpoint = 0xabd;

	public const int GDK_KEY_rightanglebracket = 0xabe;

	public const int GDK_KEY_marker = 0xabf;

	public const int GDK_KEY_oneeighth = 0xac3;

	public const int GDK_KEY_threeeighths = 0xac4;

	public const int GDK_KEY_fiveeighths = 0xac5;

	public const int GDK_KEY_seveneighths = 0xac6;

	public const int GDK_KEY_trademark = 0xac9;

	public const int GDK_KEY_signaturemark = 0xaca;

	public const int GDK_KEY_trademarkincircle = 0xacb;

	public const int GDK_KEY_leftopentriangle = 0xacc;

	public const int GDK_KEY_rightopentriangle = 0xacd;

	public const int GDK_KEY_emopencircle = 0xace;

	public const int GDK_KEY_emopenrectangle = 0xacf;

	public const int GDK_KEY_leftsinglequotemark = 0xad0;

	public const int GDK_KEY_rightsinglequotemark = 0xad1;

	public const int GDK_KEY_leftdoublequotemark = 0xad2;

	public const int GDK_KEY_rightdoublequotemark = 0xad3;

	public const int GDK_KEY_prescription = 0xad4;

	public const int GDK_KEY_permille = 0xad5;

	public const int GDK_KEY_minutes = 0xad6;

	public const int GDK_KEY_seconds = 0xad7;

	public const int GDK_KEY_latincross = 0xad9;

	public const int GDK_KEY_hexagram = 0xada;

	public const int GDK_KEY_filledrectbullet = 0xadb;

	public const int GDK_KEY_filledlefttribullet = 0xadc;

	public const int GDK_KEY_filledrighttribullet = 0xadd;

	public const int GDK_KEY_emfilledcircle = 0xade;

	public const int GDK_KEY_emfilledrect = 0xadf;

	public const int GDK_KEY_enopencircbullet = 0xae0;

	public const int GDK_KEY_enopensquarebullet = 0xae1;

	public const int GDK_KEY_openrectbullet = 0xae2;

	public const int GDK_KEY_opentribulletup = 0xae3;

	public const int GDK_KEY_opentribulletdown = 0xae4;

	public const int GDK_KEY_openstar = 0xae5;

	public const int GDK_KEY_enfilledcircbullet = 0xae6;

	public const int GDK_KEY_enfilledsqbullet = 0xae7;

	public const int GDK_KEY_filledtribulletup = 0xae8;

	public const int GDK_KEY_filledtribulletdown = 0xae9;

	public const int GDK_KEY_leftpointer = 0xaea;

	public const int GDK_KEY_rightpointer = 0xaeb;

	public const int GDK_KEY_club = 0xaec;

	public const int GDK_KEY_diamond = 0xaed;

	public const int GDK_KEY_heart = 0xaee;

	public const int GDK_KEY_maltesecross = 0xaf0;

	public const int GDK_KEY_dagger = 0xaf1;

	public const int GDK_KEY_doubledagger = 0xaf2;

	public const int GDK_KEY_checkmark = 0xaf3;

	public const int GDK_KEY_ballotcross = 0xaf4;

	public const int GDK_KEY_musicalsharp = 0xaf5;

	public const int GDK_KEY_musicalflat = 0xaf6;

	public const int GDK_KEY_malesymbol = 0xaf7;

	public const int GDK_KEY_femalesymbol = 0xaf8;

	public const int GDK_KEY_telephone = 0xaf9;

	public const int GDK_KEY_telephonerecorder = 0xafa;

	public const int GDK_KEY_phonographcopyright = 0xafb;

	public const int GDK_KEY_caret = 0xafc;

	public const int GDK_KEY_singlelowquotemark = 0xafd;

	public const int GDK_KEY_doublelowquotemark = 0xafe;

	public const int GDK_KEY_cursor = 0xaff;

	public const int GDK_KEY_leftcaret = 0xba3;

	public const int GDK_KEY_rightcaret = 0xba6;

	public const int GDK_KEY_downcaret = 0xba8;

	public const int GDK_KEY_upcaret = 0xba9;

	public const int GDK_KEY_overbar = 0xbc0;

	public const int GDK_KEY_downtack = 0xbc2;

	public const int GDK_KEY_upshoe = 0xbc3;

	public const int GDK_KEY_downstile = 0xbc4;

	public const int GDK_KEY_underbar = 0xbc6;

	public const int GDK_KEY_jot = 0xbca;

	public const int GDK_KEY_quad = 0xbcc;

	public const int GDK_KEY_uptack = 0xbce;

	public const int GDK_KEY_circle = 0xbcf;

	public const int GDK_KEY_upstile = 0xbd3;

	public const int GDK_KEY_downshoe = 0xbd6;

	public const int GDK_KEY_rightshoe = 0xbd8;

	public const int GDK_KEY_leftshoe = 0xbda;

	public const int GDK_KEY_lefttack = 0xbdc;

	public const int GDK_KEY_righttack = 0xbfc;

	public const int GDK_KEY_hebrew_doublelowline = 0xcdf;

	public const int GDK_KEY_hebrew_aleph = 0xce0;

	public const int GDK_KEY_hebrew_bet = 0xce1;

	public const int GDK_KEY_hebrew_beth = 0xce1;

	public const int GDK_KEY_hebrew_gimel = 0xce2;

	public const int GDK_KEY_hebrew_gimmel = 0xce2;

	public const int GDK_KEY_hebrew_dalet = 0xce3;

	public const int GDK_KEY_hebrew_daleth = 0xce3;

	public const int GDK_KEY_hebrew_he = 0xce4;

	public const int GDK_KEY_hebrew_waw = 0xce5;

	public const int GDK_KEY_hebrew_zain = 0xce6;

	public const int GDK_KEY_hebrew_zayin = 0xce6;

	public const int GDK_KEY_hebrew_chet = 0xce7;

	public const int GDK_KEY_hebrew_het = 0xce7;

	public const int GDK_KEY_hebrew_tet = 0xce8;

	public const int GDK_KEY_hebrew_teth = 0xce8;

	public const int GDK_KEY_hebrew_yod = 0xce9;

	public const int GDK_KEY_hebrew_finalkaph = 0xcea;

	public const int GDK_KEY_hebrew_kaph = 0xceb;

	public const int GDK_KEY_hebrew_lamed = 0xcec;

	public const int GDK_KEY_hebrew_finalmem = 0xced;

	public const int GDK_KEY_hebrew_mem = 0xcee;

	public const int GDK_KEY_hebrew_finalnun = 0xcef;

	public const int GDK_KEY_hebrew_nun = 0xcf0;

	public const int GDK_KEY_hebrew_samech = 0xcf1;

	public const int GDK_KEY_hebrew_samekh = 0xcf1;

	public const int GDK_KEY_hebrew_ayin = 0xcf2;

	public const int GDK_KEY_hebrew_finalpe = 0xcf3;

	public const int GDK_KEY_hebrew_pe = 0xcf4;

	public const int GDK_KEY_hebrew_finalzade = 0xcf5;

	public const int GDK_KEY_hebrew_finalzadi = 0xcf5;

	public const int GDK_KEY_hebrew_zade = 0xcf6;

	public const int GDK_KEY_hebrew_zadi = 0xcf6;

	public const int GDK_KEY_hebrew_qoph = 0xcf7;

	public const int GDK_KEY_hebrew_kuf = 0xcf7;

	public const int GDK_KEY_hebrew_resh = 0xcf8;

	public const int GDK_KEY_hebrew_shin = 0xcf9;

	public const int GDK_KEY_hebrew_taw = 0xcfa;

	public const int GDK_KEY_hebrew_taf = 0xcfa;

	public const int GDK_KEY_Hebrew_switch = 0xff7e;

	public const int GDK_KEY_Thai_kokai = 0xda1;

	public const int GDK_KEY_Thai_khokhai = 0xda2;

	public const int GDK_KEY_Thai_khokhuat = 0xda3;

	public const int GDK_KEY_Thai_khokhwai = 0xda4;

	public const int GDK_KEY_Thai_khokhon = 0xda5;

	public const int GDK_KEY_Thai_khorakhang = 0xda6;

	public const int GDK_KEY_Thai_ngongu = 0xda7;

	public const int GDK_KEY_Thai_chochan = 0xda8;

	public const int GDK_KEY_Thai_choching = 0xda9;

	public const int GDK_KEY_Thai_chochang = 0xdaa;

	public const int GDK_KEY_Thai_soso = 0xdab;

	public const int GDK_KEY_Thai_chochoe = 0xdac;

	public const int GDK_KEY_Thai_yoying = 0xdad;

	public const int GDK_KEY_Thai_dochada = 0xdae;

	public const int GDK_KEY_Thai_topatak = 0xdaf;

	public const int GDK_KEY_Thai_thothan = 0xdb0;

	public const int GDK_KEY_Thai_thonangmontho = 0xdb1;

	public const int GDK_KEY_Thai_thophuthao = 0xdb2;

	public const int GDK_KEY_Thai_nonen = 0xdb3;

	public const int GDK_KEY_Thai_dodek = 0xdb4;

	public const int GDK_KEY_Thai_totao = 0xdb5;

	public const int GDK_KEY_Thai_thothung = 0xdb6;

	public const int GDK_KEY_Thai_thothahan = 0xdb7;

	public const int GDK_KEY_Thai_thothong = 0xdb8;

	public const int GDK_KEY_Thai_nonu = 0xdb9;

	public const int GDK_KEY_Thai_bobaimai = 0xdba;

	public const int GDK_KEY_Thai_popla = 0xdbb;

	public const int GDK_KEY_Thai_phophung = 0xdbc;

	public const int GDK_KEY_Thai_fofa = 0xdbd;

	public const int GDK_KEY_Thai_phophan = 0xdbe;

	public const int GDK_KEY_Thai_fofan = 0xdbf;

	public const int GDK_KEY_Thai_phosamphao = 0xdc0;

	public const int GDK_KEY_Thai_moma = 0xdc1;

	public const int GDK_KEY_Thai_yoyak = 0xdc2;

	public const int GDK_KEY_Thai_rorua = 0xdc3;

	public const int GDK_KEY_Thai_ru = 0xdc4;

	public const int GDK_KEY_Thai_loling = 0xdc5;

	public const int GDK_KEY_Thai_lu = 0xdc6;

	public const int GDK_KEY_Thai_wowaen = 0xdc7;

	public const int GDK_KEY_Thai_sosala = 0xdc8;

	public const int GDK_KEY_Thai_sorusi = 0xdc9;

	public const int GDK_KEY_Thai_sosua = 0xdca;

	public const int GDK_KEY_Thai_hohip = 0xdcb;

	public const int GDK_KEY_Thai_lochula = 0xdcc;

	public const int GDK_KEY_Thai_oang = 0xdcd;

	public const int GDK_KEY_Thai_honokhuk = 0xdce;

	public const int GDK_KEY_Thai_paiyannoi = 0xdcf;

	public const int GDK_KEY_Thai_saraa = 0xdd0;

	public const int GDK_KEY_Thai_maihanakat = 0xdd1;

	public const int GDK_KEY_Thai_saraaa = 0xdd2;

	public const int GDK_KEY_Thai_saraam = 0xdd3;

	public const int GDK_KEY_Thai_sarai = 0xdd4;

	public const int GDK_KEY_Thai_saraii = 0xdd5;

	public const int GDK_KEY_Thai_saraue = 0xdd6;

	public const int GDK_KEY_Thai_sarauee = 0xdd7;

	public const int GDK_KEY_Thai_sarau = 0xdd8;

	public const int GDK_KEY_Thai_sarauu = 0xdd9;

	public const int GDK_KEY_Thai_phinthu = 0xdda;

	public const int GDK_KEY_Thai_maihanakat_maitho = 0xdde;

	public const int GDK_KEY_Thai_baht = 0xddf;

	public const int GDK_KEY_Thai_sarae = 0xde0;

	public const int GDK_KEY_Thai_saraae = 0xde1;

	public const int GDK_KEY_Thai_sarao = 0xde2;

	public const int GDK_KEY_Thai_saraaimaimuan = 0xde3;

	public const int GDK_KEY_Thai_saraaimaimalai = 0xde4;

	public const int GDK_KEY_Thai_lakkhangyao = 0xde5;

	public const int GDK_KEY_Thai_maiyamok = 0xde6;

	public const int GDK_KEY_Thai_maitaikhu = 0xde7;

	public const int GDK_KEY_Thai_maiek = 0xde8;

	public const int GDK_KEY_Thai_maitho = 0xde9;

	public const int GDK_KEY_Thai_maitri = 0xdea;

	public const int GDK_KEY_Thai_maichattawa = 0xdeb;

	public const int GDK_KEY_Thai_thanthakhat = 0xdec;

	public const int GDK_KEY_Thai_nikhahit = 0xded;

	public const int GDK_KEY_Thai_leksun = 0xdf0;

	public const int GDK_KEY_Thai_leknung = 0xdf1;

	public const int GDK_KEY_Thai_leksong = 0xdf2;

	public const int GDK_KEY_Thai_leksam = 0xdf3;

	public const int GDK_KEY_Thai_leksi = 0xdf4;

	public const int GDK_KEY_Thai_lekha = 0xdf5;

	public const int GDK_KEY_Thai_lekhok = 0xdf6;

	public const int GDK_KEY_Thai_lekchet = 0xdf7;

	public const int GDK_KEY_Thai_lekpaet = 0xdf8;

	public const int GDK_KEY_Thai_lekkao = 0xdf9;

	public const int GDK_KEY_Hangul = 0xff31;

	public const int GDK_KEY_Hangul_Start = 0xff32;

	public const int GDK_KEY_Hangul_End = 0xff33;

	public const int GDK_KEY_Hangul_Hanja = 0xff34;

	public const int GDK_KEY_Hangul_Jamo = 0xff35;

	public const int GDK_KEY_Hangul_Romaja = 0xff36;

	public const int GDK_KEY_Hangul_Codeinput = 0xff37;

	public const int GDK_KEY_Hangul_Jeonja = 0xff38;

	public const int GDK_KEY_Hangul_Banja = 0xff39;

	public const int GDK_KEY_Hangul_PreHanja = 0xff3a;

	public const int GDK_KEY_Hangul_PostHanja = 0xff3b;

	public const int GDK_KEY_Hangul_SingleCandidate = 0xff3c;

	public const int GDK_KEY_Hangul_MultipleCandidate = 0xff3d;

	public const int GDK_KEY_Hangul_PreviousCandidate = 0xff3e;

	public const int GDK_KEY_Hangul_Special = 0xff3f;

	public const int GDK_KEY_Hangul_switch = 0xff7e;

	public const int GDK_KEY_Hangul_Kiyeog = 0xea1;

	public const int GDK_KEY_Hangul_SsangKiyeog = 0xea2;

	public const int GDK_KEY_Hangul_KiyeogSios = 0xea3;

	public const int GDK_KEY_Hangul_Nieun = 0xea4;

	public const int GDK_KEY_Hangul_NieunJieuj = 0xea5;

	public const int GDK_KEY_Hangul_NieunHieuh = 0xea6;

	public const int GDK_KEY_Hangul_Dikeud = 0xea7;

	public const int GDK_KEY_Hangul_SsangDikeud = 0xea8;

	public const int GDK_KEY_Hangul_Rieul = 0xea9;

	public const int GDK_KEY_Hangul_RieulKiyeog = 0xeaa;

	public const int GDK_KEY_Hangul_RieulMieum = 0xeab;

	public const int GDK_KEY_Hangul_RieulPieub = 0xeac;

	public const int GDK_KEY_Hangul_RieulSios = 0xead;

	public const int GDK_KEY_Hangul_RieulTieut = 0xeae;

	public const int GDK_KEY_Hangul_RieulPhieuf = 0xeaf;

	public const int GDK_KEY_Hangul_RieulHieuh = 0xeb0;

	public const int GDK_KEY_Hangul_Mieum = 0xeb1;

	public const int GDK_KEY_Hangul_Pieub = 0xeb2;

	public const int GDK_KEY_Hangul_SsangPieub = 0xeb3;

	public const int GDK_KEY_Hangul_PieubSios = 0xeb4;

	public const int GDK_KEY_Hangul_Sios = 0xeb5;

	public const int GDK_KEY_Hangul_SsangSios = 0xeb6;

	public const int GDK_KEY_Hangul_Ieung = 0xeb7;

	public const int GDK_KEY_Hangul_Jieuj = 0xeb8;

	public const int GDK_KEY_Hangul_SsangJieuj = 0xeb9;

	public const int GDK_KEY_Hangul_Cieuc = 0xeba;

	public const int GDK_KEY_Hangul_Khieuq = 0xebb;

	public const int GDK_KEY_Hangul_Tieut = 0xebc;

	public const int GDK_KEY_Hangul_Phieuf = 0xebd;

	public const int GDK_KEY_Hangul_Hieuh = 0xebe;

	public const int GDK_KEY_Hangul_A = 0xebf;

	public const int GDK_KEY_Hangul_AE = 0xec0;

	public const int GDK_KEY_Hangul_YA = 0xec1;

	public const int GDK_KEY_Hangul_YAE = 0xec2;

	public const int GDK_KEY_Hangul_EO = 0xec3;

	public const int GDK_KEY_Hangul_E = 0xec4;

	public const int GDK_KEY_Hangul_YEO = 0xec5;

	public const int GDK_KEY_Hangul_YE = 0xec6;

	public const int GDK_KEY_Hangul_O = 0xec7;

	public const int GDK_KEY_Hangul_WA = 0xec8;

	public const int GDK_KEY_Hangul_WAE = 0xec9;

	public const int GDK_KEY_Hangul_OE = 0xeca;

	public const int GDK_KEY_Hangul_YO = 0xecb;

	public const int GDK_KEY_Hangul_U = 0xecc;

	public const int GDK_KEY_Hangul_WEO = 0xecd;

	public const int GDK_KEY_Hangul_WE = 0xece;

	public const int GDK_KEY_Hangul_WI = 0xecf;

	public const int GDK_KEY_Hangul_YU = 0xed0;

	public const int GDK_KEY_Hangul_EU = 0xed1;

	public const int GDK_KEY_Hangul_YI = 0xed2;

	public const int GDK_KEY_Hangul_I = 0xed3;

	public const int GDK_KEY_Hangul_J_Kiyeog = 0xed4;

	public const int GDK_KEY_Hangul_J_SsangKiyeog = 0xed5;

	public const int GDK_KEY_Hangul_J_KiyeogSios = 0xed6;

	public const int GDK_KEY_Hangul_J_Nieun = 0xed7;

	public const int GDK_KEY_Hangul_J_NieunJieuj = 0xed8;

	public const int GDK_KEY_Hangul_J_NieunHieuh = 0xed9;

	public const int GDK_KEY_Hangul_J_Dikeud = 0xeda;

	public const int GDK_KEY_Hangul_J_Rieul = 0xedb;

	public const int GDK_KEY_Hangul_J_RieulKiyeog = 0xedc;

	public const int GDK_KEY_Hangul_J_RieulMieum = 0xedd;

	public const int GDK_KEY_Hangul_J_RieulPieub = 0xede;

	public const int GDK_KEY_Hangul_J_RieulSios = 0xedf;

	public const int GDK_KEY_Hangul_J_RieulTieut = 0xee0;

	public const int GDK_KEY_Hangul_J_RieulPhieuf = 0xee1;

	public const int GDK_KEY_Hangul_J_RieulHieuh = 0xee2;

	public const int GDK_KEY_Hangul_J_Mieum = 0xee3;

	public const int GDK_KEY_Hangul_J_Pieub = 0xee4;

	public const int GDK_KEY_Hangul_J_PieubSios = 0xee5;

	public const int GDK_KEY_Hangul_J_Sios = 0xee6;

	public const int GDK_KEY_Hangul_J_SsangSios = 0xee7;

	public const int GDK_KEY_Hangul_J_Ieung = 0xee8;

	public const int GDK_KEY_Hangul_J_Jieuj = 0xee9;

	public const int GDK_KEY_Hangul_J_Cieuc = 0xeea;

	public const int GDK_KEY_Hangul_J_Khieuq = 0xeeb;

	public const int GDK_KEY_Hangul_J_Tieut = 0xeec;

	public const int GDK_KEY_Hangul_J_Phieuf = 0xeed;

	public const int GDK_KEY_Hangul_J_Hieuh = 0xeee;

	public const int GDK_KEY_Hangul_RieulYeorinHieuh = 0xeef;

	public const int GDK_KEY_Hangul_SunkyeongeumMieum = 0xef0;

	public const int GDK_KEY_Hangul_SunkyeongeumPieub = 0xef1;

	public const int GDK_KEY_Hangul_PanSios = 0xef2;

	public const int GDK_KEY_Hangul_KkogjiDalrinIeung = 0xef3;

	public const int GDK_KEY_Hangul_SunkyeongeumPhieuf = 0xef4;

	public const int GDK_KEY_Hangul_YeorinHieuh = 0xef5;

	public const int GDK_KEY_Hangul_AraeA = 0xef6;

	public const int GDK_KEY_Hangul_AraeAE = 0xef7;

	public const int GDK_KEY_Hangul_J_PanSios = 0xef8;

	public const int GDK_KEY_Hangul_J_KkogjiDalrinIeung = 0xef9;

	public const int GDK_KEY_Hangul_J_YeorinHieuh = 0xefa;

	public const int GDK_KEY_Korean_Won = 0xeff;

	public const int GDK_KEY_Armenian_ligature_ew = 0x1000587;

	public const int GDK_KEY_Armenian_full_stop = 0x1000589;

	public const int GDK_KEY_Armenian_verjaket = 0x1000589;

	public const int GDK_KEY_Armenian_separation_mark = 0x100055d;

	public const int GDK_KEY_Armenian_but = 0x100055d;

	public const int GDK_KEY_Armenian_hyphen = 0x100058a;

	public const int GDK_KEY_Armenian_yentamna = 0x100058a;

	public const int GDK_KEY_Armenian_exclam = 0x100055c;

	public const int GDK_KEY_Armenian_amanak = 0x100055c;

	public const int GDK_KEY_Armenian_accent = 0x100055b;

	public const int GDK_KEY_Armenian_shesht = 0x100055b;

	public const int GDK_KEY_Armenian_question = 0x100055e;

	public const int GDK_KEY_Armenian_paruyk = 0x100055e;

	public const int GDK_KEY_Armenian_AYB = 0x1000531;

	public const int GDK_KEY_Armenian_ayb = 0x1000561;

	public const int GDK_KEY_Armenian_BEN = 0x1000532;

	public const int GDK_KEY_Armenian_ben = 0x1000562;

	public const int GDK_KEY_Armenian_GIM = 0x1000533;

	public const int GDK_KEY_Armenian_gim = 0x1000563;

	public const int GDK_KEY_Armenian_DA = 0x1000534;

	public const int GDK_KEY_Armenian_da = 0x1000564;

	public const int GDK_KEY_Armenian_YECH = 0x1000535;

	public const int GDK_KEY_Armenian_yech = 0x1000565;

	public const int GDK_KEY_Armenian_ZA = 0x1000536;

	public const int GDK_KEY_Armenian_za = 0x1000566;

	public const int GDK_KEY_Armenian_E = 0x1000537;

	public const int GDK_KEY_Armenian_e = 0x1000567;

	public const int GDK_KEY_Armenian_AT = 0x1000538;

	public const int GDK_KEY_Armenian_at = 0x1000568;

	public const int GDK_KEY_Armenian_TO = 0x1000539;

	public const int GDK_KEY_Armenian_to = 0x1000569;

	public const int GDK_KEY_Armenian_ZHE = 0x100053a;

	public const int GDK_KEY_Armenian_zhe = 0x100056a;

	public const int GDK_KEY_Armenian_INI = 0x100053b;

	public const int GDK_KEY_Armenian_ini = 0x100056b;

	public const int GDK_KEY_Armenian_LYUN = 0x100053c;

	public const int GDK_KEY_Armenian_lyun = 0x100056c;

	public const int GDK_KEY_Armenian_KHE = 0x100053d;

	public const int GDK_KEY_Armenian_khe = 0x100056d;

	public const int GDK_KEY_Armenian_TSA = 0x100053e;

	public const int GDK_KEY_Armenian_tsa = 0x100056e;

	public const int GDK_KEY_Armenian_KEN = 0x100053f;

	public const int GDK_KEY_Armenian_ken = 0x100056f;

	public const int GDK_KEY_Armenian_HO = 0x1000540;

	public const int GDK_KEY_Armenian_ho = 0x1000570;

	public const int GDK_KEY_Armenian_DZA = 0x1000541;

	public const int GDK_KEY_Armenian_dza = 0x1000571;

	public const int GDK_KEY_Armenian_GHAT = 0x1000542;

	public const int GDK_KEY_Armenian_ghat = 0x1000572;

	public const int GDK_KEY_Armenian_TCHE = 0x1000543;

	public const int GDK_KEY_Armenian_tche = 0x1000573;

	public const int GDK_KEY_Armenian_MEN = 0x1000544;

	public const int GDK_KEY_Armenian_men = 0x1000574;

	public const int GDK_KEY_Armenian_HI = 0x1000545;

	public const int GDK_KEY_Armenian_hi = 0x1000575;

	public const int GDK_KEY_Armenian_NU = 0x1000546;

	public const int GDK_KEY_Armenian_nu = 0x1000576;

	public const int GDK_KEY_Armenian_SHA = 0x1000547;

	public const int GDK_KEY_Armenian_sha = 0x1000577;

	public const int GDK_KEY_Armenian_VO = 0x1000548;

	public const int GDK_KEY_Armenian_vo = 0x1000578;

	public const int GDK_KEY_Armenian_CHA = 0x1000549;

	public const int GDK_KEY_Armenian_cha = 0x1000579;

	public const int GDK_KEY_Armenian_PE = 0x100054a;

	public const int GDK_KEY_Armenian_pe = 0x100057a;

	public const int GDK_KEY_Armenian_JE = 0x100054b;

	public const int GDK_KEY_Armenian_je = 0x100057b;

	public const int GDK_KEY_Armenian_RA = 0x100054c;

	public const int GDK_KEY_Armenian_ra = 0x100057c;

	public const int GDK_KEY_Armenian_SE = 0x100054d;

	public const int GDK_KEY_Armenian_se = 0x100057d;

	public const int GDK_KEY_Armenian_VEV = 0x100054e;

	public const int GDK_KEY_Armenian_vev = 0x100057e;

	public const int GDK_KEY_Armenian_TYUN = 0x100054f;

	public const int GDK_KEY_Armenian_tyun = 0x100057f;

	public const int GDK_KEY_Armenian_RE = 0x1000550;

	public const int GDK_KEY_Armenian_re = 0x1000580;

	public const int GDK_KEY_Armenian_TSO = 0x1000551;

	public const int GDK_KEY_Armenian_tso = 0x1000581;

	public const int GDK_KEY_Armenian_VYUN = 0x1000552;

	public const int GDK_KEY_Armenian_vyun = 0x1000582;

	public const int GDK_KEY_Armenian_PYUR = 0x1000553;

	public const int GDK_KEY_Armenian_pyur = 0x1000583;

	public const int GDK_KEY_Armenian_KE = 0x1000554;

	public const int GDK_KEY_Armenian_ke = 0x1000584;

	public const int GDK_KEY_Armenian_O = 0x1000555;

	public const int GDK_KEY_Armenian_o = 0x1000585;

	public const int GDK_KEY_Armenian_FE = 0x1000556;

	public const int GDK_KEY_Armenian_fe = 0x1000586;

	public const int GDK_KEY_Armenian_apostrophe = 0x100055a;

	public const int GDK_KEY_Georgian_an = 0x10010d0;

	public const int GDK_KEY_Georgian_ban = 0x10010d1;

	public const int GDK_KEY_Georgian_gan = 0x10010d2;

	public const int GDK_KEY_Georgian_don = 0x10010d3;

	public const int GDK_KEY_Georgian_en = 0x10010d4;

	public const int GDK_KEY_Georgian_vin = 0x10010d5;

	public const int GDK_KEY_Georgian_zen = 0x10010d6;

	public const int GDK_KEY_Georgian_tan = 0x10010d7;

	public const int GDK_KEY_Georgian_in = 0x10010d8;

	public const int GDK_KEY_Georgian_kan = 0x10010d9;

	public const int GDK_KEY_Georgian_las = 0x10010da;

	public const int GDK_KEY_Georgian_man = 0x10010db;

	public const int GDK_KEY_Georgian_nar = 0x10010dc;

	public const int GDK_KEY_Georgian_on = 0x10010dd;

	public const int GDK_KEY_Georgian_par = 0x10010de;

	public const int GDK_KEY_Georgian_zhar = 0x10010df;

	public const int GDK_KEY_Georgian_rae = 0x10010e0;

	public const int GDK_KEY_Georgian_san = 0x10010e1;

	public const int GDK_KEY_Georgian_tar = 0x10010e2;

	public const int GDK_KEY_Georgian_un = 0x10010e3;

	public const int GDK_KEY_Georgian_phar = 0x10010e4;

	public const int GDK_KEY_Georgian_khar = 0x10010e5;

	public const int GDK_KEY_Georgian_ghan = 0x10010e6;

	public const int GDK_KEY_Georgian_qar = 0x10010e7;

	public const int GDK_KEY_Georgian_shin = 0x10010e8;

	public const int GDK_KEY_Georgian_chin = 0x10010e9;

	public const int GDK_KEY_Georgian_can = 0x10010ea;

	public const int GDK_KEY_Georgian_jil = 0x10010eb;

	public const int GDK_KEY_Georgian_cil = 0x10010ec;

	public const int GDK_KEY_Georgian_char = 0x10010ed;

	public const int GDK_KEY_Georgian_xan = 0x10010ee;

	public const int GDK_KEY_Georgian_jhan = 0x10010ef;

	public const int GDK_KEY_Georgian_hae = 0x10010f0;

	public const int GDK_KEY_Georgian_he = 0x10010f1;

	public const int GDK_KEY_Georgian_hie = 0x10010f2;

	public const int GDK_KEY_Georgian_we = 0x10010f3;

	public const int GDK_KEY_Georgian_har = 0x10010f4;

	public const int GDK_KEY_Georgian_hoe = 0x10010f5;

	public const int GDK_KEY_Georgian_fi = 0x10010f6;

	public const int GDK_KEY_Xabovedot = 0x1001e8a;

	public const int GDK_KEY_Ibreve = 0x100012c;

	public const int GDK_KEY_Zstroke = 0x10001b5;

	public const int GDK_KEY_Gcaron = 0x10001e6;

	public const int GDK_KEY_Ocaron = 0x10001d1;

	public const int GDK_KEY_Obarred = 0x100019f;

	public const int GDK_KEY_xabovedot = 0x1001e8b;

	public const int GDK_KEY_ibreve = 0x100012d;

	public const int GDK_KEY_zstroke = 0x10001b6;

	public const int GDK_KEY_gcaron = 0x10001e7;

	public const int GDK_KEY_ocaron = 0x10001d2;

	public const int GDK_KEY_obarred = 0x1000275;

	public const int GDK_KEY_SCHWA = 0x100018f;

	public const int GDK_KEY_schwa = 0x1000259;

	public const int GDK_KEY_EZH = 0x10001b7;

	public const int GDK_KEY_ezh = 0x1000292;

	public const int GDK_KEY_Lbelowdot = 0x1001e36;

	public const int GDK_KEY_lbelowdot = 0x1001e37;

	public const int GDK_KEY_Abelowdot = 0x1001ea0;

	public const int GDK_KEY_abelowdot = 0x1001ea1;

	public const int GDK_KEY_Ahook = 0x1001ea2;

	public const int GDK_KEY_ahook = 0x1001ea3;

	public const int GDK_KEY_Acircumflexacute = 0x1001ea4;

	public const int GDK_KEY_acircumflexacute = 0x1001ea5;

	public const int GDK_KEY_Acircumflexgrave = 0x1001ea6;

	public const int GDK_KEY_acircumflexgrave = 0x1001ea7;

	public const int GDK_KEY_Acircumflexhook = 0x1001ea8;

	public const int GDK_KEY_acircumflexhook = 0x1001ea9;

	public const int GDK_KEY_Acircumflextilde = 0x1001eaa;

	public const int GDK_KEY_acircumflextilde = 0x1001eab;

	public const int GDK_KEY_Acircumflexbelowdot = 0x1001eac;

	public const int GDK_KEY_acircumflexbelowdot = 0x1001ead;

	public const int GDK_KEY_Abreveacute = 0x1001eae;

	public const int GDK_KEY_abreveacute = 0x1001eaf;

	public const int GDK_KEY_Abrevegrave = 0x1001eb0;

	public const int GDK_KEY_abrevegrave = 0x1001eb1;

	public const int GDK_KEY_Abrevehook = 0x1001eb2;

	public const int GDK_KEY_abrevehook = 0x1001eb3;

	public const int GDK_KEY_Abrevetilde = 0x1001eb4;

	public const int GDK_KEY_abrevetilde = 0x1001eb5;

	public const int GDK_KEY_Abrevebelowdot = 0x1001eb6;

	public const int GDK_KEY_abrevebelowdot = 0x1001eb7;

	public const int GDK_KEY_Ebelowdot = 0x1001eb8;

	public const int GDK_KEY_ebelowdot = 0x1001eb9;

	public const int GDK_KEY_Ehook = 0x1001eba;

	public const int GDK_KEY_ehook = 0x1001ebb;

	public const int GDK_KEY_Etilde = 0x1001ebc;

	public const int GDK_KEY_etilde = 0x1001ebd;

	public const int GDK_KEY_Ecircumflexacute = 0x1001ebe;

	public const int GDK_KEY_ecircumflexacute = 0x1001ebf;

	public const int GDK_KEY_Ecircumflexgrave = 0x1001ec0;

	public const int GDK_KEY_ecircumflexgrave = 0x1001ec1;

	public const int GDK_KEY_Ecircumflexhook = 0x1001ec2;

	public const int GDK_KEY_ecircumflexhook = 0x1001ec3;

	public const int GDK_KEY_Ecircumflextilde = 0x1001ec4;

	public const int GDK_KEY_ecircumflextilde = 0x1001ec5;

	public const int GDK_KEY_Ecircumflexbelowdot = 0x1001ec6;

	public const int GDK_KEY_ecircumflexbelowdot = 0x1001ec7;

	public const int GDK_KEY_Ihook = 0x1001ec8;

	public const int GDK_KEY_ihook = 0x1001ec9;

	public const int GDK_KEY_Ibelowdot = 0x1001eca;

	public const int GDK_KEY_ibelowdot = 0x1001ecb;

	public const int GDK_KEY_Obelowdot = 0x1001ecc;

	public const int GDK_KEY_obelowdot = 0x1001ecd;

	public const int GDK_KEY_Ohook = 0x1001ece;

	public const int GDK_KEY_ohook = 0x1001ecf;

	public const int GDK_KEY_Ocircumflexacute = 0x1001ed0;

	public const int GDK_KEY_ocircumflexacute = 0x1001ed1;

	public const int GDK_KEY_Ocircumflexgrave = 0x1001ed2;

	public const int GDK_KEY_ocircumflexgrave = 0x1001ed3;

	public const int GDK_KEY_Ocircumflexhook = 0x1001ed4;

	public const int GDK_KEY_ocircumflexhook = 0x1001ed5;

	public const int GDK_KEY_Ocircumflextilde = 0x1001ed6;

	public const int GDK_KEY_ocircumflextilde = 0x1001ed7;

	public const int GDK_KEY_Ocircumflexbelowdot = 0x1001ed8;

	public const int GDK_KEY_ocircumflexbelowdot = 0x1001ed9;

	public const int GDK_KEY_Ohornacute = 0x1001eda;

	public const int GDK_KEY_ohornacute = 0x1001edb;

	public const int GDK_KEY_Ohorngrave = 0x1001edc;

	public const int GDK_KEY_ohorngrave = 0x1001edd;

	public const int GDK_KEY_Ohornhook = 0x1001ede;

	public const int GDK_KEY_ohornhook = 0x1001edf;

	public const int GDK_KEY_Ohorntilde = 0x1001ee0;

	public const int GDK_KEY_ohorntilde = 0x1001ee1;

	public const int GDK_KEY_Ohornbelowdot = 0x1001ee2;

	public const int GDK_KEY_ohornbelowdot = 0x1001ee3;

	public const int GDK_KEY_Ubelowdot = 0x1001ee4;

	public const int GDK_KEY_ubelowdot = 0x1001ee5;

	public const int GDK_KEY_Uhook = 0x1001ee6;

	public const int GDK_KEY_uhook = 0x1001ee7;

	public const int GDK_KEY_Uhornacute = 0x1001ee8;

	public const int GDK_KEY_uhornacute = 0x1001ee9;

	public const int GDK_KEY_Uhorngrave = 0x1001eea;

	public const int GDK_KEY_uhorngrave = 0x1001eeb;

	public const int GDK_KEY_Uhornhook = 0x1001eec;

	public const int GDK_KEY_uhornhook = 0x1001eed;

	public const int GDK_KEY_Uhorntilde = 0x1001eee;

	public const int GDK_KEY_uhorntilde = 0x1001eef;

	public const int GDK_KEY_Uhornbelowdot = 0x1001ef0;

	public const int GDK_KEY_uhornbelowdot = 0x1001ef1;

	public const int GDK_KEY_Ybelowdot = 0x1001ef4;

	public const int GDK_KEY_ybelowdot = 0x1001ef5;

	public const int GDK_KEY_Yhook = 0x1001ef6;

	public const int GDK_KEY_yhook = 0x1001ef7;

	public const int GDK_KEY_Ytilde = 0x1001ef8;

	public const int GDK_KEY_ytilde = 0x1001ef9;

	public const int GDK_KEY_Ohorn = 0x10001a0;

	public const int GDK_KEY_ohorn = 0x10001a1;

	public const int GDK_KEY_Uhorn = 0x10001af;

	public const int GDK_KEY_uhorn = 0x10001b0;

	public const int GDK_KEY_EcuSign = 0x10020a0;

	public const int GDK_KEY_ColonSign = 0x10020a1;

	public const int GDK_KEY_CruzeiroSign = 0x10020a2;

	public const int GDK_KEY_FFrancSign = 0x10020a3;

	public const int GDK_KEY_LiraSign = 0x10020a4;

	public const int GDK_KEY_MillSign = 0x10020a5;

	public const int GDK_KEY_NairaSign = 0x10020a6;

	public const int GDK_KEY_PesetaSign = 0x10020a7;

	public const int GDK_KEY_RupeeSign = 0x10020a8;

	public const int GDK_KEY_WonSign = 0x10020a9;

	public const int GDK_KEY_NewSheqelSign = 0x10020aa;

	public const int GDK_KEY_DongSign = 0x10020ab;

	public const int GDK_KEY_EuroSign = 0x20ac;

	public const int GDK_KEY_zerosuperior = 0x1002070;

	public const int GDK_KEY_foursuperior = 0x1002074;

	public const int GDK_KEY_fivesuperior = 0x1002075;

	public const int GDK_KEY_sixsuperior = 0x1002076;

	public const int GDK_KEY_sevensuperior = 0x1002077;

	public const int GDK_KEY_eightsuperior = 0x1002078;

	public const int GDK_KEY_ninesuperior = 0x1002079;

	public const int GDK_KEY_zerosubscript = 0x1002080;

	public const int GDK_KEY_onesubscript = 0x1002081;

	public const int GDK_KEY_twosubscript = 0x1002082;

	public const int GDK_KEY_threesubscript = 0x1002083;

	public const int GDK_KEY_foursubscript = 0x1002084;

	public const int GDK_KEY_fivesubscript = 0x1002085;

	public const int GDK_KEY_sixsubscript = 0x1002086;

	public const int GDK_KEY_sevensubscript = 0x1002087;

	public const int GDK_KEY_eightsubscript = 0x1002088;

	public const int GDK_KEY_ninesubscript = 0x1002089;

	public const int GDK_KEY_partdifferential = 0x1002202;

	public const int GDK_KEY_emptyset = 0x1002205;

	public const int GDK_KEY_elementof = 0x1002208;

	public const int GDK_KEY_notelementof = 0x1002209;

	public const int GDK_KEY_containsas = 0x100220b;

	public const int GDK_KEY_squareroot = 0x100221a;

	public const int GDK_KEY_cuberoot = 0x100221b;

	public const int GDK_KEY_fourthroot = 0x100221c;

	public const int GDK_KEY_dintegral = 0x100222c;

	public const int GDK_KEY_tintegral = 0x100222d;

	public const int GDK_KEY_because = 0x1002235;

	public const int GDK_KEY_approxeq = 0x1002248;

	public const int GDK_KEY_notapproxeq = 0x1002247;

	public const int GDK_KEY_notidentical = 0x1002262;

	public const int GDK_KEY_stricteq = 0x1002263;

	public const int GDK_KEY_braille_dot_1 = 0xfff1;

	public const int GDK_KEY_braille_dot_2 = 0xfff2;

	public const int GDK_KEY_braille_dot_3 = 0xfff3;

	public const int GDK_KEY_braille_dot_4 = 0xfff4;

	public const int GDK_KEY_braille_dot_5 = 0xfff5;

	public const int GDK_KEY_braille_dot_6 = 0xfff6;

	public const int GDK_KEY_braille_dot_7 = 0xfff7;

	public const int GDK_KEY_braille_dot_8 = 0xfff8;

	public const int GDK_KEY_braille_dot_9 = 0xfff9;

	public const int GDK_KEY_braille_dot_10 = 0xfffa;

	public const int GDK_KEY_braille_blank = 0x1002800;

	public const int GDK_KEY_braille_dots_1 = 0x1002801;

	public const int GDK_KEY_braille_dots_2 = 0x1002802;

	public const int GDK_KEY_braille_dots_12 = 0x1002803;

	public const int GDK_KEY_braille_dots_3 = 0x1002804;

	public const int GDK_KEY_braille_dots_13 = 0x1002805;

	public const int GDK_KEY_braille_dots_23 = 0x1002806;

	public const int GDK_KEY_braille_dots_123 = 0x1002807;

	public const int GDK_KEY_braille_dots_4 = 0x1002808;

	public const int GDK_KEY_braille_dots_14 = 0x1002809;

	public const int GDK_KEY_braille_dots_24 = 0x100280a;

	public const int GDK_KEY_braille_dots_124 = 0x100280b;

	public const int GDK_KEY_braille_dots_34 = 0x100280c;

	public const int GDK_KEY_braille_dots_134 = 0x100280d;

	public const int GDK_KEY_braille_dots_234 = 0x100280e;

	public const int GDK_KEY_braille_dots_1234 = 0x100280f;

	public const int GDK_KEY_braille_dots_5 = 0x1002810;

	public const int GDK_KEY_braille_dots_15 = 0x1002811;

	public const int GDK_KEY_braille_dots_25 = 0x1002812;

	public const int GDK_KEY_braille_dots_125 = 0x1002813;

	public const int GDK_KEY_braille_dots_35 = 0x1002814;

	public const int GDK_KEY_braille_dots_135 = 0x1002815;

	public const int GDK_KEY_braille_dots_235 = 0x1002816;

	public const int GDK_KEY_braille_dots_1235 = 0x1002817;

	public const int GDK_KEY_braille_dots_45 = 0x1002818;

	public const int GDK_KEY_braille_dots_145 = 0x1002819;

	public const int GDK_KEY_braille_dots_245 = 0x100281a;

	public const int GDK_KEY_braille_dots_1245 = 0x100281b;

	public const int GDK_KEY_braille_dots_345 = 0x100281c;

	public const int GDK_KEY_braille_dots_1345 = 0x100281d;

	public const int GDK_KEY_braille_dots_2345 = 0x100281e;

	public const int GDK_KEY_braille_dots_12345 = 0x100281f;

	public const int GDK_KEY_braille_dots_6 = 0x1002820;

	public const int GDK_KEY_braille_dots_16 = 0x1002821;

	public const int GDK_KEY_braille_dots_26 = 0x1002822;

	public const int GDK_KEY_braille_dots_126 = 0x1002823;

	public const int GDK_KEY_braille_dots_36 = 0x1002824;

	public const int GDK_KEY_braille_dots_136 = 0x1002825;

	public const int GDK_KEY_braille_dots_236 = 0x1002826;

	public const int GDK_KEY_braille_dots_1236 = 0x1002827;

	public const int GDK_KEY_braille_dots_46 = 0x1002828;

	public const int GDK_KEY_braille_dots_146 = 0x1002829;

	public const int GDK_KEY_braille_dots_246 = 0x100282a;

	public const int GDK_KEY_braille_dots_1246 = 0x100282b;

	public const int GDK_KEY_braille_dots_346 = 0x100282c;

	public const int GDK_KEY_braille_dots_1346 = 0x100282d;

	public const int GDK_KEY_braille_dots_2346 = 0x100282e;

	public const int GDK_KEY_braille_dots_12346 = 0x100282f;

	public const int GDK_KEY_braille_dots_56 = 0x1002830;

	public const int GDK_KEY_braille_dots_156 = 0x1002831;

	public const int GDK_KEY_braille_dots_256 = 0x1002832;

	public const int GDK_KEY_braille_dots_1256 = 0x1002833;

	public const int GDK_KEY_braille_dots_356 = 0x1002834;

	public const int GDK_KEY_braille_dots_1356 = 0x1002835;

	public const int GDK_KEY_braille_dots_2356 = 0x1002836;

	public const int GDK_KEY_braille_dots_12356 = 0x1002837;

	public const int GDK_KEY_braille_dots_456 = 0x1002838;

	public const int GDK_KEY_braille_dots_1456 = 0x1002839;

	public const int GDK_KEY_braille_dots_2456 = 0x100283a;

	public const int GDK_KEY_braille_dots_12456 = 0x100283b;

	public const int GDK_KEY_braille_dots_3456 = 0x100283c;

	public const int GDK_KEY_braille_dots_13456 = 0x100283d;

	public const int GDK_KEY_braille_dots_23456 = 0x100283e;

	public const int GDK_KEY_braille_dots_123456 = 0x100283f;

	public const int GDK_KEY_braille_dots_7 = 0x1002840;

	public const int GDK_KEY_braille_dots_17 = 0x1002841;

	public const int GDK_KEY_braille_dots_27 = 0x1002842;

	public const int GDK_KEY_braille_dots_127 = 0x1002843;

	public const int GDK_KEY_braille_dots_37 = 0x1002844;

	public const int GDK_KEY_braille_dots_137 = 0x1002845;

	public const int GDK_KEY_braille_dots_237 = 0x1002846;

	public const int GDK_KEY_braille_dots_1237 = 0x1002847;

	public const int GDK_KEY_braille_dots_47 = 0x1002848;

	public const int GDK_KEY_braille_dots_147 = 0x1002849;

	public const int GDK_KEY_braille_dots_247 = 0x100284a;

	public const int GDK_KEY_braille_dots_1247 = 0x100284b;

	public const int GDK_KEY_braille_dots_347 = 0x100284c;

	public const int GDK_KEY_braille_dots_1347 = 0x100284d;

	public const int GDK_KEY_braille_dots_2347 = 0x100284e;

	public const int GDK_KEY_braille_dots_12347 = 0x100284f;

	public const int GDK_KEY_braille_dots_57 = 0x1002850;

	public const int GDK_KEY_braille_dots_157 = 0x1002851;

	public const int GDK_KEY_braille_dots_257 = 0x1002852;

	public const int GDK_KEY_braille_dots_1257 = 0x1002853;

	public const int GDK_KEY_braille_dots_357 = 0x1002854;

	public const int GDK_KEY_braille_dots_1357 = 0x1002855;

	public const int GDK_KEY_braille_dots_2357 = 0x1002856;

	public const int GDK_KEY_braille_dots_12357 = 0x1002857;

	public const int GDK_KEY_braille_dots_457 = 0x1002858;

	public const int GDK_KEY_braille_dots_1457 = 0x1002859;

	public const int GDK_KEY_braille_dots_2457 = 0x100285a;

	public const int GDK_KEY_braille_dots_12457 = 0x100285b;

	public const int GDK_KEY_braille_dots_3457 = 0x100285c;

	public const int GDK_KEY_braille_dots_13457 = 0x100285d;

	public const int GDK_KEY_braille_dots_23457 = 0x100285e;

	public const int GDK_KEY_braille_dots_123457 = 0x100285f;

	public const int GDK_KEY_braille_dots_67 = 0x1002860;

	public const int GDK_KEY_braille_dots_167 = 0x1002861;

	public const int GDK_KEY_braille_dots_267 = 0x1002862;

	public const int GDK_KEY_braille_dots_1267 = 0x1002863;

	public const int GDK_KEY_braille_dots_367 = 0x1002864;

	public const int GDK_KEY_braille_dots_1367 = 0x1002865;

	public const int GDK_KEY_braille_dots_2367 = 0x1002866;

	public const int GDK_KEY_braille_dots_12367 = 0x1002867;

	public const int GDK_KEY_braille_dots_467 = 0x1002868;

	public const int GDK_KEY_braille_dots_1467 = 0x1002869;

	public const int GDK_KEY_braille_dots_2467 = 0x100286a;

	public const int GDK_KEY_braille_dots_12467 = 0x100286b;

	public const int GDK_KEY_braille_dots_3467 = 0x100286c;

	public const int GDK_KEY_braille_dots_13467 = 0x100286d;

	public const int GDK_KEY_braille_dots_23467 = 0x100286e;

	public const int GDK_KEY_braille_dots_123467 = 0x100286f;

	public const int GDK_KEY_braille_dots_567 = 0x1002870;

	public const int GDK_KEY_braille_dots_1567 = 0x1002871;

	public const int GDK_KEY_braille_dots_2567 = 0x1002872;

	public const int GDK_KEY_braille_dots_12567 = 0x1002873;

	public const int GDK_KEY_braille_dots_3567 = 0x1002874;

	public const int GDK_KEY_braille_dots_13567 = 0x1002875;

	public const int GDK_KEY_braille_dots_23567 = 0x1002876;

	public const int GDK_KEY_braille_dots_123567 = 0x1002877;

	public const int GDK_KEY_braille_dots_4567 = 0x1002878;

	public const int GDK_KEY_braille_dots_14567 = 0x1002879;

	public const int GDK_KEY_braille_dots_24567 = 0x100287a;

	public const int GDK_KEY_braille_dots_124567 = 0x100287b;

	public const int GDK_KEY_braille_dots_34567 = 0x100287c;

	public const int GDK_KEY_braille_dots_134567 = 0x100287d;

	public const int GDK_KEY_braille_dots_234567 = 0x100287e;

	public const int GDK_KEY_braille_dots_1234567 = 0x100287f;

	public const int GDK_KEY_braille_dots_8 = 0x1002880;

	public const int GDK_KEY_braille_dots_18 = 0x1002881;

	public const int GDK_KEY_braille_dots_28 = 0x1002882;

	public const int GDK_KEY_braille_dots_128 = 0x1002883;

	public const int GDK_KEY_braille_dots_38 = 0x1002884;

	public const int GDK_KEY_braille_dots_138 = 0x1002885;

	public const int GDK_KEY_braille_dots_238 = 0x1002886;

	public const int GDK_KEY_braille_dots_1238 = 0x1002887;

	public const int GDK_KEY_braille_dots_48 = 0x1002888;

	public const int GDK_KEY_braille_dots_148 = 0x1002889;

	public const int GDK_KEY_braille_dots_248 = 0x100288a;

	public const int GDK_KEY_braille_dots_1248 = 0x100288b;

	public const int GDK_KEY_braille_dots_348 = 0x100288c;

	public const int GDK_KEY_braille_dots_1348 = 0x100288d;

	public const int GDK_KEY_braille_dots_2348 = 0x100288e;

	public const int GDK_KEY_braille_dots_12348 = 0x100288f;

	public const int GDK_KEY_braille_dots_58 = 0x1002890;

	public const int GDK_KEY_braille_dots_158 = 0x1002891;

	public const int GDK_KEY_braille_dots_258 = 0x1002892;

	public const int GDK_KEY_braille_dots_1258 = 0x1002893;

	public const int GDK_KEY_braille_dots_358 = 0x1002894;

	public const int GDK_KEY_braille_dots_1358 = 0x1002895;

	public const int GDK_KEY_braille_dots_2358 = 0x1002896;

	public const int GDK_KEY_braille_dots_12358 = 0x1002897;

	public const int GDK_KEY_braille_dots_458 = 0x1002898;

	public const int GDK_KEY_braille_dots_1458 = 0x1002899;

	public const int GDK_KEY_braille_dots_2458 = 0x100289a;

	public const int GDK_KEY_braille_dots_12458 = 0x100289b;

	public const int GDK_KEY_braille_dots_3458 = 0x100289c;

	public const int GDK_KEY_braille_dots_13458 = 0x100289d;

	public const int GDK_KEY_braille_dots_23458 = 0x100289e;

	public const int GDK_KEY_braille_dots_123458 = 0x100289f;

	public const int GDK_KEY_braille_dots_68 = 0x10028a0;

	public const int GDK_KEY_braille_dots_168 = 0x10028a1;

	public const int GDK_KEY_braille_dots_268 = 0x10028a2;

	public const int GDK_KEY_braille_dots_1268 = 0x10028a3;

	public const int GDK_KEY_braille_dots_368 = 0x10028a4;

	public const int GDK_KEY_braille_dots_1368 = 0x10028a5;

	public const int GDK_KEY_braille_dots_2368 = 0x10028a6;

	public const int GDK_KEY_braille_dots_12368 = 0x10028a7;

	public const int GDK_KEY_braille_dots_468 = 0x10028a8;

	public const int GDK_KEY_braille_dots_1468 = 0x10028a9;

	public const int GDK_KEY_braille_dots_2468 = 0x10028aa;

	public const int GDK_KEY_braille_dots_12468 = 0x10028ab;

	public const int GDK_KEY_braille_dots_3468 = 0x10028ac;

	public const int GDK_KEY_braille_dots_13468 = 0x10028ad;

	public const int GDK_KEY_braille_dots_23468 = 0x10028ae;

	public const int GDK_KEY_braille_dots_123468 = 0x10028af;

	public const int GDK_KEY_braille_dots_568 = 0x10028b0;

	public const int GDK_KEY_braille_dots_1568 = 0x10028b1;

	public const int GDK_KEY_braille_dots_2568 = 0x10028b2;

	public const int GDK_KEY_braille_dots_12568 = 0x10028b3;

	public const int GDK_KEY_braille_dots_3568 = 0x10028b4;

	public const int GDK_KEY_braille_dots_13568 = 0x10028b5;

	public const int GDK_KEY_braille_dots_23568 = 0x10028b6;

	public const int GDK_KEY_braille_dots_123568 = 0x10028b7;

	public const int GDK_KEY_braille_dots_4568 = 0x10028b8;

	public const int GDK_KEY_braille_dots_14568 = 0x10028b9;

	public const int GDK_KEY_braille_dots_24568 = 0x10028ba;

	public const int GDK_KEY_braille_dots_124568 = 0x10028bb;

	public const int GDK_KEY_braille_dots_34568 = 0x10028bc;

	public const int GDK_KEY_braille_dots_134568 = 0x10028bd;

	public const int GDK_KEY_braille_dots_234568 = 0x10028be;

	public const int GDK_KEY_braille_dots_1234568 = 0x10028bf;

	public const int GDK_KEY_braille_dots_78 = 0x10028c0;

	public const int GDK_KEY_braille_dots_178 = 0x10028c1;

	public const int GDK_KEY_braille_dots_278 = 0x10028c2;

	public const int GDK_KEY_braille_dots_1278 = 0x10028c3;

	public const int GDK_KEY_braille_dots_378 = 0x10028c4;

	public const int GDK_KEY_braille_dots_1378 = 0x10028c5;

	public const int GDK_KEY_braille_dots_2378 = 0x10028c6;

	public const int GDK_KEY_braille_dots_12378 = 0x10028c7;

	public const int GDK_KEY_braille_dots_478 = 0x10028c8;

	public const int GDK_KEY_braille_dots_1478 = 0x10028c9;

	public const int GDK_KEY_braille_dots_2478 = 0x10028ca;

	public const int GDK_KEY_braille_dots_12478 = 0x10028cb;

	public const int GDK_KEY_braille_dots_3478 = 0x10028cc;

	public const int GDK_KEY_braille_dots_13478 = 0x10028cd;

	public const int GDK_KEY_braille_dots_23478 = 0x10028ce;

	public const int GDK_KEY_braille_dots_123478 = 0x10028cf;

	public const int GDK_KEY_braille_dots_578 = 0x10028d0;

	public const int GDK_KEY_braille_dots_1578 = 0x10028d1;

	public const int GDK_KEY_braille_dots_2578 = 0x10028d2;

	public const int GDK_KEY_braille_dots_12578 = 0x10028d3;

	public const int GDK_KEY_braille_dots_3578 = 0x10028d4;

	public const int GDK_KEY_braille_dots_13578 = 0x10028d5;

	public const int GDK_KEY_braille_dots_23578 = 0x10028d6;

	public const int GDK_KEY_braille_dots_123578 = 0x10028d7;

	public const int GDK_KEY_braille_dots_4578 = 0x10028d8;

	public const int GDK_KEY_braille_dots_14578 = 0x10028d9;

	public const int GDK_KEY_braille_dots_24578 = 0x10028da;

	public const int GDK_KEY_braille_dots_124578 = 0x10028db;

	public const int GDK_KEY_braille_dots_34578 = 0x10028dc;

	public const int GDK_KEY_braille_dots_134578 = 0x10028dd;

	public const int GDK_KEY_braille_dots_234578 = 0x10028de;

	public const int GDK_KEY_braille_dots_1234578 = 0x10028df;

	public const int GDK_KEY_braille_dots_678 = 0x10028e0;

	public const int GDK_KEY_braille_dots_1678 = 0x10028e1;

	public const int GDK_KEY_braille_dots_2678 = 0x10028e2;

	public const int GDK_KEY_braille_dots_12678 = 0x10028e3;

	public const int GDK_KEY_braille_dots_3678 = 0x10028e4;

	public const int GDK_KEY_braille_dots_13678 = 0x10028e5;

	public const int GDK_KEY_braille_dots_23678 = 0x10028e6;

	public const int GDK_KEY_braille_dots_123678 = 0x10028e7;

	public const int GDK_KEY_braille_dots_4678 = 0x10028e8;

	public const int GDK_KEY_braille_dots_14678 = 0x10028e9;

	public const int GDK_KEY_braille_dots_24678 = 0x10028ea;

	public const int GDK_KEY_braille_dots_124678 = 0x10028eb;

	public const int GDK_KEY_braille_dots_34678 = 0x10028ec;

	public const int GDK_KEY_braille_dots_134678 = 0x10028ed;

	public const int GDK_KEY_braille_dots_234678 = 0x10028ee;

	public const int GDK_KEY_braille_dots_1234678 = 0x10028ef;

	public const int GDK_KEY_braille_dots_5678 = 0x10028f0;

	public const int GDK_KEY_braille_dots_15678 = 0x10028f1;

	public const int GDK_KEY_braille_dots_25678 = 0x10028f2;

	public const int GDK_KEY_braille_dots_125678 = 0x10028f3;

	public const int GDK_KEY_braille_dots_35678 = 0x10028f4;

	public const int GDK_KEY_braille_dots_135678 = 0x10028f5;

	public const int GDK_KEY_braille_dots_235678 = 0x10028f6;

	public const int GDK_KEY_braille_dots_1235678 = 0x10028f7;

	public const int GDK_KEY_braille_dots_45678 = 0x10028f8;

	public const int GDK_KEY_braille_dots_145678 = 0x10028f9;

	public const int GDK_KEY_braille_dots_245678 = 0x10028fa;

	public const int GDK_KEY_braille_dots_1245678 = 0x10028fb;

	public const int GDK_KEY_braille_dots_345678 = 0x10028fc;

	public const int GDK_KEY_braille_dots_1345678 = 0x10028fd;

	public const int GDK_KEY_braille_dots_2345678 = 0x10028fe;

	public const int GDK_KEY_braille_dots_12345678 = 0x10028ff;

	public const int GDK_KEY_Sinh_ng = 0x1000d82;

	public const int GDK_KEY_Sinh_h2 = 0x1000d83;

	public const int GDK_KEY_Sinh_a = 0x1000d85;

	public const int GDK_KEY_Sinh_aa = 0x1000d86;

	public const int GDK_KEY_Sinh_ae = 0x1000d87;

	public const int GDK_KEY_Sinh_aee = 0x1000d88;

	public const int GDK_KEY_Sinh_i = 0x1000d89;

	public const int GDK_KEY_Sinh_ii = 0x1000d8a;

	public const int GDK_KEY_Sinh_u = 0x1000d8b;

	public const int GDK_KEY_Sinh_uu = 0x1000d8c;

	public const int GDK_KEY_Sinh_ri = 0x1000d8d;

	public const int GDK_KEY_Sinh_rii = 0x1000d8e;

	public const int GDK_KEY_Sinh_lu = 0x1000d8f;

	public const int GDK_KEY_Sinh_luu = 0x1000d90;

	public const int GDK_KEY_Sinh_e = 0x1000d91;

	public const int GDK_KEY_Sinh_ee = 0x1000d92;

	public const int GDK_KEY_Sinh_ai = 0x1000d93;

	public const int GDK_KEY_Sinh_o = 0x1000d94;

	public const int GDK_KEY_Sinh_oo = 0x1000d95;

	public const int GDK_KEY_Sinh_au = 0x1000d96;

	public const int GDK_KEY_Sinh_ka = 0x1000d9a;

	public const int GDK_KEY_Sinh_kha = 0x1000d9b;

	public const int GDK_KEY_Sinh_ga = 0x1000d9c;

	public const int GDK_KEY_Sinh_gha = 0x1000d9d;

	public const int GDK_KEY_Sinh_ng2 = 0x1000d9e;

	public const int GDK_KEY_Sinh_nga = 0x1000d9f;

	public const int GDK_KEY_Sinh_ca = 0x1000da0;

	public const int GDK_KEY_Sinh_cha = 0x1000da1;

	public const int GDK_KEY_Sinh_ja = 0x1000da2;

	public const int GDK_KEY_Sinh_jha = 0x1000da3;

	public const int GDK_KEY_Sinh_nya = 0x1000da4;

	public const int GDK_KEY_Sinh_jnya = 0x1000da5;

	public const int GDK_KEY_Sinh_nja = 0x1000da6;

	public const int GDK_KEY_Sinh_tta = 0x1000da7;

	public const int GDK_KEY_Sinh_ttha = 0x1000da8;

	public const int GDK_KEY_Sinh_dda = 0x1000da9;

	public const int GDK_KEY_Sinh_ddha = 0x1000daa;

	public const int GDK_KEY_Sinh_nna = 0x1000dab;

	public const int GDK_KEY_Sinh_ndda = 0x1000dac;

	public const int GDK_KEY_Sinh_tha = 0x1000dad;

	public const int GDK_KEY_Sinh_thha = 0x1000dae;

	public const int GDK_KEY_Sinh_dha = 0x1000daf;

	public const int GDK_KEY_Sinh_dhha = 0x1000db0;

	public const int GDK_KEY_Sinh_na = 0x1000db1;

	public const int GDK_KEY_Sinh_ndha = 0x1000db3;

	public const int GDK_KEY_Sinh_pa = 0x1000db4;

	public const int GDK_KEY_Sinh_pha = 0x1000db5;

	public const int GDK_KEY_Sinh_ba = 0x1000db6;

	public const int GDK_KEY_Sinh_bha = 0x1000db7;

	public const int GDK_KEY_Sinh_ma = 0x1000db8;

	public const int GDK_KEY_Sinh_mba = 0x1000db9;

	public const int GDK_KEY_Sinh_ya = 0x1000dba;

	public const int GDK_KEY_Sinh_ra = 0x1000dbb;

	public const int GDK_KEY_Sinh_la = 0x1000dbd;

	public const int GDK_KEY_Sinh_va = 0x1000dc0;

	public const int GDK_KEY_Sinh_sha = 0x1000dc1;

	public const int GDK_KEY_Sinh_ssha = 0x1000dc2;

	public const int GDK_KEY_Sinh_sa = 0x1000dc3;

	public const int GDK_KEY_Sinh_ha = 0x1000dc4;

	public const int GDK_KEY_Sinh_lla = 0x1000dc5;

	public const int GDK_KEY_Sinh_fa = 0x1000dc6;

	public const int GDK_KEY_Sinh_al = 0x1000dca;

	public const int GDK_KEY_Sinh_aa2 = 0x1000dcf;

	public const int GDK_KEY_Sinh_ae2 = 0x1000dd0;

	public const int GDK_KEY_Sinh_aee2 = 0x1000dd1;

	public const int GDK_KEY_Sinh_i2 = 0x1000dd2;

	public const int GDK_KEY_Sinh_ii2 = 0x1000dd3;

	public const int GDK_KEY_Sinh_u2 = 0x1000dd4;

	public const int GDK_KEY_Sinh_uu2 = 0x1000dd6;

	public const int GDK_KEY_Sinh_ru2 = 0x1000dd8;

	public const int GDK_KEY_Sinh_e2 = 0x1000dd9;

	public const int GDK_KEY_Sinh_ee2 = 0x1000dda;

	public const int GDK_KEY_Sinh_ai2 = 0x1000ddb;

	public const int GDK_KEY_Sinh_o2 = 0x1000ddc;

	public const int GDK_KEY_Sinh_oo2 = 0x1000ddd;

	public const int GDK_KEY_Sinh_au2 = 0x1000dde;

	public const int GDK_KEY_Sinh_lu2 = 0x1000ddf;

	public const int GDK_KEY_Sinh_ruu2 = 0x1000df2;

	public const int GDK_KEY_Sinh_luu2 = 0x1000df3;

	public const int GDK_KEY_Sinh_kunddaliya = 0x1000df4;

	public const int GDK_KEY_ModeLock = 0x1008ff01;

	public const int GDK_KEY_MonBrightnessUp = 0x1008ff02;

	public const int GDK_KEY_MonBrightnessDown = 0x1008ff03;

	public const int GDK_KEY_KbdLightOnOff = 0x1008ff04;

	public const int GDK_KEY_KbdBrightnessUp = 0x1008ff05;

	public const int GDK_KEY_KbdBrightnessDown = 0x1008ff06;

	public const int GDK_KEY_Standby = 0x1008ff10;

	public const int GDK_KEY_AudioLowerVolume = 0x1008ff11;

	public const int GDK_KEY_AudioMute = 0x1008ff12;

	public const int GDK_KEY_AudioRaiseVolume = 0x1008ff13;

	public const int GDK_KEY_AudioPlay = 0x1008ff14;

	public const int GDK_KEY_AudioStop = 0x1008ff15;

	public const int GDK_KEY_AudioPrev = 0x1008ff16;

	public const int GDK_KEY_AudioNext = 0x1008ff17;

	public const int GDK_KEY_HomePage = 0x1008ff18;

	public const int GDK_KEY_Mail = 0x1008ff19;

	public const int GDK_KEY_Start = 0x1008ff1a;

	public const int GDK_KEY_Search = 0x1008ff1b;

	public const int GDK_KEY_AudioRecord = 0x1008ff1c;

	public const int GDK_KEY_Calculator = 0x1008ff1d;

	public const int GDK_KEY_Memo = 0x1008ff1e;

	public const int GDK_KEY_ToDoList = 0x1008ff1f;

	public const int GDK_KEY_Calendar = 0x1008ff20;

	public const int GDK_KEY_PowerDown = 0x1008ff21;

	public const int GDK_KEY_ContrastAdjust = 0x1008ff22;

	public const int GDK_KEY_RockerUp = 0x1008ff23;

	public const int GDK_KEY_RockerDown = 0x1008ff24;

	public const int GDK_KEY_RockerEnter = 0x1008ff25;

	public const int GDK_KEY_Back = 0x1008ff26;

	public const int GDK_KEY_Forward = 0x1008ff27;

	public const int GDK_KEY_Stop = 0x1008ff28;

	public const int GDK_KEY_Refresh = 0x1008ff29;

	public const int GDK_KEY_PowerOff = 0x1008ff2a;

	public const int GDK_KEY_WakeUp = 0x1008ff2b;

	public const int GDK_KEY_Eject = 0x1008ff2c;

	public const int GDK_KEY_ScreenSaver = 0x1008ff2d;

	public const int GDK_KEY_WWW = 0x1008ff2e;

	public const int GDK_KEY_Sleep = 0x1008ff2f;

	public const int GDK_KEY_Favorites = 0x1008ff30;

	public const int GDK_KEY_AudioPause = 0x1008ff31;

	public const int GDK_KEY_AudioMedia = 0x1008ff32;

	public const int GDK_KEY_MyComputer = 0x1008ff33;

	public const int GDK_KEY_VendorHome = 0x1008ff34;

	public const int GDK_KEY_LightBulb = 0x1008ff35;

	public const int GDK_KEY_Shop = 0x1008ff36;

	public const int GDK_KEY_History = 0x1008ff37;

	public const int GDK_KEY_OpenURL = 0x1008ff38;

	public const int GDK_KEY_AddFavorite = 0x1008ff39;

	public const int GDK_KEY_HotLinks = 0x1008ff3a;

	public const int GDK_KEY_BrightnessAdjust = 0x1008ff3b;

	public const int GDK_KEY_Finance = 0x1008ff3c;

	public const int GDK_KEY_Community = 0x1008ff3d;

	public const int GDK_KEY_AudioRewind = 0x1008ff3e;

	public const int GDK_KEY_BackForward = 0x1008ff3f;

	public const int GDK_KEY_Launch0 = 0x1008ff40;

	public const int GDK_KEY_Launch1 = 0x1008ff41;

	public const int GDK_KEY_Launch2 = 0x1008ff42;

	public const int GDK_KEY_Launch3 = 0x1008ff43;

	public const int GDK_KEY_Launch4 = 0x1008ff44;

	public const int GDK_KEY_Launch5 = 0x1008ff45;

	public const int GDK_KEY_Launch6 = 0x1008ff46;

	public const int GDK_KEY_Launch7 = 0x1008ff47;

	public const int GDK_KEY_Launch8 = 0x1008ff48;

	public const int GDK_KEY_Launch9 = 0x1008ff49;

	public const int GDK_KEY_LaunchA = 0x1008ff4a;

	public const int GDK_KEY_LaunchB = 0x1008ff4b;

	public const int GDK_KEY_LaunchC = 0x1008ff4c;

	public const int GDK_KEY_LaunchD = 0x1008ff4d;

	public const int GDK_KEY_LaunchE = 0x1008ff4e;

	public const int GDK_KEY_LaunchF = 0x1008ff4f;

	public const int GDK_KEY_ApplicationLeft = 0x1008ff50;

	public const int GDK_KEY_ApplicationRight = 0x1008ff51;

	public const int GDK_KEY_Book = 0x1008ff52;

	public const int GDK_KEY_CD = 0x1008ff53;

	public const int GDK_KEY_WindowClear = 0x1008ff55;

	public const int GDK_KEY_Close = 0x1008ff56;

	public const int GDK_KEY_Copy = 0x1008ff57;

	public const int GDK_KEY_Cut = 0x1008ff58;

	public const int GDK_KEY_Display = 0x1008ff59;

	public const int GDK_KEY_DOS = 0x1008ff5a;

	public const int GDK_KEY_Documents = 0x1008ff5b;

	public const int GDK_KEY_Excel = 0x1008ff5c;

	public const int GDK_KEY_Explorer = 0x1008ff5d;

	public const int GDK_KEY_Game = 0x1008ff5e;

	public const int GDK_KEY_Go = 0x1008ff5f;

	public const int GDK_KEY_iTouch = 0x1008ff60;

	public const int GDK_KEY_LogOff = 0x1008ff61;

	public const int GDK_KEY_Market = 0x1008ff62;

	public const int GDK_KEY_Meeting = 0x1008ff63;

	public const int GDK_KEY_MenuKB = 0x1008ff65;

	public const int GDK_KEY_MenuPB = 0x1008ff66;

	public const int GDK_KEY_MySites = 0x1008ff67;

	public const int GDK_KEY_New = 0x1008ff68;

	public const int GDK_KEY_News = 0x1008ff69;

	public const int GDK_KEY_OfficeHome = 0x1008ff6a;

	public const int GDK_KEY_Open = 0x1008ff6b;

	public const int GDK_KEY_Option = 0x1008ff6c;

	public const int GDK_KEY_Paste = 0x1008ff6d;

	public const int GDK_KEY_Phone = 0x1008ff6e;

	public const int GDK_KEY_Reply = 0x1008ff72;

	public const int GDK_KEY_Reload = 0x1008ff73;

	public const int GDK_KEY_RotateWindows = 0x1008ff74;

	public const int GDK_KEY_RotationPB = 0x1008ff75;

	public const int GDK_KEY_RotationKB = 0x1008ff76;

	public const int GDK_KEY_Save = 0x1008ff77;

	public const int GDK_KEY_ScrollUp = 0x1008ff78;

	public const int GDK_KEY_ScrollDown = 0x1008ff79;

	public const int GDK_KEY_ScrollClick = 0x1008ff7a;

	public const int GDK_KEY_Send = 0x1008ff7b;

	public const int GDK_KEY_Spell = 0x1008ff7c;

	public const int GDK_KEY_SplitScreen = 0x1008ff7d;

	public const int GDK_KEY_Support = 0x1008ff7e;

	public const int GDK_KEY_TaskPane = 0x1008ff7f;

	public const int GDK_KEY_Terminal = 0x1008ff80;

	public const int GDK_KEY_Tools = 0x1008ff81;

	public const int GDK_KEY_Travel = 0x1008ff82;

	public const int GDK_KEY_UserPB = 0x1008ff84;

	public const int GDK_KEY_User1KB = 0x1008ff85;

	public const int GDK_KEY_User2KB = 0x1008ff86;

	public const int GDK_KEY_Video = 0x1008ff87;

	public const int GDK_KEY_WheelButton = 0x1008ff88;

	public const int GDK_KEY_Word = 0x1008ff89;

	public const int GDK_KEY_Xfer = 0x1008ff8a;

	public const int GDK_KEY_ZoomIn = 0x1008ff8b;

	public const int GDK_KEY_ZoomOut = 0x1008ff8c;

	public const int GDK_KEY_Away = 0x1008ff8d;

	public const int GDK_KEY_Messenger = 0x1008ff8e;

	public const int GDK_KEY_WebCam = 0x1008ff8f;

	public const int GDK_KEY_MailForward = 0x1008ff90;

	public const int GDK_KEY_Pictures = 0x1008ff91;

	public const int GDK_KEY_Music = 0x1008ff92;

	public const int GDK_KEY_Battery = 0x1008ff93;

	public const int GDK_KEY_Bluetooth = 0x1008ff94;

	public const int GDK_KEY_WLAN = 0x1008ff95;

	public const int GDK_KEY_UWB = 0x1008ff96;

	public const int GDK_KEY_AudioForward = 0x1008ff97;

	public const int GDK_KEY_AudioRepeat = 0x1008ff98;

	public const int GDK_KEY_AudioRandomPlay = 0x1008ff99;

	public const int GDK_KEY_Subtitle = 0x1008ff9a;

	public const int GDK_KEY_AudioCycleTrack = 0x1008ff9b;

	public const int GDK_KEY_CycleAngle = 0x1008ff9c;

	public const int GDK_KEY_FrameBack = 0x1008ff9d;

	public const int GDK_KEY_FrameForward = 0x1008ff9e;

	public const int GDK_KEY_Time = 0x1008ff9f;

	public const int GDK_KEY_SelectButton = 0x1008ffa0;

	public const int GDK_KEY_View = 0x1008ffa1;

	public const int GDK_KEY_TopMenu = 0x1008ffa2;

	public const int GDK_KEY_Red = 0x1008ffa3;

	public const int GDK_KEY_Green = 0x1008ffa4;

	public const int GDK_KEY_Yellow = 0x1008ffa5;

	public const int GDK_KEY_Blue = 0x1008ffa6;

	public const int GDK_KEY_Suspend = 0x1008ffa7;

	public const int GDK_KEY_Hibernate = 0x1008ffa8;

	public const int GDK_KEY_TouchpadToggle = 0x1008ffa9;

	public const int GDK_KEY_TouchpadOn = 0x1008ffb0;

	public const int GDK_KEY_TouchpadOff = 0x1008ffb1;

	public const int GDK_KEY_AudioMicMute = 0x1008ffb2;

	public const int GDK_KEY_Keyboard = 0x1008ffb3;

	public const int GDK_KEY_WWAN = 0x1008ffb4;

	public const int GDK_KEY_RFKill = 0x1008ffb5;

	public const int GDK_KEY_AudioPreset = 0x1008ffb6;

	public const int GDK_KEY_Switch_VT_1 = 0x1008fe01;

	public const int GDK_KEY_Switch_VT_2 = 0x1008fe02;

	public const int GDK_KEY_Switch_VT_3 = 0x1008fe03;

	public const int GDK_KEY_Switch_VT_4 = 0x1008fe04;

	public const int GDK_KEY_Switch_VT_5 = 0x1008fe05;

	public const int GDK_KEY_Switch_VT_6 = 0x1008fe06;

	public const int GDK_KEY_Switch_VT_7 = 0x1008fe07;

	public const int GDK_KEY_Switch_VT_8 = 0x1008fe08;

	public const int GDK_KEY_Switch_VT_9 = 0x1008fe09;

	public const int GDK_KEY_Switch_VT_10 = 0x1008fe0a;

	public const int GDK_KEY_Switch_VT_11 = 0x1008fe0b;

	public const int GDK_KEY_Switch_VT_12 = 0x1008fe0c;

	public const int GDK_KEY_Ungrab = 0x1008fe20;

	public const int GDK_KEY_ClearGrab = 0x1008fe21;

	public const int GDK_KEY_Next_VMode = 0x1008fe22;

	public const int GDK_KEY_Prev_VMode = 0x1008fe23;

	public const int GDK_KEY_LogWindowTree = 0x1008fe24;

	public const int GDK_KEY_LogGrabInfo = 0x1008fe25;

	public const GdkMemoryFormat GDK_MEMORY_DEFAULT = GdkMemoryFormat.GDK_MEMORY_B8G8R8A8_PREMULTIPLIED;

	public static nuint GDK_TYPE_APP_LAUNCH_CONTEXT => gdk_app_launch_context_get_type();

	public static nuint GDK_TYPE_RGBA => gdk_rgba_get_type();

	public static nuint GDK_TYPE_TEXTURE => gdk_texture_get_type();

	public static uint GDK_TEXTURE_ERROR => gdk_texture_error_quark();

	public static nuint GDK_TYPE_CAIRO_CONTEXT => gdk_cairo_context_get_type();

	public static nuint GDK_TYPE_CLIPBOARD => gdk_clipboard_get_type();

	public static nuint GDK_TYPE_CONTENT_DESERIALIZER => gdk_content_deserializer_get_type();

	public static nuint GDK_TYPE_CONTENT_FORMATS => gdk_content_formats_get_type();

	public static nuint GDK_TYPE_CONTENT_FORMATS_BUILDER => gdk_content_formats_builder_get_type();

	public static nuint GDK_TYPE_FILE_LIST => gdk_file_list_get_type();

	public static nuint GDK_TYPE_CONTENT_PROVIDER => gdk_content_provider_get_type();

	public static nuint GDK_TYPE_CONTENT_SERIALIZER => gdk_content_serializer_get_type();

	public static nuint GDK_TYPE_CURSOR => gdk_cursor_get_type();

	public static nuint GDK_TYPE_DEVICE_TOOL => gdk_device_tool_get_type();

	public static nuint GDK_TYPE_DEVICE => gdk_device_get_type();

	public static nuint GDK_TYPE_DEVICE_PAD => gdk_device_pad_get_type();

	public static nuint GDK_TYPE_DRAG => gdk_drag_get_type();

	public static nuint GDK_TYPE_EVENT => gdk_event_get_type();

	public static nuint GDK_TYPE_EVENT_SEQUENCE => gdk_event_sequence_get_type();

	public static nuint GDK_TYPE_BUTTON_EVENT => gdk_button_event_get_type();

	public static nuint GDK_TYPE_CROSSING_EVENT => gdk_crossing_event_get_type();

	public static nuint GDK_TYPE_DELETE_EVENT => gdk_delete_event_get_type();

	public static nuint GDK_TYPE_DND_EVENT => gdk_dnd_event_get_type();

	public static nuint GDK_TYPE_FOCUS_EVENT => gdk_focus_event_get_type();

	public static nuint GDK_TYPE_GRAB_BROKEN_EVENT => gdk_grab_broken_event_get_type();

	public static nuint GDK_TYPE_KEY_EVENT => gdk_key_event_get_type();

	public static nuint GDK_TYPE_MOTION_EVENT => gdk_motion_event_get_type();

	public static nuint GDK_TYPE_PAD_EVENT => gdk_pad_event_get_type();

	public static nuint GDK_TYPE_PROXIMITY_EVENT => gdk_proximity_event_get_type();

	public static nuint GDK_TYPE_SCROLL_EVENT => gdk_scroll_event_get_type();

	public static nuint GDK_TYPE_TOUCH_EVENT => gdk_touch_event_get_type();

	public static nuint GDK_TYPE_TOUCHPAD_EVENT => gdk_touchpad_event_get_type();

	public static nuint GDK_TYPE_FRAME_CLOCK => gdk_frame_clock_get_type();

	public static nuint GDK_TYPE_RECTANGLE => gdk_rectangle_get_type();

	public static nuint GDK_TYPE_MONITOR => gdk_monitor_get_type();

	public static nuint GDK_TYPE_POPUP_LAYOUT => gdk_popup_layout_get_type();

	public static nuint GDK_TYPE_SURFACE => gdk_surface_get_type();

	public static nuint GDK_TYPE_SEAT => gdk_seat_get_type();

	public static nuint GDK_TYPE_DISPLAY => gdk_display_get_type();

	public static nuint GDK_TYPE_DISPLAY_MANAGER => gdk_display_manager_get_type();

	public static nuint GDK_TYPE_DRAG_SURFACE => gdk_drag_surface_get_type();

	public static nuint GDK_TYPE_DRAW_CONTEXT => gdk_draw_context_get_type();

	public static nuint GDK_TYPE_DROP => gdk_drop_get_type();

	public static nuint GDK_TYPE_INPUT_SOURCE => gdk_input_source_get_type();

	public static nuint GDK_TYPE_DEVICE_PAD_FEATURE => gdk_device_pad_feature_get_type();

	public static nuint GDK_TYPE_DEVICE_TOOL_TYPE => gdk_device_tool_type_get_type();

	public static nuint GDK_TYPE_DRAG_CANCEL_REASON => gdk_drag_cancel_reason_get_type();

	public static nuint GDK_TYPE_GRAVITY => gdk_gravity_get_type();

	public static nuint GDK_TYPE_MODIFIER_TYPE => gdk_modifier_type_get_type();

	public static nuint GDK_TYPE_GL_ERROR => gdk_gl_error_get_type();

	public static nuint GDK_TYPE_VULKAN_ERROR => gdk_vulkan_error_get_type();

	public static nuint GDK_TYPE_AXIS_USE => gdk_axis_use_get_type();

	public static nuint GDK_TYPE_AXIS_FLAGS => gdk_axis_flags_get_type();

	public static nuint GDK_TYPE_DRAG_ACTION => gdk_drag_action_get_type();

	public static nuint GDK_TYPE_MEMORY_FORMAT => gdk_memory_format_get_type();

	public static nuint GDK_TYPE_EVENT_TYPE => gdk_event_type_get_type();

	public static nuint GDK_TYPE_TOUCHPAD_GESTURE_PHASE => gdk_touchpad_gesture_phase_get_type();

	public static nuint GDK_TYPE_SCROLL_DIRECTION => gdk_scroll_direction_get_type();

	public static nuint GDK_TYPE_NOTIFY_TYPE => gdk_notify_type_get_type();

	public static nuint GDK_TYPE_CROSSING_MODE => gdk_crossing_mode_get_type();

	public static nuint GDK_TYPE_KEY_MATCH => gdk_key_match_get_type();

	public static nuint GDK_TYPE_FRAME_CLOCK_PHASE => gdk_frame_clock_phase_get_type();

	public static nuint GDK_TYPE_GL_API => gdk_gl_api_get_type();

	public static nuint GDK_TYPE_SUBPIXEL_LAYOUT => gdk_subpixel_layout_get_type();

	public static nuint GDK_TYPE_PAINTABLE_FLAGS => gdk_paintable_flags_get_type();

	public static nuint GDK_TYPE_ANCHOR_HINTS => gdk_anchor_hints_get_type();

	public static nuint GDK_TYPE_SEAT_CAPABILITIES => gdk_seat_capabilities_get_type();

	public static nuint GDK_TYPE_TEXTURE_ERROR => gdk_texture_error_get_type();

	public static nuint GDK_TYPE_SURFACE_EDGE => gdk_surface_edge_get_type();

	public static nuint GDK_TYPE_FULLSCREEN_MODE => gdk_fullscreen_mode_get_type();

	public static nuint GDK_TYPE_TOPLEVEL_STATE => gdk_toplevel_state_get_type();

	public static nuint GDK_TYPE_TITLEBAR_GESTURE => gdk_titlebar_gesture_get_type();

	public static nuint GDK_TYPE_GL_CONTEXT => gdk_gl_context_get_type();

	public static uint GDK_GL_ERROR => gdk_gl_error_quark();

	public static nuint GDK_TYPE_GL_TEXTURE => gdk_gl_texture_get_type();

	public static nuint GDK_TYPE_MEMORY_TEXTURE => gdk_memory_texture_get_type();

	public static nuint GDK_TYPE_PAINTABLE => gdk_paintable_get_type();

	public static nuint GDK_TYPE_POPUP => gdk_popup_get_type();

	public static nuint GDK_TYPE_SNAPSHOT => gdk_snapshot_get_type();

	public static nuint GDK_TYPE_TOPLEVEL_LAYOUT => gdk_toplevel_layout_get_type();

	public static nuint GDK_TYPE_TOPLEVEL => gdk_toplevel_get_type();

	public static nuint GDK_TYPE_TOPLEVEL_SIZE => gdk_toplevel_size_get_type();

	public static nuint GDK_TYPE_VULKAN_CONTEXT => gdk_vulkan_context_get_type();

	public static uint GDK_VULKAN_ERROR => gdk_vulkan_error_quark();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_app_launch_context_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_rgba_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint gdk_rgba_hash(IntPtr p);

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int gdk_rgba_equal(IntPtr p1, IntPtr p2);

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark gdk_texture_error_quark();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_texture_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_cairo_context_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_clipboard_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_content_deserializer_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void gdk_content_register_deserializer(string mime_type, GType type, GdkContentDeserializeFunc deserialize, IntPtr data, GDestroyNotify notify);

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string gdk_intern_mime_type(string @string);

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_content_formats_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GdkContentFormatsHandle gdk_content_formats_parse(string @string);

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_content_formats_builder_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_file_list_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_content_provider_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_content_serializer_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void gdk_content_register_serializer(GType type, string mime_type, GdkContentSerializeFunc serialize, IntPtr data, GDestroyNotify notify);

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_cursor_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_device_tool_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_device_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_device_pad_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_drag_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int gdk_drag_action_is_unique(GdkDragAction action);

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_event_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_event_sequence_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_button_event_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_scroll_event_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_key_event_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_focus_event_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_touch_event_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_crossing_event_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_touchpad_event_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_pad_event_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_dnd_event_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_grab_broken_event_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_motion_event_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_delete_event_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_proximity_event_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_frame_timings_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_frame_clock_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_rectangle_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_monitor_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_popup_layout_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_surface_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_seat_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_display_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GdkDisplayHandle gdk_display_open(string display_name);

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GdkDisplayHandle gdk_display_get_default();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_display_manager_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GdkDisplayManagerHandle gdk_display_manager_get();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void gdk_set_allowed_backends(string backends);

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_drag_surface_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_draw_context_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_drop_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_input_source_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_device_pad_feature_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_device_tool_type_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_drag_cancel_reason_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_gravity_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_modifier_type_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_gl_error_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_vulkan_error_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_axis_use_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_axis_flags_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_drag_action_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_memory_format_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_event_type_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_touchpad_gesture_phase_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_scroll_direction_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_notify_type_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_crossing_mode_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_key_match_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_frame_clock_phase_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_gl_api_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_subpixel_layout_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_paintable_flags_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_anchor_hints_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_seat_capabilities_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_texture_error_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_surface_edge_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_fullscreen_mode_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_toplevel_state_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_titlebar_gesture_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark gdk_gl_error_quark();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_gl_context_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GdkGLContextHandle gdk_gl_context_get_current();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void gdk_gl_context_clear_current();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_gl_texture_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string gdk_keyval_name(uint keyval);

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint gdk_keyval_from_name(string keyval_name);

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void gdk_keyval_convert_case(uint symbol, out uint lower, out uint upper);

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint gdk_keyval_to_upper(uint keyval);

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint gdk_keyval_to_lower(uint keyval);

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int gdk_keyval_is_upper(uint keyval);

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int gdk_keyval_is_lower(uint keyval);

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint gdk_keyval_to_unicode(uint keyval);

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint gdk_unicode_to_keyval(uint wc);

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_memory_texture_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_paintable_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_popup_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_snapshot_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_toplevel_layout_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_toplevel_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_toplevel_size_get_type();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark gdk_vulkan_error_quark();

	[DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gdk_vulkan_context_get_type();
}
