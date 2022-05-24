using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//  Dodano - za gmail api
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;
// Dodano - ostalo
using System.IO; // filestream
using System.Threading; //CancellationToken
using System.Net.Mail; //mailmessage
using System.Net.Mime; //MediaTypeNames


namespace GmailApiTest
{
    public partial class Form1 : Form
    {
        string[] Scopes = { GmailService.Scope.GmailSend }; // Odabir scope-a.         
        string ApplicationName = "Gmail API TEST";          // Postavljanje imena aplikacije         
        MailMessage message = new MailMessage();            // Varijabla za email poruku  

        // Jednostavna funkcija za konvertiranje u Base64 vrijednost
        // nužno za slanje datoteka u attachmentu 
        string Base64UrlEncode(string input)
        {
            var data = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(data).Replace("+", "-").Replace("/", "_").Replace("=", "");
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        [Obsolete]
        private void button1_Click(object sender, EventArgs e)
        {
            UserCredential credential;
            using (FileStream stream = new FileStream(Application.StartupPath + @"/credentials.json", FileMode.Open, FileAccess.Read))
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                path = Path.Combine(path, ".credentials/gmail-dotnet-quickstart.json");
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                                  GoogleClientSecrets.Load(stream).Secrets,
                                        Scopes,
                                        "user",
                                        CancellationToken.None,
                                        new FileDataStore(path, true)).Result;
            }

            message.To.Add(textBoxTo.Text);                           // Dodaj primatelja email poruke
            if (textBoxCC.Text != "") message.CC.Add(textBoxCC.Text); // Dodaj CC polje (ako nije prazno)
            message.Subject = textBoxSubject.Text;                    // Dodaj Subject email poruke
            message.Body = textBoxMessage.Text;                       // Dodaj sadržaj email poruke
                                                                      // Pretori to u mimeMessage
            MimeKit.MimeMessage mimeMessage = MimeKit.MimeMessage.CreateFromMailMessage(message);


            //pozivanje gmail service-a
            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName
            });
            var msg = new Google.Apis.Gmail.v1.Data.Message(); // kreiranje nove Gmail poruke
            msg.Raw = Base64UrlEncode(mimeMessage.ToString()); // kodiranje poruke u Base64
            service.Users.Messages.Send(msg, "me").Execute();  // slanje emaila

            // Poruka korisniku da je poruka poslana
            MessageBox.Show("Your email has been successfully sent !",
                            "Message",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            // Dodaj attachment, ukoliko polje nije prazno     
            if (textBoxAttachment.Text != "")
            {
                Attachment data = new Attachment(textBoxAttachment.Text, MediaTypeNames.Application.Octet);
                message.Attachments.Add(data);
            }



        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Select A File";
            openDialog.Filter = "Text Files (*.txt)|*.txt" + "|" +
                                "Image Files (*.png;*.jpg)|*.png;*.jpg" + "|" +
                                "Source code files (*.cs)|*.cs" + "|" +
                                "All Files (*.*)|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxAttachment.Text = openDialog.FileName;
            }

        }
    }
}
