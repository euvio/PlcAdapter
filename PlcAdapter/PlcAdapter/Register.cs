using System;
using System.Collections.Generic;

namespace PlcAdapter
{
    public class Register
    {
        public string Id { get; set; }  // 主键
        public string Addrress { get; set; }
        public string Description { get; set; }
        public RegisterType RegisterType { get; set; }
        public int PlcId { get; set; } // PLC主键

        #region Events
        public event ValueChanging ValueChanging;
        #endregion

        #region Get Set

        public IEnumerable<(string id, object value)> GetRightValues(int length)
        {
            throw new Exception();
        }

        public IEnumerable<(string id, T value)> GetRightValues<T>(int length)
        {
            throw new Exception();
        }

        public object GetValue()
        {
            {
                IPlcRepository plcRepository = PlcRespositoryFile.Instance;
                IPlc plc = plcRepository.GetPlcById(PlcId);
                if (RegisterType == RegisterType.BoolReadOnly || RegisterType == RegisterType.BoolReadWrite)
                {
                    return plc.ReadBool(Addrress);
                }
                if (RegisterType == RegisterType.Int16ReadOnly || RegisterType == RegisterType.Int16ReadWrite)
                {
                    return plc.ReadInt16(Addrress);
                }
                if (RegisterType == RegisterType.FloatReadOnly || RegisterType == RegisterType.FloatReadOnly)
                {
                    return plc.ReadSingle(Addrress);
                }
                if (RegisterType == RegisterType.DoubleReadOnly || RegisterType == RegisterType.DoubleReadWrite)
                {
                    return plc.ReadDouble(Addrress);
                }
                if (RegisterType == RegisterType.Int32ReadOnly || RegisterType == RegisterType.Int32ReadWrite)
                {
                    return plc.ReadInt32(Addrress);
                }
                if (RegisterType == RegisterType.ByteReadOnly || RegisterType == RegisterType.ByteReadWrite)
                {
                    return plc.ReadByte(Addrress);
                }
                else
                {
                    int length = int.Parse(RegisterType.ToString().Replace("String", "").Replace("ReadOnly", "")
                        .Replace("ReadWrite", ""));
                    return plc.ReadString(Addrress, length);
                }
            }
        }

        public T GetValue<T>()
        {
            return (T)GetValue();
        }

        public void SetRightValues(IEnumerable<object> values)
        {
        }

        public void SetRightValues<T>(IEnumerable<T> values)
        {
        }

        public void SetValue(object value)
        {
            if (ValueChanging == null || ValueChanging.Invoke(this, new ValueChangingEventArgs(GetValue(), value)))
            {
                IPlcRepository plcRepository = PlcRespositoryFile.Instance;
                IPlc plc = plcRepository.GetPlcById(PlcId);
                if (RegisterType == RegisterType.BoolReadOnly || RegisterType == RegisterType.BoolReadWrite)
                {
                    plc.WriteBool(Addrress, (bool)value);
                }
                else
                {
                    plc.WriteString(Addrress, (string)value);
                }
            }
        }

        public void SetValue<T>(T value)
        {
            SetValue(value);
        }

        #endregion Get Set
    }

    #region 事件模型

    public delegate bool ValueChanging(object sender, ValueChangingEventArgs eventArgs);

    public class ValueChangingEventArgs : EventArgs
    {
        public ValueChangingEventArgs(object oldValue, object newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }

        public object NewValue { get; }
        public object OldValue { get; }
    }

    #endregion 事件模型
}