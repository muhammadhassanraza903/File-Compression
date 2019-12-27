using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace File_Compression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Browser_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if(file.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                string filename = file.FileName;
                fileDialogue.Text = filename;
                MessageBox.Show("File uploaded Successfully");
            }
        }

        private void btn_Compress_Click(object sender, EventArgs e)
        {
            string path = fileDialogue.Text;
            FileStream sourcefile = File.OpenRead(path);
            FileStream destinationFile = File.Create(path +".zip");

            byte[] buffer = new byte[sourcefile.Length];
            sourcefile.Read(buffer, 0, buffer.Length);

            using (GZipStream output = new GZipStream(destinationFile, CompressionMode.Compress))
            {
                Console.WriteLine("Compressing {0} to {1}", sourcefile.Name, destinationFile.Name, false);

                output.Write(buffer, 0, buffer.Length);
            }

            sourcefile.Close();
            destinationFile.Close();
            MessageBox.Show("File compressed Successfully");
            fileDialogue.Clear();

        }
        public static void Decompress(FileInfo fileToDecompress)
        {
            using (FileStream orginalFileStream = fileToDecompress.OpenRead())
            {
                string currentFileName = fileToDecompress.FullName;
                string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

                using (FileStream decompressedStream = File.Create(newFileName))
                {
                    using (GZipStream decompressionStream = new GZipStream(orginalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedStream);
                        Console.WriteLine("Decompressed: {0}", fileToDecompress.Name);
                    }
                }
                MessageBox.Show("File Decompressed Successfully");
            }
        }
        private void btn_Decompress_Click(object sender, EventArgs e)
        {
            string path = fileDialogue.Text;
            FileInfo filepath = new FileInfo(path);
            Decompress(filepath);
            fileDialogue.Clear();   
        }
    }
}
