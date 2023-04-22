using Microsoft.VisualBasic.FileIO;
using MsgKit;
using System.Diagnostics;

namespace Msg_Creation
{
    public partial class Form1 : Form
    {
        private DateTime startDate;
        private DateTime endDate;
        private string selectedFolder;
        private string selectedFilePath;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSelectRange_Click(object sender, EventArgs e)
        {
            startDate = dtpStartDate.Value;
            endDate = dtpEndDate.Value;
            Debug.WriteLine(startDate);

            
            // Do something with the selected date range...
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ensuring all other is disabled during generating, cause we dont mess or corrupt the process 
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            outputDirectory.Enabled = false;
            selectCSV.Enabled = false; 

            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                using (TextFieldParser parser = new TextFieldParser(selectedFilePath))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(";");

                    // Loop through each line of the file
                    while (!parser.EndOfData)
                    {
                        // Get the current line and split it into an array of values
                        string[] fields = parser.ReadFields();

                        
                        string column1 = fields[0];
                        string column2 = fields[1];
                        string column3 = fields[2];
                        Debug.WriteLine(column1);
                        Debug.WriteLine(column2);
                        Debug.WriteLine(column3);
                        using (var email = new Email(
                              new Sender($"{column2}", $"{column1}"),
                              new Representing("", ""),
                                  ""))
                        {
                            email.Recipients.AddTo("testmail@gmail.com", "VAGGOS VAL");
                            email.Subject = "ΑΝΑΓΓΕΛΙΑ ΠΑΡΟΥΣΙΩΝ";
                            email.SentOn = currentDate;
                            email.BodyHtml = "<html><head></head><body>Σήμερα στις παρευρέθηκαν στην πρακτική</body></html>";
                            string date1 = currentDate.ToString("MM-dd-yyy");
                            Directory.CreateDirectory($"{selectedFolder}\\{date1}");
                            email.Save($@"{selectedFolder}\{date1}\{column3}.msg");
                            //Debug.WriteLine(date1);
                        }


                        
                    }
                }
                
            }
            /*  
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            outputDirectory.Enabled = true;
            selectCSV.Enabled = true;*/

        }

        private void outDirectory_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                // Set the initial directory for the dialog
                dialog.SelectedPath = "C:\\";

                // Show the dialog and get the result
                DialogResult result = dialog.ShowDialog();

                
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    // The user selected a directory
                    selectedFolder = dialog.SelectedPath;
                    //Debug.WriteLine(selectedFolder);

                    
                }
            }
        }

        private void selectCSV_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                // Set the initial directory for the dialog
                dialog.InitialDirectory = "C:\\";
                dialog.Filter = "CSV files (*.csv)|*.csv";

                // Show the dialog and get the result
                DialogResult result = dialog.ShowDialog();

                // Process the result
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
                {
                    // The user selected a file
                    selectedFilePath = dialog.FileName;

                    // Get the directory from the selected file path
                    //string selectedFile = Path.GetDirectoryName(selectedFilePath);
                    //Debug.WriteLine(selectedFile);
                    

                    
                }
            }

        }
    }
}