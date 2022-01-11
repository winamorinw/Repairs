using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace Repairs
{
    [Serializable]
    class cbxDolg2Container : System.Collections.ArrayList
    {
        public void Serialize()
        {
            String dir = @"C:\RepairSettings";
            if (!Directory.Exists(dir)) // "!" забыл поставить
            {
                Directory.CreateDirectory(dir);
            }


            Stream file_stream = new FileStream(@"C:\RepairSettings\dolg2.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file_stream, this);
            file_stream.Close();
        }



        public cbxDolg2Container Deserialize()
        {
            cbxDolg2Container result = new cbxDolg2Container();
            if (File.Exists(@"C:\RepairSettings\dolg2.txt"))
            {
                Stream file_stream = new FileStream(@"C:\RepairSettings\dolg2.txt", FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                result = (cbxDolg2Container)formatter.Deserialize(file_stream);
                file_stream.Close();
                return result;
            }
            else
            {
                return result;
            }
        }
    }
}
