using System;
using System.Drawing;
using System.Text;

namespace Converter
{
    class Converter
    {
        #region members

        private byte[] _value;
        private bool _valid;

        #endregion

        #region private properties

        private byte[] Value
        {
            get { return _value; }
            set
            {
                //trim end of array
                int i = value.Length;
                while (i > 0 && value[i - 1] == 0) i--;
                Array.Resize(ref value, i);

                _value = value;
                _valid = true;
            }
        }

        #endregion


        private void ResetValue()
        {
            _valid = false;
        }


        #region public properties

        public Color TextColor
        {
            get { return (_valid) ? Color.Black : Color.Gray; }
        }

        //used by bit converter
        public ulong ULong
        {
            get
            {

                if (Value.Length > sizeof(ulong)) return 0;

                byte[] bytes = new byte[sizeof(ulong)];

                Array.Copy(Value,bytes,Math.Min(bytes.Length,Value.Length));

                ulong i = BitConverter.ToUInt64(bytes, 0);
                return i;
            }
            set
            {
                Value = BitConverter.GetBytes(value);
            }
        }
        

        public string Int64
        {
            get
            {
                if (Value.Length > sizeof(ulong)) return "";

                byte[] bytes = new byte[sizeof(ulong)];

                Array.Copy(Value,bytes,Math.Min(bytes.Length,Value.Length));

                long i = BitConverter.ToInt64(bytes, 0);
                return i.ToString();
            }
            set
            {
                long a;
                if (long.TryParse(value, out a))
                {
                    Value = BitConverter.GetBytes(a);
                }
                else ResetValue();
            }
        }

        public string Hex64
        {
            get
            {
                if (Value.Length > sizeof(ulong)) return "";

                byte[] bytes = new byte[sizeof(ulong)];

                Array.Copy(Value, bytes, Math.Min(bytes.Length, Value.Length));

                ulong x = BitConverter.ToUInt64(bytes, 0);
                return x.ToString("X");
            }
            set
            {
                ulong a;
                if (ulong.TryParse(value, System.Globalization.NumberStyles.HexNumber, null, out a))
                {
                    Value = BitConverter.GetBytes(a);
                }
                else ResetValue();
            }
        }

        public string Float
        {
            get
            {
                if (Value.Length > sizeof(float)) return "";

                byte[] bytes = new byte[sizeof(float)];

                Array.Copy(Value, bytes, Math.Min(bytes.Length, Value.Length));

                float f = BitConverter.ToSingle(bytes, 0);
                return f.ToString();
            }
            set
            {
                float f;
                if (float.TryParse(value, out f))
                {
                    Value = BitConverter.GetBytes(f);
                }
                else ResetValue();
            }
        }

        public string Double
        {
            get
            {
                if (Value.Length > sizeof(double)) return "";

                byte[] bytes = new byte[sizeof(double)];

                Array.Copy(Value, bytes, Math.Min(bytes.Length, Value.Length));

                double f = BitConverter.ToDouble(bytes, 0);
                return f.ToString();
            }
            set
            {
                double f;
                if (double.TryParse(value, out f))
                {
                    Value = BitConverter.GetBytes(f);
                }
                else ResetValue();
            }
        }

        public string Ascii
        {
            get
            {
                byte[] bytes = new byte[Value.Length];
                Array.Copy(Value, bytes, Value.Length);

                //bytes -> ASCII
                char[] chars = Encoding.ASCII.GetChars(bytes);
                Array.Reverse(chars);

                //replace 'x0'->'space'
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] == 0) chars[i] = ' ';
                }
                return new string(chars);
            }
            set
            {
                byte[] bytes = Encoding.ASCII.GetBytes(value);
                Array.Reverse(bytes);

                Value = bytes;
            }
        }

        public string Unicode
        {
            get
            {
                byte[] bytes = new byte[(Value.Length + 1) & (~0x1)];
                Array.Copy(Value, bytes, Value.Length);

                char[] chars = new char[bytes.Length/2];

                //bytes -> chars
                for (int i = 0; i < chars.Length; i++)
                {
                    chars[i] = BitConverter.ToChar(bytes, i*2);
                }
                Array.Reverse(chars);

                //replace 'x0'->'space'
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] == 0) chars[i] = ' ';
                }

                return new string(chars);
            }
            set
            {
                char[] chars = value.ToCharArray();
                Array.Reverse(chars);

                byte[] bytes = new byte[chars.Length * 2];

                for (int i = 0; i < chars.Length; i++)
                {
                    byte[] two = BitConverter.GetBytes(chars[i]);
                    Array.Copy(two, 0, bytes, i*2, 2);
                }
                Value = bytes;
            }
        }

        public string Unixtime
        {
            get
            {
                if (Value.Length > sizeof(ulong)) return "";

                byte[] bytes = new byte[sizeof(ulong)];
                Array.Copy(Value, bytes, Math.Min(bytes.Length, Value.Length));

                ulong i = BitConverter.ToUInt64(bytes, 0);

                DateTime dateTime = new DateTime((long)(i + 62135596800) * 10000000, DateTimeKind.Utc);

                return dateTime.ToString();
            }
            set
            {
                DateTime dateTime;
                if(DateTime.TryParse(value, out dateTime))
                {
                    Value = BitConverter.GetBytes((ulong)dateTime.Ticks / 10000000 - 62135596800);
                }
                else ResetValue();
            }
        }
        #endregion

    }
}
