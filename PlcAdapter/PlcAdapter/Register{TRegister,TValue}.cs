using System;

namespace PlcAdapter
{
    public class Register<TRegisterType, TValue> where TRegisterType : RegisterType<TValue>, new() where TValue : struct
    {
        public event ValueChanging<TValue> ValueChanging;

        public string Addrress { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }  // 主键
        public int PlcId { get; set; }

        public TValue Value
        {
            get
            {
                IPlcRepository plcRepository = PlcRespositoryFile.Instance;
                IPlc plc = plcRepository.GetPlcById(PlcId);
                if (typeof(TValue) == typeof(short))
                {
                    return (TValue)((object)plc.ReadInt16(Addrress));
                }

                return (TValue)((object)plc.ReadBool(Addrress));
            }
            set
            {
                if (ValueChanging == null || ValueChanging.Invoke(this, new ValueChangingEventArgs<TValue>(Value, value)))
                {
                    IPlcRepository plcRepository = PlcRespositoryFile.Instance;
                    IPlc plc = plcRepository.GetPlcById(PlcId);
                    if (typeof(TValue) == typeof(short))
                    {
                        plc.WriteInt16(Addrress, (short)((object)value));
                    }
                    plc.WriteBool(Addrress, (bool)((object)value));
                }
            }
        }

        public (string id, TRegisterType value)[] RightValues
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }

    #region 事件模型

    public delegate bool ValueChanging<TValue>(object sender, ValueChangingEventArgs<TValue> eventArgs);

    public class ValueChangingEventArgs<TValue> : EventArgs
    {
        public ValueChangingEventArgs(TValue oldValue, TValue newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }

        public TValue NewValue { get; }
        public TValue OldValue { get; }
    }

    #endregion 事件模型

    #region Read Write Type
    public interface RegisterType<TValue> where TValue : struct
    {
    }

    public class ReadOnlyType<TValue> : RegisterType<TValue> where TValue : struct
    {

    }

    public class ReadWriteType<TValue> : RegisterType<TValue> where TValue : struct
    {
    }
    #endregion
}