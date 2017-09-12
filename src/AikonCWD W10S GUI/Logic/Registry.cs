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
            /// Check for current windows version
            /// 64 bits OS
            if (Environment.Is64BitOperatingSystem)
            {
                /// Dependes on which folder you are looking at, this has to be specified
                switch (RegistryType)
                {
                    /// HKEY_CLASSES_ROOT
                    case 0:
                        using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64))
                        using (var key = hklm.OpenSubKey(Path, true))
                        {
                            if (key != null)
                            {
                                key.SetValue(Subkey, Value);
                            }
                        }
                        break;
                    /// HKEY_CURRENT_USER
                    case 1:
                        using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                        using (var key = hklm.OpenSubKey(Path, true))
                        {
                            if (key != null)
                            {
                                key.SetValue(Subkey, Value);
                            }
                        }
                        break;
                    /// HKEY_LOCAL_MACHINE
                    case 2:
                        using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                        using (var key = hklm.OpenSubKey(Path, true))
                        {
                            if (key != null)
                            {
                                key.SetValue(Subkey, Value);
                            }
                        }
                        break;
                    /// HKEY_USERS
                    case 3:
                        using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.Users, RegistryView.Registry64))
                        using (var key = hklm.OpenSubKey(Path, true))
                        {
                            if (key != null)
                            {
                                key.SetValue(Subkey, Value);
                            }
                        }
                        break;
                    ///HKEY_CURRENT_CONFIG
                    case 4:
                        using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.CurrentConfig, RegistryView.Registry64))
                        using (var key = hklm.OpenSubKey(Path, true))
                        {
                            if (key != null)
                            {
                                key.SetValue(Subkey, Value);
                            }
                        }
                        break;
                }
            }
            /// 32 bits OS
            else
            {
                /// Dependes on which folder you are looking at, this has to be specified
                switch (RegistryType)
                {
                    /// HKEY_CLASSES_ROOT
                    case 0:
                        using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry32))
                        using (var key = hklm.OpenSubKey(Path, true))
                        {
                            if (key != null)
                            {
                                key.SetValue(Subkey, Value);
                            }
                        }
                        break;
                    /// HKEY_CURRENT_USER
                    case 1:
                        using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry32))
                        using (var key = hklm.OpenSubKey(Path, true))
                        {
                            if (key != null)
                            {
                                key.SetValue(Subkey, Value);
                            }
                        }
                        break;
                    /// HKEY_LOCAL_MACHINE
                    case 2:
                        using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32))
                        using (var key = hklm.OpenSubKey(Path, true))
                        {
                            if (key != null)
                            {
                                key.SetValue(Subkey, Value);
                            }
                        }
                        break;
                    /// HKEY_USERS
                    case 3:
                        using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.Users, RegistryView.Registry32))
                        using (var key = hklm.OpenSubKey(Path, true))
                        {
                            if (key != null)
                            {
                                key.SetValue(Subkey, Value);
                            }
                        }
                        break;
                    ///HKEY_CURRENT_CONFIG
                    case 4:
                        using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.CurrentConfig, RegistryView.Registry32))
                        using (var key = hklm.OpenSubKey(Path, true))
                        {
                            if (key != null)
                            {
                                key.SetValue(Subkey, Value);
                            }
                        }
                        break;
                }
            }

        }
    }
}
