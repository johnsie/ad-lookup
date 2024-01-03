using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_Lookup
{
    public partial class frmUserLookup : Form
    {
        public frmUserLookup()
        {
            InitializeComponent();
        }

        private void user_lookup_Load(object sender, EventArgs e)
        {
       //     ListUsers();
        }

        private void cmdUserLookup_Click(object sender, EventArgs e)
        {
           

        //  DisplayUserInfo()
        }

        private void CmdResetPass_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == txtNewPassConfirm.Text)
            {

                //net user /domain USERNAME NEWPASS

                String CmdText = @"user /domain " + txtUsername.Text + " "+txtNewPass.Text;

                Process proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "net.exe",
                        Arguments = CmdText,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };

                proc.Start();
                String cmdOutput = proc.StandardOutput.ReadToEnd();
                MessageBox.Show("The password for this user has been reset");

            }

            else
            {
                MessageBox.Show("Passwords didn't match");   
             }
        }

        private void cmdUnlockUser_Click(object sender, EventArgs e)
        {
            //   Net user loginid / ACTIVE:YES / domain



  

            String CmdText = @"user " + txtUsername.Text + " /ACTIVE:YES  /domain";

            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "net.exe",
                    Arguments = CmdText,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            String cmdOutput = proc.StandardOutput.ReadToEnd();
            MessageBox.Show("The user has been unlocked");


        }

        private void cmdShowInactiveUsers_Click(object sender, EventArgs e)
        {


            //Clear the list of users
            lstUsers.Items.Clear();
            //Get all the users
            //NET USERS / DOMAIN > USERS.TXT





            String finalOutput ="";
            String CmdText = @"users  /domain";
            //Message
            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "net.exe",
                    Arguments = CmdText,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            String cmdOutput = proc.StandardOutput.ReadToEnd();


            cmdOutput = RemoveFirstLines(cmdOutput, 8);

            //Now parse out the names
            using (StringReader reader = new StringReader(cmdOutput))
            {
                string line = string.Empty;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        // do something with the line

                        string[] adusers = line.Split(' ');

                        foreach (var aduser in adusers)
                        {
                            if(!(aduser==""))
                            {
                                System.Console.WriteLine($"<{aduser}>");
                                finalOutput = finalOutput + "\r\n" + aduser;

                                if (CheckIfUserIsInActive(aduser))
                                    {

                                    lstUsers.Items.Add(aduser);
                                    }//end check to see if the user is
                            }
               
                        }



                    }

                } while (line != null);
            }



            lstUsers.Sorted = true;

            txtUserLookupReponse.Text = finalOutput;


        }



        public static bool CheckIfUserIsInActive(string aduser) {


            //find out when the user last logged itn
            //net user administrator | findstr / B / C:"Last logon"
            String finalOutput = "";
            String CmdText = @"users  /domain";


            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "net.exe",
                    Arguments = CmdText,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            String cmdOutput = proc.StandardOutput.ReadToEnd();


            cmdOutput = RemoveFirstLines(cmdOutput, 8);




            //if the user logged in recentle
            //return true
            //else
            //return false

            return false;
        
        }//end check if user is inactive

  


        public static string RemoveFirstLines(string text, int linesCount)
        {
            var lines = Regex.Split(text, "\r\n|\r|\n").Skip(linesCount);
            return string.Join(Environment.NewLine, lines.ToArray());
        }








        public void ListUsers()
        {

            //NET USERS / DOMAIN > USERS.TXT
            String finalOutput = "";
            String CmdText = @"users  /domain";
            //Message
            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "net.exe",
                    Arguments = CmdText,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            String cmdOutput = proc.StandardOutput.ReadToEnd();


            cmdOutput = RemoveFirstLines(cmdOutput, 8);

            //Now parse out the names
            using (StringReader reader = new StringReader(cmdOutput))
            {
                string line = string.Empty;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        // do something with the line

                        string[] words = line.Split(' ');

                        foreach (var word in words)
                        {
                            if (!(word == ""))
                            {
                                //      System.Console.WriteLine($"<{word}>");
                                //     finalOutput = finalOutput + "\r\n" + word;
                              
                                lstUsers.Items.Add(word);
                                lstTemp.Items.Add(word);

                            }

                        }



                    }

                } while (line != null);
            }






        }//end ListUsers





        public void DisplayUser(string username)
        {

            String CmdText = @"user " + username + " /domain";
            //Message
            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "net.exe",
                    Arguments = CmdText,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            String cmdOutput = proc.StandardOutput.ReadToEnd();
            txtUserLookupReponse.Text = cmdOutput;

        }//end void displayuser

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayUser(lstUsers.SelectedItem.ToString());

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
     
            SearchByUser();
        }

      private void SearchByUser() {

            lstUsers.Items.Clear();
            for (int i = lstTemp.Items.Count - 1; i >= 0; i--)
            {

                if (lstTemp.Items[i].ToString().Contains(txtUsername.Text.ToString()))
                {
                    String[] strPieces = lstTemp.Items[i].ToString().Split('|');
                    lstUsers.Items.Add(strPieces[0]);
                  
                }//end if
            }

            lstUsers.Sorted= true;

        }//end void

        private void lstTemp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
        private void cmdLookupUser_Click(object sender, EventArgs e)
        {
            DisplayUser(txtUsername.Text);

        }

    
        
    }
}
