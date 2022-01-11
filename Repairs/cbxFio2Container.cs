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
    class cbxFio2Container : System.Collections.ArrayList
    {
        public void Serialize()
        {
            String dir = @"C:\RepairSettings";
            if (!Directory.Exists(dir)) // "!" забыл поставить
            {
                Directory.CreateDirectory(dir);
            }


            Stream file_stream = new FileStream(@"C:\RepairSettings\fio2.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file_stream, this);
            file_stream.Close();
        }



        public cbxFio2Container Deserialize()
        {
            cbxFio2Container result = new cbxFio2Container();
            if (File.Exists(@"C:\RepairSettings\fio2.txt"))
            {
                Stream file_stream = new FileStream(@"C:\RepairSettings\fio2.txt", FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                result = (cbxFio2Container)formatter.Deserialize(file_stream);
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
