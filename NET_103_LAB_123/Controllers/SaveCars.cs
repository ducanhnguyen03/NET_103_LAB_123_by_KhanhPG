using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace NET_103_LAB_123.Controllers
{
    [Serializable]
    internal class SaveCars
    {
        FileStream _fS;
        BinaryFormatter _bF;
        public void Save<T>(string path, T Objects)
        {

            if (Read<T>(path) != null)
            {
               
                List<T> lstObject = Read<T>(path);
                _fS = new FileStream(path, FileMode.Create);
                _bF = new BinaryFormatter();
                lstObject.Add(Objects);
                _bF.Serialize(_fS, lstObject);
                _fS.Close();


            }
            else if(Read<T>(path) == null)
            {
                List<T> lstObject = new List<T>();
                _fS = new FileStream(path, FileMode.Create);
                _bF = new BinaryFormatter();
                lstObject.Add(Objects);
                _bF.Serialize(_fS, lstObject);
                _fS.Close();
            } 
               
        }
        public List<T> Read<T>(string path)
        {
            try
            {
                List<T> lstObject = new List<T>();
                 using   FileStream fS =  File.Open(path, FileMode.Open,FileAccess.Read,FileShare.Read);
                _bF = new BinaryFormatter();
                lstObject = (List<T>)_bF.Deserialize(fS);
                return lstObject;

            }
            catch (Exception)
            {
                return null;
               
            }

        }
    }
}
