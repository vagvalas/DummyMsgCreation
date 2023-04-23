using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MsgKit;

namespace DummyMsgFiles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //string path = System.IO.Path.Combine(Environment.CurrentDirectory, @"C:\users\Vangelis\Desktop\");  
            // I didnt manage to set a path for Desktop, so use relative filenames.
            for (int month = 4; month < 8; month++)                  //set your months
            {
                for (int day = 1; day < 2; day++)
                {
                    if (month == 4 && day == 31)
                    {
                        continue;
                    }
                    if (month == 6 && day == 31)                 //those months doesnt have 31th date and hit an exception on DateTime function
                    {                                            //not OPTIMAL of course, it was for one-time-usage
                        continue;
                    }
                    for (int manari = 0; manari < 5; manari++)
                    {
                        Random rnd = new Random();
                        int hours = rnd.Next(17, 22);  // creates a random hour
                        int minute = rnd.Next(1, 59);   // creates a random minute
                        DateTime date1 = new DateTime(2022, month, day, hours, minute, 00);  //defaul date format
                        string date2 = date1.ToString("dd/MM/yyyy");    //need for naming folders dd-MM-yyyy

                        string[] mails = File.ReadAllLines(@"C:\users\Vangelis\Desktop\emails.txt");
                        string[] manarakia = File.ReadAllLines(@"C:\users\Vangelis\Desktop\manarakia.txt");
                        string[] onomata = File.ReadAllLines(@"C:\users\Vangelis\Desktop\names.txt");        //three arrays need for content
                                                                                                             //the naming was dummy names from internet
                        using (var email = new Email(
                            new Sender($"{mails[manari]}", $"{onomata[manari]}"),
                            new Representing("", ""),
                                ""))
                        {
                            email.Recipients.AddTo("testmail@gmail.com", "VAGGOS VAL");

                            //email.Recipients.AddCc("crocodile@neverland.com", "The evil ticking crocodile");
                            email.Subject = $"ΑΝΑΓΓΕΛΙΑ ΠΑΡΟΥΣΙΩΝ {date2}";

                            email.SentOn = date1;  //we need two date formats, date1, for sent, and date2 for naming on folders
                            string name = "{";
                            

                            email.BodyHtml = $"<html><head></head><body>Σήμερα στις {date2} παρευρέθηκαν στην πρακτική τους άσκηση οι παρακάτω ωφελούμενοι:<br><br>&#9;{manarakia[manari]}<br><br>Ευχαριστώ, <br> {name} </body></html>";
                            string foldername = date1.ToString("MM-dd-yyy");

                            Directory.CreateDirectory($"C:\\users\\Vangelis\\Desktop\\KEKMAILS\\{foldername}");  //create each date
                            email.Save($@"C:\users\Vangelis\Desktop\KEKMAILS\{foldername}\{onomata[manari]}.msg");  //create each message(email) on corresponding date

                            string lastpath = $"C:\\users\\Vangelis\\Desktop\\KEKMAILS\\{foldername}\\{onomata[manari]}.msg";
                            string lastfolder = $"C:\\users\\Vangelis\\Desktop\\KEKMAILS\\{foldername}\\";                      //setting the last forlder, and file for change date
                            File.SetLastWriteTime(lastpath, date1);
                            File.SetCreationTime(lastpath, date1);
                            Directory.SetCreationTime(lastfolder, date1);
                            Directory.SetLastWriteTimeUtc(lastfolder, date1);        //change actually dates, for creation and modified
                        }
                    }
                }
            }
        }
    }
}

