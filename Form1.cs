// Name:Harshal Thavrani
// Date 22/7/2021
// Student ID: 8733610
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Globalization;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtFirstNameHT_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnSaveHT_Click(object sender, EventArgs e)
        {

            try
            {

                //memberid
                string memberId;
                memberId = txtMemberIdHT.Text.ToUpper();
                txtMemberIdHT.Text = memberId;
                Regex membercode = new Regex(@"^([A-Z]|[0-9])+$");
                if (membercode.IsMatch(memberId))
                {
                    lblErrorMIHT.Text = "";
                }
                else
                {
                    lblErrorMIHT.Visible = true;
                    lblErrorMIHT.Text = "Please write an alpha numeric member ID";
                }
                //firstname
                if (txtFirstNameHT.Text.Length > 0)
                {
                    char[] firstname = txtFirstNameHT.Text.ToCharArray();
                    string fname = firstname[0].ToString().ToUpper();
                    for (int i = 1; i < firstname.Length; i++)
                        fname += firstname[i].ToString().ToLower();
                    txtFirstNameHT.Text = fname;
                }
                txtFirstNameHT.Select(txtFirstNameHT.Text.Length, 0);
                string lineItem;
                string fileName = txtFilePathNameHT.Text;
                if (txtFirstNameHT.Text == "" && txtFirstNameHT.Text.Length < 2)
                {
                    lblerrorfn.Visible = true;
                    lblerrorfn.Text = "First Name Cannot be empty and must be more than two charcters";
                }
                //lastname
                if (txtLastNameHT.Text.Length > 0)
                {
                    char[] lastname = txtLastNameHT.Text.ToCharArray();
                    string lname = lastname[0].ToString().ToUpper();
                    for (int i = 1; i < lastname.Length; i++)
                        lname += lastname[i].ToString().ToLower();
                    txtLastNameHT.Text = lname;
                }
                txtLastNameHT.Select(txtLastNameHT.Text.Length, 0);
                if (txtLastNameHT.Text == "" && txtLastNameHT.Text.Length < 2)
                {
                    lblerrorln.Visible = true;
                    lblerrorln.Text = "Last Name Cannot be empty and must be more than two charcters";
                }
                //date
                string Date = txtDateRegisteredHT.Text;
                
                DateTime dateTimeObj;
                if (DateTime.TryParse(txtDateRegisteredHT.Text, out dateTimeObj))
                {
                    if (dateTimeObj > DateTime.Today)
                        lblerrordr.Text = "Date must not be in the future";
                    else
                        txtDateRegisteredHT.Text = Date.ToString();
                }
                else
                {
                    lblerrordr.Visible = true;
                    lblerrordr.Text = "Date is Not Valid Please Write in 12/05/2021 Form";
                }
                //numbofclass
                string numberofclass;
                numberofclass = txtNumberOfClassesHT.Text;
                txtNumberOfClassesHT.Text = numberofclass;
                Regex Numbofclass = new Regex(@"^[0-9]+");
                if (Numbofclass.IsMatch(numberofclass.ToString()))
                {
                    lblerrornoc.Text = "";
                }
                else
                {

                    lblerrornoc.Visible = true;
                    lblerrornoc.Text = "Please write a valid whole number in Number Of Classes";
                }
                //totalcostperclass
                try
                {
                    if (txtTotalCostPerClassHT.Text != "")
                    {
                        int totalcostperclass;
                        totalcostperclass = int.Parse(txtTotalCostPerClassHT.Text);
                        txtTotalCostPerClassHT.Text = totalcostperclass.ToString();
                        Regex Currency = new Regex(@"^[0-9]+");
                        if (Currency.IsMatch(totalcostperclass.ToString()))
                        {
                            lbltcpc.Text = "";
                        }
                        else
                        {
                            lbltcpc.Visible = true;
                            lbltcpc.Text = "Please write a valid Currency in Total Cost Per Class";
                        }
                        int totalcostofallclasses;
                        totalcostofallclasses = int.Parse(txtNumberOfClassesHT.Text) * int.Parse(txtTotalCostPerClassHT.Text);
                        txtTotalCostofAllClassesHT.Text = totalcostofallclasses.ToString();
                    }
                    else
                    {
                        lbltcpc.Visible = true;
                        lbltcpc.Text = "You must enter a number for total cost per class";
                    }

                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //totalcostpaid
                try
                {
                    if (txtTotalPaidHT.Text != "")
                    {
                        int totalcostpaid;
                        totalcostpaid = int.Parse(txtTotalPaidHT.Text);
                        txtTotalPaidHT.Text = totalcostpaid.ToString();
                        Regex Currency = new Regex(@"^[0-9]+");
                        if (Currency.IsMatch(totalcostpaid.ToString()))
                        {
                            lbltp.Text = "";
                        }
                        else
                        {
                            lbltp.Visible = true;
                            lbltp.Text = "Please write a valid Currency in Total Paid";
                        }
                        int amountoutstanding;
                        amountoutstanding = int.Parse(txtTotalPaidHT.Text) - int.Parse(txtTotalCostofAllClassesHT.Text);
                        txtAmountOutstandingHT.Text = amountoutstanding.ToString();
                    }
                    else
                    {
                        lbltp.Visible = true;
                        lbltp.Text = "Please write a valid number in Total Paid";
                    }

                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                string line;
                List<string> lst = new List<string>();
                string[] lineContent;
                bool add = true;
                try

                {
                    using (StreamReader sr2 = new StreamReader(txtFilePathNameHT.Text))
                    {
                        while ((line = sr2.ReadLine()) != null)
                        {
                            
                            lineContent = line.Split("\t\t");
                            if (lineContent[0] != txtMemberIdHT.Text)
                            {
                                lst.Add(line);
                            }
                            else
                            {
                                add = false;
                            }
                        }
                    }
                    
                    if (add == true)
                    {
                        using (StreamWriter showrecord = new StreamWriter(fileName, true))
                        {
                            lineItem = txtMemberIdHT.Text.Trim() + "\t\t" +
                                txtFirstNameHT.Text.Trim() + "\t\t" +
                                txtLastNameHT.Text.Trim() + "\t\t" +
                                txtDateRegisteredHT.Text.Trim() + "\t\t" +
                                txtNumberOfClassesHT.Text.Trim() + "\t\t" +
                                "$" + txtTotalCostPerClassHT.Text.Trim() + "\t\t" +
                                "$" + txtTotalCostofAllClassesHT.Text.Trim() + "\t\t" +
                                "$" + txtTotalPaidHT.Text.Trim() + "\t\t" +
                                "$" + txtAmountOutstandingHT.Text.Trim();
                            showrecord.WriteLine(lineItem);
                            showrecord.Flush();
                        }
                    }
                    else
                    {
                        using (StreamWriter showrecord = new StreamWriter(fileName, false))
                        {
                            richTxtbxHT.Clear();
                            for (int i = 0; i < lst.Count; i++)
                            {
                                showrecord.WriteLine(lst[i]);
                                richTxtbxHT.AppendText("\n\r\t" + lst[i]);
                            }
                            lineItem = txtMemberIdHT.Text.Trim() + "\t\t" +
                                txtFirstNameHT.Text.Trim() + "\t\t" +
                                txtLastNameHT.Text.Trim() + "\t\t" +
                                txtDateRegisteredHT.Text.Trim() + "\t\t" +
                                txtNumberOfClassesHT.Text.Trim() + "\t\t" +
                                "$" + txtTotalCostPerClassHT.Text.Trim() + "\t\t" +
                                "$" + txtTotalCostofAllClassesHT.Text.Trim() + "\t\t" +
                                "$" + txtTotalPaidHT.Text.Trim() + "\t\t" +
                                "$" + txtAmountOutstandingHT.Text.Trim();
                            showrecord.WriteLine(lineItem);
                            showrecord.Flush();
                        }
                        richTxtbxHT.Clear();

                        
                    }
                    StreamReader sr = null;
                    string lines;
                    try
                    {
                        richTxtbxHT.Clear();
                        sr = new StreamReader(txtFilePathNameHT.Text);
                        while ((lines = sr.ReadLine()) != null)
                        {
                            richTxtbxHT.AppendText("\n\r\t" + lines);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (sr != null)
                        {
                            sr.Close();
                            sr.Dispose();
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtMemberIdHT.Clear();
            txtFirstNameHT.Clear();
            txtLastNameHT.Clear();
            txtDateRegisteredHT.Clear();
            txtNumberOfClassesHT.Clear();
            txtTotalCostPerClassHT.Clear();
            txtTotalCostofAllClassesHT.Clear();
            txtTotalPaidHT.Clear();
            txtAmountOutstandingHT.Clear();



        }
        private void txtLastNameHT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDateRegisteredHT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumberOfClassesHT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalCostPerClassHT_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtTotalPaidHT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalCostofAllClassesHT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmFileExistsHT_Click(object sender, EventArgs e)
        {
            btnReloadRecordsHT.Enabled = true;
            btnDeleteHT.Enabled = true;
            btnSaveHT.Enabled = true;
            btnEmptyFile.Enabled = true;
            try
            {
                string FileLocation = txtFilePathNameHT.Text;

                string Filedirectory = Directory.GetCurrentDirectory();

                if (!File.Exists(FileLocation))
                {
                    if (txtFilePathNameHT.Text.StartsWith("C:\\") || txtFilePathNameHT.Text.StartsWith("D:\\"))
                    {
                        File.Create(FileLocation).Close();

                    }
                    else
                    {
                        string newfile = (Filedirectory + "\\" + FileLocation);
                        File.Create(newfile).Close();
                        txtFilePathNameHT.Text = newfile;
                        MessageBox.Show("A New File Has Been Created. " + newfile);
                    }
                }
                else
                {

                    StreamReader sr = null;
                    string line;
                    try
                    {
                        richTxtbxHT.Clear();
                        sr = new StreamReader(FileLocation);
                        while ((line = sr.ReadLine()) != null)
                        {
                            richTxtbxHT.AppendText("\n\r\t" + line);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (sr != null)
                        {
                            sr.Close();
                            sr.Dispose();
                        }
                    }
                }
            }
            catch (FileNotFoundException fnex)
            {
                MessageBox.Show(fnex.Message);
            }
            catch (DirectoryNotFoundException dex)
            {
                MessageBox.Show(dex.Message);
            }
            catch (IOException iex)
            {
                MessageBox.Show(iex.Message);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }



        }

        private void txtMemberIdHT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMemberIdHT_Click(object sender, EventArgs e)
        {

        }

        private void txtFilePathNameHT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExitHT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEmptyFile_Click(object sender, EventArgs e)
        {
            File.WriteAllText(txtFilePathNameHT.Text, String.Empty);
            File.WriteAllText(txtFilePathNameHT.Text, String.Empty);
            try
            {

                emptyfile(txtFilePathNameHT.Text, richTxtbxHT);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void emptyfile(string file, RichTextBox txtBox)
        {
            StreamReader emptyfile = null;
            string line;
            try
            {
                txtBox.Clear();
                emptyfile = new StreamReader(file);

                while ((line = emptyfile.ReadLine()) != null)
                {
                    txtBox.AppendText(line + "\r\n");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                if (emptyfile != null)
                {
                    emptyfile.Close();
                    emptyfile.Dispose();

                }
            }


        }

        private void btnReloadRecordsHT_Click(object sender, EventArgs e)
        {
            try
            {

                StreamReader sr = null;
                string lines;
                try
                {
                    richTxtbxHT.Clear();
                    sr = new StreamReader(txtFilePathNameHT.Text);
                    while ((lines = sr.ReadLine()) != null)
                    {
                        richTxtbxHT.AppendText("\n\r\t" + lines);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (sr != null)
                    {
                        sr.Close();
                        sr.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDeleteHT_Click(object sender, EventArgs e)
        {
            
            string line;
            List<string> lst = new List<string>();
            string[] lineContent;
            bool add = true;
            try

            {
                using (StreamReader sr2 = new StreamReader(txtFilePathNameHT.Text))
                {
                    while ((line = sr2.ReadLine()) != null)
                    {

                        lineContent = line.Split("\t\t");
                        if (lineContent[0] != txtMemberIdHT.Text)
                        {
                            lst.Add(line);
                        }
                        else
                        {
                            add = false;
                        }
                    }
                }

                if (add == true)
                {

                    lblerrordel.Text = "Record to be deleted doesnt exist";
                    lblerrordel.Visible = true;
                }
                else
                {
                    using (StreamWriter showrecord = new StreamWriter(txtFilePathNameHT.Text, false))
                    {
                        richTxtbxHT.Clear();
                        for (int i = 0; i < lst.Count; i++)
                        {
                            showrecord.WriteLine(lst[i]);
                            richTxtbxHT.AppendText("\n\r\t" + lst[i]);
                        }
           
                        showrecord.Flush();
                    }
                    richTxtbxHT.Clear();
                    txtMemberIdHT.Text = "";

                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
            }
        
    }
}
