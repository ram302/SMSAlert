using System;
using System.Windows.Forms;
using Twilio;
using Twilio.Exceptions;
using Twilio.Rest.Api.V2010;
using System.Configuration;
using Twilio.Rest.Api.V2010.Account;

namespace SMSAlert
{
    public partial class Main : Form
    {
        /*
         * Set the following fields as environment variables in my system:
         *      - RUN sysdm.cpl
         *           - Advanced
         *           - Environment Variables
         *           - Added under System Variables
         */
        string TWILIO_SID = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
        string TWILIO_AUTH = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");

        // Twilio provided a number; find in App.config
        string TWILIO_PHONE = ConfigurationManager.AppSettings["TWILIO_PHONE"];

        

        public Main()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                TwilioClient.Init(TWILIO_SID, TWILIO_AUTH);

                var message = MessageResource.Create(
                    body: SMS_Input.Text,
                    from: new Twilio.Types.PhoneNumber(TWILIO_PHONE),
                    to: new Twilio.Types.PhoneNumber("+16468314967")
                );
            }
            catch(Twilio.Exceptions.ApiException ex)
            {
                // Implement a logger here?
            }
            finally
            {
                // Something to do in all cases here.
            }
        }
    }
}
