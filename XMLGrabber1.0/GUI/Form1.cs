using System;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using SwfDotNet.IO;
using SwfDotNet.IO.Tags;
using System.Collections;
using System.Threading;
using System.Net;
using System.Windows.Forms;
using System.Text;

namespace XMLGrabber1._0
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class TextBoxConsole : TextWriter
        {
            TextBox output = null;

            public TextBoxConsole(TextBox _output)
            {
                output = _output;
                output.ScrollBars = ScrollBars.Both;
                output.WordWrap = true;
            }

            public override void Write(char value)
            {
                base.Write(value);
                output.AppendText(value.ToString());
            }

            public override Encoding Encoding
            {
                get { return System.Text.Encoding.UTF8; }
            }
        }

        private void getpackets_Click_1(object sender, EventArgs e)
        {

            {
                TextWriter writer = new TextBoxConsole(tbConsole);
                Console.SetOut(writer);

                string swfPath = Path.Combine(Directory.GetCurrentDirectory(), "client.swf");
                bool all = true;


                if (!File.Exists(swfPath))
                {
                    MessageBox.Show("Cant find client.swf.");
                    return;
                }

                
                Console.WriteLine("Reading swf...");
                SwfReader swfReader = new SwfReader(swfPath);
                Swf swf = swfReader.ReadSwf();
                Console.WriteLine("Completed reading the swf!");


                IEnumerator tagsEnu = swf.Tags.GetEnumerator();
                while (tagsEnu.MoveNext())
                {
                    BaseTag tag = (BaseTag)tagsEnu.Current;
                    if (tag.name != null)
                    {
                        if (tag.TagCode == (int)TagCodeEnum.DoABC2 && all)
                        {
                            Console.WriteLine("Extracting...");
                            BinaryWriter abc = new BinaryWriter(File.Open("abcdata.abc", FileMode.Create));
                            for (int i = 0; i < ((DoABC2Tag)tag).ABC.Length; i++)
                            {
                                abc.Write(((DoABC2Tag)tag).ABC[i]);
                            }
                            abc.Close();

                            if (!File.Exists("rabcdasm.exe"))
                            {
                                string tempExeName = Path.Combine(Directory.GetCurrentDirectory(), "rabcdasm.exe");
                                using (FileStream fsDst = new FileStream(tempExeName, FileMode.CreateNew, FileAccess.Write))
                                {
                                    byte[] bytes = Resource1.GetRabcdasmExe();

                                    fsDst.Write(bytes, 0, bytes.Length);
                                }
                            }

                            ProcessStartInfo Info = new ProcessStartInfo();
                            Info.FileName = "rabcdasm.exe";
                            Info.Arguments = "abcdata.abc";
                            Info.RedirectStandardOutput = true;
                            Info.RedirectStandardError = true;
                            Info.UseShellExecute = false;
                            Info.CreateNoWindow = true;
                            Info.WindowStyle = ProcessWindowStyle.Hidden;

                            Process processTemp = new Process();
                            processTemp.StartInfo = Info;
                            processTemp.EnableRaisingEvents = true;
                            try
                            {
                                processTemp.Start();
                                processTemp.WaitForExit();
                            }
                            catch (Exception)
                            {
                                throw;
                            }
                            
                            Console.WriteLine("Extracting completed!");
                            if (File.Exists("abcdata\\kabam\\rotmg\\messaging\\impl\\GameServerConnection.class.asasm"))
                            {
                                Console.WriteLine("Writing Packets.xml...");
                                StreamWriter packets = new StreamWriter("packets.xml");
                                packets.WriteLine("<Packets>");
                                StreamReader read = new StreamReader("abcdata\\kabam\\rotmg\\messaging\\impl\\GameServerConnection.class.asasm");
                                string pattern = "QName\\(PackageNamespace\\(\\\"\\\"\\), \\\"(\\w+)\\\"\\) slotid (?:.+) type QName\\(PackageNamespace\\(\\\"\\\"\\), \\\"int\\\"\\) value Integer\\((\\d+)\\)";

                                Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);
                                MatchCollection matches = rgx.Matches(read.ReadToEnd());
                                foreach (Match match in matches)
                                {
                                    if (match.Groups.Count == 3)
                                    {
                                        //Console.WriteLine("{0} = {1}", match.Groups[1].Value, match.Groups[2].Value);
                                        packets.WriteLine("\t<Packet>\n\t\t<PacketName>{0}</PacketName>\n\t\t<PacketID>{1}</PacketID>\n\t</Packet>", match.Groups[1].Value.ToString().Replace("_", ""), match.Groups[2].Value.ToString());
                                    }
                                }
                                packets.WriteLine("</Packets>");
                                packets.Close();
                                Console.WriteLine("Writing Packets.xml done...");
                               
                                string[] a = Directory.GetFiles(Environment.CurrentDirectory, "rabcdasm.exe");                              
                                Array.ForEach(a, File.Delete);
                               
                                string[] b = Directory.GetFiles(Environment.CurrentDirectory, "abcdata.abc");
                                Array.ForEach(b, File.Delete);
                            }
                            else
                            {
                                Console.WriteLine("Cant find data for packets.xml");
                            }
                        }
                    }
                }
                Thread.Sleep(1000);
                swfReader.Close();          
            }

        }

   

        private void getprod_Click_1(object sender, EventArgs e)
        {
            TextWriter writer = new TextBoxConsole(tbConsole);
            Console.SetOut(writer);

            Console.WriteLine("Downloading current production client.swf...");
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += Client_DownloadProgressChanged;
            Client.DownloadFileCompleted += Client_DownloadFileCompleted;
            Client.DownloadFileAsync(new Uri("https://realmofthemadgodhrd.appspot.com/client"), "client.swf");    
        }

        private void Client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            Console.WriteLine("Downloading completed!");
            ProgressBar.Value = 0;
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            ProgressBar.Maximum = (int)e.TotalBytesToReceive / 100;
            ProgressBar.Value = (int)e.BytesReceived / 100;
         
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }
        
        private void tilesxml_Click(object sender, EventArgs e)
        {
            
            TextWriter writer = new TextBoxConsole(tbConsole);
            Console.SetOut(writer);
            Console.WriteLine("Downloading Tiles.xml...");
            WebClient Client = new WebClient();
            Client.DownloadFileAsync(new Uri("https://static.drips.pw/rotmg/production/current/xmlc/GroundTypes.xml"), "tiles.xml");
            Client.DownloadProgressChanged += Client_DownloadProgressChanged;
            Client.DownloadFileCompleted += Client_DownloadFileCompleted;               
        }

        private void getobjectsandtiles_Click_1(object sender, EventArgs e)
        {
            TextWriter writer = new TextBoxConsole(tbConsole);
            Console.SetOut(writer);
            Console.WriteLine("Downloading Objects.xml...");
            WebClient Client = new WebClient();
            Client.DownloadFileAsync(new Uri("https://static.drips.pw/rotmg/production/current/xmlc/Objects.xml"), "objects.xml");
            Client.DownloadProgressChanged += Client_DownloadProgressChanged;
            Client.DownloadFileCompleted += Client_DownloadFileCompleted;        
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

