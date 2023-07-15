class LetterChecker
  def find_least_repeated_letter(str)
    return nil if str.strip.empty?
    word_array = get_string_letters_only(str).split()
    unique_letters = ""
    
    word_array.each do |word|
      letter = get_unique_letter(word) 
      unique_letters << letter if !letter.nil?
    end

    get_unique_letter(unique_letters)
  end
  
  private
  def get_string_letters_only(str)
    result = ""
    str.chars.each do
       |letter| result << letter if ('a'..'z').include?(letter.downcase) || letter == " "
    end
    result
  end

  def get_unique_letter(word)
    word.each_char do |letter|
      return letter if word.count(letter) == 1 
    end
    nil
  end
end