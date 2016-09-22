using NPOI.Extend;
using NPOI.SS.UserModel;

namespace NPOI.Example
{
    [NPOIObject]
    public class ModelOne
    {
        [NPOIColumn(0)]
        [HeaderStyle(ColumnWidth = 40, ForegroundColor = "gray", TextColor = "White", TextAlign = HorizontalAlignment.Right)]
        [CellStyle(TextColor = "#eeeeee", ForegroundColor = "#333333")]
        [AlternateCellStyle(TextColor = "Red", ForegroundColor = "Blue")]
        public uint Id { get; set; }

        [NPOIColumn("From")]
        [DrawingIgnore]
        [RichText]
        public string FromHtml { get; set; }

        [NPOIColumn(1)]
        [HeaderStyle(ColumnWidth = 23, ForegroundColor = "#FF0000", TextColor = "#FFFFFF")]
        public string Name { get; set; }

        [NPOIColumn(2)]
        [HeaderStyle(ColumnWidth = 40, ForegroundColor = "#00FF00", TextColor = "red")]
        [CellStyle(FontFamily = "Matura MT Script Capitals", ForegroundColor = "#FFFFFF", TextColor = "#000000")]
        [AlternateCellStyle(FontWeight = 700)]
        public string From { get; set; }

        [NPOIColumn(3)]
        [HeaderStyle(ColumnWidth = 40, ForegroundColor = "#0000FF", TextColor = "#FFFFFF")]
        [AlternateCellStyle(FontWeight = 700)]
        public string Type { get; set; }

        [NPOIColumn(4)]
        [HeaderStyle(ColumnWidth = 40, ForegroundColor = "#000000", TextColor = "#FFFFFF", TextAlign = HorizontalAlignment.Center)]
        [AlternateCellStyle(FontSize = 5)]
        public string Country { get; set; }

        [NPOIColumn(5, "Country Code")]
        public string Code { get; set; }
    }
}