using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Convert_money
{
    public partial class convert_money : Form
    {
        public convert_money()
        {
            InitializeComponent();
        }

        private void btconvert_Click(object sender, EventArgs e)
        {

            txtn.Text = txtn.Text.Trim();
            //1. validation from here
            //1.1 null validation 
            if (txtn.Text == "")
            {
                //message EN: 
                txtkq.Text = "Bạn chưa nhập số tiền cần chuyển đổi. Please input your amount.";
            }
            //1.2 not numeric validation
          //else if (!isnumeric(txtn.Text))
          //  {
          //message EN: Allow number only
          //   txtkq.Text = "Bạn phải nhập bằng số.";
          //  }
          //1.2 validation max length
            else if (txtn.Text.Length > 21)
            {
                //message EN: 
                txtkq.Text = "Bạn chỉ được nhập tối đa 21 ký tự số (tỷ tỷ). Allow up go 21 chars only billion billion, e.g 100.000.000.000.000.000.000";
            }
            else
            {
                // validation is ok then run the func
                //read Vietnam Dong in Vietnamese
                  txtkq.Text = replace_special_word(join_unit(txtn.Text)).ToUpper().Trim();
                //read Dollars in Vietnamese
                 
               
            }

        }

        private string join_unit(string n)
        {
            int sokytu = n.Length;
            int sodonvi = (sokytu % 3 > 0) ? (sokytu / 3 + 1) : (sokytu / 3);
            n = n.PadLeft(sodonvi * 3, '0');
            sokytu = n.Length;
            string chuoi = "";
            int i = 1;
            while (i <= sodonvi)
            {
                if (i == sodonvi) chuoi = join_number((int.Parse(n.Substring(sokytu - (i * 3), 3))).ToString()) + unit(i) + chuoi;
                else chuoi = join_number(n.Substring(sokytu - (i * 3), 3)) + unit(i) + chuoi;
                i += 1;
            }
            return chuoi;
        }

        private string join_unit_in_usd(string n)
        {
            int sokytu = n.Length;
            int sodonvi = (sokytu % 3 > 0) ? (sokytu / 3 + 1) : (sokytu / 3);
            n = n.PadLeft(sodonvi * 3, '0');
            sokytu = n.Length;
            string chuoi = "";
            int i = 1;
            while (i <= sodonvi)
            {
                if (i == sodonvi)
                    chuoi = join_number_in_usd((int.Parse(n.Substring(sokytu - (i * 3), 3))).ToString()) + unit_in_usd(i) + chuoi;
                else chuoi = join_number_in_usd(n.Substring(sokytu - (i * 3), 3)) + unit_in_usd(i) + chuoi;
                i += 1;
            }
            return chuoi;
        }


        private string unit(int n)
        {
            string chuoi = ""; 
            // unit Dong (VND)
            if (n == 1) chuoi = " Đồng";
            //thousand
            else if (n == 2) chuoi = " nghìn ";
            //million
            else if (n == 3) chuoi = " triệu ";
            //billion 1.000.000.000
            else if (n == 4) chuoi = " tỷ ";
            //thousand billion 1.000.000.000.000
            else if (n == 5) chuoi = " nghìn tỷ ";
            //million billion 1.000.000.000.000.000
            else if (n == 6) chuoi = " triệu tỷ ";
            // billion billion 1.000.000.000.000.000.000
            else if (n == 7) chuoi = " tỷ tỷ ";
            return chuoi;
        }

        private string unit_in_usd(int n)
        {
            string chuoi = "";
            // unit Dong (VND)
            if (n == 1) chuoi = " Đô La Mỹ ";
            //thousand
            else if (n == 2) chuoi = " nghìn ";
            //million
            else if (n == 3) chuoi = " triệu ";
            //billion 1.000.000.000
            else if (n == 4) chuoi = " tỷ ";
            //thousand billion 1.000.000.000.000
            else if (n == 5) chuoi = " nghìn tỷ ";
            //million billion 1.000.000.000.000.000
            else if (n == 6) chuoi = " triệu tỷ ";
            // billion billion 1.000.000.000.000.000.000
            else if (n == 7) chuoi = " tỷ tỷ ";
            return chuoi;
        }



        private string convert_number(string n)
        {
            string chuoi = "";
            //zero
            if (n == "0") chuoi = "không";
            //one
            else if (n == "1") chuoi = "một";
            //two
            else if (n == "2") chuoi = "hai";
            //three
            else if (n == "3") chuoi = "ba";
            //four
            else if (n == "4") chuoi = "bốn";
            //five
            else if (n == "5") chuoi = "năm";
            //six
            else if (n == "6") chuoi = "sáu";
            //seven
            else if (n == "7") chuoi = "bảy";
            //eight
            else if (n == "8") chuoi = "tám";
            //nine
            else if (n == "9") chuoi = "chín";
            return chuoi;
        }

        private string convert_number_in_usd(string n)
        {
            string chuoi = "";
            //zero
            if (n == "0") chuoi = "không";
            //one
            else if (n == "1") chuoi = "một";
            //two
            else if (n == "2") chuoi = "hai";
            //three
            else if (n == "3") chuoi = "ba";
            //four
            else if (n == "4") chuoi = "bốn";
            //five
            else if (n == "5") chuoi = "năm";
            //six
            else if (n == "6") chuoi = "sáu";
            //seven
            else if (n == "7") chuoi = "bảy";
            //eight
            else if (n == "8") chuoi = "tám";
            //nine
            else if (n == "9") chuoi = "chín";
            return chuoi;
        }

        private string join_number(string n)
        {
            string chuoi = "";
            int i = 1, j = n.Length;
            while (i <= j)
            {
                if (i == 1) chuoi = convert_number(n.Substring(j - i, 1)) + chuoi;
                //in dozens, Vietnamese will say +'mươi' , eg 30 = ba mươi
                else if (i == 2) chuoi = convert_number(n.Substring(j - i, 1)) + " mươi " + chuoi;
                //in hundreds, Vietnamese will say +'trăm', eg 300 = ba trăm
                else if (i == 3) chuoi = convert_number(n.Substring(j - i, 1)) + " trăm " + chuoi;
                i += 1;
            }
            return chuoi;
        }

        private string join_number_in_usd(string n)
        {
            string chuoi = "";
            int i = 1, j = n.Length;
            while (i <= j)
            {
                if (i == 1) chuoi = convert_number_in_usd(n.Substring(j - i, 1)) + chuoi;
                //in dozens, Vietnamese will say +'mươi' , eg 30 = ba mươi
                else if (i == 2) chuoi = convert_number_in_usd(n.Substring(j - i, 1)) + " mươi " + chuoi;
                //in hundreds, Vietnamese will say +'trăm', eg 300 = ba trăm
                else if (i == 3) chuoi = convert_number_in_usd(n.Substring(j - i, 1)) + " trăm " + chuoi;
                i += 1;
            }
            return chuoi;
        }

        private string join_number_in_usd_for_decimal(string n)
        {
            string chuoi = "";
            int i = 1, j = n.Length;
            while (i <= j)
            {

                if (i == 1) chuoi = convert_number_in_usd(n.Substring(j - i, 1)) + chuoi;
                //in dozens, Vietnamese will say +'mươi' , eg 30 = ba mươi
                else if (i == 2) chuoi = convert_number_in_usd(n.Substring(j - i, 1)) + " mươi " + chuoi;
                //in hundreds, Vietnamese will say +'trăm', eg 300 = ba trăm
                else if (i == 3) chuoi = convert_number_in_usd(n.Substring(j - i, 1)) + " trăm " + chuoi;
                //in hundreds, Vietnamese will say +'trăm', eg 300 = ba trăm

                i += 1;
            }
            return chuoi;
        }

        private string replace_special_word(string chuoi)
        {
            //some special case to read the amount in Vietnamese
            chuoi = chuoi.Replace("không mươi không ", "");
            chuoi = chuoi.Replace(" mươi không ", " mươi ");
            // if zero in the middle, eg 201 = hai trăm lẻ một nghìn
            // 200 hai trăm
            // -0 'lẻ' / 'linh instead of 'không'
            // --1 một
            chuoi = chuoi.Replace("không mươi", "linh");
            chuoi = chuoi.Replace("i không", "i");
            //if 5 is in the unit level, Vietnamese says it 'lăm' instead of 'năm' 
            //e.g 45 = bốn mươi lăm - 450 = bốn trăm năm mươi - 455 = bốn trăm năm mươi lăm
            // so i decide to distinguish this case by the last digit of tens 'mươi' -> 'i'
            // dozens case, eg: 10 = mười, 15 = mười lăm. But from twenty, call it 'mươi' e.g 25 = hai mươi lăm
            chuoi = chuoi.Replace("i năm", "i lăm");
            chuoi = chuoi.Replace("một mươi", "mười");
            //if 1 is in the unit level, call it 'mốt' instead of 'một'
            //eg 21 = hai mươi mốt or 201 = hai trăm lẻ một nghìn
            chuoi = chuoi.Replace("mươi một", "mươi mốt");
            chuoi = chuoi.Replace("không trăm đồng", " đồng");
            chuoi = chuoi.Replace("không nghìn đồng", " đồng");

            //some special case to read the Vietnam Dong amount in Engish
            chuoi = chuoi.Replace(" and and ", " and ");
            // to read USD amound in Vietnamese
            chuoi = chuoi.Replace("KHÔNG CHẴN", "CHẴN");
            chuoi = chuoi.Replace("USD and ", "USD ");
           // chuoi = chuoi.Replace("MỸ LẺ", "MỸ");
            chuoi = chuoi.Replace("MỸ LINH", "MỸ");
            chuoi = chuoi.Replace("  ", " ");
            chuoi = chuoi.Replace(" .", ".");
            return chuoi;
        }
        //check numeric character, if yes, return error 
        // use in vietnamese only, vietnamese currency doesn't have decimal
        //private bool isnumeric(string chuoi)
        //{
        //    foreach (char c in chuoi) if (!char.IsDigit(c)) return false;
        //    return true;
        //}

        private void btabout_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void txtkq_TextChanged(object sender, EventArgs e)
        {

        }

        private void convert_money_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btconvert2_Click(object sender, EventArgs e)
        {
            // eg 1562,25 = Dollars One Thousand Five Hundred and Sixty Two and two five 
            // thousand's    hundred's      ten's          one's    decimal separator    decimal
            //     1            5             6              2             ,               25
            String val = "", val2="", wholeNo = txtn2.Text, points = "", andStr = "", pointStr = "";
            String endStr = "only.";
            String endStrVN = "chẵn.";
            try
            {
                // in Vietnam, they use dot to seperate whole part and decimal part in USD
                //you can modify to db format if you want
                int decimalPlace = txtn2.Text.IndexOf(".");
                if (decimalPlace > 0)
                {
                    wholeNo = txtn2.Text.Substring(0, decimalPlace);
                    points = txtn2.Text.Substring(decimalPlace + 1);
                    if (points.Length==1) { points = points + 0; }
                    if (Convert.ToInt32(points) > 0)
                    {
                        andStr = "";// just to .separate whole numbers from points/cents  
                        pointStr = tens(points);
                        endStr = "cents.";//Cents  
                        endStrVN = "cents.";
                    }
                }

                //result of read USD in Vietnamese
                val2 = String.Format("{0} {1} {2}", replace_special_word(join_unit_in_usd(wholeNo)).ToUpper().Trim(), replace_special_word(join_number_in_usd_for_decimal(points)).ToUpper().Trim(), endStrVN.ToUpper());
                // val2 = replace_special_word(join_unit_in_usd(wholeNo)).ToUpper().Trim() +" "+ replace_special_word(join_number_in_usd_for_decimal(points)).ToUpper().Trim()+ " "+endStr;
                txtusd.Text = replace_special_word(val2);

                val = String.Format("USD {0} {1}{2} {3}", ConvertWholeNumber(wholeNo).ToLower().Trim(), andStr, pointStr.ToLower(), endStr);
                //result of read USD in English
                txtUSD2.Text = "("+replace_special_word(val).Trim()+")";

                
            }
            catch { }
            
        }

        private static String ConvertWholeNumber(String Number)
        {
            string word = "";
            try
            {
                bool beginsZero = false;//tests for 0XX
                bool isDone = false;//test if already translated
                double dblAmt = (Convert.ToDouble(Number));
                //if ((dblAmt > 0) && number.StartsWith("0"))
                if (dblAmt > 0)
                {//test for zero or digit zero in a nuemric
                    beginsZero = Number.StartsWith("0");

                    int numDigits = Number.Length;
                    int pos = 0;//store digit grouping
                    String place = "";//digit grouping name:hundred,thousand,etc...
                    switch (numDigits)
                    {
                        case 1://ones' range

                            word = ones(Number);
                            isDone = true;
                            break;
                        case 2://tens' range
                            word = tens(Number);
                            isDone = true;
                            break;
                        case 3://hundreds' range
                            pos = (numDigits % 3) + 1;
                            place = " Hundred ";
                            break;
                        case 4://thousands' range
                        case 5:
                        case 6:
                            pos = (numDigits % 4) + 1;
                            place = " Thousand ";
                            break;
                        case 7://millions' range
                        case 8:
                        case 9:
                            pos = (numDigits % 7) + 1;
                            place = " Million ";
                            break;
                        case 10://Billions's range
                        case 11:
                        case 12:

                            pos = (numDigits % 10) + 1;
                            place = " Billion ";
                            break;
                        //add extra case options for anything above Billion...
                        default:
                            isDone = true;
                            break;
                    }
                    if (!isDone)
                    {//if transalation is not done, continue...(Recursion comes in now!!)
                        if (Number.Substring(0, pos) != "0" && Number.Substring(pos) != "0")
                        {
                            try
                            {
                                    word = ConvertWholeNumber(Number.Substring(0, pos)) + place + ConvertWholeNumber(Number.Substring(pos));
                            }
                            catch { }
                        }
                        else
                        {
                            word = ConvertWholeNumber(Number.Substring(0, pos)) + ConvertWholeNumber(Number.Substring(pos));
                        }

                        //check for trailing zeros
                        //if (beginsZero) word = " and " + word.Trim();
                    }
                    //ignore digit grouping names
                    if (word.Trim().Equals(place.Trim())) word = "";
                }
            }
            catch { }
            return word.Trim();
        }

        private static String tens(String Number)
        {
            int _Number = Convert.ToInt32(Number);
            String name = null;
            switch (_Number)
            {
                case 10:
                    name = "and " + "Ten";
                    break;
                case 11:
                    name = "and " + "Eleven";
                    break;
                case 12:
                    name = "and " + "Twelve";
                    break;
                case 13:
                    name = "and " + "Thirteen";
                    break;
                case 14:
                    name = "and " + "Fourteen";
                    break;
                case 15:
                    name = "and " + "Fifteen";
                    break;
                case 16:
                    name = "and " + "Sixteen";
                    break;
                case 17:
                    name = "and " + "Seventeen";
                    break;
                case 18:
                    name = "and " + "Eighteen";
                    break;
                case 19:
                    name = "and " + "Nineteen";
                    break;
                case 20:
                    name = "and " + "Twenty";
                    break;
                case 30:
                    name = "and " + "Thirty";
                    break;
                case 40:
                    name = "and " + "Fourty";
                    break;
                case 50:
                    name = "and " + "Fifty";
                    break;
                case 60:
                    name = "and " + "Sixty";
                    break;
                case 70:
                    name = "and " + "Seventy";
                    break;
                case 80:
                    name = "and " + "Eighty";
                    break;
                case 90:
                    name = "and " + "Ninety";
                    break;
                default:
                    if (_Number > 0)
                    {
                        name = "and " +tens(Number.Substring(0, 1) + "0") + " " + ones(Number.Substring(1));
                    }
                    break;
            }
            return name;
        }
        private static String ones(String Number)
        {
            int _Number = Convert.ToInt32(Number);
            String name = "";
            switch (_Number)
            {

                case 1:
                    name = "One";
                    break;
                case 2:
                    name = "Two";
                    break;
                case 3:
                    name = "Three";
                    break;
                case 4:
                    name = "Four";
                    break;
                case 5:
                    name = "Five";
                    break;
                case 6:
                    name = "Six";
                    break;
                case 7:
                    name = "Seven";
                    break;
                case 8:
                    name = "Eight";
                    break;
                case 9:
                    name = "Nine";
                    break;
            }
            return name;
        }

        private void txtusd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtn2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
