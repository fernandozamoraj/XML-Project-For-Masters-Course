using System;
using System.Collections.Generic;
using PicassosInventorySystem.Model;

namespace PicassosInventorySystem.Utility
{
    public class IdManager
    {
        static IdManager _theIdManager = new IdManager();

        List<string> _Ids = new List<string>();

        public static IdManager GetIdManager()
        {
            return _theIdManager;
        }
        
        public string GetNewId(object o, string prefix)
        {
            _Ids.Sort();

            int lastItemIndex = _Ids.Count - 1;
            ulong nextId = 1;
            string nextIdString; 

            if(lastItemIndex > -1)
            {
                nextId = Convert.ToUInt64(_Ids[lastItemIndex]) + 1;
            }

            nextIdString = nextId.ToString().PadLeft(10, '0');

            _Ids.Add(nextIdString);

            return prefix + nextIdString;
        }

        public void RegisterId(Entity entity, string id)
        {
            string numericId = string.Empty;
            
            foreach(char c in id)
            {
                if(char.IsNumber(c))
                {
                    numericId += c;
                }
            }

            if(!_Ids.Contains(numericId))
            {
                _Ids.Add(numericId);
                _Ids.Sort();
            }
        }

        public static string FixId(string prefix, string id)
        {
            string newId = prefix + id;

            string numericId = string.Empty;

            foreach(char c in newId)
            {
                if(char.IsNumber(c))
                {
                    numericId += c;
                }
            }

            return prefix + numericId;
        }
    }
}
