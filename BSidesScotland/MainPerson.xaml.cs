using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Text.RegularExpressions;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BSidesScotland
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPerson : Page
    {
        public MainPerson()
        {
            this.InitializeComponent();
        }

        private void ContinueButton1_Click(object sender, RoutedEventArgs e)
        {
            //verify user input - if invalid return true

            Person myperson = new Person();
            RegexUtilities myreg = new RegexUtilities();

            //Combo Box for Title
            var combobox = TitleComboBox;
            var comboboxitem = (ComboBoxItem)TitleComboBox.SelectedItem;
            if (comboboxitem == null)

            {
                DisplayErrorMessage("Select a value for Title", "Input Error");
                myperson.Title = "";
            }
            else
            {
                myperson.Title = comboboxitem.Content.ToString();

            }
            //Combo Box for Categories
            combobox = CategoryComboBox;
            comboboxitem = (ComboBoxItem)CategoryComboBox.SelectedItem;
            if (comboboxitem == null)
            {
                DisplayErrorMessage("Select a value for Category", "Input Error");
                myperson.Category = "";
            }
            else
            {
                myperson.Category = comboboxitem.Content.ToString();
            }

            myperson.FirstName = FirstNameTextBox.Text;
            if  (! ValidateAlpha(myperson.FirstName))
                {
                DisplayErrorMessage("Incorrect value for field - ", "Input Error","First Name", FirstNameTextBox);
            }
            myperson.SurName = SurnameTextBox.Text;
            if (! ValidateAlphaSpecial(myperson.SurName))
            {
                DisplayErrorMessage("Incorrect value for field - ", "Input Error", "Surname", SurnameTextBox);
            }
            myperson.Mobile = MobileTextBox.Text;
            if (!ValidateNumeric(myperson.Mobile))
            {
                DisplayErrorMessage("Incorrect value for field - ", "Input Error", "Mobile Number", MobileTextBox);
            }
            myperson.Email = EmailTextBox.Text;
            myreg.emailaddress = myperson.Email;
            if ( ! myreg.IsValidEmail(EmailTextBox.Text))
                {
                DisplayErrorMessage("Incorrect value for field - ", "Input Error", "Email Address", EmailTextBox);
            }
        }

        private bool ValidateAlpha (string alphavalue)
        {

            if (alphavalue=="")
            {
                return false;
            }
            Regex rgx = new Regex(@"^[a-zA-Z][a-zA-Z]*$");
            if (! rgx.IsMatch(alphavalue))
            {
                return false;
            }
            return true;
        }

        private bool ValidateAlphaSpecial(string alphanumericvalue)
        {

            if (alphanumericvalue == "")
            {
                return false;
            }
            Regex rgx = new Regex(@"^[a-z,.'A-Z][a-zA-Z,.']*$");
            if (!rgx.IsMatch(alphanumericvalue))
            {
                return false;
            }
            return true;
        }


        private bool ValidateNumeric(string numericvalue)
        {

            if (numericvalue == "")
            {
                return false;
            }
            Regex rgx = new Regex(@"^[0-9][0-9]*$");
            if (!rgx.IsMatch(numericvalue))
            {
                return false;
            }
            return true;
        }
        private async void DisplayErrorMessage(string message, string caption, string inputfield, TextBox txt)
        {
            message = message += " " + inputfield;
            var dialog = new MessageDialog(message, caption);
            await dialog.ShowAsync();
            txt.SelectAll();
            txt.Text = String.Empty;
        }


        private async void DisplayErrorMessage(string message, string caption, string inputfield, ComboBox combo)
        {
            message = message += " " + inputfield;
            var dialog = new MessageDialog(message, caption);
            await dialog.ShowAsync();
        }

        private async void DisplayErrorMessage(string message, string caption)
        {
            var dialog = new MessageDialog(message, caption);
            await dialog.ShowAsync();
            
        }


        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
