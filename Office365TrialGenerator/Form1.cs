using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using System.IO;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Office365TrialGenerator
{
    public partial class office365TrialGenFrm : Form
    {
        string challengeCode = "";
        public office365TrialGenFrm()
        {
            InitializeComponent();            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OverviewLbl_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void SendSMSBtn_Click(object sender, EventArgs e)
        {

            //Set the country code based on the combo box selection
            var countryAssignment = regionTxt.SelectedIndex;
            int countryCode = 0;
            switch (countryAssignment)
            {
                case 0:
                    countryCode = 1;
                    break;
                case 1:
                    countryCode = 353;
                    break;
                default:
                    countryCode = 1;
                    break;
            }

            //Perform the API call to send the SMS message
            try
            {
                var client = new RestClient("https://signup.microsoft.com");
                var request = new RestRequest("/api/signupservice/hipchallenge?api-version=1&client-request-id=695790c5-7fbc-45b9-9217-304e509000ae&culture=en-us");
                request.AddParameter("application/json", ParameterType.RequestBody);
                request.AddParameter("phoneNumber", phoneNumberTxt.Text);
                request.AddParameter("phoneCountryCode", countryCode);
                request.AddParameter("useVoice", false);
                request.AddParameter("emailAddress", emailAddressTxt.Text);
                var response = client.Post(request);             
                var obj = JsonConvert.DeserializeObject<dynamic>(response.Content.ToString());             
                challengeCode = obj["challengeId"];
                Console.WriteLine(response.IsSuccessful);                
                Console.WriteLine(challengeCode);                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void AuthBtn_Click(object sender, EventArgs e)
        {
            var countryAssignment = regionTxt.SelectedIndex;
            int countryCode = 0;
            switch (countryAssignment)
            {
                case 0:
                    countryCode = 1;
                    break;
                case 1:
                    countryCode = 353;
                    break;
                default:
                    countryCode = 1;
                    break;
            }
            try
            {
                var client = new RestClient("https://signup.microsoft.com/api/signupservice/verifyhipchallenge?api-version=1&client-request-id=695790c5-7fbc-45b9-9217-304e509000ae&culture=en-us");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                //request.AddParameter("application/json", "{\r\"HipChallengeResponse\": {\r\n\"challengeId\": \"challengeCode\",\r\n\"challengeAnswer\": \"954095\"\r\n  },\r\n  \"ContextData\": {\r\n    \"regionCode\": \"IE\",\r\n    \"firstName\": \"The\",\r\n    \"lastName\": \"Dude\",\r\n    \"emailAddress\": \"devildante1005@yahoo.com\",\r\n    \"phoneNumber\": \"1234567890\",\r\n    \"organizationName\": \"Company\",\r\n    \"domainName\": \"\"\r\n  }\r\n}", ParameterType.RequestBody);
                request.AddJsonBody(new { HipChallengeResponse = new { challengeId = challengeCode, challengeAnswer = challengeAnswerTxt.Text }, ContextData = new { regionCode = countryCode, firstName = fNameTxt.Text, lastName = lNameTxt.Text, emailAddress = emailAddressTxt.Text, phoneNumber = phoneNumberTxt.Text, organizationName = orgNameTxt.Text, domainName = ""} });                
                IRestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
                Console.WriteLine(challengeCode);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient("https://signup.microsoft.com/api/signupservice/adminsignup?api-version=1&client-request-id=695790c5-7fbc-45b9-9217-304e509000ae&culture=en-us");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                //request.AddJsonBody(new { AdminAccountInfo = new { userId = userIdTxt.Text, domainName = domainNameTxt.Text, password = passwordTxt.Text, domainPurchaseOption = 0 }, AdminContactPreferences = new { emailContactPreference = false, phoneContactPreference = false, partnerContactPreference = false }, OfferIds = "[b07a1127 - de83 - 4a6d - 9f85 - 2c104bdae8b4]", SkipAuxiliaryPostSignupActions = true, AdminUserInfo = new { regionCode = "IE", firstName = fNameTxt.Text, lastName = lNameTxt.Text, emailAddress = emailAddressTxt.Text, phoneNumber = phoneNumberTxt.Text, organizationName = orgNameTxt.Text, organizationSize = "1" } });
                request.AddJsonBody(new { AdminAccountInfo = new { userId = userIdTxt.Text, domainName = domainNameTxt.Text, password = passwordTxt.Text, domainPurchaseOption = 0 }, AdminContactPreferences = new { emailContactPreference = false, phoneContactPreference = false, partnerContactPreference = false }, SkipAuxiliaryPostSignupActions = true, AdminUserInfo = new { regionCode = regionTxt.Text, firstName = fNameTxt.Text, lastName = lNameTxt.Text, emailAddress = emailAddressTxt.Text, phoneNumber = phoneNumberTxt.Text, organizationName = orgNameTxt.Text, organizationSize = "1" } });
                IRestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
                string result = " ";
                if (response.IsSuccessful == true)
                {
                    result = "Success! A text file has been saved to your desktop with your account details.";
                    var successMessage = MessageBox.Show(result, "Closing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    result = "Failed";
                    var failureMessage = MessageBox.Show(result, "Closing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                //Save created credentials to a text file on the users desktop
                string desktopPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
                if (!File.Exists("Office365TrialCredentials.txt")) //Checks to see if the file exists
                {
                    //FileStream fs = new FileStream(desktopPath),
                    File.Create(desktopPath+@"\Office365TrialCredentials.txt").Close(); //Create the file
                    using (StreamWriter sw = File.AppendText(desktopPath+@"\Office365TrialCredentials.txt"))
                    {
                        sw.WriteLine("The account generated is an empty Office 365 Account that you can add any products to that you need to test with.\r\n");
                        sw.WriteLine("You can access this account by going to the Office 365 login page and using the generated credentials while the trial lasts.\r\n");
                        sw.WriteLine("This account was created on " + DateTime.Now + " and will expire on " + DateTime.Now.AddDays(30)+ "\r\n");
                        sw.WriteLine("Username: "+userIdTxt.Text + "@" + domainNameTxt.Text + ".onmicrosoft.com");
                        sw.WriteLine("Password: " + passwordTxt.Text);
                    }
                }
                else //If file already exists, overwrite it
                {
                    File.WriteAllText(desktopPath+@"\Office365TrialCredentials.txt", String.Empty);
                    using (StreamWriter sw = File.AppendText(desktopPath+@"\Office365TrialCredentials.txt"))
                    {
                        sw.WriteLine("The account generated is an empty Office 365 Account that you can add any products to that you need to test with.\r\n");
                        sw.WriteLine("You can access this account by going to the Office 365 login page and using the generated credentials while the trial lasts.\r\n");
                        sw.WriteLine("This account was created on " + DateTime.Now + " and will expire on " + DateTime.Now.AddDays(30)+"\r\n");
                        sw.WriteLine("Username: " + userIdTxt.Text + "@" + domainNameTxt.Text + ".onmicrosoft.com");
                        sw.WriteLine("Password: " + passwordTxt.Text);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }           
        }
    }
}
