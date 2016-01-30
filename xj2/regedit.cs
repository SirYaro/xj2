namespace xj2
{
    using Microsoft.Win32;
    using System;

    internal class regedit
    {
        public static string bb = "QUEENa4c";

        public static string read(string name)
        {
            RegistryKey key2 = Registry.LocalMachine.OpenSubKey("SOFTWARE", true);
            RegistryKey key3 = key2.OpenSubKey(bb, true);
            if (key3 == null)
            {
                key2.CreateSubKey(bb);
                key3 = key2.OpenSubKey(bb, true);
            }
            return (key3.GetValue(name) as string);
        }

        public static void write(string name, string tovalue)
        {
            RegistryKey key2 = Registry.LocalMachine.OpenSubKey("SOFTWARE", true);
            RegistryKey key3 = key2.OpenSubKey(bb, true);
            if (key3 == null)
            {
                key2.CreateSubKey(bb);
                key3 = key2.OpenSubKey(bb, true);
            }
            key3.SetValue(name, tovalue);
        }
    }
}

