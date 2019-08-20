using System;
using System.Linq;

namespace Presys.Calibrators.Comm.DryBlocks.Modbus
{
    public class DryBlocks
    {
        private ModbusHelper modbus;

        public DryBlocks()
        {
        }       

        public static string[] GetInputTypes()
        {
            return Common.InputTypes;
        }        

        public void InitiateComm(string configuration)
        {
            try
            {
                var serialPort = configuration.Split('|')[0];
                var modbusAddress = configuration.Split('|')[1];
                var baudRate = byte.Parse(configuration.Split('|')[2]);
                var parity = byte.Parse(configuration.Split('|')[3]);
                var length = byte.Parse(configuration.Split('|')[4]);
                var stopBits = byte.Parse(configuration.Split('|')[5]);
                var readTimeout = short.Parse(configuration.Split('|')[6]);
                var minTimeInterChar = short.Parse(configuration.Split('|')[7]);

                modbus = new ModbusHelper(serialPort, modbusAddress, baudRate, parity, length, stopBits, readTimeout, minTimeInterChar);
            }
            catch (Exception ex)
            {
                throw new Exception("Invalid Configuration. Try to understand how the parameters work.", ex);
            }
        }

        public void FinishComm()
        {
            modbus.ResetData();            
        }        

        public void ChangeInputType(string inputType)
        {
            var resp = WriteByteToDevice(29060, GetInputCode(inputType));

            if (resp != 0 && resp != 255)
            {
                throw new Exception(Common.Errors[resp]);
            }                
        }

        public string GetCurrentInputType()
        {
            byte inputTypeCode;
            ReadByteFromDevice(29060, out inputTypeCode);
            return Common.InputTypes[inputTypeCode];
        }        

        public string ReadInputValue()
        {
            float readvalue;
            short decimalPlaces;
            ReadFloatFromDevice(29050, out readvalue, out decimalPlaces);
            return DataConverters.ConvertFloatToString(readvalue, decimalPlaces);
        }

        public string ReadProbeValue()
        {
            float readvalue;
            short decimalPlaces;
            ReadFloatFromDevice(29061, out readvalue, out decimalPlaces);
            return DataConverters.ConvertFloatToString(readvalue, decimalPlaces);
        }

        public string ReadOutputControlValue()
        {
            float readvalue;
            short decimalPlaces;
            ReadFloatFromDevice(29066, out readvalue, 2);
            return DataConverters.ConvertFloatToString(readvalue, 2);
        }

        public string SetSetPointValue(string text)
        {
            var floatValue = DataConverters.ConvertInputTextToFloat(text);

            var intValue = DataConverters.ConvertFloatToIntRemovingDecimalPlaces(floatValue, 1);

            byte[] bytesToBeWrite = DataConverters.ExtractBytesFromInt(intValue);
            Array.Resize(ref bytesToBeWrite, 5);
            bytesToBeWrite[4] = 1;

            var shortToBeWrite = DataConverters.ConvertByteArrayToShortArray(bytesToBeWrite);

            var resp = modbus.WriteRawDataToDevice(29044, shortToBeWrite);

            if (resp == 0)
            {
                return DataConverters.ConvertFloatToString(floatValue, 1);
            }

            throw new Exception(Common.Errors[resp]);
        }

        private static byte GetInputCode(string inputType)
        {
            return (byte)Common.InputTypes.ToList().IndexOf(inputType);
        }       

        private byte WriteByteToDevice(short address, byte data)
        {
            return modbus.WriteRawDataToDevice(address, new short[] { (short)data });
        }

        private void ReadByteFromDevice(short registerAddress, out byte value)
        {
            short[] bytes = new short[1];
            var resp = modbus.ReadRawData(registerAddress, bytes);

            if (resp == 0)
            {
                value = (byte)bytes[0];
                return;
            }

            throw new Exception(Common.Errors[resp]);
        }

        private void ReadFloatFromDevice(short registerAddress, out float value, out short decimalPlaces)
        {
            short[] bytes = new short[5];
            var resp = modbus.ReadRawData(registerAddress, bytes);

            short[] bytesValue = new short[4];
            Array.Copy(bytes, bytesValue, 4);

            decimalPlaces = bytes[4];

            if (resp == 0)
            {
                value = DataConverters.ConvertInt32ToFloat(DataConverters.ConvertRawDataToInt32(bytes), decimalPlaces);            
                return;
            }

            throw new Exception(Common.Errors[resp]);
        }

        private void ReadFloatFromDevice(short registerAddress, out float value, short decimalPlaces)
        {
            short[] bytes = new short[4];
            var resp = modbus.ReadRawData(registerAddress, bytes);              

            if (resp == 0)
            {
                value = DataConverters.ConvertInt32ToFloat(DataConverters.ConvertRawDataToInt32(bytes), decimalPlaces);
                return;
            }

            throw new Exception(Common.Errors[resp]);
        }
    }
}
