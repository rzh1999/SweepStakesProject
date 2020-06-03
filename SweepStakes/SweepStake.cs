using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace SweepStakes
{
    public class SweepStake
    {
        private Dictionary<int, Contestant> _contestants;

        private string name;
        public string Name { get => name; set => name = value; }
       

        public SweepStake(string name)
        {
            this.Name = name;
            _contestants = new Dictionary<int, Contestant>();
        }
        public string SweepStakes() {
            return UserInterface.GetSweepStakesName();
        }

       public void RegisterContestant(Contestant contestant)
        {
            if (contestant != null)
            {
                _contestants.Add(contestant.registrationNumber, contestant);
            }
        }

        public Contestant PickWinner()
        {
            List<int> keyList = new List<int>(_contestants.Keys);

            Random random = new Random();

            int randomKey = keyList[random.Next(keyList.Count)];

            
            var maileMessage = BuildMessage(_contestants[randomKey]);

            SendEmail(maileMessage);
            
            return _contestants[randomKey];
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"Contestant info: {contestant.registrationNumber} {contestant.firstName} {contestant.lastName}");
        }

        public void CreateContestant(int numberOfContestants)
        {
           
            string firstName = null;
            string lastName = null;
            string emailAddress = null;
            for (int i = 0; i < numberOfContestants; i++)
            {
                firstName = UserInterface.GetFirstName();
                lastName = UserInterface.GetLastName();
                emailAddress = UserInterface.GetEmailAddress();
                Contestant contestant = new Contestant(firstName, lastName, emailAddress);
                RegisterContestant(contestant);               
            }

        }

        public MimeMessage BuildMessage(Contestant contestant)
        {
            var mailMessage = new MimeMessage();
            
            mailMessage.From.Add(new MailboxAddress(contestant.firstName, contestant.emailAddress));
            
            mailMessage.To.Add(new MailboxAddress("Billy", "myemailtesterforschool@gmail.com"));
            mailMessage.Subject = "Test";
            mailMessage.Body = new TextPart("plain")
            {
                Text = "Hello"
            };

            return mailMessage;
        }

        public void SendEmail(MimeMessage mimeMessage)
        {
            var smtpClient = new SmtpClient();

            smtpClient.Connect("smtp.gmail.com", 465, true);
            smtpClient.Authenticate("myemailtesterforschool@gmail.com", "*******");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);
        }
    }
}
