# Vietnamese Invoice Amount Converter

This Python script utilizes the Streamlit library to create a simple web application that converts a numeric invoice amount into its Vietnamese word representation.

### Features:

Converts numbers up to trillions (tỷ tỷ).
Handles special cases for better readability (e.g., "lăm" for five in the units place).
### How to Use:

Clone or download the repository containing this script (main.py).
Ensure you have Python and Streamlit installed (refer to their official documentation for installation instructions).
Open a terminal or command prompt and navigate to the directory containing the script.
Run the script using the following command:
```Bash
streamlit run main.py
```

A web app will launch in your default browser.
Enter the invoice amount in the text input field.
Click on the "Save Data" button.
### Output:

If the invoice amount is valid, the application will display the converted Vietnamese word representation along with a success message.

### Code Structure:

The script is divided into several functions:

unit: Converts a number (1-7) to its corresponding Vietnamese unit (Đồng, nghìn, triệu, etc.).
number_map: Dictionary for converting single digits (0-9) to their Vietnamese words.
convert_number: Converts a single digit string to its Vietnamese word.
join_number: Converts a group of digits (up to three) to its Vietnamese word representation with appropriate units (mươi, trăm).
join_unit: Converts a complete number string to its Vietnamese word representation with units (Đồng, nghìn, triệu, etc.).
replace_special_word: Replaces special words and phrases in the Vietnamese number representation for improved readability.
### Requirements:

Python 3.x
Streamlit library (pip install streamlit)
### Disclaimer:

This script is provided for educational purposes only. It may contain limitations or errors. Feel free to modify or improve upon it as needed.
