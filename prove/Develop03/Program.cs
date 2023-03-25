using System;

//class Program
//{
    //static void Main(string[] args)
    //{
        //Console.WriteLine("Hello Develop03 World!\n");

        //// This will start by displaying "Praise the Lord somebody" and waiting for the user to press the enter key
        //Console.WriteLine("Praise the Lord somebody");
        //Console.ReadLine();

        //// This will clear the console
        //Console.Clear();

        //// This will show "I am next in line for a miracle" in the console where "Praise the Lord somebody" used to be
        
        //Console.WriteLine("I am next in line for a miracle");
        //Console.ReadLine();

        //Console.Clear();

        //Console.WriteLine("Thank you for being God!");
    //}


    class Scripture {
        //public string reference; 
        private string reference;
        //public string[] verses;
        private string[] verses;

        public Scripture(string reference, string verse) {
            this.reference = reference;
            this.verses = new string[] { verse };
        }

        public Scripture(string reference, string startVerse, string endVerse) {
            this.reference = reference;
            this.verses = GenerateVerses(startVerse, endVerse);
        }

        private string[] GenerateVerses(string startVerse, string endVerse) {
            string[] verses = new string[GetVerseNumber(endVerse) - GetVerseNumber(startVerse) + 1];
            for (int i = 0; i < verses.Length; i++) {
                verses[i] = $"{GetBook(startVerse)} {GetChapter(startVerse)}:{GetVerseNumber(startVerse) + i}";
            }
            return verses;
        }

        private string GetBook(string verse) {
            return verse.Split(' ')[0];
        }

        private int GetChapter(string verse) {
            return int.Parse(verse.Split(' ')[1].Split(':')[0]);
        }

        private int GetVerseNumber(string verse) {
            return int.Parse(verse.Split(':')[1]);
        }

        public void Display() {
            Console.Clear();
            Console.WriteLine(reference);
            foreach (string verse in verses) {
                Console.WriteLine(verse);
            }
        }

        public bool HideNextWord() {
            int numWordsHidden = 0;
            foreach (string verse in verses) {
                string[] words = verse.Split(' ');
                int wordIndex = new Random().Next(words.Length);
                if (words[wordIndex] != "") {
                    words[wordIndex] = "";
                    numWordsHidden++;
                }
                Console.WriteLine(string.Join(' ', words));
            }
            return numWordsHidden > 0;
        }
    }

    class ScriptureHider {
        private Scripture scripture;

        public ScriptureHider(Scripture scripture) {
            this.scripture = scripture;
        }

        public void Start() {
            scripture.Display();
            while (true) {
                Console.WriteLine("Press Enter to continue, or type 'quit' to exit.");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit") {
                    break;
                }
                if (!scripture.HideNextWord()) {
                    break;
                }
            }
        }
    }

    class Program {
        static void Main(string[] args) {
            ScriptureHider scriptureHider = new ScriptureHider(new Scripture("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));
            scriptureHider.Start();

            scriptureHider = new ScriptureHider(new Scripture("Proverbs 3:5-6", "Trust in the LORD with all thine heart; and lean not unto thine own understanding. [6] In all thy ways acknowledge him, and he shall direct thy paths."));
            scriptureHider.Start();
        }
    }
