namespace MentorLake.Gtk4.GLib;

public enum GUserDirectory : uint
{
	G_USER_DIRECTORY_DESKTOP,
	G_USER_DIRECTORY_DOCUMENTS,
	G_USER_DIRECTORY_DOWNLOAD,
	G_USER_DIRECTORY_MUSIC,
	G_USER_DIRECTORY_PICTURES,
	G_USER_DIRECTORY_PUBLIC_SHARE,
	G_USER_DIRECTORY_TEMPLATES,
	G_USER_DIRECTORY_VIDEOS,
	G_USER_N_DIRECTORIES
}

public enum GNumberParserError : uint
{
	G_NUMBER_PARSER_ERROR_INVALID,
	G_NUMBER_PARSER_ERROR_OUT_OF_BOUNDS
}

public enum GVariantClass : uint
{
	G_VARIANT_CLASS_BOOLEAN = 'b',
	G_VARIANT_CLASS_BYTE = 'y',
	G_VARIANT_CLASS_INT16 = 'n',
	G_VARIANT_CLASS_UINT16 = 'q',
	G_VARIANT_CLASS_INT32 = 'i',
	G_VARIANT_CLASS_UINT32 = 'u',
	G_VARIANT_CLASS_INT64 = 'x',
	G_VARIANT_CLASS_UINT64 = 't',
	G_VARIANT_CLASS_HANDLE = 'h',
	G_VARIANT_CLASS_DOUBLE = 'd',
	G_VARIANT_CLASS_STRING = 's',
	G_VARIANT_CLASS_OBJECT_PATH = 'o',
	G_VARIANT_CLASS_SIGNATURE = 'g',
	G_VARIANT_CLASS_VARIANT = 'v',
	G_VARIANT_CLASS_MAYBE = 'm',
	G_VARIANT_CLASS_ARRAY = 'a',
	G_VARIANT_CLASS_TUPLE = '(',
	G_VARIANT_CLASS_DICT_ENTRY = '{'
}

public enum GTimeType : uint
{
	G_TIME_TYPE_STANDARD,
	G_TIME_TYPE_DAYLIGHT,
	G_TIME_TYPE_UNIVERSAL
}

public enum GTokenType : uint
{
	G_TOKEN_EOF = 0,
	G_TOKEN_LEFT_PAREN = '(',
	G_TOKEN_RIGHT_PAREN = ')',
	G_TOKEN_LEFT_CURLY = '{',
	G_TOKEN_RIGHT_CURLY = '}',
	G_TOKEN_LEFT_BRACE = '[',
	G_TOKEN_RIGHT_BRACE = ']',
	G_TOKEN_EQUAL_SIGN = '=',
	G_TOKEN_COMMA = ',',
	G_TOKEN_NONE = 256,
	G_TOKEN_ERROR,
	G_TOKEN_CHAR,
	G_TOKEN_BINARY,
	G_TOKEN_OCTAL,
	G_TOKEN_INT,
	G_TOKEN_HEX,
	G_TOKEN_FLOAT,
	G_TOKEN_STRING,
	G_TOKEN_SYMBOL,
	G_TOKEN_IDENTIFIER,
	G_TOKEN_IDENTIFIER_NULL,
	G_TOKEN_COMMENT_SINGLE,
	G_TOKEN_COMMENT_MULTI,
	G_TOKEN_LAST
}

public enum GMarkupParseFlags : uint
{
	G_MARKUP_DO_NOT_USE_THIS_UNSUPPORTED_FLAG = 1 << 0,
	G_MARKUP_TREAT_CDATA_AS_TEXT = 1 << 1,
	G_MARKUP_PREFIX_ERROR_POSITION = 1 << 2,
	G_MARKUP_IGNORE_QUALIFIED = 1 << 3
}

public enum GIOStatus : uint
{
	G_IO_STATUS_ERROR,
	G_IO_STATUS_NORMAL,
	G_IO_STATUS_EOF,
	G_IO_STATUS_AGAIN
}

public enum GUriFlags : uint
{
	G_URI_FLAGS_NONE = 0,
	G_URI_FLAGS_PARSE_RELAXED = 1 << 0,
	G_URI_FLAGS_HAS_PASSWORD = 1 << 1,
	G_URI_FLAGS_HAS_AUTH_PARAMS = 1 << 2,
	G_URI_FLAGS_ENCODED = 1 << 3,
	G_URI_FLAGS_NON_DNS = 1 << 4,
	G_URI_FLAGS_ENCODED_QUERY = 1 << 5,
	G_URI_FLAGS_ENCODED_PATH = 1 << 6,
	G_URI_FLAGS_ENCODED_FRAGMENT = 1 << 7,
	G_URI_FLAGS_SCHEME_NORMALIZE = 1 << 8
}

public enum GRegexMatchFlags : uint
{
	G_REGEX_MATCH_ANCHORED = 1 << 4,
	G_REGEX_MATCH_NOTBOL = 1 << 7,
	G_REGEX_MATCH_NOTEOL = 1 << 8,
	G_REGEX_MATCH_NOTEMPTY = 1 << 10,
	G_REGEX_MATCH_PARTIAL = 1 << 15,
	G_REGEX_MATCH_NEWLINE_CR = 1 << 20,
	G_REGEX_MATCH_NEWLINE_LF = 1 << 21,
	G_REGEX_MATCH_NEWLINE_CRLF = G_REGEX_MATCH_NEWLINE_CR | G_REGEX_MATCH_NEWLINE_LF,
	G_REGEX_MATCH_NEWLINE_ANY = 1 << 22,
	G_REGEX_MATCH_NEWLINE_ANYCRLF = G_REGEX_MATCH_NEWLINE_CR | G_REGEX_MATCH_NEWLINE_ANY,
	G_REGEX_MATCH_BSR_ANYCRLF = 1 << 23,
	G_REGEX_MATCH_BSR_ANY = 1 << 24,
	G_REGEX_MATCH_PARTIAL_SOFT = G_REGEX_MATCH_PARTIAL,
	G_REGEX_MATCH_PARTIAL_HARD = 1 << 27,
	G_REGEX_MATCH_NOTEMPTY_ATSTART = 1 << 28
}

public enum GTraverseType : uint
{
	G_IN_ORDER,
	G_PRE_ORDER,
	G_POST_ORDER,
	G_LEVEL_ORDER
}

public enum GDateWeekday : uint
{
	G_DATE_BAD_WEEKDAY = 0,
	G_DATE_MONDAY = 1,
	G_DATE_TUESDAY = 2,
	G_DATE_WEDNESDAY = 3,
	G_DATE_THURSDAY = 4,
	G_DATE_FRIDAY = 5,
	G_DATE_SATURDAY = 6,
	G_DATE_SUNDAY = 7
}

public enum GRegexCompileFlags : uint
{
	G_REGEX_CASELESS = 1 << 0,
	G_REGEX_MULTILINE = 1 << 1,
	G_REGEX_DOTALL = 1 << 2,
	G_REGEX_EXTENDED = 1 << 3,
	G_REGEX_ANCHORED = 1 << 4,
	G_REGEX_DOLLAR_ENDONLY = 1 << 5,
	G_REGEX_UNGREEDY = 1 << 9,
	G_REGEX_RAW = 1 << 11,
	G_REGEX_NO_AUTO_CAPTURE = 1 << 12,
	G_REGEX_OPTIMIZE = 1 << 13,
	G_REGEX_FIRSTLINE = 1 << 18,
	G_REGEX_DUPNAMES = 1 << 19,
	G_REGEX_NEWLINE_CR = 1 << 20,
	G_REGEX_NEWLINE_LF = 1 << 21,
	G_REGEX_NEWLINE_CRLF = G_REGEX_NEWLINE_CR | G_REGEX_NEWLINE_LF,
	G_REGEX_NEWLINE_ANYCRLF = G_REGEX_NEWLINE_CR | (1 << 22),
	G_REGEX_BSR_ANYCRLF = 1 << 23,
	G_REGEX_JAVASCRIPT_COMPAT = 1 << 25
}

public enum GMarkupCollectType : uint
{
	G_MARKUP_COLLECT_INVALID,
	G_MARKUP_COLLECT_STRING,
	G_MARKUP_COLLECT_STRDUP,
	G_MARKUP_COLLECT_BOOLEAN,
	G_MARKUP_COLLECT_TRISTATE,
	G_MARKUP_COLLECT_OPTIONAL = 1 << 16
}

public enum GChecksumType : uint
{
	G_CHECKSUM_MD5,
	G_CHECKSUM_SHA1,
	G_CHECKSUM_SHA256,
	G_CHECKSUM_SHA512,
	G_CHECKSUM_SHA384
}

public enum GSliceConfig : uint
{
	G_SLICE_CONFIG_ALWAYS_MALLOC = 1,
	G_SLICE_CONFIG_BYPASS_MAGAZINES,
	G_SLICE_CONFIG_WORKING_SET_MSECS,
	G_SLICE_CONFIG_COLOR_INCREMENT,
	G_SLICE_CONFIG_CHUNK_SIZES,
	G_SLICE_CONFIG_CONTENTION_COUNTER
}

public enum GNormalizeMode : uint
{
	G_NORMALIZE_DEFAULT,
	G_NORMALIZE_NFD = G_NORMALIZE_DEFAULT,
	G_NORMALIZE_DEFAULT_COMPOSE,
	G_NORMALIZE_NFC = G_NORMALIZE_DEFAULT_COMPOSE,
	G_NORMALIZE_ALL,
	G_NORMALIZE_NFKD = G_NORMALIZE_ALL,
	G_NORMALIZE_ALL_COMPOSE,
	G_NORMALIZE_NFKC = G_NORMALIZE_ALL_COMPOSE
}

public enum GOptionFlags : uint
{
	G_OPTION_FLAG_NONE = 0,
	G_OPTION_FLAG_HIDDEN = 1 << 0,
	G_OPTION_FLAG_IN_MAIN = 1 << 1,
	G_OPTION_FLAG_REVERSE = 1 << 2,
	G_OPTION_FLAG_NO_ARG = 1 << 3,
	G_OPTION_FLAG_FILENAME = 1 << 4,
	G_OPTION_FLAG_OPTIONAL_ARG = 1 << 5,
	G_OPTION_FLAG_NOALIAS = 1 << 6
}

public enum GHookFlagMask : uint
{
	G_HOOK_FLAG_ACTIVE = 1 << 0,
	G_HOOK_FLAG_IN_CALL = 1 << 1,
	G_HOOK_FLAG_MASK = 0x0f
}

public enum GErrorType : uint
{
	G_ERR_UNKNOWN,
	G_ERR_UNEXP_EOF,
	G_ERR_UNEXP_EOF_IN_STRING,
	G_ERR_UNEXP_EOF_IN_COMMENT,
	G_ERR_NON_DIGIT_IN_CONST,
	G_ERR_DIGIT_RADIX,
	G_ERR_FLOAT_RADIX,
	G_ERR_FLOAT_MALFORMED
}

public enum GLogLevelFlags
{
	G_LOG_FLAG_RECURSION = 1 << 0,
	G_LOG_FLAG_FATAL = 1 << 1,
	G_LOG_LEVEL_ERROR = 1 << 2,
	G_LOG_LEVEL_CRITICAL = 1 << 3,
	G_LOG_LEVEL_WARNING = 1 << 4,
	G_LOG_LEVEL_MESSAGE = 1 << 5,
	G_LOG_LEVEL_INFO = 1 << 6,
	G_LOG_LEVEL_DEBUG = 1 << 7,
	G_LOG_LEVEL_MASK = ~(G_LOG_FLAG_RECURSION | G_LOG_FLAG_FATAL)
}

public enum GLogWriterOutput : uint
{
	G_LOG_WRITER_HANDLED = 1,
	G_LOG_WRITER_UNHANDLED = 0
}

public enum GUnicodeScript
{
	G_UNICODE_SCRIPT_INVALID_CODE = -1,
	G_UNICODE_SCRIPT_COMMON = 0,
	G_UNICODE_SCRIPT_INHERITED,
	G_UNICODE_SCRIPT_ARABIC,
	G_UNICODE_SCRIPT_ARMENIAN,
	G_UNICODE_SCRIPT_BENGALI,
	G_UNICODE_SCRIPT_BOPOMOFO,
	G_UNICODE_SCRIPT_CHEROKEE,
	G_UNICODE_SCRIPT_COPTIC,
	G_UNICODE_SCRIPT_CYRILLIC,
	G_UNICODE_SCRIPT_DESERET,
	G_UNICODE_SCRIPT_DEVANAGARI,
	G_UNICODE_SCRIPT_ETHIOPIC,
	G_UNICODE_SCRIPT_GEORGIAN,
	G_UNICODE_SCRIPT_GOTHIC,
	G_UNICODE_SCRIPT_GREEK,
	G_UNICODE_SCRIPT_GUJARATI,
	G_UNICODE_SCRIPT_GURMUKHI,
	G_UNICODE_SCRIPT_HAN,
	G_UNICODE_SCRIPT_HANGUL,
	G_UNICODE_SCRIPT_HEBREW,
	G_UNICODE_SCRIPT_HIRAGANA,
	G_UNICODE_SCRIPT_KANNADA,
	G_UNICODE_SCRIPT_KATAKANA,
	G_UNICODE_SCRIPT_KHMER,
	G_UNICODE_SCRIPT_LAO,
	G_UNICODE_SCRIPT_LATIN,
	G_UNICODE_SCRIPT_MALAYALAM,
	G_UNICODE_SCRIPT_MONGOLIAN,
	G_UNICODE_SCRIPT_MYANMAR,
	G_UNICODE_SCRIPT_OGHAM,
	G_UNICODE_SCRIPT_OLD_ITALIC,
	G_UNICODE_SCRIPT_ORIYA,
	G_UNICODE_SCRIPT_RUNIC,
	G_UNICODE_SCRIPT_SINHALA,
	G_UNICODE_SCRIPT_SYRIAC,
	G_UNICODE_SCRIPT_TAMIL,
	G_UNICODE_SCRIPT_TELUGU,
	G_UNICODE_SCRIPT_THAANA,
	G_UNICODE_SCRIPT_THAI,
	G_UNICODE_SCRIPT_TIBETAN,
	G_UNICODE_SCRIPT_CANADIAN_ABORIGINAL,
	G_UNICODE_SCRIPT_YI,
	G_UNICODE_SCRIPT_TAGALOG,
	G_UNICODE_SCRIPT_HANUNOO,
	G_UNICODE_SCRIPT_BUHID,
	G_UNICODE_SCRIPT_TAGBANWA,
	G_UNICODE_SCRIPT_BRAILLE,
	G_UNICODE_SCRIPT_CYPRIOT,
	G_UNICODE_SCRIPT_LIMBU,
	G_UNICODE_SCRIPT_OSMANYA,
	G_UNICODE_SCRIPT_SHAVIAN,
	G_UNICODE_SCRIPT_LINEAR_B,
	G_UNICODE_SCRIPT_TAI_LE,
	G_UNICODE_SCRIPT_UGARITIC,
	G_UNICODE_SCRIPT_NEW_TAI_LUE,
	G_UNICODE_SCRIPT_BUGINESE,
	G_UNICODE_SCRIPT_GLAGOLITIC,
	G_UNICODE_SCRIPT_TIFINAGH,
	G_UNICODE_SCRIPT_SYLOTI_NAGRI,
	G_UNICODE_SCRIPT_OLD_PERSIAN,
	G_UNICODE_SCRIPT_KHAROSHTHI,
	G_UNICODE_SCRIPT_UNKNOWN,
	G_UNICODE_SCRIPT_BALINESE,
	G_UNICODE_SCRIPT_CUNEIFORM,
	G_UNICODE_SCRIPT_PHOENICIAN,
	G_UNICODE_SCRIPT_PHAGS_PA,
	G_UNICODE_SCRIPT_NKO,
	G_UNICODE_SCRIPT_KAYAH_LI,
	G_UNICODE_SCRIPT_LEPCHA,
	G_UNICODE_SCRIPT_REJANG,
	G_UNICODE_SCRIPT_SUNDANESE,
	G_UNICODE_SCRIPT_SAURASHTRA,
	G_UNICODE_SCRIPT_CHAM,
	G_UNICODE_SCRIPT_OL_CHIKI,
	G_UNICODE_SCRIPT_VAI,
	G_UNICODE_SCRIPT_CARIAN,
	G_UNICODE_SCRIPT_LYCIAN,
	G_UNICODE_SCRIPT_LYDIAN,
	G_UNICODE_SCRIPT_AVESTAN,
	G_UNICODE_SCRIPT_BAMUM,
	G_UNICODE_SCRIPT_EGYPTIAN_HIEROGLYPHS,
	G_UNICODE_SCRIPT_IMPERIAL_ARAMAIC,
	G_UNICODE_SCRIPT_INSCRIPTIONAL_PAHLAVI,
	G_UNICODE_SCRIPT_INSCRIPTIONAL_PARTHIAN,
	G_UNICODE_SCRIPT_JAVANESE,
	G_UNICODE_SCRIPT_KAITHI,
	G_UNICODE_SCRIPT_LISU,
	G_UNICODE_SCRIPT_MEETEI_MAYEK,
	G_UNICODE_SCRIPT_OLD_SOUTH_ARABIAN,
	G_UNICODE_SCRIPT_OLD_TURKIC,
	G_UNICODE_SCRIPT_SAMARITAN,
	G_UNICODE_SCRIPT_TAI_THAM,
	G_UNICODE_SCRIPT_TAI_VIET,
	G_UNICODE_SCRIPT_BATAK,
	G_UNICODE_SCRIPT_BRAHMI,
	G_UNICODE_SCRIPT_MANDAIC,
	G_UNICODE_SCRIPT_CHAKMA,
	G_UNICODE_SCRIPT_MEROITIC_CURSIVE,
	G_UNICODE_SCRIPT_MEROITIC_HIEROGLYPHS,
	G_UNICODE_SCRIPT_MIAO,
	G_UNICODE_SCRIPT_SHARADA,
	G_UNICODE_SCRIPT_SORA_SOMPENG,
	G_UNICODE_SCRIPT_TAKRI,
	G_UNICODE_SCRIPT_BASSA_VAH,
	G_UNICODE_SCRIPT_CAUCASIAN_ALBANIAN,
	G_UNICODE_SCRIPT_DUPLOYAN,
	G_UNICODE_SCRIPT_ELBASAN,
	G_UNICODE_SCRIPT_GRANTHA,
	G_UNICODE_SCRIPT_KHOJKI,
	G_UNICODE_SCRIPT_KHUDAWADI,
	G_UNICODE_SCRIPT_LINEAR_A,
	G_UNICODE_SCRIPT_MAHAJANI,
	G_UNICODE_SCRIPT_MANICHAEAN,
	G_UNICODE_SCRIPT_MENDE_KIKAKUI,
	G_UNICODE_SCRIPT_MODI,
	G_UNICODE_SCRIPT_MRO,
	G_UNICODE_SCRIPT_NABATAEAN,
	G_UNICODE_SCRIPT_OLD_NORTH_ARABIAN,
	G_UNICODE_SCRIPT_OLD_PERMIC,
	G_UNICODE_SCRIPT_PAHAWH_HMONG,
	G_UNICODE_SCRIPT_PALMYRENE,
	G_UNICODE_SCRIPT_PAU_CIN_HAU,
	G_UNICODE_SCRIPT_PSALTER_PAHLAVI,
	G_UNICODE_SCRIPT_SIDDHAM,
	G_UNICODE_SCRIPT_TIRHUTA,
	G_UNICODE_SCRIPT_WARANG_CITI,
	G_UNICODE_SCRIPT_AHOM,
	G_UNICODE_SCRIPT_ANATOLIAN_HIEROGLYPHS,
	G_UNICODE_SCRIPT_HATRAN,
	G_UNICODE_SCRIPT_MULTANI,
	G_UNICODE_SCRIPT_OLD_HUNGARIAN,
	G_UNICODE_SCRIPT_SIGNWRITING,
	G_UNICODE_SCRIPT_ADLAM,
	G_UNICODE_SCRIPT_BHAIKSUKI,
	G_UNICODE_SCRIPT_MARCHEN,
	G_UNICODE_SCRIPT_NEWA,
	G_UNICODE_SCRIPT_OSAGE,
	G_UNICODE_SCRIPT_TANGUT,
	G_UNICODE_SCRIPT_MASARAM_GONDI,
	G_UNICODE_SCRIPT_NUSHU,
	G_UNICODE_SCRIPT_SOYOMBO,
	G_UNICODE_SCRIPT_ZANABAZAR_SQUARE,
	G_UNICODE_SCRIPT_DOGRA,
	G_UNICODE_SCRIPT_GUNJALA_GONDI,
	G_UNICODE_SCRIPT_HANIFI_ROHINGYA,
	G_UNICODE_SCRIPT_MAKASAR,
	G_UNICODE_SCRIPT_MEDEFAIDRIN,
	G_UNICODE_SCRIPT_OLD_SOGDIAN,
	G_UNICODE_SCRIPT_SOGDIAN,
	G_UNICODE_SCRIPT_ELYMAIC,
	G_UNICODE_SCRIPT_NANDINAGARI,
	G_UNICODE_SCRIPT_NYIAKENG_PUACHUE_HMONG,
	G_UNICODE_SCRIPT_WANCHO,
	G_UNICODE_SCRIPT_CHORASMIAN,
	G_UNICODE_SCRIPT_DIVES_AKURU,
	G_UNICODE_SCRIPT_KHITAN_SMALL_SCRIPT,
	G_UNICODE_SCRIPT_YEZIDI,
	G_UNICODE_SCRIPT_CYPRO_MINOAN,
	G_UNICODE_SCRIPT_OLD_UYGHUR,
	G_UNICODE_SCRIPT_TANGSA,
	G_UNICODE_SCRIPT_TOTO,
	G_UNICODE_SCRIPT_VITHKUQI,
	G_UNICODE_SCRIPT_MATH
}

public enum GFormatSizeFlags : uint
{
	G_FORMAT_SIZE_DEFAULT = 0,
	G_FORMAT_SIZE_LONG_FORMAT = 1 << 0,
	G_FORMAT_SIZE_IEC_UNITS = 1 << 1,
	G_FORMAT_SIZE_BITS = 1 << 2
}

public enum GFileError : uint
{
	G_FILE_ERROR_EXIST,
	G_FILE_ERROR_ISDIR,
	G_FILE_ERROR_ACCES,
	G_FILE_ERROR_NAMETOOLONG,
	G_FILE_ERROR_NOENT,
	G_FILE_ERROR_NOTDIR,
	G_FILE_ERROR_NXIO,
	G_FILE_ERROR_NODEV,
	G_FILE_ERROR_ROFS,
	G_FILE_ERROR_TXTBSY,
	G_FILE_ERROR_FAULT,
	G_FILE_ERROR_LOOP,
	G_FILE_ERROR_NOSPC,
	G_FILE_ERROR_NOMEM,
	G_FILE_ERROR_MFILE,
	G_FILE_ERROR_NFILE,
	G_FILE_ERROR_BADF,
	G_FILE_ERROR_INVAL,
	G_FILE_ERROR_PIPE,
	G_FILE_ERROR_AGAIN,
	G_FILE_ERROR_INTR,
	G_FILE_ERROR_IO,
	G_FILE_ERROR_PERM,
	G_FILE_ERROR_NOSYS,
	G_FILE_ERROR_FAILED
}

public enum GConvertError : uint
{
	G_CONVERT_ERROR_NO_CONVERSION,
	G_CONVERT_ERROR_ILLEGAL_SEQUENCE,
	G_CONVERT_ERROR_FAILED,
	G_CONVERT_ERROR_PARTIAL_INPUT,
	G_CONVERT_ERROR_BAD_URI,
	G_CONVERT_ERROR_NOT_ABSOLUTE_PATH,
	G_CONVERT_ERROR_NO_MEMORY,
	G_CONVERT_ERROR_EMBEDDED_NUL
}

public enum GUnicodeBreakType : uint
{
	G_UNICODE_BREAK_MANDATORY,
	G_UNICODE_BREAK_CARRIAGE_RETURN,
	G_UNICODE_BREAK_LINE_FEED,
	G_UNICODE_BREAK_COMBINING_MARK,
	G_UNICODE_BREAK_SURROGATE,
	G_UNICODE_BREAK_ZERO_WIDTH_SPACE,
	G_UNICODE_BREAK_INSEPARABLE,
	G_UNICODE_BREAK_NON_BREAKING_GLUE,
	G_UNICODE_BREAK_CONTINGENT,
	G_UNICODE_BREAK_SPACE,
	G_UNICODE_BREAK_AFTER,
	G_UNICODE_BREAK_BEFORE,
	G_UNICODE_BREAK_BEFORE_AND_AFTER,
	G_UNICODE_BREAK_HYPHEN,
	G_UNICODE_BREAK_NON_STARTER,
	G_UNICODE_BREAK_OPEN_PUNCTUATION,
	G_UNICODE_BREAK_CLOSE_PUNCTUATION,
	G_UNICODE_BREAK_QUOTATION,
	G_UNICODE_BREAK_EXCLAMATION,
	G_UNICODE_BREAK_IDEOGRAPHIC,
	G_UNICODE_BREAK_NUMERIC,
	G_UNICODE_BREAK_INFIX_SEPARATOR,
	G_UNICODE_BREAK_SYMBOL,
	G_UNICODE_BREAK_ALPHABETIC,
	G_UNICODE_BREAK_PREFIX,
	G_UNICODE_BREAK_POSTFIX,
	G_UNICODE_BREAK_COMPLEX_CONTEXT,
	G_UNICODE_BREAK_AMBIGUOUS,
	G_UNICODE_BREAK_UNKNOWN,
	G_UNICODE_BREAK_NEXT_LINE,
	G_UNICODE_BREAK_WORD_JOINER,
	G_UNICODE_BREAK_HANGUL_L_JAMO,
	G_UNICODE_BREAK_HANGUL_V_JAMO,
	G_UNICODE_BREAK_HANGUL_T_JAMO,
	G_UNICODE_BREAK_HANGUL_LV_SYLLABLE,
	G_UNICODE_BREAK_HANGUL_LVT_SYLLABLE,
	G_UNICODE_BREAK_CLOSE_PARANTHESIS,
	G_UNICODE_BREAK_CLOSE_PARENTHESIS = G_UNICODE_BREAK_CLOSE_PARANTHESIS,
	G_UNICODE_BREAK_CONDITIONAL_JAPANESE_STARTER,
	G_UNICODE_BREAK_HEBREW_LETTER,
	G_UNICODE_BREAK_REGIONAL_INDICATOR,
	G_UNICODE_BREAK_EMOJI_BASE,
	G_UNICODE_BREAK_EMOJI_MODIFIER,
	G_UNICODE_BREAK_ZERO_WIDTH_JOINER
}

public enum GIOChannelError : uint
{
	G_IO_CHANNEL_ERROR_FBIG,
	G_IO_CHANNEL_ERROR_INVAL,
	G_IO_CHANNEL_ERROR_IO,
	G_IO_CHANNEL_ERROR_ISDIR,
	G_IO_CHANNEL_ERROR_NOSPC,
	G_IO_CHANNEL_ERROR_NXIO,
	G_IO_CHANNEL_ERROR_OVERFLOW,
	G_IO_CHANNEL_ERROR_PIPE,
	G_IO_CHANNEL_ERROR_FAILED
}

public enum GMainContextFlags : uint
{
	G_MAIN_CONTEXT_FLAGS_NONE = 0,
	G_MAIN_CONTEXT_FLAGS_OWNERLESS_POLLING = 1
}

public enum GThreadPriority : uint
{
	G_THREAD_PRIORITY_LOW,
	G_THREAD_PRIORITY_NORMAL,
	G_THREAD_PRIORITY_HIGH,
	G_THREAD_PRIORITY_URGENT
}

public enum GShellError : uint
{
	G_SHELL_ERROR_BAD_QUOTING,
	G_SHELL_ERROR_EMPTY_STRING,
	G_SHELL_ERROR_FAILED
}

public enum GUriParamsFlags : uint
{
	G_URI_PARAMS_NONE = 0,
	G_URI_PARAMS_CASE_INSENSITIVE = 1 << 0,
	G_URI_PARAMS_WWW_FORM = 1 << 1,
	G_URI_PARAMS_PARSE_RELAXED = 1 << 2
}

public enum GThreadError : uint
{
	G_THREAD_ERROR_AGAIN
}

public enum GTestLogType : uint
{
	G_TEST_LOG_NONE,
	G_TEST_LOG_ERROR,
	G_TEST_LOG_START_BINARY,
	G_TEST_LOG_LIST_CASE,
	G_TEST_LOG_SKIP_CASE,
	G_TEST_LOG_START_CASE,
	G_TEST_LOG_STOP_CASE,
	G_TEST_LOG_MIN_RESULT,
	G_TEST_LOG_MAX_RESULT,
	G_TEST_LOG_MESSAGE,
	G_TEST_LOG_START_SUITE,
	G_TEST_LOG_STOP_SUITE
}

public enum GFileSetContentsFlags : uint
{
	G_FILE_SET_CONTENTS_NONE = 0,
	G_FILE_SET_CONTENTS_CONSISTENT = 1 << 0,
	G_FILE_SET_CONTENTS_DURABLE = 1 << 1,
	G_FILE_SET_CONTENTS_ONLY_EXISTING = 1 << 2
}

public enum GSeekType : uint
{
	G_SEEK_CUR,
	G_SEEK_SET,
	G_SEEK_END
}

public enum GVariantParseError : uint
{
	G_VARIANT_PARSE_ERROR_FAILED,
	G_VARIANT_PARSE_ERROR_BASIC_TYPE_EXPECTED,
	G_VARIANT_PARSE_ERROR_CANNOT_INFER_TYPE,
	G_VARIANT_PARSE_ERROR_DEFINITE_TYPE_EXPECTED,
	G_VARIANT_PARSE_ERROR_INPUT_NOT_AT_END,
	G_VARIANT_PARSE_ERROR_INVALID_CHARACTER,
	G_VARIANT_PARSE_ERROR_INVALID_FORMAT_STRING,
	G_VARIANT_PARSE_ERROR_INVALID_OBJECT_PATH,
	G_VARIANT_PARSE_ERROR_INVALID_SIGNATURE,
	G_VARIANT_PARSE_ERROR_INVALID_TYPE_STRING,
	G_VARIANT_PARSE_ERROR_NO_COMMON_TYPE,
	G_VARIANT_PARSE_ERROR_NUMBER_OUT_OF_RANGE,
	G_VARIANT_PARSE_ERROR_NUMBER_TOO_BIG,
	G_VARIANT_PARSE_ERROR_TYPE_ERROR,
	G_VARIANT_PARSE_ERROR_UNEXPECTED_TOKEN,
	G_VARIANT_PARSE_ERROR_UNKNOWN_KEYWORD,
	G_VARIANT_PARSE_ERROR_UNTERMINATED_STRING_CONSTANT,
	G_VARIANT_PARSE_ERROR_VALUE_EXPECTED,
	G_VARIANT_PARSE_ERROR_RECURSION
}

public enum GAsciiType : uint
{
	G_ASCII_ALNUM = 1 << 0,
	G_ASCII_ALPHA = 1 << 1,
	G_ASCII_CNTRL = 1 << 2,
	G_ASCII_DIGIT = 1 << 3,
	G_ASCII_GRAPH = 1 << 4,
	G_ASCII_LOWER = 1 << 5,
	G_ASCII_PRINT = 1 << 6,
	G_ASCII_PUNCT = 1 << 7,
	G_ASCII_SPACE = 1 << 8,
	G_ASCII_UPPER = 1 << 9,
	G_ASCII_XDIGIT = 1 << 10
}

public enum GKeyFileFlags : uint
{
	G_KEY_FILE_NONE = 0,
	G_KEY_FILE_KEEP_COMMENTS = 1 << 0,
	G_KEY_FILE_KEEP_TRANSLATIONS = 1 << 1
}

public enum GUriHideFlags : uint
{
	G_URI_HIDE_NONE = 0,
	G_URI_HIDE_USERINFO = 1 << 0,
	G_URI_HIDE_PASSWORD = 1 << 1,
	G_URI_HIDE_AUTH_PARAMS = 1 << 2,
	G_URI_HIDE_QUERY = 1 << 3,
	G_URI_HIDE_FRAGMENT = 1 << 4
}

public enum GIOError : uint
{
	G_IO_ERROR_NONE,
	G_IO_ERROR_AGAIN,
	G_IO_ERROR_INVAL,
	G_IO_ERROR_UNKNOWN
}

public enum GTraverseFlags : uint
{
	G_TRAVERSE_LEAVES = 1 << 0,
	G_TRAVERSE_NON_LEAVES = 1 << 1,
	G_TRAVERSE_ALL = G_TRAVERSE_LEAVES | G_TRAVERSE_NON_LEAVES,
	G_TRAVERSE_MASK = 0x03,
	G_TRAVERSE_LEAFS = G_TRAVERSE_LEAVES,
	G_TRAVERSE_NON_LEAFS = G_TRAVERSE_NON_LEAVES
}

public enum GDateMonth : uint
{
	G_DATE_BAD_MONTH = 0,
	G_DATE_JANUARY = 1,
	G_DATE_FEBRUARY = 2,
	G_DATE_MARCH = 3,
	G_DATE_APRIL = 4,
	G_DATE_MAY = 5,
	G_DATE_JUNE = 6,
	G_DATE_JULY = 7,
	G_DATE_AUGUST = 8,
	G_DATE_SEPTEMBER = 9,
	G_DATE_OCTOBER = 10,
	G_DATE_NOVEMBER = 11,
	G_DATE_DECEMBER = 12
}

public enum GFileTest : uint
{
	G_FILE_TEST_IS_REGULAR = 1 << 0,
	G_FILE_TEST_IS_SYMLINK = 1 << 1,
	G_FILE_TEST_IS_DIR = 1 << 2,
	G_FILE_TEST_IS_EXECUTABLE = 1 << 3,
	G_FILE_TEST_EXISTS = 1 << 4
}

public enum GTestFileType : uint
{
	G_TEST_DIST,
	G_TEST_BUILT
}

public enum GTestTrapFlags : uint
{
	G_TEST_TRAP_SILENCE_STDOUT = 1 << 7,
	G_TEST_TRAP_SILENCE_STDERR = 1 << 8,
	G_TEST_TRAP_INHERIT_STDIN = 1 << 9
}

public enum GUnicodeType : uint
{
	G_UNICODE_CONTROL,
	G_UNICODE_FORMAT,
	G_UNICODE_UNASSIGNED,
	G_UNICODE_PRIVATE_USE,
	G_UNICODE_SURROGATE,
	G_UNICODE_LOWERCASE_LETTER,
	G_UNICODE_MODIFIER_LETTER,
	G_UNICODE_OTHER_LETTER,
	G_UNICODE_TITLECASE_LETTER,
	G_UNICODE_UPPERCASE_LETTER,
	G_UNICODE_SPACING_MARK,
	G_UNICODE_ENCLOSING_MARK,
	G_UNICODE_NON_SPACING_MARK,
	G_UNICODE_DECIMAL_NUMBER,
	G_UNICODE_LETTER_NUMBER,
	G_UNICODE_OTHER_NUMBER,
	G_UNICODE_CONNECT_PUNCTUATION,
	G_UNICODE_DASH_PUNCTUATION,
	G_UNICODE_CLOSE_PUNCTUATION,
	G_UNICODE_FINAL_PUNCTUATION,
	G_UNICODE_INITIAL_PUNCTUATION,
	G_UNICODE_OTHER_PUNCTUATION,
	G_UNICODE_OPEN_PUNCTUATION,
	G_UNICODE_CURRENCY_SYMBOL,
	G_UNICODE_MODIFIER_SYMBOL,
	G_UNICODE_MATH_SYMBOL,
	G_UNICODE_OTHER_SYMBOL,
	G_UNICODE_LINE_SEPARATOR,
	G_UNICODE_PARAGRAPH_SEPARATOR,
	G_UNICODE_SPACE_SEPARATOR
}

public enum GIOCondition : uint
{
	G_IO_IN = 1,
	G_IO_OUT = 4,
	G_IO_PRI = 2,
	G_IO_ERR = 8,
	G_IO_HUP = 16,
	G_IO_NVAL = 32
}

public enum GTestSubprocessFlags : uint
{
	G_TEST_SUBPROCESS_INHERIT_STDIN = 1 << 0,
	G_TEST_SUBPROCESS_INHERIT_STDOUT = 1 << 1,
	G_TEST_SUBPROCESS_INHERIT_STDERR = 1 << 2
}

public enum GOptionArg : uint
{
	G_OPTION_ARG_NONE,
	G_OPTION_ARG_STRING,
	G_OPTION_ARG_INT,
	G_OPTION_ARG_CALLBACK,
	G_OPTION_ARG_FILENAME,
	G_OPTION_ARG_STRING_ARRAY,
	G_OPTION_ARG_FILENAME_ARRAY,
	G_OPTION_ARG_DOUBLE,
	G_OPTION_ARG_INT64
}

public enum GOptionError : uint
{
	G_OPTION_ERROR_UNKNOWN_OPTION,
	G_OPTION_ERROR_BAD_VALUE,
	G_OPTION_ERROR_FAILED
}

public enum GDateDMY : uint
{
	G_DATE_DAY = 0,
	G_DATE_MONTH = 1,
	G_DATE_YEAR = 2
}

public enum GOnceStatus : uint
{
	G_ONCE_STATUS_NOTCALLED,
	G_ONCE_STATUS_PROGRESS,
	G_ONCE_STATUS_READY
}

public enum GIOFlags : uint
{
	G_IO_FLAG_APPEND = 1 << 0,
	G_IO_FLAG_NONBLOCK = 1 << 1,
	G_IO_FLAG_IS_READABLE = 1 << 2,
	G_IO_FLAG_IS_WRITABLE = 1 << 3,
	G_IO_FLAG_IS_WRITEABLE = 1 << 3,
	G_IO_FLAG_IS_SEEKABLE = 1 << 4,
	G_IO_FLAG_MASK = (1 << 5) - 1,
	G_IO_FLAG_GET_MASK = G_IO_FLAG_MASK,
	G_IO_FLAG_SET_MASK = G_IO_FLAG_APPEND | G_IO_FLAG_NONBLOCK
}

public enum GSpawnFlags : uint
{
	G_SPAWN_DEFAULT = 0,
	G_SPAWN_LEAVE_DESCRIPTORS_OPEN = 1 << 0,
	G_SPAWN_DO_NOT_REAP_CHILD = 1 << 1,
	G_SPAWN_SEARCH_PATH = 1 << 2,
	G_SPAWN_STDOUT_TO_DEV_NULL = 1 << 3,
	G_SPAWN_STDERR_TO_DEV_NULL = 1 << 4,
	G_SPAWN_CHILD_INHERITS_STDIN = 1 << 5,
	G_SPAWN_FILE_AND_ARGV_ZERO = 1 << 6,
	G_SPAWN_SEARCH_PATH_FROM_ENVP = 1 << 7,
	G_SPAWN_CLOEXEC_PIPES = 1 << 8
}

public enum GRegexError : uint
{
	G_REGEX_ERROR_COMPILE,
	G_REGEX_ERROR_OPTIMIZE,
	G_REGEX_ERROR_REPLACE,
	G_REGEX_ERROR_MATCH,
	G_REGEX_ERROR_INTERNAL,
	G_REGEX_ERROR_STRAY_BACKSLASH = 101,
	G_REGEX_ERROR_MISSING_CONTROL_CHAR = 102,
	G_REGEX_ERROR_UNRECOGNIZED_ESCAPE = 103,
	G_REGEX_ERROR_QUANTIFIERS_OUT_OF_ORDER = 104,
	G_REGEX_ERROR_QUANTIFIER_TOO_BIG = 105,
	G_REGEX_ERROR_UNTERMINATED_CHARACTER_CLASS = 106,
	G_REGEX_ERROR_INVALID_ESCAPE_IN_CHARACTER_CLASS = 107,
	G_REGEX_ERROR_RANGE_OUT_OF_ORDER = 108,
	G_REGEX_ERROR_NOTHING_TO_REPEAT = 109,
	G_REGEX_ERROR_UNRECOGNIZED_CHARACTER = 112,
	G_REGEX_ERROR_POSIX_NAMED_CLASS_OUTSIDE_CLASS = 113,
	G_REGEX_ERROR_UNMATCHED_PARENTHESIS = 114,
	G_REGEX_ERROR_INEXISTENT_SUBPATTERN_REFERENCE = 115,
	G_REGEX_ERROR_UNTERMINATED_COMMENT = 118,
	G_REGEX_ERROR_EXPRESSION_TOO_LARGE = 120,
	G_REGEX_ERROR_MEMORY_ERROR = 121,
	G_REGEX_ERROR_VARIABLE_LENGTH_LOOKBEHIND = 125,
	G_REGEX_ERROR_MALFORMED_CONDITION = 126,
	G_REGEX_ERROR_TOO_MANY_CONDITIONAL_BRANCHES = 127,
	G_REGEX_ERROR_ASSERTION_EXPECTED = 128,
	G_REGEX_ERROR_UNKNOWN_POSIX_CLASS_NAME = 130,
	G_REGEX_ERROR_POSIX_COLLATING_ELEMENTS_NOT_SUPPORTED = 131,
	G_REGEX_ERROR_HEX_CODE_TOO_LARGE = 134,
	G_REGEX_ERROR_INVALID_CONDITION = 135,
	G_REGEX_ERROR_SINGLE_BYTE_MATCH_IN_LOOKBEHIND = 136,
	G_REGEX_ERROR_INFINITE_LOOP = 140,
	G_REGEX_ERROR_MISSING_SUBPATTERN_NAME_TERMINATOR = 142,
	G_REGEX_ERROR_DUPLICATE_SUBPATTERN_NAME = 143,
	G_REGEX_ERROR_MALFORMED_PROPERTY = 146,
	G_REGEX_ERROR_UNKNOWN_PROPERTY = 147,
	G_REGEX_ERROR_SUBPATTERN_NAME_TOO_LONG = 148,
	G_REGEX_ERROR_TOO_MANY_SUBPATTERNS = 149,
	G_REGEX_ERROR_INVALID_OCTAL_VALUE = 151,
	G_REGEX_ERROR_TOO_MANY_BRANCHES_IN_DEFINE = 154,
	G_REGEX_ERROR_DEFINE_REPETION = 155,
	G_REGEX_ERROR_INCONSISTENT_NEWLINE_OPTIONS = 156,
	G_REGEX_ERROR_MISSING_BACK_REFERENCE = 157,
	G_REGEX_ERROR_INVALID_RELATIVE_REFERENCE = 158,
	G_REGEX_ERROR_BACKTRACKING_CONTROL_VERB_ARGUMENT_FORBIDDEN = 159,
	G_REGEX_ERROR_UNKNOWN_BACKTRACKING_CONTROL_VERB = 160,
	G_REGEX_ERROR_NUMBER_TOO_BIG = 161,
	G_REGEX_ERROR_MISSING_SUBPATTERN_NAME = 162,
	G_REGEX_ERROR_MISSING_DIGIT = 163,
	G_REGEX_ERROR_INVALID_DATA_CHARACTER = 164,
	G_REGEX_ERROR_EXTRA_SUBPATTERN_NAME = 165,
	G_REGEX_ERROR_BACKTRACKING_CONTROL_VERB_ARGUMENT_REQUIRED = 166,
	G_REGEX_ERROR_INVALID_CONTROL_CHAR = 168,
	G_REGEX_ERROR_MISSING_NAME = 169,
	G_REGEX_ERROR_NOT_SUPPORTED_IN_CLASS = 171,
	G_REGEX_ERROR_TOO_MANY_FORWARD_REFERENCES = 172,
	G_REGEX_ERROR_NAME_TOO_LONG = 175,
	G_REGEX_ERROR_CHARACTER_VALUE_TOO_LARGE = 176
}

public enum GTestResult : uint
{
	G_TEST_RUN_SUCCESS,
	G_TEST_RUN_SKIPPED,
	G_TEST_RUN_FAILURE,
	G_TEST_RUN_INCOMPLETE
}

public enum GSpawnError : uint
{
	G_SPAWN_ERROR_FORK,
	G_SPAWN_ERROR_READ,
	G_SPAWN_ERROR_CHDIR,
	G_SPAWN_ERROR_ACCES,
	G_SPAWN_ERROR_PERM,
	G_SPAWN_ERROR_TOO_BIG,
	[Obsolete] G_SPAWN_ERROR_2BIG = G_SPAWN_ERROR_TOO_BIG,
	G_SPAWN_ERROR_NOEXEC,
	G_SPAWN_ERROR_NAMETOOLONG,
	G_SPAWN_ERROR_NOENT,
	G_SPAWN_ERROR_NOMEM,
	G_SPAWN_ERROR_NOTDIR,
	G_SPAWN_ERROR_LOOP,
	G_SPAWN_ERROR_TXTBUSY,
	G_SPAWN_ERROR_IO,
	G_SPAWN_ERROR_NFILE,
	G_SPAWN_ERROR_MFILE,
	G_SPAWN_ERROR_INVAL,
	G_SPAWN_ERROR_ISDIR,
	G_SPAWN_ERROR_LIBBAD,
	G_SPAWN_ERROR_FAILED
}

public enum GMarkupError : uint
{
	G_MARKUP_ERROR_BAD_UTF8,
	G_MARKUP_ERROR_EMPTY,
	G_MARKUP_ERROR_PARSE,
	G_MARKUP_ERROR_UNKNOWN_ELEMENT,
	G_MARKUP_ERROR_UNKNOWN_ATTRIBUTE,
	G_MARKUP_ERROR_INVALID_CONTENT,
	G_MARKUP_ERROR_MISSING_ATTRIBUTE
}

public enum GKeyFileError : uint
{
	G_KEY_FILE_ERROR_UNKNOWN_ENCODING,
	G_KEY_FILE_ERROR_PARSE,
	G_KEY_FILE_ERROR_NOT_FOUND,
	G_KEY_FILE_ERROR_KEY_NOT_FOUND,
	G_KEY_FILE_ERROR_GROUP_NOT_FOUND,
	G_KEY_FILE_ERROR_INVALID_VALUE
}

public enum GBookmarkFileError : uint
{
	G_BOOKMARK_FILE_ERROR_INVALID_URI,
	G_BOOKMARK_FILE_ERROR_INVALID_VALUE,
	G_BOOKMARK_FILE_ERROR_APP_NOT_REGISTERED,
	G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND,
	G_BOOKMARK_FILE_ERROR_READ,
	G_BOOKMARK_FILE_ERROR_UNKNOWN_ENCODING,
	G_BOOKMARK_FILE_ERROR_WRITE,
	G_BOOKMARK_FILE_ERROR_FILE_NOT_FOUND
}

public enum GUriError : uint
{
	G_URI_ERROR_FAILED,
	G_URI_ERROR_BAD_SCHEME,
	G_URI_ERROR_BAD_USER,
	G_URI_ERROR_BAD_PASSWORD,
	G_URI_ERROR_BAD_AUTH_PARAMS,
	G_URI_ERROR_BAD_HOST,
	G_URI_ERROR_BAD_PORT,
	G_URI_ERROR_BAD_PATH,
	G_URI_ERROR_BAD_QUERY,
	G_URI_ERROR_BAD_FRAGMENT
}
