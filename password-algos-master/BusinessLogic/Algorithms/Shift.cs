namespace BusinessLogic.Algorithms{
    class Shift: IAlgo{
        
        public string generate(string password){
            return reverse(password);
        }

        private string reverse(string text){
            var data = new Data();
            char[] charArray = text.ToCharArray();
            for(int i = 0; i < charArray.Length; i++){
                if (data.dict.ContainsKey(charArray[i].ToString())){
                    string getValue = data.dict[charArray[i].ToString()];
                    charArray[i] = getValue[0];
                }
            }
            return new string( charArray );
        }

    }
}