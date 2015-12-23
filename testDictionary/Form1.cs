using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testDictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SMSDecode sms = new SMSDecode();
            textBox2.Text = sms.decode(textBox1.Text);
        }
    }

    class SMSDecode
    {
        Dictionary<string, char> smsTH = new Dictionary<string, char>();
        public SMSDecode()
        {
            smsTH.Add("0000", ' ');
            smsTH.Add("0001", ' ');
            smsTH.Add("0002", ' ');
            smsTH.Add("0003", ' ');
            smsTH.Add("0004", ' ');
            smsTH.Add("0005", ' ');
            smsTH.Add("0006", ' ');
            smsTH.Add("0007", ' ');
            smsTH.Add("0008", ' ');
            smsTH.Add("0009", ' ');
            smsTH.Add("000A", ' ');
            smsTH.Add("000B", ' ');
            smsTH.Add("000C", ' ');
            smsTH.Add("000D", ' ');
            smsTH.Add("000E", ' ');
            smsTH.Add("000F", ' ');
            smsTH.Add("0010", ' ');
            smsTH.Add("0011", ' ');
            smsTH.Add("0012", ' ');
            smsTH.Add("0013", ' ');
            smsTH.Add("0014", ' ');
            smsTH.Add("0015", ' ');
            smsTH.Add("0016", ' ');
            smsTH.Add("0017", ' ');
            smsTH.Add("0018", ' ');
            smsTH.Add("0019", ' ');
            smsTH.Add("001A", ' ');
            smsTH.Add("001B", ' ');
            smsTH.Add("001C", ' ');
            smsTH.Add("001D", ' ');
            smsTH.Add("001E", ' ');
            smsTH.Add("001F", ' ');
            smsTH.Add("0020", ' ');
            smsTH.Add("0021", '!');
            smsTH.Add("0022", '"');
            smsTH.Add("0023", '#');
            smsTH.Add("0024", '$');
            smsTH.Add("0025", '%');
            smsTH.Add("0026", '&');
            smsTH.Add("0027", '\'');
            smsTH.Add("0028", '(');
            smsTH.Add("0029", ')');
            smsTH.Add("002A", '*');
            smsTH.Add("002B", '+');
            smsTH.Add("002C", ',');
            smsTH.Add("002D", '-');
            smsTH.Add("002E", '.');
            smsTH.Add("002F", '/');
            smsTH.Add("0030", '0');
            smsTH.Add("0031", '1');
            smsTH.Add("0032", '2');
            smsTH.Add("0033", '3');
            smsTH.Add("0034", '4');
            smsTH.Add("0035", '5');
            smsTH.Add("0036", '6');
            smsTH.Add("0037", '7');
            smsTH.Add("0038", '8');
            smsTH.Add("0039", '9');
            smsTH.Add("003A", ':');
            smsTH.Add("003B", ';');
            smsTH.Add("003C", '<');
            smsTH.Add("003D", '=');
            smsTH.Add("003E", '>');
            smsTH.Add("003F", '?');
            smsTH.Add("0040", '@');
            smsTH.Add("0041", 'A');
            smsTH.Add("0042", 'B');
            smsTH.Add("0043", 'C');
            smsTH.Add("0044", 'D');
            smsTH.Add("0045", 'E');
            smsTH.Add("0046", 'F');
            smsTH.Add("0047", 'G');
            smsTH.Add("0048", 'H');
            smsTH.Add("0049", 'I');
            smsTH.Add("004A", 'J');
            smsTH.Add("004B", 'K');
            smsTH.Add("004C", 'L');
            smsTH.Add("004D", 'M');
            smsTH.Add("004E", 'N');
            smsTH.Add("004F", 'O');
            smsTH.Add("0050", 'P');
            smsTH.Add("0051", 'Q');
            smsTH.Add("0052", 'R');
            smsTH.Add("0053", 'S');
            smsTH.Add("0054", 'T');
            smsTH.Add("0055", 'U');
            smsTH.Add("0056", 'V');
            smsTH.Add("0057", 'W');
            smsTH.Add("0058", 'X');
            smsTH.Add("0059", 'Y');
            smsTH.Add("005A", 'Z');
            smsTH.Add("005B", '[');
            smsTH.Add("005C", '\\');
            smsTH.Add("005D", ']');
            smsTH.Add("005E", '^');
            smsTH.Add("005F", '_');
            smsTH.Add("0060", '\'');
            smsTH.Add("0061", 'a');
            smsTH.Add("0062", 'b');
            smsTH.Add("0063", 'c');
            smsTH.Add("0064", 'd');
            smsTH.Add("0065", 'e');
            smsTH.Add("0066", 'f');
            smsTH.Add("0067", 'g');
            smsTH.Add("0068", 'h');
            smsTH.Add("0069", 'i');
            smsTH.Add("006A", 'j');
            smsTH.Add("006B", 'k');
            smsTH.Add("006C", 'l');
            smsTH.Add("006D", 'm');
            smsTH.Add("006E", 'n');
            smsTH.Add("006F", 'o');
            smsTH.Add("0070", 'p');
            smsTH.Add("0071", 'q');
            smsTH.Add("0072", 'r');
            smsTH.Add("0073", 's');
            smsTH.Add("0074", 't');
            smsTH.Add("0075", 'u');
            smsTH.Add("0076", 'v');
            smsTH.Add("0077", 'w');
            smsTH.Add("0078", 'x');
            smsTH.Add("0079", 'y');
            smsTH.Add("007A", 'z');
            smsTH.Add("007B", '{');
            smsTH.Add("007C", '|');
            smsTH.Add("007D", '}');
            smsTH.Add("007E", '~');
            smsTH.Add("007F", ' ');


            smsTH.Add("0E00", ' ');
            smsTH.Add("0E01", 'ก');
            smsTH.Add("0E02", 'ข');
            smsTH.Add("0E03", 'ฃ');
            smsTH.Add("0E04", 'ค');
            smsTH.Add("0E05", 'ฅ');
            smsTH.Add("0E06", 'ฆ');
            smsTH.Add("0E07", 'ง');
            smsTH.Add("0E08", 'จ');
            smsTH.Add("0E09", 'ฉ');
            smsTH.Add("0E0A", 'ช');
            smsTH.Add("0E0B", 'ซ');
            smsTH.Add("0E0C", 'ฌ');
            smsTH.Add("0E0D", 'ญ');
            smsTH.Add("0E0E", 'ฎ');
            smsTH.Add("0E0F", 'ฏ');
            smsTH.Add("0E10", 'ฐ');
            smsTH.Add("0E11", 'ฑ');
            smsTH.Add("0E12", 'ฒ');
            smsTH.Add("0E13", 'ณ');
            smsTH.Add("0E14", 'ด');
            smsTH.Add("0E15", 'ต');
            smsTH.Add("0E16", 'ถ');
            smsTH.Add("0E17", 'ท');
            smsTH.Add("0E18", 'ธ');
            smsTH.Add("0E19", 'น');
            smsTH.Add("0E1A", 'บ');
            smsTH.Add("0E1B", 'ป');
            smsTH.Add("0E1C", 'ผ');
            smsTH.Add("0E1D", 'ฝ');
            smsTH.Add("0E1E", 'พ');
            smsTH.Add("0E1F", 'ฟ');
            smsTH.Add("0E20", 'ภ');
            smsTH.Add("0E21", 'ม');
            smsTH.Add("0E22", 'ย');
            smsTH.Add("0E23", 'ร');
            smsTH.Add("0E24", 'ฤ');
            smsTH.Add("0E25", 'ล');
            smsTH.Add("0E26", 'ฦ');
            smsTH.Add("0E27", 'ว');
            smsTH.Add("0E28", 'ศ');
            smsTH.Add("0E29", 'ษ');
            smsTH.Add("0E2A", 'ส');
            smsTH.Add("0E2B", 'ห');
            smsTH.Add("0E2C", 'ฬ');
            smsTH.Add("0E2D", 'อ');
            smsTH.Add("0E2E", 'ฮ');
            smsTH.Add("0E2F", 'ฯ');
            smsTH.Add("0E30", 'ะ');
            smsTH.Add("0E31", 'ั');
            smsTH.Add("0E32", 'า');
            smsTH.Add("0E33", 'ำ');
            smsTH.Add("0E34", 'ิ');
            smsTH.Add("0E35", 'ี');
            smsTH.Add("0E36", 'ึ');
            smsTH.Add("0E37", 'ื');
            smsTH.Add("0E38", 'ุ');
            smsTH.Add("0E39", 'ู');
            smsTH.Add("0E3A", ' ');
            smsTH.Add("0E3B", ' ');
            smsTH.Add("0E3C", ' ');
            smsTH.Add("0E3D", ' ');
            smsTH.Add("0E3E", ' ');
            smsTH.Add("0E3F", '฿');
            smsTH.Add("0E40", 'เ');
            smsTH.Add("0E41", 'แ');
            smsTH.Add("0E42", 'โ');
            smsTH.Add("0E43", 'ใ');
            smsTH.Add("0E44", 'ไ');
            smsTH.Add("0E45", 'า');
            smsTH.Add("0E46", 'ๆ');
            smsTH.Add("0E47", '็');
            smsTH.Add("0E48", '่');
            smsTH.Add("0E49", '้');
            smsTH.Add("0E4A", '๊');
            smsTH.Add("0E4B", '๋');
            smsTH.Add("0E4C", '์');
            smsTH.Add("0E4D", 'ํ');
            smsTH.Add("0E4E", ' ');
            smsTH.Add("0E4F", ' ');
            smsTH.Add("0E50", '๐');
            smsTH.Add("0E51", '๑');
            smsTH.Add("0E52", '๒');
            smsTH.Add("0E53", '๓');
            smsTH.Add("0E54", '๔');
            smsTH.Add("0E55", '๕');
            smsTH.Add("0E56", '๖');
            smsTH.Add("0E57", '๗');
            smsTH.Add("0E58", '๘');
            smsTH.Add("0E59", '๙');
            smsTH.Add("0E5A", ' ');
            smsTH.Add("0E5B", ' ');
            smsTH.Add("0E5C", ' ');
            smsTH.Add("0E5D", ' ');
            smsTH.Add("0E5E", ' ');
            smsTH.Add("0E5F", ' ');
            smsTH.Add("0E60", ' ');
            smsTH.Add("0E61", ' ');
            smsTH.Add("0E62", ' ');
            smsTH.Add("0E63", ' ');
            smsTH.Add("0E64", ' ');
            smsTH.Add("0E65", ' ');
            smsTH.Add("0E66", ' ');
            smsTH.Add("0E67", ' ');
            smsTH.Add("0E68", ' ');
            smsTH.Add("0E69", ' ');
            smsTH.Add("0E6A", ' ');
            smsTH.Add("0E6B", ' ');
            smsTH.Add("0E6C", ' ');
            smsTH.Add("0E6D", ' ');
            smsTH.Add("0E6E", ' ');
            smsTH.Add("0E6F", ' ');
            smsTH.Add("0E70", ' ');
            smsTH.Add("0E71", ' ');
            smsTH.Add("0E72", ' ');
            smsTH.Add("0E73", ' ');
            smsTH.Add("0E74", ' ');
            smsTH.Add("0E75", ' ');
            smsTH.Add("0E76", ' ');
            smsTH.Add("0E77", ' ');
            smsTH.Add("0E78", ' ');
            smsTH.Add("0E79", ' ');
            smsTH.Add("0E7A", ' ');
            smsTH.Add("0E7B", ' ');
            smsTH.Add("0E7C", ' ');
            smsTH.Add("0E7D", ' ');
            smsTH.Add("0E7E", ' ');
            smsTH.Add("0E7F", ' ');
        }

        public string decode(string smsText)
        {
            int i = 0;
            string smstext = "";
            string tmpText = "";
            while (i < smsText.Length)
            {
                tmpText = smsText.Substring(i, 4);
                i += 4;
                if (smsTH.ContainsKey(tmpText))
                {
                    smstext += smsTH[tmpText];
                }
            }
            return smstext;
        }

    }
}
