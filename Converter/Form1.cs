using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        readonly Converter _converter = new Converter();

        public Form1()
        {
            InitializeComponent();

            txInt64.DataBindings.Add("Text", _converter, "Int64", true, DataSourceUpdateMode.OnPropertyChanged);
            txInt64.DataBindings.Add("ForeColor", _converter, "TextColor", false, DataSourceUpdateMode.OnPropertyChanged);

            txHex64.DataBindings.Add("Text", _converter, "Hex64", true, DataSourceUpdateMode.OnPropertyChanged);
            txHex64.DataBindings.Add("ForeColor", _converter, "TextColor", false, DataSourceUpdateMode.OnPropertyChanged);

            txFloat.DataBindings.Add("Text", _converter, "Float", true, DataSourceUpdateMode.OnPropertyChanged);
            txFloat.DataBindings.Add("ForeColor", _converter, "TextColor", false, DataSourceUpdateMode.OnPropertyChanged);

            txDouble.DataBindings.Add("Text", _converter, "Double", true, DataSourceUpdateMode.OnPropertyChanged);
            txDouble.DataBindings.Add("ForeColor", _converter, "TextColor", false, DataSourceUpdateMode.OnPropertyChanged);

            txAscii.DataBindings.Add("Text", _converter, "Ascii", true, DataSourceUpdateMode.OnPropertyChanged);
            txAscii.DataBindings.Add("ForeColor", _converter, "TextColor", false, DataSourceUpdateMode.OnPropertyChanged);

            txUnicode.DataBindings.Add("Text", _converter, "Unicode", true, DataSourceUpdateMode.OnPropertyChanged);
            txUnicode.DataBindings.Add("ForeColor", _converter, "TextColor", false, DataSourceUpdateMode.OnPropertyChanged);

            txUnixtime.DataBindings.Add("Text", _converter, "Unixtime", true, DataSourceUpdateMode.OnPropertyChanged);
            txUnixtime.DataBindings.Add("ForeColor", _converter, "TextColor", false, DataSourceUpdateMode.OnPropertyChanged);

            bitControl1.DataBindings.Add("Value", _converter, "ULong", true, DataSourceUpdateMode.OnPropertyChanged);
        }
   }
}