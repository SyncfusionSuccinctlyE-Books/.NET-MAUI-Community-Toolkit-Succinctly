using CommunityToolkit.Maui.Markup;
using MarkupExample;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

class SampleContentPage : ContentPage
{
    private SampleViewModel ViewModel { get; set; }
    public SampleContentPage()
    {
        ViewModel = new SampleViewModel();

        Content = new Grid
        {
            RowDefinitions = Rows.Define(
                (Row.TextEntry, 36)),

            ColumnDefinitions = Columns.Define(
                (Column.Description, Star),
                (Column.Input, Stars(2))),

            Children =
            {
                new Label()
                    .Text("Code:")
                    .Row(Row.TextEntry).Column(Column.Description),

                new Entry
                {
                    Keyboard = Keyboard.Numeric,
                    BackgroundColor = Colors.AliceBlue,
                }.Row(Row.TextEntry).Column(Column.Input)
                 .FontSize(15)
                 .Placeholder("Enter number")
                 .TextColor(Colors.Black)
                 .Height(44)
                 .Margin(5, 5)
                 .Bind(Entry.TextProperty, nameof(ViewModel.RegistrationCode))
            }
        }.Margin(10);
    }

    enum Row { TextEntry }
    enum Column { Description, Input }
}