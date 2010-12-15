using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Converter
{
    public partial class BitControl : UserControl
    {
        readonly CheckBox[] checks = new CheckBox[64];
        public BitControl()
        {

            InitializeComponent();

            const int offset = 5;

            int lenth = (Right - Left - offset*2)/8;
            int heigh = (Bottom - Top - offset*2)/8;

            for (int i = 0; i < checks.Length; i++)
            {
                checks[i] = new CheckBox();
                checks[i].AutoSize = true;
                checks[i].Name = i.ToString();
                checks[i].Location = new Point(offset + lenth * ((63 - i) / 8), offset + heigh * ((63 - i) % 8));
                checks[i].Size = new Size(lenth, heigh);
                checks[i].Text = i.ToString();
                checks[i].Size = new Size(40, 14);

                checks[i].CheckedChanged += OnCheckedChanged;
                Controls.Add(checks[i]);
            }
        }

        private void OnCheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            if(chk != null)
            {
                int i;
                if(int.TryParse(chk.Name, out i))
                {
                    if (chk.Checked) Value |= 1ul << i;
                    else Value &=~ (1ul << i);
                }
            }
        }

        private ulong _value;

        public event EventHandler ValueChanged;

        [Bindable(BindableSupport.Yes, BindingDirection.TwoWay)]
        public ulong Value
        {
            get
            {
                 return _value;
            }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    for (int i = 0; i < checks.Length; i++)
                    {
                        checks[i].Checked = (_value & (1ul << i)) != 0;
                    }
                    EventHandler t = ValueChanged;
                    if (t != null)
                    {
                        t(this, EventArgs.Empty);
                    }
                }
            }
        }

    }
}
