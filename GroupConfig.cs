// Написал Алексей Сырчин, спиздил Андрей Игошин
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FourElements
{
    // Сам разберешься
    class ConfigEntry
    {
        public string GroupId;
        public string GroupType;
        public string[] Codes;
    }

    class GroupConfig
    {
        public ConfigEntry[] Data;

        public void ReadConfig(string FileName)
        {
            StreamReader SR = new StreamReader(FileName);
            string currentLine;
            ConfigEntry e = new ConfigEntry();

            currentLine = SR.ReadLine();

            if (currentLine != null && !currentLine.Contains(";"))
            {
               
                if (currentLine.Contains("-group"))
                {
                    if (e != null)
                    {
                        e = null;
                    }
                    else
                    {
                        e = new ConfigEntry();
                    }
                }

                if (currentLine.Contains("-eog"))
                {
                    Data.Append<ConfigEntry>(e);
                    e = null;
                }

                string[] t = currentLine.Split(':');

            }

            SR.Close();
        }
    }
}
