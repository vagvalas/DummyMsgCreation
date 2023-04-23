using Microsoft.VisualBasic.FileIO;
using MsgKit;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Msg_Creation
{
    public partial class Form1 : Form
    {
        private DateTime startDate;
        private DateTime endDate;
        private string selectedFolder;
        private string selectedFilePath;
        private string mainBody;
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
            //TEST PUSH
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            //Ensuring all other is disabled during generating, cause we dont mess or corrupt the process 
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btn_outputDirectory.Enabled = false;
            btn_selectCSV.Enabled = false; 
            txtb_from_email.Enabled = false;
            txtb_from_name.Enabled = false; 
            txtb_subject.Enabled = false;
            txtb_to_email.Enabled = false;
            txtb_to_name.Enabled = false;
            /*string emailFrom = txtb_from_email.Text;
            string nameFrom = txtb_from_name.Text;*/
            string emailTo = txtb_to_email.Text;
            string nameTo = txtb_to_name.Text;
            string subject = txtb_subject.Text;


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
                        string[] csv_fields = parser.ReadFields();

                        
                        string company_name = csv_fields[0];
                        string company_email = csv_fields[1];
                        string individual_name = csv_fields[2];
                        /*Debug.WriteLine(company_name);
                        Debug.WriteLine(company_email);
                        Debug.WriteLine(individual_name);*/
                        richTextBoxBody_Replace(this, EventArgs.Empty, company_name, individual_name, currentDate);
                        using (var email = new Email(
                              new Sender($"{company_email}", $"{company_name}"),
                              new Representing("", ""),
                                  ""))
                        {
                            email.Recipients.AddTo(emailTo, nameTo);
                            email.Subject = subject;
                            email.SentOn = currentDate;
                            email.BodyText = mainBody; //the STRING refers to bodyText not bodyHTML
                            string date1 = currentDate.ToString("MM-dd-yyy");
                            Directory.CreateDirectory($"{selectedFolder}\\{date1}");
                            email.Save($@"{selectedFolder}\{date1}\{individual_name}.msg");
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
        private void richTextBoxBody_Replace(object sender, EventArgs e, string org_name, string person_name, DateTime cur_date)
        {
            // Get the current text content of the RichTextBox
            mainBody = rich_txtb_body.Text;
            mainBody = rich_txtb_body.Text.Replace("\n", Environment.NewLine);
            mainBody = rich_txtb_body.Text.Replace("NAME", person_name).Replace("{DATE}", cur_date.ToString("MM/dd/yyyy"));
            /*// Find all instances of the string "NAME" within the text content
            int index = mainBody.IndexOf("NAME");
            //Debug.WriteLine(person_name);
            while (index != -1)
            {
                // Replace the string "NAME" with the value of your variable using string interpolation
                tempbody = mainBody.Substring(0, index) + $"{person_name}" + mainBody.Substring(index + 4);
                Debug.WriteLine("MPIKE");
                // Find the next occurrence of the string "NAME"
                index = mainBody.IndexOf("NAME", index + 1);
            }*/

            // Update the text content of the RichTextBox with the interpolated values
            //rich_txtb_body.Text = mainBody;
        }
        private void richTextBoxBody_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Debug.WriteLine("ENTER");
                e.SuppressKeyPress = true;  // prevent the default behavior of creating a new paragraph
                rich_txtb_body.AppendText(Environment.NewLine);
                //Debug.WriteLine(rich_txtb_body.Text);// insert a new line character
            }
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