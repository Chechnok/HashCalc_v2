using System.Diagnostics;
using System.IO.Hashing;
using System.Security.Cryptography;
using System.Text;

namespace HashCalc
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
            calculateButton.Enabled = false;
        }

        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            selectedFileName.Text = openFileDialog.SafeFileName;

            calculateButton.Enabled = true;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!openFileDialog.CheckFileExists)
                {
                    return;
                }

                md5HashLabel.Text = string.Empty;
                sha1HashLabel.Text = string.Empty;
                sha256HashLabel.Text = string.Empty;
                sha384HashLabel.Text = string.Empty;
                crc32HashLabel.Text = string.Empty;

                if (md5CheckBox.Checked)
                {
                    using var stream = File.OpenRead(openFileDialog.FileName);

                    using var hashMD5 = MD5.Create();

                    var md5 = hashMD5.ComputeHash(stream);

                    md5HashLabel.Text = BitConverter
                        .ToString(md5)
                        .Replace("-", "")
                        .ToUpperInvariant();
                }

                if (sha1CheckBox.Checked)
                {
                    using var stream = File.OpenRead(openFileDialog.FileName);

                    using var hashSHA1 = SHA1.Create();

                    var sha1 = hashSHA1.ComputeHash(stream);

                    sha1HashLabel.Text = BitConverter
                        .ToString(sha1)
                        .Replace("-", "")
                        .ToUpperInvariant();
                }

                if (sha256CheckBox.Checked)
                {
                    using var stream = File.OpenRead(openFileDialog.FileName);

                    using var hashSHA256 = SHA256.Create();

                    var sha256 = hashSHA256.ComputeHash(stream);

                    sha256HashLabel.Text = BitConverter
                        .ToString(sha256)
                        .Replace("-", "")
                        .ToUpperInvariant();
                }

                if (sha384CheckBox.Checked)
                {
                    using var stream = File.OpenRead(openFileDialog.FileName);

                    using var hashSHA384 = SHA384.Create();

                    var sha384 = hashSHA384.ComputeHash(stream);

                    sha384HashLabel.Text = BitConverter
                        .ToString(sha384)
                        .Replace("-", "")
                        .ToUpperInvariant();
                }

                if (crc32CheckBox.Checked)
                {
                    var fileBytes = File.ReadAllBytes(openFileDialog.FileName);

                    var crc32 = Crc32.Hash(fileBytes);

                    crc32HashLabel.Text = BitConverter
                        .ToString(crc32)
                        .Replace("-", "")
                        .ToUpperInvariant();
                }
            }
            catch(Exception ex) 
            {
                textBox1.Text = $"{ex.Message}";
            }
            
        }
        private void Save_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("Hash.txt", true))
            {
                sw.WriteLine($"MD5 - {md5HashLabel.Text}, SHA1 - {sha1HashLabel.Text}, SHA256 - {sha256HashLabel.Text}, SHA384 - {sha384HashLabel.Text}, CRC32 - {crc32HashLabel.Text}");
            }
        }

        private void Review_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Чи сподобався вам калькулятор?", "Review", MessageBoxButtons.YesNo);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}