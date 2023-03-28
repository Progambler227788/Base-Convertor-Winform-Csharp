using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Convertor_Decimal
{
    public partial class Conversion : Form
    {
        //readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Conversion()
        {
            InitializeComponent();
            //materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

    //******************** BACKEND CODE OF MY CONVERTER *************************************************//

         // Power function 
        public BigInteger power(BigInteger base_value, BigInteger value )
        {
            if (value == 0) return 1;

            return base_value * power(base_value, value - 1);
        }
    /*************************BINARY NUMBER SECTION **********************************/
        public char check_char(BigInteger num)
        {
            char a = 'A';
            BigInteger chek = 10;
            for (int i = 0; i < 6; i++, chek++)
            {
                if (chek == num)
                {
                    return a;
                }
                a++;

            }
            return a;
        }

        // For converting decimal to octal and hexa decimal 
        public string convert_decimal_octal_hexa(BigInteger dec, BigInteger divider)
        {
            string res = "";


            if (divider == 8)
            {
                while (dec != 0)  // Loop for dividng base 10 by base 8
                {
                    res = Convert.ToString(dec % divider) + res;
                    dec /= divider;  // divide by divider passed as 8
                }
                return res;  // in case of 8
            }

            while (dec != 0)  // Loop for dividing base 10 by base 16
            {
                BigInteger rem = dec % divider;
                if (rem >= 10 && rem <= 15)
                    res = check_char(rem) + res;
                else
                    res = Convert.ToString(dec % divider) + res;

                dec /= divider;  // divide by 16
            }

            return res;



        }


        public BigInteger convert_Binary_To_Decimal(string Binary)
        {

            BigInteger res = 0, m = 0;  // Here m is used for indexing from 0 to length, i is starting from last of string
            int i;

            // It is converting binary to decimal notation
            for (i = Binary.Length - 1; i >= 0; i--, m++)
            {

                if (Binary[i] == '1')
                {

                    res += power(2, m); // here m is used as 1 as in 2^1.

                }

            }
            return res;

        }

        // Used to convert Binary to other notations
        public string Convert_Binary(string Binary, BigInteger base_Value) 
        {

            BigInteger res = convert_Binary_To_Decimal(Binary);

            if (base_Value == 8 && res > 7)
            {
                // Doing conversion from  BigInteger to string to octal
                return convert_decimal_octal_hexa(res, 8);
            }


            // Doing conversion from  BigInteger to string to hexadecimal
            else if (base_Value == 16 && res > 9)
            {
                return convert_decimal_octal_hexa(res, 16);
            }

            return res.ToString();


        }

        /*************************END   OF  BINARY NUMBER SECTION **********************************/




        /*************************DECIMAL NUMBER SECTION **********************************/

        public string Convert_Decimal(string Decimal,BigInteger base_value)
        {
            string res = "";

            if (base_value == 2)  // To convert decimal to binary
            {
                res = Decimal_To_Binary(BigInteger.Parse(Decimal));
            }
            else if (base_value == 8) // To convert decimal to octal
            {
                res = convert_decimal_octal_hexa(BigInteger.Parse(Decimal), 8);
            }
            else               // To convert decimal to hexa decimal
                res = convert_decimal_octal_hexa(BigInteger.Parse(Decimal), 16);






            return res;


        }
        // Function used to convert decimal to binary 
        public string Decimal_To_Binary(BigInteger dec)
        {
            
            string bin = "";
            while (dec != 0)
            {    // Used to convert dec result in character like 0 and 1
                bin = (dec % 2).ToString()  + bin;
                dec /= 2;

            }
            return bin;

        }


        /*************************END OF  DECIMAL NUMBER SECTION **********************************/





        /*************************  OCTAL  NUMBER SECTION **********************************/


        public string Convert_Octal(string oct, BigInteger base_value)
        {
            string res = "";

            // Convert octal to decimal then decimal to binary.
            if (base_value == 2)
            {
                res = Decimal_To_Binary(convert_Octal_To_Decimal(oct));

            }
            // Convert octal to decimal 
            else if (base_value == 10)
            {
                res = convert_Octal_To_Decimal(oct).ToString();
            }
            else  // Convert octal to decimal and then to hexadecimal
                res = convert_decimal_octal_hexa(convert_Octal_To_Decimal(oct), 16);




            return res;


        }
        public BigInteger convert_Octal_To_Decimal(string Oct)
        {

            BigInteger res = 0, m = 0;  // Here m is used for indexing from 0 to length, i is starting from last of string
            int i;  // i is used for indexing of characters

            // It is converting binary to decimal notation
            for (i = Oct.Length - 1; i >= 0; i--, m++)
            {


                // 1 * 8^1 + 7 * 8^0 = 8 + 7 = 15  converting 17 to 15 decimal
                res += (Oct[i]-'0' ) * power(8, m); // here m is used as 1 as in 2^1.   

            }
            return res;

        }







        /*************************END   OF  OCTAL NUMBER SECTION **********************************/







        /*************************  HEXADECIMAL  NUMBER SECTION **********************************/

        // convert hexadecimal to decimal

        public BigInteger check_char_hexa(char a)
        {

            BigInteger num = 10;
            char check = 'A';
            for (int i = 0; i < 6; i++, num++, check++)
            {
                if (check == a)
                {
                    return num;
                }

            }
            return -1;
        }

        public BigInteger Convert_Hexa_To_Decimal(string hexa)
        {
            BigInteger res = 0, m = 0;  // Here m is used for indexing from 0 to length, i is starting from last of string
            int i;  // i is used for indexing of characters

            // It is converting binary to decimal notation
            for (i = hexa.Length - 1; i >= 0; i--, m++)
            {
                if (hexa[i]>='A' && hexa[i] <= 'F')
                {
                   res += check_char_hexa(hexa[i]) * power(16, m);
                }
                else
                res += (hexa[i] - '0') * power(16, m); // here m is used as 1 as in 2^1.   

            }
            return res;
        }

        public string Convert_HexaDecimal(string hexa, BigInteger base_value)
        {
            string res = "";
            // Convert hexadecimal to decimal to binary
            if(base_value == 2)
            {
                res = Decimal_To_Binary(Convert_Hexa_To_Decimal(hexa));

            }
            else if (base_value == 10)
            {
                res = Convert_Hexa_To_Decimal(hexa).ToString();
            }
            else
                res = convert_decimal_octal_hexa(convert_Octal_To_Decimal(hexa), 8);

            return res;
        }
        /****************************END OF HEXA SECTION      ************************************************/


        // Reset the all tools of form of conversion
        private void Reset_Click(object sender, EventArgs e)
        {
            m = 0;
            hexr.Visible = octr.Visible = binr.Visible = decr.Visible= false;
            hexr.Text = "hex";
            octr.Text = "oct";
            decr.Text = "dec";
            binr.Text = "bin";
            length_out.Visible = false;
            
            ComboBox_List.SelectedIndex = 0; // Making default value of combo box to binary
            InputBox.Clear();
            for (int i = 0; i < Check_List.Items.Count; i++)
            {
                Check_List.SetItemChecked(i, false);
            }

            //Giving default values to textboxes of outputs
            BinaryBox.Text = OctalBox.Text = DecimalBox.Text = HexaBox.Text = "Output here";
            BinaryBox.Visible = OctalBox.Visible = DecimalBox.Visible = HexaBox.Visible =  // text boxes
            bin.Visible = oct.Visible = dec.Visible = hex.Visible = false;  // labels
            info.Text = "info";
            info.Visible = false;
            InputBox.Focus();




        }
        // Combox_List

        private void InputBox_KeyPress(object sender, KeyPressEventArgs e, int m)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
            switch (m)
            {
                case 0:
                    if (!(Char.IsControl(e.KeyChar) || e.KeyChar == '0' || e.KeyChar == '1'))
                        e.Handled = true;
                    break;
                case 1:
                    if (!(Char.IsControl(e.KeyChar) || (Char.IsNumber(e.KeyChar) && (int)e.KeyChar >= 48 && (int)e.KeyChar <= 55)))
                        e.Handled = true;
                    break;
                case 2:
                    if (!(Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar)))
                        e.Handled = true;
                    break;
                case 3:
                    if (!(Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar) || (e.KeyChar >= 'A' && e.KeyChar <= 'F')))
                        e.Handled = true;
                    break;
                default:
                    break;
            }

        }
        public int m; 
        
        // variable used for choice in key press args
        
       

        private void Conversion_Load(object sender, EventArgs e)
        {
            ComboBox_List.SelectedIndex = 0; // Making default value of combo box to binary
            Convert_Button.Size = new Size (96, 36);
            Reset.Size = new Size (96, 36);
        }

        // TO handle keys related to specific notations like Binary for 0,1,Decimal 0-9, Octal 0-7, Hexa( 0-9,A-F)
        private void InputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
            switch (m)
            {
                case 0:
                    if (!(Char.IsControl(e.KeyChar) || e.KeyChar == '0' || e.KeyChar == '1'))
                        e.Handled = true;
                    break;
                case 1:
                    if (!(Char.IsControl(e.KeyChar) || (Char.IsNumber(e.KeyChar) && (int)e.KeyChar >= 48 && (int)e.KeyChar <= 55)))
                        e.Handled = true;
                    break;
                case 2:
                    if (!(Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar)))
                        e.Handled = true;
                    break;
                case 3:
                    if (!(Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar) || (e.KeyChar >= 'A' && e.KeyChar <= 'F')))
                        e.Handled = true;
                    break;
                default:
                    break;
            }
        }

        private void ComboBox_List_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            InputBox.Clear();
        }

        private void InputBox_MouseHover(object sender, EventArgs e)
        {
            InputBox.Focus();
        }

        

        private void ComboBox_List_SelectedIndexChanged_1(object sender, EventArgs e)
        {


            InputBox.Clear();
            string item = "";
            if (ComboBox_List.SelectedItem != null)
                item = ComboBox_List.SelectedItem.ToString();
            else
            {
                MessageBox.Show("Please select any item from box where FROM is written !!!"); return;
            }

            if (item == "Binary")
            {
                m = 0;
                InputBox_KeyPress(this, new KeyPressEventArgs((char)'\0'));

            }
            else if (item == "Octal")
            {
                m = 1;
                InputBox_KeyPress(this, new KeyPressEventArgs((char)'\0'));
            }
            else if (item == "Decimal")
            {
                m = 2;
                InputBox_KeyPress(this, new KeyPressEventArgs((char)'\0'));
            }
            else
            {
                m = 3;
                InputBox_KeyPress(this, new KeyPressEventArgs((char)'\0'));
            }
            InputBox.Focus();

        }

        private void Convert_Button_Click(object sender, EventArgs e)
        {
            if (Check_List.SelectedItem == null) {  // in case check list items are unselected
                MessageBox.Show("Please Check Any item from box.\nBox is under location where TO is written");
             
                return; }
            if(InputBox.Text==null)  // in case no number is entered by user in input box
            {
                MessageBox.Show("You have not entered any number.\nPlease fill the text box in order to use it !!!! ");
                return;
            }
            BinaryBox.Text = OctalBox.Text = DecimalBox.Text = HexaBox.Text="Output here";
            BinaryBox.Visible = OctalBox.Visible = DecimalBox.Visible = HexaBox.Visible =  // text boxes
            bin.Visible =  oct.Visible = dec.Visible = hex.Visible  // labels
            = hexr.Visible =binr.Visible = octr.Visible = decr.Visible= false; // Lengths of outputs
            info.Visible = true;
            info.Text = "You entered "+InputBox.TextLength.ToString()+" characters in input";
            // BINARY CASE

           if(ComboBox_List.SelectedItem.ToString() == "Binary") {


               if(Check_List.GetItemChecked(0))  // 2 by 2
                {
                    BinaryBox.Visible = true;
                    bin.Visible = true;
                    
                    BinaryBox.Text = InputBox.Text +" same result due to same types of conversions";
                    // Length
                    binr.Visible = true;
                    binr.Text = BinaryBox.Text.Length.ToString();

                }
                if(Check_List.GetItemChecked(1)) // 2 by 8 
                {
                    OctalBox.Visible = true;
                    oct.Visible = true;
                    OctalBox.Text = Convert_Binary(InputBox.Text , 8 )  ;
                    // Length
                    octr.Visible = true;
                    octr.Text = OctalBox.Text.Length.ToString();

                }
                if(Check_List.GetItemChecked(2)) // 2 by 10 
                {
                    DecimalBox.Visible = true;
                    dec.Visible = true;
                    DecimalBox.Text = Convert_Binary(InputBox.Text , 10 )  ;

                    // Length
                    decr.Visible = true;
                    decr.Text = DecimalBox.Text.Length.ToString();

                }
                
                if(Check_List.GetItemChecked(3)) // 2 by 16
                {
                    HexaBox.Visible = true;
                    hex.Visible = true;
                    HexaBox.Text = Convert_Binary(InputBox.Text , 16 )  ;
                    // Length
                    hexr.Visible = true;
                    hexr.Text = HexaBox.Text.Length.ToString();

                }
               



            }

            // OCTAL CASE
            if (ComboBox_List.SelectedItem.ToString() == "Octal")
            {


                if (Check_List.GetItemChecked(0))  // 8 by 2
                {
                    BinaryBox.Visible = true;
                    bin.Visible = true;
                    BinaryBox.Text = Convert_Octal(InputBox.Text,2);
                    // Length
                    binr.Visible = true;
                    binr.Text = BinaryBox.Text.Length.ToString();

                }

                if (Check_List.GetItemChecked(1)) // 8 by 8
                {
                    OctalBox.Visible = true;
                    oct.Visible = true;
                    OctalBox.Text = InputBox.Text + " same result due to same types of conversions";
                    octr.Visible = true;
                    octr.Text = OctalBox.Text.Length.ToString();

                }
                if (Check_List.GetItemChecked(2)) // 8 by 10 
                {
                    DecimalBox.Visible = true;
                    dec.Visible = true;
                    DecimalBox.Text = Convert_Octal(InputBox.Text, 10);
                    decr.Visible = true;
                    decr.Text = DecimalBox.Text.Length.ToString();

                }

                if (Check_List.GetItemChecked(3)) // 8 by 16
                {
                    HexaBox.Visible = true;
                    hex.Visible = true;
                    HexaBox.Text = Convert_Octal(InputBox.Text, 16);
                    hexr.Visible = true;
                    hexr.Text = HexaBox.Text.Length.ToString();

                }




            }
            // Decimal Case

            if (ComboBox_List.SelectedItem.ToString() == "Decimal")
            {


                if (Check_List.GetItemChecked(0))  // 10 by 2
                {
                    BinaryBox.Visible = true;
                    bin.Visible = true;
                    BinaryBox.Text = Convert_Decimal(InputBox.Text, 2);

                    // Length
                    binr.Visible = true;
                    binr.Text = BinaryBox.Text.Length.ToString();

                }

                if (Check_List.GetItemChecked(1)) // 10 by 8
                {
                    OctalBox.Visible = true;
                    oct.Visible = true;
                    OctalBox.Text = Convert_Decimal(InputBox.Text, 8);

                    octr.Visible = true;
                    octr.Text = OctalBox.Text.Length.ToString();

                }
                if (Check_List.GetItemChecked(2)) // 10 by 10
                {

                    DecimalBox.Visible = true;
                    dec.Visible = true;
                    DecimalBox.Text = InputBox.Text + " same result due to same types of conversions";

                    decr.Visible = true;
                    decr.Text = DecimalBox.Text.Length.ToString();


                }

                if (Check_List.GetItemChecked(3)) // 10 by 16
                {
                    HexaBox.Visible = true;
                    hex.Visible = true;
                    HexaBox.Text = Convert_Decimal(InputBox.Text, 16);
                    // Length of outputs
                    hexr.Visible = true;
                    hexr.Text = HexaBox.Text.Length.ToString();

                }




            }

            // Hexa Decimal Case

            if (ComboBox_List.SelectedItem.ToString() == "HexaDecimal")
            {


                if (Check_List.GetItemChecked(0))  // 16 by 2
                {
                    BinaryBox.Visible = true;
                    bin.Visible = true;
                    BinaryBox.Text = Convert_HexaDecimal(InputBox.Text, 2);

                    // Length
                    binr.Visible = true;
                    binr.Text = BinaryBox.Text.Length.ToString();

                }

                if (Check_List.GetItemChecked(1)) // 16 by 8
                {

                    OctalBox.Visible = true;
                    oct.Visible = true;
                    OctalBox.Text = Convert_HexaDecimal(InputBox.Text, 8);

                    octr.Visible = true;
                    octr.Text = OctalBox.Text.Length.ToString();

                }
                if (Check_List.GetItemChecked(2)) // 16 by 10 
                {
                    DecimalBox.Visible = true;
                    dec.Visible = true;
                    DecimalBox.Text = Convert_HexaDecimal(InputBox.Text, 10);

                    // Length
                    decr.Visible = true;
                    decr.Text = DecimalBox.Text.Length.ToString();

                }

                if (Check_List.GetItemChecked(3)) // 16 by 16
                {
                    
                    HexaBox.Visible = true;
                    hex.Visible = true;
                    HexaBox.Text = InputBox.Text + " same result due to same types of conversions";
                    //Length

                    hexr.Visible = true;
                    hexr.Text = HexaBox.Text.Length.ToString();

                }




            }


            length_out.Visible = true;

        }

        //private void textBox1_KeyPress(object sender, KeyPressEventArgs e)  // This is used to accept only Binary Number
        //{
        //    if (!char.IsControl(e.KeyChar) && !(e.KeyChar == '0' || e.KeyChar == '1'))
        //    {

        //        e.Handled = true;
        //        // In case no control key or 0 or 1 then it will not accept these keys like a,b,c or 9,8
        //    }
        //}



    }
}


//private void InputBox_Click(object sender, EventArgs e)
//{

//    InputBox.Clear();
//    string item = "";
//    if (ComboBox_List.SelectedItem != null)
//        item = ComboBox_List.SelectedItem.ToString();
//    else
//    {
//        MessageBox.Show("Please select any item from box where FROM is written !!!"); return;
//    }

//    if (item == "Binary")
//    {
//        m = 0;
//        InputBox_KeyPress(this, new KeyPressEventArgs((char)'\0'));

//    }
//    else if (item == "Octal")
//    {
//        m = 1;
//        InputBox_KeyPress(this, new KeyPressEventArgs((char)'\0'));
//    }
//    else if (item == "Decimal")
//    {
//        m = 2;
//        InputBox_KeyPress(this, new KeyPressEventArgs((char)'\0'));
//    }
//    else
//    {
//        m = 3;
//        InputBox_KeyPress(this, new KeyPressEventArgs((char)'\0'));
//    }


//}
