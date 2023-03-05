namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "carro", "gato", "casa", "cachorro", "frutas" };
            Random random = new Random();
            int index = random.Next(0, words.Length);
            string word = words[index];

            char[] letters = new char[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                letters[i] = '_';
            }

            int attemps = 6;
            bool won = false;

            while (attemps > 0 && !won)
            {
                Console.WriteLine("Palavra: " + String.Join(" ", letters));
                Console.WriteLine("Tentativas restantes: " + attemps);
                Console.Write("Digite uma letra: ");

                char letter = char.Parse(Console.ReadLine());

                bool found = false;

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == letter)
                    {
                        letters[i] = letter;
                        found = true;
                    }
                }

                if (!found)
                {
                    attemps--;
                }

                if (String.Join("", letters) == word)
                {
                    won = true;
                }
            }
            if (won)
            {
                Console.WriteLine("Parabéns! Voçê acetou a palavra: " + word);
            }
            else
            {
                Console.WriteLine("Que pena! Suas tentativas acabaram. A palavra era: " + word);
            }
            Console.ReadLine();
        }
    }
}
