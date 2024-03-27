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

namespace MentorLake.Gtk4.GLib;

public enum GTokenType
{
	G_TOKEN_EOF,
	G_TOKEN_LEFT_PAREN,
	G_TOKEN_RIGHT_PAREN,
	G_TOKEN_LEFT_CURLY,
	G_TOKEN_RIGHT_CURLY,
	G_TOKEN_LEFT_BRACE,
	G_TOKEN_RIGHT_BRACE,
	G_TOKEN_EQUAL_SIGN,
	G_TOKEN_COMMA,
	G_TOKEN_NONE,
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
	G_TOKEN_COMMENT_MULTI
}
