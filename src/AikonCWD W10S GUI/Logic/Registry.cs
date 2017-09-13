using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikonCWD_W10S_GUI.Logic
{
    public class Registry
    {
        /// <summary>
        /// Changes a value in a subkey
        /// </summary>
        /// <param name="RegistryType">0 - HKEY_CLASSES_ROOT | 1 - HKEY_CURRENT_USER | 2 - HKEY_LOCAL_MACHINE | 3- HKEY_USERS | 4 - HKEY_CURRENT_CONFIG</param>
        /// <param name="Path">Path to subkey</param>
        /// <param name="Subkey">Subkey</param>
        /// <param name="Value">New value</param>
        public static void ChangeRegistry(int RegistryType, string Path, string Subkey, string Value)
        {
            /// 32 o 63 bits, this is necessary since regedit tree changes 
            RegistryView OStype;

            if (Environment.Is64BitOperatingSystem)
            {
                OStype = RegistryView.Registry64;
            }
            else
            {
                OStype = RegistryView.Registry32;
            }

            /// Dependes on which folder you are looking at, this has to be specified
            /// Set to whatever to assign, cant set it to null
            RegistryHive Folder = RegistryHive.ClassesRoot;

            switch (RegistryType)
            {
                /// HKEY_CLASSES_ROOT
                case 0:
                    Folder = RegistryHive.ClassesRoot;
                    break;
                /// HKEY_CURRENT_USER
                case 1:
                    Folder = RegistryHive.CurrentUser;
                    break;
                /// HKEY_LOCAL_MACHINE
                case 2:
                    Folder = RegistryHive.LocalMachine;
                    break;
                /// HKEY_USERS
                case 3:
                    Folder = RegistryHive.Users;
                    break;
                ///HKEY_CURRENT_CONFIG
                case 4:
                    Folder = RegistryHive.CurrentConfig;
                    break;
            }

            /// Do something to the key
            using (var hklm = RegistryKey.OpenBaseKey(Folder, OStype))
            using (var key = hklm.OpenSubKey(Path, true))
            {
                if (key != null)
                {
                    key.SetValue(Subkey, Value);
                }
            }

        }
    }
}
