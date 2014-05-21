using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Sirius.Coletor.Util
{
    public class DeviceId
    {

        private static Int32 FILE_DEVICE_HAL = 0x00000101;
        private static Int32 FILE_ANY_ACCESS = 0x0;
        private static Int32 METHOD_BUFFERED = 0x0;

        private static Int32 IOCTL_HAL_GET_DEVICEID =
            ((FILE_DEVICE_HAL) << 16) | ((FILE_ANY_ACCESS) << 14)
            | ((21) << 2) | (METHOD_BUFFERED);

        [DllImport("coredll.dll")]
        private static extern bool KernelIoControl(Int32 IoControlCode, IntPtr InputBuffer, Int32 InputBufferSize, byte[] OutputBuffer, Int32 OutputBufferSize, ref Int32 BytesReturned);

        public static string GetDeviceID()
        {
            byte[] data = new byte[256];
            Int32 OutputBufferSize, BytesReturned;
            OutputBufferSize = data.Length;
            BytesReturned = 0;

            bool retVal = KernelIoControl(IOCTL_HAL_GET_DEVICEID, IntPtr.Zero, 0, data, OutputBufferSize, ref BytesReturned);
            // If the request failed, exit the method now
            if (retVal)
            {
                Int32 PresetIDOffset = BitConverter.ToInt32(data, 4);
                Int32 PlatformIDOffset = BitConverter.ToInt32(data, 0xc);
                Int32 PlatformIDSize = BitConverter.ToInt32(data, 0x10);

                // Convert the Preset ID segments into a string so they can be 
                // displayed easily.
                var sb = new StringBuilder();
                sb.Append(String.Format("{0:X8}-{1:X4}-{2:X4}-{3:X4}-",
                                        BitConverter.ToInt32(data, PresetIDOffset),
                                        BitConverter.ToInt16(data, PresetIDOffset + 4),
                                        BitConverter.ToInt16(data, PresetIDOffset + 6),
                                        BitConverter.ToInt16(data, PresetIDOffset + 8)));

                // Break the Platform ID down into 2-digit hexadecimal numbers
                // and append them to the Preset ID. This will result in a 
                // string-formatted Device ID
                for (int i = PlatformIDOffset; i < PlatformIDOffset + PlatformIDSize; i++)
                {
                    sb.Append(String.Format("{0:X2}", data[i]));
                }
                // return the Device ID string
                return sb.ToString();
            }
            return null;
        }
    }

}
