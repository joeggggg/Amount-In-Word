import streamlit as st

def unit(n):
  """
  Converts a number to its corresponding Vietnamese unit (Dong, nghìn, triệu, tỷ, etc.).

  Args:
    n: The number to convert.

  Returns:
    The Vietnamese unit corresponding to the number.
  """

  if n == 1:
    return "Đồng"
  elif n == 2:
    return "nghìn "
  elif n == 3:
    return "triệu "
  elif n == 4:
    return "tỷ "
  elif n == 5:
    return "nghìn tỷ "
  elif n == 6:
    return "triệu tỷ "
  elif n == 7:
    return "tỷ tỷ "
  else:
    return ""

# Dictionary for digit to word conversion (single digit)
number_map = {
    "0": "không", "1": "một", "2": "hai", "3": "ba", "4": "bốn",
    "5": "năm", "6": "sáu", "7": "bảy", "8": "tám", "9": "chín"
}

def convert_number(n):
  """
  Converts a single digit number (0-9) to its corresponding Vietnamese word.

  Args:
    n: The number to convert (as a string).

  Returns:
    The Vietnamese word corresponding to the number, or an empty string if the input is not a single digit.
  """

  # Use a dictionary for efficient lookups
  number_map = {
      "0": "không",
      "1": "một",
      "2": "hai",
      "3": "ba",
      "4": "bốn",
      "5": "năm",
      "6": "sáu",
      "7": "bảy",
      "8": "tám",
      "9": "chín"
  }

  if n in number_map:
    return number_map[n]
  else:
    return ""


def join_number(n):
  """Converts a group of digits (up to three) to its Vietnamese word representation."""
  chuoi = ""
  for i, digit in enumerate(reversed(n)):
    word = convert_number(digit)
    if word:  # Add unit only if digit has a word conversion
      chuoi = word + (" mươi " if i == 1 else (" trăm " if i == 2 else " ")) + chuoi
  return chuoi.strip()  # Remove trailing whitespace


def join_unit(n):
  """
  Converts a number string to its Vietnamese word representation with units (Đồng, nghìn, triệu, tỷ, etc.).

  Args:
    n: The number string to convert.

  Returns:
    The Vietnamese word representation of the number with units, or an empty string if the input is empty.
  """

  if not n:
    return ""

  # Calculate the number of digit groups (based on multiples of 3)
  num_groups = (len(n) % 3) + (len(n) // 3)

  # Pad with zeros to ensure a multiple of 3 digits
  n = n.zfill(num_groups * 3)

  chuoi = ""
  i = 1
  while i <= num_groups:
    # Extract a group of 3 digits
    digit_group = n[-i * 3: -i * 3 + 3]

    # Convert digit group to word representation using join_number (assumed to exist)
    group_word = join_number(digit_group)  + " "

    # Add unit based on group position and combine with previous results
    if i == num_groups:
      chuoi = group_word + unit(i) + chuoi  
    else:
      chuoi = group_word + unit(i) + " " + chuoi 

    i += 1

  return chuoi


def replace_special_word(chuoi):
  """
  Replaces special words and phrases in the Vietnamese number representation to improve readability.

  Args:
    chuoi: The Vietnamese number representation string.

  Returns:
    The modified string with special words replaced.
  """

  # Replace common phrases to improve readability
  chuoi = chuoi.replace("không mươi không", "").replace(" mươi không ", " mươi ")
  # if zero in the middle, eg 201 = hai trăm lẻ một nghìn
  # 200 hai trăm
  # -0 'lẻ' / 'linh instead of 'không'
  # --1 một
  # chuoi = chuoi.replace("không mươi", "linh")
  # chuoi = chuoi.replace("i không", "i")
  chuoi = chuoi.replace("không mươi", "linh").replace("i không", "i")
  # if 5 is in the unit level, Vietnamese says it 'lăm' instead of 'năm' 
  # e.g 45 = bốn mươi lăm - 450 = bốn trăm năm mươi - 455 = bốn trăm năm mươi lăm
  # so i decide to distinguish this case by the last digit of tens 'mươi' -> 'i'
  # dozens case, eg: 10 = mười, 15 = mười lăm. But from twenty, call it 'mươi' e.g 25 = hai mươi lăm

  # if 1 is in the unit level, call it 'mốt' instead of 'một'
  # eg 21 = hai mươi mốt or 201 = hai trăm lẻ một nghìn

  # and the misc
  chuoi = (chuoi.replace("i năm", "i lăm").replace("một mươi", "mười").replace("mươi một", "mươi mốt").replace("không trăm đồng", " đồng")
          .replace("không nghìn đồng", " đồng")
          .replace("đồng ", " đồng")
          .replace("  ", " ")
          .replace(" .", "."))
  

  return chuoi



# Title and text input for invoice amount
st.title("Input Invoice Amount")
input  = st.text_input("Enter your amount:")


# Button to save data
save_button = st.button("Save Data")

# Display information on successful save
if save_button:
  if input:  # Check if both inputs have values
    amount_in_word = replace_special_word(join_unit(input))
    st.write(amount_in_word)
    st.success("Invoice amount converted successfully!")
  else:
    st.warning("Please enter invoice amount before saving.")
