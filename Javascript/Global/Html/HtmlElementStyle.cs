namespace Javascript.Global {
	///<summary>
	///Represents the current settings of all possible inline styles for a given element.
	///</summary>
	public class HtmlElementStyle {
		///<summary>
		/// Sets or retrieves the bottom position of the object in the units specified by the bottom attribute.
		///</summary>
		public int posBottom;
		///<summary>
		/// Sets or retrieves the height of the object in the units specified by the height attribute.
		///</summary>
		public int posHeight;
		///<summary>
		///Sets or retrieves the left position of the object in the units specified by the left attribute.
		///</summary>
		public int posLeft;
		///<summary>
		///Sets or retrieves the right position of the object in the units specified by the right attribute.
		///</summary>
		public int posRight;
		///<summary>
		///Sets or retrieves the top position of the object in the units specified by the top attribute.
		///</summary>
		public int posTop;
		///<summary>
		///Sets or retrieves the width of the object in the units specified by the width attribute.
		///</summary>
		public int posWidth;
		///<summary>
		///SSets or retrieves on which side of the object the text will flow.
		///</summary>
		public string styleFloat;

		/// <summary>
		/// Sets or retrieves a value indicating how to manage the content of the object when the content exceeds the height or width of the object.
		///	String that specifies or receives one of the following values.
		///	visible		Default. Content is not clipped and scroll bars are not added.
		///	scroll		Content is clipped and scroll bars are added, even if the content does not exceed the dimensions of the object.
		///	hidden		Content that exceeds the dimensions of the object is not shown.
		///	auto			Content is clipped and scrolling is added only when necessary.
		/// </summary>
		public string overflow {
			get;
			set;
		}
		/// <summary>
		/// Sets or retrieves how to manage the content of the object when the content exceeds the width of the object.
		///	String that specifies or receives one of the following values.
		///	visible		Default. Content is not clipped and scroll bars are not added. Elements are clipped to the size of the containing window or frame.
		///	scroll		Content is clipped and scroll bars are added, even if the content does not exceed the dimensions of the object.
		///	hidden		Content that exceeds the dimensions of the object is not shown.
		///	auto			Content is clipped and scrolling is added only when necessary.
		/// </summary>
		public string overflowX {
			get;
			set;
		}
		/// <summary>
		/// Sets or retrieves how to manage the content of the object when the content exceeds the height of the object.
		///	String that specifies or receives one of the following values.
		///	visible		Default. Content is not clipped and scroll bars are not added. Elements are clipped to the size of the containing window or frame.
		///	scroll		Content is clipped and scroll bars are added, even if the content does not exceed the dimensions of the object.
		///	hidden		Content that exceeds the dimensions of the object is not shown.
		///	auto			Content is clipped and scrolling is added only when necessary.
		/// </summary>
		public string overflowY {
			get;
			set;
		}
		/// <summary>
		/// Sets or retrieves the type of positioning used for the object.
		///	String that specifies or receives one of the following values.
		///	static		Default. Object has no special positioning; it follows the layout rules of HTML.
		///	absolute	Object is positioned relative to parent element's position—or to the body object if its parent element is not positioned—using the top and left properties.
		///	relative	Object is positioned according to the normal flow, and then offset by the top and left properties.
		///	fixed			Windows Internet Explorer 7 and later. Object is positioned relative to the viewport containing the content.
		/// </summary>
		public string position {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the left position of the object.
		///</summary>
		public int pixelLeft {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the top position of the object.
		///</summary>
		public int pixelTop {
			get;
			set;
		}
		///<summary>
		///Opacity (supported by Mozilla Gecko and Apple WebKit)
		///</summary>
		public double opacity {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the height of the object in the units specified by the height attribute.
		///</summary>
		public int pixelHeight {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the width of the object.
		///</summary>
		public int pixelWidth {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the height of the object.
		///String that specifies or receives one of the following values.
		///auto				Default.
		///height			Floating-point number followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units Reference.
		///percentage	Integer followed by a percent sign (%). The value is a percentage of the height of the parent object, which must be specified explicitly. Negative values are not allowed.
		///</summary>
		public string height {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the width of the object.
		///String that specifies or receives one of the following values.
		///auto				Default. Default width of the object.
		///width				Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units.
		///percentage	Integer, followed by a %. The value is a percentage of the width of the parent object, whether or not it is specified explicitly. Negative values are not allowed.
		///</summary>
		public string width {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the persisted representation of the style rule.
		///</summary>
		public string cssText {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves whether the content of the object is displayed.
		///String that specifies or receives one of the following values.
		///inherit		Default. Object inherits the visibility of the next parent object.
		///visible		Object is visible.
		///hidden		Object is hidden.
		///collapse  Internet Explorer 8. Used in tables to remove rows and columns; for all other elements, same as hidden.
		///</summary>
		public string visibility {
			get;
			set;
		}
		/// <summary>
		/// Sets or retrieves whether the object is rendered.
		/// String that specifies or receives one of the following values.
		///	blockObject is rendered as a block element.
		///	inlineDefault. Object is rendered as an inline element sized by the dimensions of the content.
		///	list-item Microsoft Internet Explorer 6 and later. Object is rendered as a block element, and a list-item marker is added.
		///	none Object is not rendered.
		///	table-header-group Object is rendered as tHead. Table header is always displayed before all other rows and row groups, and after any top captions. The header is displayed on each page spanned by a table.
		///	table-footer-group Object is rendered as tFoot. Table footer is always displayed after all other rows and row groups, and before any bottom captions. The footer is displayed on each page spanned by a table.
		///	inline-block Object is rendered inline, but the contents of the object are rendered as a block element. Adjacent inline elements are rendered on the same line, space permitting.
		///	String that specifies or receives one of the following values.
		/// table
		/// Internet Explorer 8. Object is rendered as table.
		/// inline-table
		/// Internet Explorer 8. Object is rendered as table within an inline-block.
		/// table-row
		/// Internet Explorer 8. Object is rendered as tr.
		/// table-row-group
		/// Internet Explorer 8. Object is rendered as tBody. Table body is always displayed after table-header-group objects and before table-footer-group objects.
		/// table-column
		/// Internet Explorer 8. Object is rendered as col.
		/// table-column-group
		/// Internet Explorer 8. Object is rendered as colGroup.
		/// table-cell
		/// Internet Explorer 8. Object is rendered as cell (td) or header cell (th), depending on location within the table.
		/// table-caption
		/// Internet Explorer 8. Object is rendered as caption.
		/// run-in
		/// Internet Explorer 8. If the run-in box contains a block element, object is rendered as a block. If not, and the following sibling is a block (which is neither floating nor absolutely positioned), object is rendered as the first inline-block of the sibling. Otherwise, same as block.
		/// ruby
		/// Internet Explorer 8. Specifies that an element defines a ruby structure. This and the following values are from the CSS3 Ruby Module.
		/// ruby-base
		/// Internet Explorer 8. Specifies that an element defines a ruby base.
		/// ruby-text
		/// Internet Explorer 8. Specifies that an element defines a ruby text.
		/// ruby-base-container
		/// Internet Explorer 8. Specifies a container for one or more ruby base elements.
		/// ruby-text-container
		/// Internet Explorer 8. Specifies a container for one or more ruby text elements.
		/// </summary>
		public string display {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the position of the object relative to the top of the next positioned object in the document hierarchy.
		///String that specifies or receives one of the following values:
		///auto				Default. Default position according to the regular HTML layout of the page.
		///length			Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units Reference.
		///percentage	Integer, followed by a percent sign (%). This value is a percentage of the height of the parent object.
		///</summary>
		public string top {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the bottom position of the object in relation to the bottom of the next positioned object in the document hierarchy.
		///String that specifies or receives one of the following values:
		///auto				Default. Default position according to the regular HTML layout of the page.
		///length			Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units Reference.
		///percentage	Integer, followed by a percent sign (%). This value is a percentage of the height of the parent object.
		///</summary>
		public string bottom {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the position of the object relative to the left edge of the next positioned object in the document hierarchy.
		///String that specifies or receives one of the following values:
		///auto				Default. Position is determined by the regular HTML layout of the page.
		///length			Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units Reference.
		///percentage	Integer, followed by a percent sign (%). The value is a percentage of the width of the parent object.
		///</summary>
		public string left {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the position of the object relative to the right edge of the next positioned object in the document hierarchy.
		///String that specifies or receives one of the following values:
		///auto				Default. Position is determined by the regular HTML layout of the page.
		///length			Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units Reference.
		///percentage	Integer, followed by a percent sign (%). The value is a percentage of the width of the parent object.
		///</summary>
		public string right {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the stacking order of positioned objects.
		///String or Integer that specifies or receives one of the following values.
		///auto. Default. String that specifies the stacking order of the positioned objects based on the order in which the objects appear in the HTML source.
		///order. Integer that specifies the position of the object in the stacking order.
		///</summary>
		public string zIndex {
			get;
			set;
		}

		public StyleFilterCollection filters {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the filter or collection of filters applied to the object.
		///</summary>
		public string filter {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves a value that indicates whether the text in the object has blink, line-through, overline, or underline decorations.
		///String that specifies or receives one of the following values.
		///none					Default. Text has no decoration.
		///underline			Text is underlined.
		///overline			Text has a line over it.
		///line-through	Text has a line drawn through it.
		///blink					Not implemented.
		///</summary>
		public string textDecoration {
			get;
			set;
		}
		/// <summary>
		/// Sets or retrieves whether the text in the object is left-aligned, right-aligned, centered, or justified.
		/// String that specifies or receives one of the following values.
		/// left		Default. Text is aligned to the left.
		///	right		Text is aligned to the right.
		///	center	Text is centered.
		///	justify	Text is justified
		/// </summary>
		public string textAlign {
			get;
			set;
		}
		/// <summary>
		/// Sets or retrieves the type of cursor to display as the mouse pointer moves over the object.
		/// Default value is auto.
		/// String that specifies or receives one or more of the following possible values, separated by commas.
		///	all-scroll		Microsoft Internet Explorer 6 and later. Arrows pointing up, down, left, and right with a dot in the middle, indicating that the page can be scrolled in any direction.
		///	auto					Default. Browser determines which cursor to display based on the current context.
		///	col-resize		Internet Explorer 6 and later. Arrows pointing left and right with a vertical bar separating them, indicating that the item/column can be resized horizontally.
		///	crosshair			Simple cross hair.
		///	default				Platform-dependent default cursor; usually an arrow.
		///	hand					Hand with the first finger pointing up, as when the user moves the pointer over a link.
		///	help					Arrow with question mark, indicating help is available.
		///	move					Crossed arrows, indicating something is to be moved.
		///	no-drop				Internet Explorer 6 and later. Hand with a small circle with a line through it, indicating that the dragged item cannot be dropped at the current cursor location.
		///	not-allowed		Internet Explorer 6 and later. Circle with a line through it, indicating that the requested action will not be carried out.
		///	pointer				Internet Explorer 6 and later. Hand with the first finger pointing up, as when the user moves the pointer over a link. Identical to hand.
		///	progress			Internet Explorer 6 and later. Arrow with an hourglass next to it, indicating that a process is running in the background. User interaction with the page is unaffected.
		///	row-resize		Internet Explorer 6 and later. Arrows pointing up and down with a horizontal bar separating them, indicating that the item/row can be resized vertically.
		///	text					Editable text; usually an I-bar.
		///	url(uri)			Internet Explorer 6 and later. Cursor is defined by the author, using a custom Uniform Resource Identifier (URI), such as url('mycursor.cur'). Cursors of type .CUR and .ANI are the only supported cursor types.
		///	vertical-text	Internet Explorer 6 and later. Editable vertical text, indicated by a horizontal I-bar.
		///	wait					Hourglass or watch, indicating that the program is busy and the user should wait.
		///	*-resize			Arrows, indicating an edge is to be moved; the asterisk (*) can be N, NE, NW, S, SE, SW, E, or W—each representing a compass direction.
		/// </summary>
		public string cursor {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the vertical alignment of the object.
		///Default value is baseline.
		///String that specifies or receives one of the following values.
		///auto				Aligns the contents of an object according to the value of the layout-flow attribute.
		///baseline		Default. Aligns the contents of an object supporting VALIGN to the base line.
		///sub					Vertically aligns the text to subscript.
		///super				Vertically aligns the text to superscript.
		///top					Vertically aligns the contents of an object supporting VALIGN to the top of the object.
		///middle			Vertically aligns the contents of an object supporting VALIGN to the middle of the object.
		///bottom			Vertically aligns the contents of an object supporting VALIGN to the bottom of the object.
		///text-top		Vertically aligns the text of an object supporting VALIGN to the top of the object.
		///text-bottom	Vertically aligns the text of an object supporting VALIGN to the bottom of the object.
		///</summary>
		public string verticalAlign {
			get;
			set;
		}
		/// <summary>
		/// Sets or retrieves a string that indicates whether the table layout is fixed.
		///	auto		Default. Column width is set by the widest unbreakable content in the column cells.
		///	fixed		Table and column widths are set either by the sum of the widths on the col objects or, if these are not specified, by the width of the first row of cells. If no width is specified for the table, it renders by default with width=100%.
		/// </summary>
		public string tableLayout {
			get;
			set;
		}
		public string margin;
		public string marginTop;
		public string marginBottom;
		public string marginLeft;
		public string marginRight;
		public string borderTop;
		public string borderBottom;
		public string borderLeft;
		public string borderRight;
		/// <summary>
		/// Sets or retrieves the amount of space to insert between the object and its margin or, if there is a border, between the object and its border.
		///	String that specifies or receives one of the following values.
		///	length			Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units.
		///	percentage	Integer, followed by a %. The value is a percentage of the width of the parent object.
		///	The property has a default value of 0 for all objects with the following exceptions: TD -> 1, TH -> 1
		/// </summary>
		public string padding {
			get;
			set;
		}
		public string paddingTop;
		public string paddingBottom;
		public string paddingLeft;
		public string paddingRight;
		///<summary>
		///Sets or retrieves a value that indicates whether lines are automatically broken inside the object.
		///String that specifies or receives one of the following values.
		///normal		Default. Lines of text break automatically. Content wraps to the next line if it exceeds the width of the object.
		///nowrap		Line breaks are suppressed. Content does not wrap to the next line.
		///pre				Line breaks and other whitespace are preserved. This possible value is supported in Microsoft Internet Explorer 6 and later when the !DOCTYPE declaration specifies standards-compliant mode. When the !DOCTYPE declaration does not specify standards-compliant mode, you can retrieve this value, but it does not affect rendering—it functions like the normal value.
		///pre-line (in IE8)
		///Sequences of line breaks are preserved.
		///pre-wrap (in IE8)
		///Sequences of line breaks are collapsed.
		///</summary>
		public string whiteSpace {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the foreground color of the object's content.
		///</summary>
		public string color {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the color behind the content of the object.
		///String or Integer that specifies or receives one of the following values.
		///transparent		Default. Color of the next parent object through which the background is visible.
		///color					Any color value, including those specified in the Color Table.
		///</summary>
		public string backgroundColor {
			get;
			set;
		}
		/// <summary>
		/// Sets or retrieves the background image of the object.
		/// String that specifies or receives one of the following values.
		///	none			Default. Color of the next parent through which the background is visible.
		///	url(sUrl)	Location of the background image, where sUrl is an absolute or relative URL.
		/// </summary>
		public string backgroundImage {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves how the backgroundImage property of the object is tiled.
		///String that specifies or receives one of the following values.
		///repeat		Default. Image is repeated horizontally and vertically.
		///no-repeat	Image is not repeated.
		///repeat-x	Image is repeated horizontally.
		///repeat-y	Image is repeated vertically.
		///</summary>
		public string backgroundRepeat {
			get;
			set;
		}
		/// <summary>
		/// Sets or retrieves how the background image is attached to the object within the document.
		/// String that specifies or receives one of the following values.
		///	scroll	Default. Background image scrolls with the object as the document is scrolled.
		///	fixed		Background image stays fixed within the viewable area of the object.
		/// </summary>
		public string backgroundAttachment {
			get;
			set;
		}
		/// <summary>
		/// Sets or retrieves the position of the background of the object.
		/// String that specifies or receives one or two of the following values.
		/// length			Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units Reference.
		/// percentage	Integer, followed by a percent sign (%). The value is a percentage of the width or height of the object.
		/// vAlignment Vertical alignment value. Possible values include the following:
		///			top					Vertical alignment is at the top.
		///			center			Vertical alignment is centered.
		///			bottom			Vertical alignment is at the bottom.
		/// hAlignment	Horizontal alignment value. Possible values include the following:
		///			left				Horizontal alignment is to the left.
		///			center			Horizontal alignment is centered.
		///			right				Horizontal alignment is to the right.
		/// </summary>
		public string backgroundPosition {
			get;
			set;
		}
		public string backgroundPositionX {
			get;
			set;
		}
		public string backgroundPositionY {
			get;
			set;
		}
		/// <summary>
		/// Sets or retrieves up to five separate background properties of the object.
		/// String that specifies or receives up to five of the following space-delimited values, in any order:
		///	color Any of the range of color values available to the backgroundColor property.
		/// image Any of the range of image values available to the backgroundImage property.
		///	repeat Any of the range of repeat values available to the backgroundRepeat property.
		///	attachment Any of the range of attachment values available to the backgroundAttachment property.
		///	position Any of the range of position values available to the backgroundPosition property.
		/// </summary>
		public string background {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves a value that indicates the font size used for text in the object.
		///value = String that specifies or receives one of the following values.
		///absolute-size Set of keywords that indicate predefined font sizes. Named font sizes scale according to the user's font setting preferences. Possible values include the following: xx-small, x-small, small, medium, large, x-large, xx-large.
		///relative-size Set of keywords that are interpreted as relative to the font size of the parent object. Possible values include the following: larger, smaller.
		///length Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see the CSS Length Units Reference.
		///percentage Integer, followed by a percent (%). The value is a percentage of the parent object's font size. In Microsoft Internet Explorer 3.0, the value is calculated as a percentage of the default font size.
		///Default - medium (of the absolute-size set).
		///</summary>
		public string fontSize {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the font style of the object as italic, normal, or oblique.
		///String that specifies or receives one of the following values.
		///normal Default. Font is normal.
		///italic Font is italic.
		///oblique Font is italic.
		///</summary>
		public string fontStyle {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves whether the text of the object is in small capital letters.
		///String that specifies or receives one of the following values.
		///normal Default. Font is normal.
		///small-caps Font is in small capital letters.
		///</summary>
		public string fontVariant {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the name of the font used for text in the object.
		///String that specifies or receives one of the following values.
		///family-name Any of the available font families supported by the browser. For example, Times, Helvetica, Zapf-Chancery, Western, or Courier.
		///generic-name Any of the following font families: serif, sans-serif, cursive, fantasy, or monospace.
		///</summary>
		public string fontFamily {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the weight of the font of the object.
		///String that specifies or receives one of the following values.
		///normal Font is normal.
		///bold Font is bold.
		///bolder Font is at least as bold as the default bold weight.
		///lighter Font is lighter than normal.
		///100 Font is at least as light as the 200 weight.
		///200 Font is at least as bold as the 100 weight and at least as light as the 300 weight.
		///300 Font is at least as bold as the 200 weight and at least as light as the 400 weight.
		///400 Font is normal.
		///500 Font is at least as bold as the 400 weight and at least as light as the 600 weight.
		///600 Font is at least as bold as the 500 weight and at least as light as the 700 weight.
		///700 Font is bold.
		///800 Font is at least as bold as the 700 weight and at least as light as the 900 weight.
		///900 Font is at least as bold as the 800 weight.
		///</summary>
		public string fontWeight {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the distance between lines in the object.
		///String that specifies or receives one of the following values.
		///normal			Default. Default height.
		///height			Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units Reference.
		///percentage	Integer, followed by a percent sign (%). The value is a percentage of the height of the parent object.
		///</summary>
		public string lineHeight {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves a combination of separate font properties of the object. Alternatively, sets or retrieves one or more of six user-preference fonts.
		///String that specifies or receives up to six of the following space-delimited property values. Alternatively, sets or retrieves the six listed text fonts.
		///font-style Any of the range of font-style values available to the fontStyle property.
		///font-variant Any of the range of font-variant values available to the fontVariant property.
		///font-weight Any of the range of font-weight values available to the fontWeight property.
		///font-size Any of the range of font-size values available to the fontSize property. When this value is an integer followed by a percent (%), the value is a percentage of the parent object's font size. In Microsoft Internet Explorer 3.0, a percentage value is calculated as a percentage of the default font size.
		///line-height Any of the range of line-height values available to the lineHeight property. When used with the font property, this attribute must include a slash (/) before the value. Line height percentage values are calculated as a percentage of the font size of the element itself, not of the parent.
		///font-family Any of the range of font-family values available to the fontFamily property. This property can be set to multiple comma-separated values. Its default value depends on user settings.
		///caption User-preference font used in objects that have captions—buttons, labels, and so on.
		///icon User-preference font used in icon labels.
		///menu User-preference font used in menus.
		///message-box User-preference font used in dialog boxes.
		///small-caption User-preference font used in small controls.
		///status-bar User-preference font used in window status bars.
		///</summary>
		public string font {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves a value that indicates whether the row and cell borders of a table are joined in a single border or detached as in standard HTML.
		///String that specifies or receives one of the following values.
		///separate Default. Borders are detached (standard HTML).
		///collapse Borders are collapsed, where adjacent, into a single border.
		///</summary>
		public string borderCollapse {
			get;
			set;
		}
		/// <summary>
		/// Sets or retrieves the properties to draw around the object.
		/// String that specifies or receives one or more of the following space-delimited values:
		///	width. Any of the range of width values available to the borderWidth property.
		///	style. Any of the range of style values available to the borderStyle property.
		///	color. Any of the range of color values available to the borderColor property.
		/// </summary>
		public string border {
			get;
			set;
		}
		/// <summary>
		/// Sets or retrieves the style of the left, right, top, and bottom borders of the object.
		/// String that specifies or receives one of the following values.
		/// none. Default. No border is drawn, regardless of any specified borderWidth.
		/// dotted. Border is a dotted line. This value is supported on the Macintosh platform, as of Microsoft Internet Explorer 4.01, and on the Microsoft Windows platform, as of Internet Explorer 5.5. It renders as a solid line on Unix platforms, and on Windows systems running earlier versions of Windows Internet Explorer.
		///	dashed. Border is a dashed line. This value is supported on the Macintosh platform as of Internet Explorer 4.01 and on the Windows platform, as of Internet Explorer 5.5. It renders as a solid line on Unix platforms, and on Windows systems running earlier versions of Internet Explorer.
		///	solid. Border is a solid line.
		///	double. Border is a double line drawn on top of the background of the object. The sum of the two single lines and the space between equals the borderWidth value. The border width must be at least 3 pixels wide to draw a double border.
		///	groove. 3-D groove is drawn in colors based on the value. The borderWidth property of the object must be specified for the style to render correctly.
		///	ridge. 3-D ridge is drawn in colors based on the value.
		///	inset. 3-D inset is drawn in colors based on the value.
		///	window-inset. Border is the same as inset, but is surrounded by an additional single line, drawn in colors based on the value.
		///	outset. 3-D outset is drawn in colors based on the value.
		/// window-inset. Internet Explorer 6 and later. Same as inset with a thin outside border.
		/// </summary>
		public string borderStyle {
			get;
			set;
		}
		/// <summary>
		/// Sets or retrieves the width of the left, right, top, and bottom borders of the object.
		/// String that specifies or receives up to four of the following values:
		///	medium. Default.
		/// thin. Width less than the default.
		/// thick. Width greater than the default.
		/// width. Width consisting of a floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px)
		/// </summary>
		public string borderWidth {
			get;
			set;
		}
		/// <summary>
		/// Sets or retrieves the border color of the object.
		///	String that specifies or receives one or more of the following space-delimited values:
		/// transparent. Border is transparent.
		/// color. Up to four color names or RGB values in the Color Table.
		/// </summary>
		public string borderColor {
			get;
			set;
		}
		///<summary>
		///Returns the optional priority, "important".
		///</summary>
		///<param name="propertyName">property name</param>
		public string getPropertyPriority(string propertyName) {
			return null;
		}
		///<summary>
		///Returns the property value.
		///</summary>
		///<param name="propertyName">property name</param>
		public string getPropertyValue(string propertyName) {
			return null;
		}
		///<summary>
		///Sets the property value.
		///</summary>
		///<param name="propertyName">property name</param>
		///<param name="value">value</param>
		///<param name="priority">'important' or null</param>
		public string setProperty(string propertyName, string value, string priority) {
			return null;
		}
		///<summary>
		///Removed a declaration from a stylesheet
		///</summary>
		///<param name="propertyName">property name</param>
		/// <remarks>Opera refuses to remove the last remaining property of a rule.</remarks>
		public void removeProperty(string propertyName) {
		}
	}
}
