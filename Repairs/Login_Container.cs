using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Repairs
{
    [Serializable]
    class Login_Container
    {
        public void Serialize()
        {
            Stream fileStream = new FileStream("data.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, this);
            fileStream.Close();
        }

        public Login_Container Deserialize()
        {
            Login_Container result = new Login_Container();
            if (File.Exists("data.txt"))
            {
                Stream fileStream = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                result = (Login_Container) formatter.Deserialize(fileStream);
                fileStream.Close();
                return result;

            }
            else
            {
                return result;
            }

        }
    }
}
