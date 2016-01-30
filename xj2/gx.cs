namespace xj2
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Net;
    using System.Net.NetworkInformation;
    using System.Text;
    using System.Windows.Forms;

    internal class gx
    {
        public static bool isnet = false;
        public static string version = "4.1";
        public static string wz = "http://acanlaser.b0.upaiyun.com/a4cversion.txt";

        public static void jcgx()
        {
            Ping ping = new Ping();
            if (ping.Send("119.75.218.45").Status != IPStatus.Success)
            {
                isnet = false;
            }
            else
            {
                isnet = true;
                WebRequest request = null;
                WebResponse response = null;
                try
                {
                    request = WebRequest.Create(wz);
                    response = request.GetResponse();
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream, Encoding.ASCII))
                        {
                            if (!reader.ReadLine().Equals(version) && (MessageBox.Show("new version 新版本") == DialogResult.OK))
                            {
                                Process.Start(reader.ReadLine());
                            }
                        }
                    }
                }
                catch (WebException)
                {
                }
                catch (Exception)
                {
                }
                finally
                {
                    if (response != null)
                    {
                        response.Close();
                    }
                    if (request != null)
                    {
                        request.Abort();
                    }
                }
            }
        }
    }
}

