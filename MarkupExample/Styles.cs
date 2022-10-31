using CommunityToolkit.Maui.Markup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkupExample
{
    public class Styles
    {
        static Style<Label> link;

        public static Style<Label> Link => link ??= new Style<Label>(
            (Span.FontSizeProperty, 14),
            (Span.TextColorProperty, Colors.CornflowerBlue),
            (Span.TextDecorationsProperty, TextDecorations.Underline)
        );
    }
}
