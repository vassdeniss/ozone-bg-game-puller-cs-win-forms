using System;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ozone_puller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            Result.Clear();
            if (ConsoleList.CheckedItems.Count > 0)
            {
                for (int i = 0; i < ConsoleList.CheckedItems.Count; i++)
                {
                    string console = string.Empty;
                    switch (ConsoleList.CheckedItems[i].ToString())
                    {
                        case "PS5":
                            console = "ps5";
                            break;
                        case "PS4":
                            console = "ps4";
                            break;
                        case "pc":
                            console = "pc";
                            break;
                        case "Xbox One":
                            console = "xbox-one";
                            break;
                        case "Nintendo Switch":
                            console = "nintendo-switch";
                            break;
                    }
                    for (int j = 0; j < 50; j++)
                    {
                        WebClient client = new WebClient();
                        string htmlCode;
                        try
                        {
                            htmlCode = client.DownloadString($"https://www.ozone.bg/gaming/igri/{console}/?p={j}");
                        }
                        catch (Exception)
                        {
                            Result.Text += "\nThat is everything!";
                            break;
                        }

                        Regex regex = new Regex(@"productData.*?ids:.*?value:'(?<price>.*?)',.*?currency:'(?<currency>.*?)',.*?name:'(?<name>.*?)'.*?<\/script>", RegexOptions.Singleline);

                        MatchCollection matches = regex.Matches(htmlCode);
                        foreach (Match match in matches)
                        {
                            StringBuilder sb = new StringBuilder();

                            string name = match.Groups["name"].Value;
                            string currency = match.Groups["currency"].Value;
                            int price = (int)Math.Ceiling(decimal.Parse(match.Groups["price"].Value));

                            sb.AppendLine(name);
                            sb.AppendLine($"-{price} {currency}");

                            Result.Text += sb.ToString();
                        }
                    }
                }
            }
        }
    }
}
