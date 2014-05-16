using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Sirius.Coletor.Util
{
    public class DeviceId
    {

        [DllImport("coredll.dll")]
        private extern static int GetDeviceUniqueID([In, Out] byte[] appdata,
                                                    int cbApplictionData,
                                                    int dwDeviceIDVersion,
                                                    [In, Out] byte[] deviceIDOuput,
                                                    out uint pcbDeviceIDOutput);


        /// <summary>
        /// Gets the unique Device ID.
        /// </summary>
        /// <returns></returns>
        public static string GetDeviceID()
        {
            string appString = "Sirius";
            byte[] appData = new byte[appString.Length];
            for (int count = 0; count < appString.Length; count++)
            {
                appData[count] = (byte)appString[count];
            }

            int appDataSize = appData.Length;
            var deviceOutput = new byte[10];
            uint sizeOut;
            GetDeviceUniqueID(appData, appDataSize, 1, deviceOutput, out sizeOut);

            string idString = "";
            for (int i = 0; i < deviceOutput.Length; i++)
            {
                if (i == 4 || i == 6 || i == 8 || i == 10)
                    idString = String.Format("{0}-{1}", idString, deviceOutput[i].ToString("x2"));
                else
                    idString = String.Format("{0}{1}", idString, deviceOutput[i].ToString("x2"));
            }
            return idString;
        }
    }

}
