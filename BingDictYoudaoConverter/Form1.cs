using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using BingDictYoudaoConverter.Models;

namespace BingDictYoudaoConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bing2Youdao_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                CheckFileExists = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Filter = "xml 文件|*.xml"
            };
            var ret = openFileDialog.ShowDialog();

            if (ret != DialogResult.OK) return;

            var file = openFileDialog.FileName;

            var bingWords = SerializeHelper.FromXML<PhraseList>(File.ReadAllText(file));

            var ydXml = new XElement("wordbook",
                bingWords.Phrases.Select(x => new XElement("item", 
                    new XElement("word", x.Eng),
                    new XElement("trans", x.Defi),
                    new XElement("phonetic", x.Phonetic),
                    new XElement("tags", "未分"), 
                    new XElement("progress", 0))));

            var saveFileDialog = new SaveFileDialog
            {
                AddExtension = true,
                CheckPathExists = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Filter = "xml 文件|*.xml"
            };

            var saveRet = saveFileDialog.ShowDialog();
            if (saveRet == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, ydXml.ToString());
            }

            MessageBox.Show("转换成功。");
        }

        private void Youdao2Bing_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                CheckFileExists = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Filter = "xml 文件|*.xml"
            };
            var ret = openFileDialog.ShowDialog();

            if (ret != DialogResult.OK) return;

            var file = openFileDialog.FileName;

            var ydElements = XElement.Parse(File.ReadAllText(file));
            var bindgWords = ydElements.Elements("item").Select(element => new Phrase
            {
                Eng = element.Element("word").Value,
                Phonetic = element.Element("phonetic").Value,
                Defi = element.Element("trans").Value,
                Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            }).ToList();

            var phraseList = new PhraseList {Phrases = bindgWords};

            var bingXml = SerializeHelper.ToXml(phraseList);

            var saveFileDialog = new SaveFileDialog
            {
                AddExtension = true,
                CheckPathExists = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Filter = "xml 文件|*.xml"
            };

            var saveRet = saveFileDialog.ShowDialog();
            if (saveRet == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, bingXml.ToString());
            }

            MessageBox.Show("转换成功。");
        }
    }
}
